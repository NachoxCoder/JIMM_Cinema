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
        private readonly BE_Usuario usuarioActual;
        private BE_Usuario usuarioSeleccionado;

        public Fr_GestionUsuarios(BE_Usuario usuario)
        {
            InitializeComponent();
            gestorUsuario = new BLL_Usuario();
            usuarioActual = usuario;
            this.Load += Fr_GestionUsuarios_Load;
            btnGuardar.Click += btnGuardar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnModificar.Click += btnModificar_Click;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            btnMostrarPassword.MouseDown += btnMostrarPassword_MouseDown;
            btnMostrarPassword.MouseUp += btnMostrarPassword_MouseUp;
            btnNuevoUsuario.Click += btnNuevoUsuario_Click;
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
                //Remover el usuario actual y el usuario admin
                usuarios.RemoveAll(x => x.ID == usuarioActual.ID || x.ID == 1);
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

                var nuevoUsuario = new BE_Usuario
                {
                    Username = txtUsername.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Area = txtArea.Text,
                    Password = Servicio.Encriptacion.EncriptarPassword(txtPassword.Text),
                    listaPermisos = new List<BE_Componente>()
                };

                gestorUsuario.Alta(nuevoUsuario);
                MessageBox.Show("usuario guardado correctamente");
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
                if (usuarioSeleccionado == null)
                {
                    MessageBox.Show("Debe seleccionar un usuario para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show($"¿Está seguro que desea eliminar el usuario {usuarioSeleccionado.Username}?",
                    "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gestorUsuario.Baja(usuarioSeleccionado);
                    MessageBox.Show("Usuario eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                    LimpiarForm();
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
                usuarioSeleccionado.Password = Servicio.Encriptacion.EncriptarPassword(txtPassword.Text);

                gestorUsuario.Modificar(usuarioSeleccionado);
                MessageBox.Show("usuario modificado correctamente");
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
                btnEliminar.Enabled = true;
            }
        }

        private void Mostrarusuario()
        {
            txtUsername.Text = usuarioSeleccionado.Username;
            txtNombre.Text = usuarioSeleccionado.Nombre;
            txtApellido.Text = usuarioSeleccionado.Apellido;
            txtArea.Text = usuarioSeleccionado.Area;
            txtPassword.Text = Servicio.Encriptacion.DesencriptarPassword(usuarioSeleccionado.Password);
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
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtArea.Text) || 
                    string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
