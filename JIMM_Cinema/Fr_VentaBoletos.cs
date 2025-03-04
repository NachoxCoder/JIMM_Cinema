using BE;
using BLL;
using Gestion_Cine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI
{
    public partial class Fr_VentaBoletos : Form
    {
        private readonly BLL_Pelicula gestorPelicula;
        private readonly BLL_Funcion gestorFuncion;
        private readonly BLL_Cliente gestorCliente;
        private readonly BLL_Butaca gestorButaca;
        //private readonly BLL_Bitacora gestorBitacora;
        private readonly BLL_Boleto gestorBoleto;
        private readonly BLL_Membresia gestorMembresia;
        private BE_Cliente clienteSeleccionado;
        private BE_Funcion funcionSeleccionada;
        private BE_Pelicula peliculaSeleccionada;
        private BE_Usuario usuarioActual;
        public Fr_VentaBoletos()
        {
            InitializeComponent();
            gestorPelicula = new BLL_Pelicula();
            gestorFuncion = new BLL_Funcion();
            gestorCliente = new BLL_Cliente();
            gestorButaca = new BLL_Butaca();
            //gestorBitacora = new BLL_Bitacora();
            gestorBoleto = new BLL_Boleto();
            gestorMembresia = new BLL_Membresia();
            //usuarioActual = usuario;
            this.Load += Fr_VentaBoletos_Load;
        }

        private void Fr_VentaBoletos_Load(object sender, EventArgs e)
        {
            peliculaSeleccionada = dgvPeliculas.CurrentRow?.DataBoundItem as BE_Pelicula;
            CargarPeliculasDisponibles();
            CargarFuncionesDisponibles(peliculaSeleccionada);
            CargarMetodosPago();
        }

        private void CargarFuncionesDisponibles(BE_Pelicula pelicula)
        {
            if (pelicula == null)
            {
                return;
            }

            var funciones = gestorFuncion.ConsultarFuncionesPorPelicula(pelicula)
                .Where(f => f.AsientosDisponibles() > 0 && f.FechaFuncion >= DateTime.Today)
                .OrderBy(f => f.FechaFuncion).ThenBy(f => f.HoraInicio).ToList();

            dgvFunciones.DataSource = funciones;
        }


        private void AbrirFrRegistroCliente()
        {
            var frRegistroCliente = new Fr_GestionCliente();
            frRegistroCliente.ShowDialog();
        }


        private void dgvFunciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFunciones.CurrentRow != null)
            {
                funcionSeleccionada = (BE_Funcion)dgvFunciones.CurrentRow.DataBoundItem;

                lstBxButacasSeleccionadas.Items.Clear();

                CargarButacasDisponibles(funcionSeleccionada);

                ActualizarTotal();
            }

        }

        private void CargarButacasDisponibles(BE_Funcion funcionSeleccionada)
        {
            panelButacas.Controls.Clear();

            if (funcionSeleccionada == null || funcionSeleccionada.Sala == null)
            {
                return;
            }
            try
            {
                var boletosExistentes = gestorBoleto.Consultar().Where(x => x.Funcion.ID == funcionSeleccionada.ID).ToList();

                var butacasOcupadas = boletosExistentes.SelectMany(x => x.Butacas).Select(b => new { b.Fila, b.Numero }).ToList();


                foreach (var butaca in funcionSeleccionada.Sala.Butacas.OrderBy(b => b.Fila).ThenBy(b => b.Numero))
                {
                    bool estaOcupada = butacasOcupadas.Any(x => x.Fila == butaca.Fila && x.Numero == butaca.Numero);

                    Button btnButaca = new Button
                    {
                        Text = $"{butaca.Fila}{butaca.Numero}",
                        Tag = butaca,
                        BackColor = estaOcupada ? Color.Red : Color.LightGreen,
                        Width = 50,
                        Height = 50,
                        Margin = new Padding(5),
                        Enabled = !estaOcupada,
                        Font = new Font("Arial", 10, FontStyle.Bold)
                    };

                    btnButaca.Click += BtnButaca_Click;
                    panelButacas.Controls.Add(btnButaca);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las butacas: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnButaca_Click(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            var butaca = (BE_Butaca)boton.Tag;

            if (!butaca.Disponible)
            {
                MessageBox.Show("La butaca seleccionada no está disponible", "Butaca Ocupada",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstBxButacasSeleccionadas.Items.Contains(butaca))
            {
                lstBxButacasSeleccionadas.Items.Remove(butaca);
                boton.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                lstBxButacasSeleccionadas.Items.Add(butaca);
                boton.BackColor = System.Drawing.Color.Yellow;
            }

            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            if(funcionSeleccionada == null || lstBxButacasSeleccionadas.Items.Count == 0)
            {
                lblTotal.Text = "Total: $0.00";
                return;
            }
            decimal total = funcionSeleccionada.Precio * lstBxButacasSeleccionadas.Items.Count;

            if (clienteSeleccionado != null)
            {
                var membresiaEncontrada = gestorMembresia.ConsultarPorCliente(clienteSeleccionado.ID).FirstOrDefault(x => x.EstaActiva);
                if (membresiaEncontrada != null)
                {
                    switch (membresiaEncontrada.Tipo)
                    {
                        case TipoMembresia.Plata:
                            total *= 0.9m;
                            break;
                        case TipoMembresia.Oro:
                            total *= 0.8m;
                            break;
                        case TipoMembresia.Premium:
                            total *= 0.7m;
                            break;
                    }
                }
            }

            lblTotal.Text = $"Total: ${total:N2}";
        }

        private void btnCompletarVenta_Click(object sender, EventArgs e)
        {
            if (!ValidarVenta())
                return;
            {
                try
                {
                    decimal total = decimal.Parse(lblTotal.Text.Replace("Total: $", "").Trim());
                    var boleto = new BE_Boleto
                    {
                        Funcion = funcionSeleccionada,
                        Cliente = clienteSeleccionado,
                        FechaVenta = DateTime.Now,
                        Butacas = lstBxButacasSeleccionadas.Items.Cast<BE_Butaca>().ToList(),
                        Metodo = (BE_Boleto.MetodoPago)cmbxMetodoPago.SelectedItem,
                        Precio = total
                    };

                    gestorBoleto.Alta(boleto);

                    foreach (BE_Butaca butaca in boleto.Butacas)
                    {
                        gestorButaca.OcuparButaca(butaca);
                    }

                    MessageBox.Show("Venta completada con éxito", "Venta Exitosa",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /*gestorBitacora.Log(usuarioActual, 
                        $"Venta de {lstBxButacasSeleccionadas.Items.Count} butacas para la función: " +
                        $"{funcionSeleccionada.PeliculaTitulo()} al cliente: {clienteSeleccionado.NombreCompleto()}");*/

                    LimpiarForm();
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar la venta: {ex.Message}", "Venta Fallo!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarVenta()
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Validacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (funcionSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una función", "Validacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (lstBxButacasSeleccionadas.Items.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una butaca", "Validacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarForm()
        {
            txtClientDNI.Clear();
            txtNombreCliente.Clear();
            txtMembresiaCliente.Clear();
            clienteSeleccionado = null;
            funcionSeleccionada = null;
            lstBxButacasSeleccionadas.Items.Clear();
            lblTotal.Text = "Total: $0.00";
            CargarPeliculasDisponibles();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            var frRegistroCliente = new Fr_GestionCliente();
            frRegistroCliente.ShowDialog();
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            var frMembresia = new Fr_GestionMembresia();
            frMembresia.ShowDialog();
        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            funcionSeleccionada = null;
            lstBxButacasSeleccionadas.Items.Clear();
            lblTotal.Text = "Total: $0.00";

            if (string.IsNullOrWhiteSpace(txtClientDNI.Text))
            {
                MessageBox.Show("Debe ingresar un DNI", "Campo Requerido",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clienteSeleccionado = gestorCliente.Consultar().FirstOrDefault(x => x.DNI == txtClientDNI.Text.Trim());
            if (clienteSeleccionado == null)
            {
                if (MessageBox.Show("No se encontró un cliente con ese DNI, ¿Desea registrarlo", "Nuevo Cliente",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    AbrirFrRegistroCliente();
                }
            }
            else
            {
                MostrarInfoCliente();
            }
        }

        private void MostrarInfoCliente()
        {
            if (clienteSeleccionado != null)
            {
                var membresiaEncontrada = gestorMembresia.ConsultarPorCliente(clienteSeleccionado.ID).FirstOrDefault(x => x.EstaActiva);

                txtNombreCliente.Text = clienteSeleccionado.NombreCompleto();
                txtMembresiaCliente.Text = membresiaEncontrada != null ? membresiaEncontrada.Tipo.ToString() : "Ninguna";
            }
        }

        private void CargarPeliculasDisponibles()
        {
            dgvPeliculas.DataSource = gestorPelicula.ConsultarPeliculasActivas();
        }

        private void dgvPeliculas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPeliculas.CurrentRow != null)
            {
                peliculaSeleccionada = (BE_Pelicula)dgvPeliculas.CurrentRow.DataBoundItem;
                CargarFuncionesDisponibles(peliculaSeleccionada);
            }
        }

        private void CargarMetodosPago()
        {
            cmbxMetodoPago.DataSource = Enum.GetValues(typeof(BE_Boleto.MetodoPago));
            cmbxMetodoPago.SelectedIndex = -0;
        }
    }
}