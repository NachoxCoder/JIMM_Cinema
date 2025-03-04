using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace Gestion_Cine
{
    public partial class Fr_GestionCliente : Form
    {
        private readonly BLL_Cliente gestorCliente;
        private BE_Cliente clienteSeleccionado;

        public Fr_GestionCliente()
        {
            InitializeComponent();
            gestorCliente = new BLL_Cliente();
        }

        private void Fr_GestionCliente_Load_1(object sender, EventArgs e)
        {
            RefrescarGrilla(dgvClientes, gestorCliente.Consultar());
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtDNI.Enabled = true;
            LimpiarFormulario();
            dgvClientes.ClearSelection();
        }

        private void RefrescarGrilla(DataGridView pDgv, object pOrigen)
        {
            pDgv.DataSource = null;
            pDgv.DataSource = pOrigen;
        }


        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El nombre y apellido son obligatorios");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("El DNI es obligatorio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("El email es invalido");
                return false;
            }

            if (dtpFechaNacimiento.Value > DateTime.Today.AddYears(-16))
            {
                MessageBox.Show("La fecha de nacimiento debe ser ayor a 16 años");
                return false;
            }

            return true;
        }

        private void MostrarCliente()
        {
            txtDNI.Enabled = false;

            txtNombre.Text = clienteSeleccionado.Nombre;
            txtApellido.Text = clienteSeleccionado.Apellido;
            txtDNI.Text = clienteSeleccionado.DNI;
            dtpFechaNacimiento.Value = clienteSeleccionado.FechaNacimiento;
            txtEmail.Text = clienteSeleccionado.Email;
            txtTelefono.Text = clienteSeleccionado.Telefono;
            txtDireccion.Text = clienteSeleccionado.Direccion;
        }

        private void LimpiarFormulario()
        {
            clienteSeleccionado = null;
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            dtpFechaNacimiento.Value = DateTime.Today.AddYears(-16);
            txtEmail.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null || !ValidarDatos()) return;
            try
            {
                clienteSeleccionado.Nombre = txtNombre.Text;
                clienteSeleccionado.Apellido = txtApellido.Text;
                clienteSeleccionado.Email = txtEmail.Text;
                clienteSeleccionado.Telefono = txtTelefono.Text;
                clienteSeleccionado.Direccion = txtDireccion.Text;
                clienteSeleccionado.FechaNacimiento = dtpFechaNacimiento.Value;

                if (gestorCliente.Modificar(clienteSeleccionado))
                {
                    MessageBox.Show("Cliente modificado correctamente");
                    //gestorBitacora.Log(usuarioActual, $"Se modificó el cliente: {clienteSeleccionado.NombreCompleto()}");
                    RefrescarGrilla(dgvClientes, gestorCliente.Consultar());
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar cliente: {ex.Message}");
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarDatos()) return;

                BE_Cliente cliente = new BE_Cliente
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    DNI = txtDNI.Text,
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    Email = txtEmail.Text,
                    Telefono = txtTelefono.Text,
                    Direccion = txtDireccion.Text
                };

                gestorCliente.Alta(cliente);

                MessageBox.Show("Cliente guardado correctamente");
                //gestorBitacora.Log(usuarioActual, $"Se guardó el cliente: {clienteSeleccionado.NombreCompleto()}");
                RefrescarGrilla(dgvClientes, gestorCliente.Consultar());
                LimpiarFormulario();
                txtDNI.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar client:{ex.Message}");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null) return;
            if (MessageBox.Show("Esta seguro que se desea eliminar al cliente: " +
                $"{clienteSeleccionado.NombreCompleto()}?", "Eliminar cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (gestorCliente.Baja(clienteSeleccionado))
                    {
                        MessageBox.Show("Cliente eliminado correctamente");
                        //gestorBitacora.Log(usuarioActual, $"Se eliminó el cliente: {clienteSeleccionado.NombreCompleto()}");
                        RefrescarGrilla(dgvClientes, gestorCliente.Consultar());
                        LimpiarFormulario();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvClientes_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                clienteSeleccionado = (BE_Cliente)dgvClientes.CurrentRow.DataBoundItem;
                MostrarCliente();
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            txtDNI.Enabled = true;
            LimpiarFormulario();
        }
    }
}
