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

namespace UI
{
    public partial class Fr_GestionUsuarios : Form
    {
        private readonly BLL_Usuario gestorUsuario;
        //private readonly BLL_Bitacora gestorBitacora;
        private readonly BE_Usuario usuarioActual;
        private BE_Usuario usuarioSeleccionado;

        public Fr_GestionUsuarios()
        {
            InitializeComponent();
            gestorUsuario = new BLL_Usuario();
            //gestorBitacora = new BLL_Bitacora();
            //usuarioActual = usuario;
        }

        private void Fr_GestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            btnEliminar.Enabled = false;
        }

        private void CargarUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = null;
                var usuarios = gestorUsuario.Consultar();
                usuarios.RemoveAll(x => x.ID == usuarioActual.ID);
                dgvUsuarios.DataSource = usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarDatos()) return;

                if (usuarioSeleccionado == null)
                    usuarioSeleccionado = new BE_Usuario();

                usuarioSeleccionado.Username = txtUsername.Text;
                usuarioSeleccionado.Nombre = txtNombre.Text;
                usuarioSeleccionado.Apellido = txtApellido.Text;
                usuarioSeleccionado.Area = txtArea.Text;
                usuarioSeleccionado.Password = Servicio.Encriptacion.EncriptarPassword(txtPassword.Text);

                gestorUsuario.Alta(usuarioSeleccionado);
                MessageBox.Show("usuario guardado correctamente");
                //gestorBitacora.Log(usuarioActual, $"Se ha guardado el usuario {usuarioSeleccionado.Username}");
                CargarUsuarios();
                LimpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el usuario: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuarioSeleccionado != null)
                {
                    if (MessageBox.Show($"¿Está seguro que desea eliminar el usuario {usuarioSeleccionado.Username}?", "Eliminar usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        gestorUsuario.Baja(usuarioSeleccionado);
                            MessageBox.Show("usuario eliminado correctamente");
                            //gestorBitacora.Log(usuarioActual, $"Se ha eliminado el usuario {usuarioSeleccionado.Username}");
                            CargarUsuarios();
                            LimpiarForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el usuario: {ex.Message}");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuarioSeleccionado == null)
                {
                    MessageBox.Show("Debe seleccionar un usuario para modificar");
                    return;
                }

                if (!ValidarDatos()) return;

                usuarioSeleccionado.Username = txtUsername.Text;
                usuarioSeleccionado.Nombre = txtNombre.Text;
                usuarioSeleccionado.Apellido = txtApellido.Text;
                usuarioSeleccionado.Area = txtArea.Text;

                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    usuarioSeleccionado.Password = Servicio.Encriptacion.EncriptarPassword(txtPassword.Text);
                }

                gestorUsuario.Modificar(usuarioSeleccionado);
                MessageBox.Show("usuario modificado correctamente");
                //gestorBitacora.Log(usuarioActual, $"Se ha modificado el usuario: {usuarioSeleccionado.Username}");
                CargarUsuarios();
                LimpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar usuario: {ex.Message}");
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                usuarioSeleccionado = (BE_Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                Mostrarusuario();
                HabilitarControles(false);
                btnEliminar.Enabled = true;
            }
        }

        private void Mostrarusuario()
        {
            txtUsername.Text = usuarioSeleccionado.Username;
            txtNombre.Text = usuarioSeleccionado.Nombre;
            txtApellido.Text = usuarioSeleccionado.Apellido;
            txtArea.Text = usuarioSeleccionado.Area;
            txtPassword.Text = "*********";
        }

        private void LimpiarForm()
        {
            usuarioSeleccionado = null;
            txtUsername.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtArea.Clear();
            txtPassword.Clear();
            btnEliminar.Enabled = false;
            HabilitarControles(true);
        }

        private void HabilitarControles(bool habilitar)
        {
            txtUsername.ReadOnly = !habilitar;
            txtNombre.ReadOnly = !habilitar;
            txtApellido.ReadOnly = !habilitar;
            txtArea.ReadOnly = !habilitar;
            txtPassword.ReadOnly = !habilitar;
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtArea.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }

            return true;
        }

        private void btnMostrarPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnMostrarPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
    }
}
