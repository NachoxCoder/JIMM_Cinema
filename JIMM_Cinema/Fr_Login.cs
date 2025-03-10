using BLL;
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
using Servicio;
using Gestion_Cine;

namespace UI
{
    public partial class Fr_Login : Form
    {
        private readonly BLL_Usuario gestorUsuario;
        private readonly BLL_Bitacora gestorBitacora;
        private int iniciosDeSesion;
        private const int maxIntentos = 3;
        public Fr_Login()
        {
            InitializeComponent();
            gestorUsuario = new BLL_Usuario();
            gestorBitacora = new BLL_Bitacora();
            iniciosDeSesion = 0;
        }

        public void Fr_Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            AcceptButton = btnIngresar;
            txtUsername.Clear();
            txtPassword.Clear();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Debe ingresar un usuario y una contraseña", "Campos Requeridos",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var usuario = new BE_Usuario
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };

                if (gestorUsuario.ValidarCredenciales(usuario.Username, usuario.Password))
                {
                    //Traer la data del usuario
                    usuario = gestorUsuario.Consultar()
                               .Find(x => x.Username.ToLower() == txtUsername.Text.ToLower());

                    Hide();
                    new Fr_MenuPrincipal(usuario, this).Show();
                }
                else
                {
                    iniciosDeSesion++;
                    if (iniciosDeSesion >= maxIntentos)
                    {
                        MessageBox.Show("Se ha superado el máximo de intentos permitidos. La aplicacion se cerrara." +
                                        "Contacte a un Administrador del Sistema", "Error de Seguridad",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    MessageBox.Show($"Usuario o contraseña incorrectos. Intentos Restantes: " +
                                    $"{maxIntentos - iniciosDeSesion}", "Error de Autenticacion",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al intentar Iniciar Sesion",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarPassword_MouseDown(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnMostrarPassword_MouseUp(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            Application.Exit();
        }
    }
}
