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
            btnAsignarMembresia.Click += btnAsignarMembresia_Click;
            btnRemoverMembresia.Click += btnRemoverMembresia_Click_1;
            btnBuscarCliente.Click += btnBuscarCliente_Click_1;
            dgvMembresias.SelectionChanged += dgvMembresias_SelectionChanged;

        }

        private void Fr_GestionMembresia_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
            CargarMembresias();
        }

        private void ConfigurarControles()
        {
            var membresias = Enum.GetValues(typeof(TipoMembresia));
            cmbTipoMembresia.DataSource = membresias;
        }

        private void CargarMembresias()
        {
            dgvMembresias.DataSource = gestorMembresia.Consultar();
        }

        private void MostrarDatosMembresia()
        {
            if (membresiaSeleccionada != null)
            {
                cmbTipoMembresia.SelectedItem = membresiaSeleccionada.Tipo;
            }
        }

        private void LimpiarFormulario()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            cmbTipoMembresia.SelectedIndex = 0;
            clienteSeleccionado = null;
            membresiaSeleccionada = null;
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

            clienteSeleccionado = gestorCliente.ObtenerporDNI(txtDNI.Text.Trim());

            if (clienteSeleccionado == null)
            {
                MessageBox.Show("No se encontró ningun cliente con el DNI ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtNombre.Text = clienteSeleccionado.NombreCompleto();
            ActualizarGrillaMembresias();
        }

        private void ActualizarGrillaMembresias()
        {
            if (clienteSeleccionado != null)
            {
                var membresiasCliente = gestorMembresia.ConsultarPorCliente(clienteSeleccionado.ID);
                dgvMembresias.DataSource = membresiasCliente;
                membresiaSeleccionada = membresiasCliente.FirstOrDefault(m => m.EstaActiva);
                ActualizarControles();
            }
        }

        private void ActualizarControles()
        {
            bool tieneMembresiaActiva = membresiaSeleccionada?.EstaActiva ?? false;
            btnAsignarMembresia.Enabled = !tieneMembresiaActiva;
            btnRemoverMembresia.Enabled = tieneMembresiaActiva;
            cmbTipoMembresia.Enabled = !tieneMembresiaActiva;

            if (tieneMembresiaActiva)
            {
                cmbTipoMembresia.SelectedItem = membresiaSeleccionada.Tipo;
            }
        }

        private void btnAsignarMembresia_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteSeleccionado == null) return;

                var nuevaMembresia = new BE_Membresia
                {
                    Cliente = clienteSeleccionado,
                    Tipo = (TipoMembresia)cmbTipoMembresia.SelectedItem
                };

                if (gestorMembresia.Alta(nuevaMembresia))
                {
                    MessageBox.Show("Membresía asignada correctamente", "Membresía Asignada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrillaMembresias();
                    LimpiarFormulario();
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
    }
}
