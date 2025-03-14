using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;

namespace BLL
{
    public class BLL_Backup
    {
        private readonly string _dataPath;
        private readonly string _backupPath;
        private readonly BLL_Bitacora _gestorBitacora;

        public BLL_Backup()
        {
            _dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATA");
            _backupPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BACKUP");
            _gestorBitacora = new BLL_Bitacora();
        }

        public bool RealizarBackup(string usuarioId)
        {
            try
            {
                if (!Directory.Exists(_backupPath))
                {
                    Directory.CreateDirectory(_backupPath);
                }

                string timestamp = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                string backupFolder = Path.Combine(_backupPath, $"BACKUP-{timestamp}");
                Directory.CreateDirectory(backupFolder);

                if(!Directory.Exists(_dataPath))
                {
                    throw new DirectoryNotFoundException($"No se encontró la carpeta de datos: {_dataPath}");
                }

                foreach (string file in Directory.GetFiles(_dataPath, "*.xml"))
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(backupFolder, fileName);
                    File.Copy(file, destFile, true);
                }

                var mapperUsuario = new MapperUsuario();
                var usuario = mapperUsuario.ConsultarPorID(int.Parse(usuarioId));
                _gestorBitacora.LogEvent("BACKUP", usuario);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar el backup", ex);
            }
        }

        public bool RealizarRestore(string backupFolder, string usuarioId)
        {
            try
            {
                if (!Directory.Exists(backupFolder))
                {
                    throw new DirectoryNotFoundException($"No se encontró la carpeta de backup: {backupFolder}");
                }

                if (!Directory.Exists(_dataPath))
                {
                    Directory.CreateDirectory(_dataPath);
                }

                foreach (string file in Directory.GetFiles(backupFolder, "*.xml"))
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(_dataPath, fileName);
                    File.Copy(file, destFile, true);
                }

                var mapperUsuario = new MapperUsuario();
                var usuario = mapperUsuario.ConsultarPorID(int.Parse(usuarioId));
                _gestorBitacora.LogEvent("RESTORE", usuario);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar el restore", ex);
            }
        }
    }
}
