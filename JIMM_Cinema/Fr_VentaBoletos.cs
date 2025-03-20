using BE;
using BLL;
using Gestion_Cine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private readonly BLL_Boleto gestorBoleto;
        private readonly BLL_Membresia gestorMembresia;
        private BE_Cliente clienteSeleccionado;
        private BE_Funcion funcionSeleccionada;
        private BE_Pelicula peliculaSeleccionada;
        public Fr_VentaBoletos()
        {
            InitializeComponent();
            gestorPelicula = new BLL_Pelicula();
            gestorFuncion = new BLL_Funcion();
            gestorCliente = new BLL_Cliente();
            gestorButaca = new BLL_Butaca();
            gestorBoleto = new BLL_Boleto();
            gestorMembresia = new BLL_Membresia();
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

            //Obtenemos las funciones de la pelicula seleccionada que tengan asientos disponibles y que la fecha de la funcion sea mayor o igual a la fecha actual
            var funciones = gestorFuncion.ConsultarFuncionesPorPelicula(pelicula)
                .Where(f => f.AsientosDisponibles() > 0 && f.FechaFuncion >= DateTime.Today)
                .OrderBy(f => f.FechaFuncion).ThenBy(f => f.HoraInicio).ToList();

            dgvFunciones.DataSource = funciones;

            //Formateamos las columna Sala de la grilla
            if (dgvFunciones.Columns.Contains("Sala"))
            {
                dgvFunciones.Columns["Sala"].DefaultCellStyle.Format = "SalaNombre";
                dgvFunciones.Columns["Sala"].HeaderText = "Sala";
            }
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

        //Carga las butacas disponibles de la funcion seleccionada
        private void CargarButacasDisponibles(BE_Funcion funcionSeleccionada)
        {
            //Utilizamos la funcion SuspendedLayout para evitar que se redibuje el panel por cada funcion seleccionada
            panelButacas.SuspendLayout();
            //Limpiamos el panel de butacas para evitar que persistan controles previos
            panelButacas.Controls.Clear();

            //Si no hay una funcion seleccionada o la sala de la funcion es nula, salimos del metodo
            if (funcionSeleccionada == null || funcionSeleccionada.Sala == null)
            {
                //Reanudamos el layout del panel
                panelButacas.ResumeLayout();
                return;
            }
            try
            {
                //Obtenemos los boletos existentes para la funcion seleccionada
                var boletosExistentes = gestorBoleto.Consultar().Where(x => x.Funcion.ID == funcionSeleccionada.ID).ToList();

                //Obtenemos las butacas de los boletos existentes (ocupadas)
                var butacasOcupadas = boletosExistentes.SelectMany(x => x.Butacas).Select(b => new { b.Fila, b.Numero }).ToList();

                //Obtenemos las filas de butacas de la sala de la funcion seleccionada (cada sala puede tener un diferencte numero de filas)
                var filas = funcionSeleccionada.Sala.Butacas.Select(b => b.Fila).Distinct().OrderBy(f => f).ToList();

                //Definimos constantes para evitar los numeros magicos
                const int TAMANO_BOTON = 40;
                const int SEPARACION_BOTONES = 5;
                const int INCIO_CUADRICULA_X = 40;
                const int INCIO_CUADRICULA_Y = 40;
                const int UBICACION_LABEL_Y = 10;
                const int UBICACION_LABEL_X = 10;
                const int CANTIDAD_COLUMNAS_SALAS = 20;
                const int ANCHO_LABEL_FILA = 30;

                //Creamos labels para las columnas para identificar la ubicacion de las butacaa, 1 label por cada columna
                for (int col = 1; col <= 20; col++)
                {
                    Label lblCol = new Label
                    {
                        Text = col.ToString(),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Size = new Size(TAMANO_BOTON, CANTIDAD_COLUMNAS_SALAS),
                        //Se define la ubicacion de cada label y el margen de separacion entre ellas
                        Location = new Point(INCIO_CUADRICULA_X + (col - 1) * (TAMANO_BOTON + SEPARACION_BOTONES), UBICACION_LABEL_Y)
                    };
                    panelButacas.Controls.Add(lblCol);
                }

                //Creamos labels para las filas y botones para las butacas
                //Recorremos la coleccion de filas de la sala
                for (int indice = 0; indice < filas.Count; indice++)
                {
                    //Obtenemos la fila actual
                    string fila = filas[indice];

                    //Creamos un label para la fila actual
                    Label lblFila = new Label
                    {
                        Text = fila,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Size = new Size(ANCHO_LABEL_FILA, TAMANO_BOTON),
                        Location = new Point(UBICACION_LABEL_X, INCIO_CUADRICULA_Y + indice * (TAMANO_BOTON + SEPARACION_BOTONES))
                    };
                    panelButacas.Controls.Add(lblFila);

                    //Obtenemos las butacas de la fila actual y las ordenamos por numero
                    var butacasFila = funcionSeleccionada.Sala.Butacas.Where(b => b.Fila == fila).OrderBy(b => b.Numero).ToList();

                    //Recorremos las butacas de la fila actual y verificamos si estan ocupadas
                    foreach (var butaca in butacasFila)
                    {
                        //Verificamos si la butaca actual esta ocupada
                        bool estaOcupada = butacasOcupadas.Any(x => x.Fila == butaca.Fila && x.Numero == butaca.Numero);

                        //Creamos un boton por cada butaca
                        Button btnButaca = new Button
                        {
                            Text = $"{butaca.Fila}{butaca.Numero}",
                            Tag = butaca,
                            //Si la butaca esta ocupada, el color de fondo sera rojo, de lo contrario verde
                            BackColor = estaOcupada ? Color.Red : Color.LightGreen,
                            Size = new Size(TAMANO_BOTON, TAMANO_BOTON),
                            Location = new Point( INCIO_CUADRICULA_X + (butaca.Numero - 1) * (TAMANO_BOTON + SEPARACION_BOTONES),
                            INCIO_CUADRICULA_Y + indice * (TAMANO_BOTON + SEPARACION_BOTONES)),
                            //Si la butaca esta ocupada, el boton estara deshabilitado, de lo contrario habilitado
                            Enabled = !estaOcupada,
                            Font = new Font("Arial", 9, FontStyle.Bold)
                        };

                        //Asignamos el evento click al boton
                        btnButaca.Click += BtnButaca_Click;
                        //Agregamos el boton al panel
                        panelButacas.Controls.Add(btnButaca);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las butacas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Evento click de los botones de las butacas
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

            //Si la butaca ya esta seleccionada, la removemos de la lista de butacas seleccionadas y cambiamos el color del boton a verde
            if (lstBxButacasSeleccionadas.Items.Contains(butaca))
            {
                lstBxButacasSeleccionadas.Items.Remove(butaca);
                boton.BackColor = Color.LightGreen;
            }
            //Si la butaca no esta seleccionada, la agregamos a la lista de butacas seleccionadas y cambiamos el color del boton a amarillo
            else
            {
                lstBxButacasSeleccionadas.Items.Add(butaca);
                boton.BackColor = Color.Yellow;
            }

            ActualizarTotal();
        }

        //Actualiza el total de la venta
        private void ActualizarTotal()
        {
            //Si no hay una funcion seleccionada o no hay butacas seleccionadas, el total sera 0
            if (funcionSeleccionada == null || lstBxButacasSeleccionadas.Items.Count == 0)
            {
                lblTotal.Text = "Total: $0.00";
                return;
            }
            //Calculamos el total de la venta
            decimal total = funcionSeleccionada.Precio * lstBxButacasSeleccionadas.Items.Count;

            //Si hay un cliente seleccionado, verificamos si tiene una membresia activa y aplicamos el descuento correspondiente
            if (clienteSeleccionado != null)
            {
                //Obtenemos la membresia activa del cliente
                var membresiaEncontrada = gestorMembresia.ConsultarPorCliente(clienteSeleccionado.ID).FirstOrDefault(x => x.EstaActiva);
                //Si se encontro una membresia activa, aplicamos el descuento correspondiente
                if (membresiaEncontrada != null)
                {
                    //Aplicamos el descuento correspondiente segun el tipo de membresia
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
            //Formateamos el total y lo asignamos al label
            lblTotal.Text = $"Total: ${total:N2}";
        }

        //Evento click del boton Completar Venta
        private void btnCompletarVenta_Click(object sender, EventArgs e)
        {
            if (!ValidarVenta())
                return;
            {
                try
                {
                    //Obtenemos el total de la venta
                    decimal total = decimal.Parse(lblTotal.Text.Replace("Total: $", "").Trim());
                    //Creamos un objeto boleto con los datos de la venta
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

                    MessageBox.Show("Venta completada con éxito\nSe ha generado un PDF del boleto en la carpeta BOLETOS.",
                                    "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            AbrirFrRegistroCliente();
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            var frMembresia = new Fr_GestionMembresia();
            frMembresia.ShowDialog();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
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

        //Evento click del boton Ver Boletos
        private void btnVerBoletos_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtenemos la ruta de la carpeta de boletos
                string boletosPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BOLETOS");

                //Si la carpeta no existe, la creamos
                if (!Directory.Exists(boletosPath))
                {
                    Directory.CreateDirectory(boletosPath);
                }

                //Abrimos la carpeta de boletos utilizando el explorador de windows
                System.Diagnostics.Process.Start("explorer.exe", boletosPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la carpeta de boletos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}