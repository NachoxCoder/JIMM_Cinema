using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;

namespace UI
{
    public partial class Fr_GestionMembresia : Form
    {
        private readonly BLL_Membresia gestorMembresia;
        private readonly BLL_Cliente gestorCliente;
        private BE_Cliente clienteSeleccionado;
        private BE_Membresia membresiaSeleccionada;

        public Fr_GestionMembresia()
        {
            InitializeComponent();
            gestorMembresia = new BLL_Membresia();
            gestorCliente = new BLL_Cliente();
            this.Load += Fr_GestionMembresia_Load;

        }

        private void Fr_GestionMembresia_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
            CargarMetodosPago();
            LimpiarFormulario();
            dgvMembresias.DataSource = null;
        }

        private void ConfigurarControles()
        {
            var membresias = Enum.GetValues(typeof(TipoMembresia));
            cmbTipoMembresia.DataSource = membresias;
            CostoMensualMembresia();
        }

        private void CargarMetodosPago()
        {
            cmbMetodoPago.DataSource = Enum.GetValues(typeof(BE_Membresia.MetodoPagoMembresia));
            cmbMetodoPago.SelectedIndex = 0;
        }

        private void MostrarDatosMembresia()
        {
            if (membresiaSeleccionada != null)
            {
                cmbTipoMembresia.SelectedItem = membresiaSeleccionada.Tipo;
                txtCostoMensual.Text = $"${membresiaSeleccionada.CostoMensual:N2}";
                cmbMetodoPago.SelectedItem = membresiaSeleccionada.Metodo;
            }
        }

        private void LimpiarFormulario()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            cmbTipoMembresia.SelectedIndex = 0;
            clienteSeleccionado = null;
            membresiaSeleccionada = null;
            txtCostoMensual.Clear();
            ActualizarControles();
        }

        private void dgvMembresias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMembresias.CurrentRow != null)
            {
                membresiaSeleccionada = (BE_Membresia)dgvMembresias.CurrentRow.DataBoundItem;
                clienteSeleccionado = membresiaSeleccionada.Cliente;
                txtDNI.Text = clienteSeleccionado.DNI;
                txtNombre.Text = clienteSeleccionado.NombreCompleto();
                MostrarDatosMembresia();
            }
        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Debe ingresar un DNI para buscar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            membresiaSeleccionada = null;

            clienteSeleccionado = gestorCliente.ObtenerporDNI(txtDNI.Text.Trim());

            if (clienteSeleccionado == null)
            {
                MessageBox.Show("No se encontró ningun cliente con el DNI ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtNombre.Text = clienteSeleccionado.NombreCompleto();
            var membresiasCliente = gestorMembresia.ConsultarPorCliente(clienteSeleccionado.ID);
            dgvMembresias.DataSource = membresiasCliente;
            dgvMembresias.ClearSelection();

            if (membresiasCliente.Any())
            {
                membresiaSeleccionada = membresiasCliente.FirstOrDefault(x => x.EstaActiva);
                if (membresiaSeleccionada != null)
                {
                    MostrarDatosMembresia();
                }
                else
                {
                    cmbTipoMembresia.SelectedIndex = 0;
                    CostoMensualMembresia();
                }
            }
            else
            {
                membresiaSeleccionada = null;
            }

            ActualizarControles();
        }

        private void ActualizarGrillaMembresias()
        {
            if (clienteSeleccionado != null)
            {
                var membresiasCliente = gestorMembresia.ConsultarPorCliente(clienteSeleccionado.ID);
                dgvMembresias.DataSource = membresiasCliente;
                if (membresiasCliente.Any())
                {
                    membresiaSeleccionada = membresiasCliente.FirstOrDefault(x => x.EstaActiva);
                    if (membresiaSeleccionada != null)
                    {
                        MostrarDatosMembresia();
                    }
                    else
                    {
                        cmbTipoMembresia.SelectedIndex = 0;
                        CostoMensualMembresia();
                    }
                }
                else
                {
                    membresiaSeleccionada = null;
                }

                ActualizarControles();
            }
        }

        private void ActualizarControles()
        {
            bool clienteSeleccionadoExiste = clienteSeleccionado != null;
            bool tieneMembresiaActiva = membresiaSeleccionada?.EstaActiva ?? false;

            btnAsignarMembresia.Enabled = clienteSeleccionadoExiste && !tieneMembresiaActiva;
            btnRemoverMembresia.Enabled = clienteSeleccionadoExiste && tieneMembresiaActiva;
            cmbTipoMembresia.Enabled = clienteSeleccionadoExiste && !tieneMembresiaActiva;
            cmbMetodoPago.Enabled = clienteSeleccionadoExiste && !tieneMembresiaActiva;

            if (tieneMembresiaActiva)
            {
                cmbTipoMembresia.SelectedItem = membresiaSeleccionada.Tipo;
                txtCostoMensual.Text = $"${membresiaSeleccionada.CostoMensual:N2}";
            }
        }

        private void btnAsignarMembresia_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteSeleccionado == null)
                {
                    MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbMetodoPago.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un método de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var nuevaMembresia = new BE_Membresia
                {
                    Cliente = clienteSeleccionado,
                    Tipo = (TipoMembresia)cmbTipoMembresia.SelectedItem
                };

                nuevaMembresia.ActualizarCostoMensual();

                BE_Membresia.MetodoPagoMembresia metodoPago = (BE_Membresia.MetodoPagoMembresia)cmbMetodoPago.SelectedItem;
                string mensajeMetodo = $"Se realizará un pago de: ${nuevaMembresia.CostoMensual:N2} mediante {metodoPago}";

                if (MessageBox.Show($"{mensajeMetodo}\n¿Desea confirmar la suscripción?",
                                   "Confirmar Suscripción",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (gestorMembresia.Alta(nuevaMembresia))
                    {
                        MessageBox.Show("Membresía asignada correctamente", "Membresía Asignada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarGrillaMembresias();
                        cmbTipoMembresia.SelectedIndex = 0;
                        CostoMensualMembresia();
                        cmbMetodoPago.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoverMembresia_Click_1(object sender, EventArgs e)
        {
            if (membresiaSeleccionada?.EstaActiva != true) return;

            if (MessageBox.Show($"Confirma Cancelar la membresia del Cliente {clienteSeleccionado.NombreCompleto()}?",
                "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (gestorMembresia.CancelarMembresia(membresiaSeleccionada))
                {
                    MessageBox.Show("Membresía cancelada correctamente", "Membresía Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrillaMembresias();
                }
            }
        }

        private void cmbTipoMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CostoMensualMembresia();
        }

        private void CostoMensualMembresia()
        {
            var tipoMembresia = (TipoMembresia)cmbTipoMembresia.SelectedItem;
            var membresia = new BE_Membresia { Tipo = tipoMembresia };  
            membresia.ActualizarCostoMensual();
            txtCostoMensual.Text = $"${membresia.CostoMensual:N2}";
        }
    }
}
