﻿using BLL;
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
        private bool contraseñaVisible = false;

        public Fr_Login()
        {
            InitializeComponent();
            gestorUsuario = new BLL_Usuario();
            gestorBitacora = new BLL_Bitacora();
            iniciosDeSesion = 0;
            this.Load += Fr_Login_Load;
            btnIngresar.Click += btnIngresar_Click;
            btnSalir.Click += btnSalir_Click;
            btnMostrarPassword.Click += btnMostrarPassword_Click;
        }

        public void Fr_Login_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            AcceptButton = btnIngresar;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMostrarPassword_Click(object sender, EventArgs e)
        {
            contraseñaVisible = !contraseñaVisible;

            if(contraseñaVisible)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
