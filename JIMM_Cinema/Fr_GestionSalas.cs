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
    public partial class Fr_GestionSalas : Form
    {
        private readonly BLL_Sala gestorSala;
        private BE_Sala salaSeleccionada;
        public Fr_GestionSalas()
        {
            InitializeComponent();
            gestorSala = new BLL_Sala();
            this.Load += Fr_GestionSalas_Load;
            btnEliminarSala.Click += btnEliminarSala_Click;
            btnGuardarSala.Click += btnGuardarSala_Click;
            dgvSalas.SelectionChanged += dgvSalas_SelectionChanged;
            btnModificarSala.Click += btnModificarSala_Click;
            btnNuevaSala.Click += btnNuevaSala_Click;
        }

        private void Fr_GestionSalas_Load(object sender, EventArgs e)
        {
            CargarSalas();
        }

        private void CargarSalas()
        {
            try
            {
                dgvSalas.DataSource = null;
                dgvSalas.DataSource = gestorSala.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardarSala_Click(object sender, EventArgs e)
        {   
            try
            {
                if (!ValidarDatos()) return;
                BE_Sala sala = new BE_Sala
                {
                    Nombre = txtNombreSala.Text,
                    Capacidad = (int)numCapacidad.Value,
                    Tiene3D = chk3D.Checked
                };
                for (int i = 65; i < numFilas.Value + 65; i++)
                {
                    for (int j = 1; j < numButacasPorFila.Value + 1; j++)
                    {
                        char letraFila = (char)i;

                        BE_Butaca butaca = new BE_Butaca
                        {
                            Fila = letraFila.ToString(),
                            Numero = j,
                            Disponible = true
                        };

                        sala.Butacas.Add(butaca);
                    }
                }
                gestorSala.Alta(sala);
                MessageBox.Show("Sala guardada correctamente");
                CargarSalas();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreSala.Text))
            {
                MessageBox.Show("El nombre de la sala no puede estar vacío");
                return false;
            }

            int totalButacas = (int)numFilas.Value * (int)numButacasPorFila.Value;

            if (numCapacidad.Value <= 0 || numCapacidad.Value != totalButacas)
            {
                MessageBox.Show($"La capacidad de la sala debe ser mayor a 0 e igual al numero de butacas declarado, " +
                    $"(multiplicacion de numero de filas por butacas en cada fila: {totalButacas}");
                return false;
            }

            return true;
        }

        private void btnEliminarSala_Click(object sender, EventArgs e)
        {
            try
            {
                if (salaSeleccionada == null)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar la sala seleccionada?",
                        "Eliminar Sala", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (gestorSala.Baja(salaSeleccionada))
                        {
                            MessageBox.Show("Sala eliminada correctamente");
                            CargarSalas();
                            LimpiarFormulario();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar sala: {ex.Message}");
            }
        }

        private void dgvSalas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSalas.CurrentRow != null)
            {
                salaSeleccionada = (BE_Sala)dgvSalas.CurrentRow.DataBoundItem;
                MostrarSala();
            }
        }

        private void MostrarSala()
        {
            txtNombreSala.Text = salaSeleccionada.Nombre;
            numCapacidad.Value = salaSeleccionada.Capacidad;
            chk3D.Checked = salaSeleccionada.Tiene3D;
        }

        private void LimpiarFormulario()
        {
            salaSeleccionada = null;
            txtNombreSala.Clear();
            numCapacidad.Value = 0;
            chk3D.Checked = false;
            numFilas.Value = 0;
            numButacasPorFila.Value = 0;
        }

        private void btnModificarSala_Click(object sender, EventArgs e)
        {
            try
            {
                if (salaSeleccionada == null)
                {
                    MessageBox.Show("Debe seleccionar una sala", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidarDatos()) return;

                salaSeleccionada.Nombre = txtNombreSala.Text;
                salaSeleccionada.Capacidad = (int)numCapacidad.Value;
                salaSeleccionada.Tiene3D = chk3D.Checked;

                if (gestorSala.Modificar(salaSeleccionada))
                {
                    MessageBox.Show("Sala modificada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarSalas();
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevaSala_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
