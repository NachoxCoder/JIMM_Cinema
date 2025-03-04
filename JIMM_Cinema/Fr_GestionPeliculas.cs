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
    public partial class Fr_GestionPeliculas : Form
    {
        private readonly BLL_Pelicula gestorPelicula;
        private readonly BLL_Funcion gestorFuncion;
        private readonly BLL_Sala gestorSala;
        //private readonly BLL_Bitacora gestorBitacora;
        private BE_Usuario usuarioActual;
        private BE_Pelicula peliculaSeleccionada;
        private BE_Funcion funcionSeleccionada;

        public Fr_GestionPeliculas()
        {
            InitializeComponent();
            gestorPelicula = new BLL_Pelicula();
            gestorFuncion = new BLL_Funcion();
            gestorSala = new BLL_Sala();
            //gestorBitacora = new BLL_Bitacora();
            //usuarioActual = usuario;
            this.Load += Fr_GestionPeliculas_Load;
        }

        private void Fr_GestionPeliculas_Load(object sender, EventArgs e)
        {
            peliculaSeleccionada = dgvPeliculas.CurrentRow?.DataBoundItem as BE_Pelicula;
            RefrescarGrilla(dgvPeliculas, gestorPelicula.Consultar());
            RefrescarGrilla(dgvFunciones, gestorFuncion.ConsultarFuncionesPorPelicula(peliculaSeleccionada));
            CargarSalas();

        }

        private void btn_NuevaPelicula_Click(object sender, EventArgs e)
        {
            LimpiarFormularioPelicula();
            chkPeliculaActiva.Checked = true;
        }

        private void btnGuardarPelicula_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarPelicula()) return;
                BE_Pelicula pelicula = new BE_Pelicula
                {
                    Titulo = txtTitulo.Text,
                    Sinopsis = txtSinopsis.Text,
                    Duracion = (int)numDuracion.Value,
                    Rating = txtRating.Text,
                    EstaActiva = chkPeliculaActiva.Checked
                };

                gestorPelicula.Alta(pelicula);
                MessageBox.Show("Pelicula guardada correctamente");
                RefrescarGrilla(dgvPeliculas, gestorPelicula.Consultar());
                LimpiarFormularioPelicula();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar pelicula: {ex.Message}");
            }
        }

        private void btnNuevaFuncion_Click(object sender, EventArgs e)
        {
            LimpiarFormularioFuncion();
            chkFuncionActiva.Checked = true;
        }

        private void btnGuardarFuncion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPeliculas.Rows.Count == 0)
                {
                    throw new Exception("Debe seleccionar una película para agregar una función");
                }

                peliculaSeleccionada = (BE_Pelicula)dgvPeliculas.CurrentRow.DataBoundItem;

                if (!ValidarDatosFuncion()) return;

                var nuevaFuncion = new BE_Funcion
                {
                    Pelicula = peliculaSeleccionada,
                    FechaFuncion = dtpFecha.Value.Date,
                    HoraInicio = dtpHoraInicio.Value.TimeOfDay,
                    HoraFin = dtpHoraFin.Value.TimeOfDay,
                    Sala = gestorSala.Consultar().FirstOrDefault(s => s.ID == (int)cmbSala.SelectedValue),
                    Precio = numPrecio.Value,
                    EstaActiva = chkFuncionActiva.Checked,
                };

                gestorFuncion.ValidarHorarios(nuevaFuncion);

                if (gestorFuncion.Alta(nuevaFuncion))
                {
                        MessageBox.Show("Función guardada correctamente");
                        //gestorBitacora.Log(usuarioActual, $"Se guardó la función de la película: {peliculaSeleccionada.Titulo}");
                        RefrescarGrilla(dgvFunciones, gestorFuncion.ConsultarFuncionesPorPelicula(peliculaSeleccionada));
                        LimpiarFormularioFuncion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar función: {ex.Message}");
            }
        }

        private void dgvPeliculas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPeliculas.CurrentRow != null)
            {
                peliculaSeleccionada = (BE_Pelicula)dgvPeliculas.CurrentRow.DataBoundItem;
                if(peliculaSeleccionada != null)
                {
                    MostrarPelicula();
                    RefrescarGrilla(dgvFunciones, gestorFuncion.ConsultarFuncionesPorPelicula(peliculaSeleccionada));
                }
            }
        }

        private void dgvFunciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFunciones.CurrentRow != null)
            {
                MostrarFuncion();
            }
        }

        private void MostrarPelicula()
        {
            txtTitulo.Text = peliculaSeleccionada.Titulo;
            numDuracion.Value = peliculaSeleccionada.Duracion;
            txtSinopsis.Text = peliculaSeleccionada.Sinopsis;
            txtRating.Text = peliculaSeleccionada.Rating;
            chkPeliculaActiva.Checked = peliculaSeleccionada.EstaActiva;
        }

        private void MostrarFuncion()
        {
            if(dgvFunciones.CurrentRow == null)
            {
                return;
            }
            funcionSeleccionada = (BE_Funcion)dgvFunciones.CurrentRow.DataBoundItem;

            if(funcionSeleccionada == null)
            {
                return;
            }

            dtpFecha.Value = funcionSeleccionada.FechaFuncion;
            dtpHoraInicio.Value = DateTime.Today.Add(funcionSeleccionada.HoraInicio);
            dtpHoraFin.Value = DateTime.Today.Add(funcionSeleccionada.HoraFin);
            cmbSala.SelectedValue = funcionSeleccionada.Sala.ID;
            numPrecio.Value = funcionSeleccionada.Precio;
            chkFuncionActiva.Checked = funcionSeleccionada.EstaActiva;
        }

        private void LimpiarFormularioPelicula()
        {
            peliculaSeleccionada = null;
            txtTitulo.Clear();
            numDuracion.Value = 0;
            txtSinopsis.Clear();
            txtRating.Clear();
            chkPeliculaActiva.Checked = false;
        }

        private void LimpiarFormularioFuncion()
        {
            dtpFecha.Value = DateTime.Today;
            dtpHoraInicio.Value = DateTime.Now;
            cmbSala.SelectedIndex = 0;
            numPrecio.Value = 0;
            chkFuncionActiva.Checked = false;
        }

        private void dtpHoraDesde_ValueChanged(object sender, EventArgs e)
        {
            if (peliculaSeleccionada != null)
            {
                TimeSpan duracion = TimeSpan.FromMinutes(peliculaSeleccionada.Duracion + 30);
                dtpHoraFin.Value = dtpHoraInicio.Value.Add(duracion);
            }
        }

        private void btnModificarPelicula_Click(object sender, EventArgs e)
        {
            try
            {
                if (peliculaSeleccionada == null)
                {
                    MessageBox.Show("Seleccione una película para modificar");
                    return;
                }

                peliculaSeleccionada.Titulo = txtTitulo.Text;
                peliculaSeleccionada.Sinopsis = txtSinopsis.Text;
                peliculaSeleccionada.Duracion = (int)numDuracion.Value;
                peliculaSeleccionada.Rating = txtRating.Text;
                peliculaSeleccionada.EstaActiva = chkPeliculaActiva.Checked;

                if (gestorPelicula.Modificar(peliculaSeleccionada))
                {
                    MessageBox.Show("Pelicula modificada correctamente");
                    //gestorBitacora.Log(usuarioActual, $"Se modificó la película: {peliculaSeleccionada.Titulo}");
                    RefrescarGrilla(dgvPeliculas, gestorPelicula.Consultar());
                    LimpiarFormularioPelicula();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void btnEliminarPelicula_Click(object sender, EventArgs e)
        {
            try
            {
                if (peliculaSeleccionada == null)
                {
                    MessageBox.Show("Seleccione una película para eliminar");
                    return;
                }

                if (MessageBox.Show("¿Está seguro que desea eliminar la película?", "Eliminar Película",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (gestorPelicula.Baja(peliculaSeleccionada))
                    {
                        MessageBox.Show("Película eliminada correctamente");
                        //gestorBitacora.Log(usuarioActual, $"Se eliminó la película: {peliculaSeleccionada.Titulo}");
                        RefrescarGrilla(dgvPeliculas, gestorPelicula.Consultar());
                        LimpiarFormularioPelicula();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarFuncion_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcionSeleccionada == null)
                {
                    MessageBox.Show("Seleccione una función para modificar");
                    return;
                }

                funcionSeleccionada.FechaFuncion = dtpFecha.Value.Date;
                funcionSeleccionada.HoraInicio = dtpHoraInicio.Value.TimeOfDay;
                funcionSeleccionada.HoraFin = dtpHoraFin.Value.TimeOfDay;
                funcionSeleccionada.Sala = gestorSala.Consultar().FirstOrDefault(s => s.ID == (int)cmbSala.SelectedValue);
                funcionSeleccionada.Precio = numPrecio.Value;
                funcionSeleccionada.EstaActiva = chkFuncionActiva.Checked;

                gestorFuncion.ValidarHorarios(funcionSeleccionada);

                if (gestorFuncion.Modificar(funcionSeleccionada))
                {
                    MessageBox.Show("Función modificada correctamente");
                    //gestorBitacora.Log(usuarioActual, $"Se modificó la función de la película: {peliculaSeleccionada.Titulo}");
                    RefrescarGrilla(dgvFunciones, gestorFuncion.ConsultarFuncionesPorPelicula(peliculaSeleccionada));
                    LimpiarFormularioFuncion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarFuncion_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcionSeleccionada == null)
                {
                    MessageBox.Show("Seleccione una función para eliminar");
                    return;
                }

                if (MessageBox.Show("¿Está seguro que desea eliminar la función?", "Eliminar Función",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (gestorFuncion.Baja(funcionSeleccionada))
                    {
                        MessageBox.Show("Función eliminada correctamente");
                        //gestorBitacora.Log(usuarioActual, $"Se eliminó la función de la película: {peliculaSeleccionada.Titulo}");
                        RefrescarGrilla(dgvFunciones, gestorFuncion.ConsultarFuncionesPorPelicula(peliculaSeleccionada));
                        LimpiarFormularioFuncion();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidarDatosFuncion()
        {
            if (peliculaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una película para agregar una función");
                return false;
            }

            if (dtpFecha.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha de la función no puede ser anterior a la fecha actual");
                return false;
            }

            if(dtpHoraInicio.Value.TimeOfDay >= dtpHoraFin.Value.TimeOfDay)
            {
                MessageBox.Show("La hora de inicio debe ser menor a la hora de fin");
                return false;
            }

            if (cmbSala.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una sala para la función");
                return false;
            }

            if (numPrecio.Value <= 0)
            {
                MessageBox.Show("El precio de la función debe ser mayor a 0");
                return false;
            }

            return true;
        }


        private void RefrescarGrilla(DataGridView pDgv, object pOrigen)
        {
            pDgv.DataSource = null;
            pDgv.DataSource = pOrigen;
        }


        private void CargarSalas()
        {
            try
            {
                var salas = gestorSala.Consultar();
                cmbSala.DataSource = null;
                cmbSala.DisplayMember = "Nombre";
                cmbSala.ValueMember = "ID";
                cmbSala.DataSource = salas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidarPelicula()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("El título de la película es requerido");
                return false;
            }

            if (numDuracion.Value <= 0)
            {
                MessageBox.Show("La duracion debe ser mayor a 0");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSinopsis.Text))
            {
                throw new Exception("La sinopsis de la pelicula es requerida");
            }

            return true;
        }
    }
}
