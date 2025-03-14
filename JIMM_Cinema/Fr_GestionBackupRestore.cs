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
using BE;
using BLL;

namespace UI
{
    public partial class Fr_GestionBackupRestore : Form
    {
        private readonly BLL_Backup gestorBackup;
        private readonly BLL_Bitacora gestorBitacora;
        private readonly BLL_Usuario gestorUsuario;
        private readonly BE_Usuario usuarioActual;
        private int backupEventcount = 0;
        private int restoreEventcount = 0;

        public Fr_GestionBackupRestore(BE_Usuario usuario)
        {
            InitializeComponent();
            gestorBackup = new BLL_Backup();
            gestorBitacora = new BLL_Bitacora();
            gestorUsuario = new BLL_Usuario();
            usuarioActual = usuario;
            this.Load += Fr_GestionBackupRestore_Load;
            btnBackup.Click += btnBackup_Click;
            btnRestore.Click += btnRestore_Click;
        }

        private void Fr_GestionBackupRestore_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            CargarHistorialBackups();
        }

        private void ConfigurarGrilla()
        {
            dgvBackups.AutoGenerateColumns = false;
            dgvBackups.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn {Name = "Fecha", DataPropertyName = "Fecha", HeaderText = "Fecha Regsitro"},
                new DataGridViewTextBoxColumn {Name = "UsuarioId", DataPropertyName = "UsuarioId", HeaderText = "ID Usuario"},
                new DataGridViewTextBoxColumn {Name = "UsuarioNombre", DataPropertyName = "UsuarioNombre", HeaderText = "Nombre Usuario"},
                new DataGridViewTextBoxColumn {Name = "TipoEvento", DataPropertyName = "TipoEvento", HeaderText = "Evento"},
                new DataGridViewTextBoxColumn {Name = "EventoId", DataPropertyName = "EventoId", HeaderText = "ID Evento"}
            });
        }

        private void CargarHistorialBackups()
        {
            try
            {
                var registros = gestorBitacora.Consultar()
                    .Where(b => b.Evento.Contains("BACKUP") || b.Evento.Contains("RESTORE")).Select(x => new
                    {
                        Fecha = x.Fecha,
                        UsuarioId = x.Usuario?.ID,
                        UsuarioNombre = x.Usuario?.Username,
                        TipoEvento = x.Evento.Contains("BACKUP") ? "Backup" : "Restore",
                        EventoId = x.Evento.Contains("BACKUP") ? ++backupEventcount : ++restoreEventcount
                    }).OrderByDescending(x => x.Fecha).ToList();

                dgvBackups.DataSource = registros;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if(gestorBackup.RealizarBackup(usuarioActual.ID.ToString()))
                {
                    MessageBox.Show("Backup realizado con éxito", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarHistorialBackups();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar backup: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBackups.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un backup para restaurar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var fechaSeleccionada = (DateTime)dgvBackups.CurrentRow.Cells["Fecha"].Value;
                string fechaBackup = fechaSeleccionada.ToString("yyyy-MM-dd-HH-mm-ss");

                string backupRootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BACKUP");

                if (!Directory.Exists(backupRootPath))
                {
                    MessageBox.Show("No se encontraron backups para restaurar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var backupFolder = Directory.GetDirectories(backupRootPath).Where(x => Path.GetFileName(x).Contains(fechaBackup)).ToList();

                if (backupFolder.Count == 0)
                {
                    MessageBox.Show("No se encontraron backups para restaurar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string carpetaBackup = backupFolder[0];
                if (MessageBox.Show($"¿Está seguro que desea restaurar el backup de fecha: {fechaSeleccionada:dd/MM/yyyy HH:mm:ss}?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (gestorBackup.RealizarRestore(carpetaBackup, usuarioActual.ID.ToString()))
                    {
                        MessageBox.Show("Restore realizado con éxito", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarHistorialBackups();

                        Application.Restart();
                    }
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar restore: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
