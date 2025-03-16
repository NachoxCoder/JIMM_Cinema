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
    public partial class Fr_GestionPermisos : Form
    {
        private readonly BLL_Usuario gestorUsuario;
        private readonly BLL_Permiso gestorPermiso;
        private readonly BE_Usuario usuarioActual;


        public Fr_GestionPermisos(BE_Usuario usuario)
        {
            InitializeComponent();
            gestorUsuario = new BLL_Usuario();
            gestorPermiso = new BLL_Permiso();
            usuarioActual = usuario;
            this.Load += Fr_GestionPermisos_Load;
        }

        private void Fr_GestionPermisos_Load(object sender, EventArgs e)
        {
            CargarTreeViews();
            CargarCheckedListPermisos();
        }

        //Cargo todos los TreeView
        private void CargarTreeViews()
        {
            CargarArbolUsuarios();
            CargarArbolRoles();
            CargarArbolPermisos();
            CargarArbolRolesPermisos();
            CargarArbolUsuariosPermisos();
        }

        //TreeView Usuarios
        private void CargarArbolUsuarios()
        {
            tvUsuarios.Nodes.Clear();
            var usuarios = gestorUsuario.Consultar();
            usuarios.RemoveAll(x => x.ID == usuarioActual.ID || x.ID == 1);
            foreach (var usuario in usuarios)
            {
                tvUsuarios.Nodes.Add(new TreeNode(usuario.Username) { Tag = usuario });
            }
        }

        //TreeView Roles
        private void CargarArbolRoles()
        {
            tvRoles.Nodes.Clear();
            foreach (var rol in gestorPermiso.ListarRoles())
            {
                tvRoles.Nodes.Add(new TreeNode(rol.Nombre) { Tag = rol });
            }
        }

        //TreeView Permisos
        private void CargarArbolPermisos()
        {
            tvPermisos.Nodes.Clear();
            foreach (var permiso in gestorPermiso.ListarPermisos())
            {
                tvPermisos.Nodes.Add(new TreeNode(permiso.Nombre) { Tag = permiso });
            }
        }

        //TreeView Roles-Permisos
        private void CargarArbolRolesPermisos()
        {
            tvRolesPermisos.Nodes.Clear();
            foreach (var rol in gestorPermiso.ListarRoles())
            {
                if (rol is BE_Rol rolObj)
                {
                    var nodoRol = new TreeNode(rol.Nombre) { Tag = rol };
                    foreach (var permiso in rolObj.ObtenerHijos())
                    {
                        nodoRol.Nodes.Add(new TreeNode(permiso.Nombre) { Tag = permiso });
                    }
                    tvRolesPermisos.Nodes.Add(nodoRol);
                }
            }
        }

        //TreeView Usuarios-Permisos
        private void CargarArbolUsuariosPermisos()
        {
            tvUsuariosPermisos.Nodes.Clear();
            var usuarios = gestorUsuario.Consultar();
            usuarios.RemoveAll(x => x.ID == usuarioActual.ID);
            foreach (var usuario in usuarios)
            {
                var nodoUsuario = new TreeNode(usuario.Username) { Tag = usuario };
                var permisos = gestorPermiso.ListarPermisosUsuario(usuario);

                foreach (var componente in permisos)
                {
                    var nodoPermiso = new TreeNode(componente.Nombre) { Tag = componente };
                    if (componente is BE_Rol rol)
                    {
                        foreach (var permisoHijo in rol.ObtenerHijos())
                        {
                            nodoPermiso.Nodes.Add(new TreeNode(permisoHijo.Nombre) { Tag = permisoHijo });
                        }
                    }
                    nodoUsuario.Nodes.Add(nodoPermiso);
                }
                tvUsuariosPermisos.Nodes.Add(nodoUsuario);
            }
        }

        //Cargamos la lista de todos los Permisos
        private void CargarCheckedListPermisos()
        {
            clbPermisos.Items.Clear();
            foreach (var permiso in gestorPermiso.ListarPermisos())
            {
                clbPermisos.Items.Add(permiso, false);
            }
        }

        //Boton crear nuevo Rol
        private void btnCrearRol_Click(object sender, EventArgs e)
        {
            try
            {
                //Valido que el ususario haya introducido los datos necesarios para crear un nuevo rol
                if (string.IsNullOrWhiteSpace(txtNombreRol.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre para el rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(clbPermisos.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un permiso para el rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Si los datos existen creamos un nuevo rol asignandole todos los permisos que el usuario haya seleccionado
                var nuevoRol = new BE_Rol(txtNombreRol.Text);

                foreach (BE_Permiso permiso in clbPermisos.CheckedItems)
                {
                    gestorPermiso.AsignarPermisoARol(nuevoRol, permiso);
                }

                if (gestorPermiso.Guardar(nuevoRol))
                {
                    MessageBox.Show("Rol creado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTreeViews();
                    txtNombreRol.Clear();

                    //Limpio el checklistbox
                    for (int i = 0; i < clbPermisos.Items.Count; i++)
                    {
                        clbPermisos.SetItemChecked(i, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton Eliminar Rol
        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprobamos que se encuentre seleccionado un Rol
                if (tvRoles.SelectedNode?.Tag is BE_Rol rolSeleccionado)
                {
                    //Pasamos el rol a la BLL para que lo remueva
                    if (gestorPermiso.Eliminar(rolSeleccionado))
                    {
                        MessageBox.Show("Rol eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTreeViews();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un rol para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton Asignar Permiso a Rol
        private void btnAsignarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificamos que esten seleccionados un Rol y un Permiso es sus respectivos TreeViews
                if (tvRoles.SelectedNode?.Tag is BE_Rol rolSeleccionado &&
                    tvPermisos.SelectedNode?.Tag is BE_Permiso permisoSeleccionado)
                {
                    //Le asigno el permiso seleccionado al rol seleccionado utilizando la BLL
                    if (gestorPermiso.AsignarPermisoARol(rolSeleccionado, permisoSeleccionado))
                    {
                        MessageBox.Show("Permiso asignado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTreeViews();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un rol y un permiso para asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton Quitar Permiso a Rol
        private void btnQuitarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificamos que este seleccionado un permiso dentro de un Rol
                if (tvRolesPermisos.SelectedNode?.Parent != null &&
                    tvRolesPermisos.SelectedNode?.Parent.Tag is BE_Rol rolSeleccionado &&
                    tvRolesPermisos.SelectedNode?.Tag is BE_Permiso permisoSeleccionado)
                {
                    //Utilizamos la BLL para remover el permiso al rol
                    if (gestorPermiso.EliminarPermisoDeRol(rolSeleccionado, permisoSeleccionado))
                    {
                        MessageBox.Show("Permiso removido con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTreeViews();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un permiso para remover", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton asignar Rol a Usuario
        private void btnAsignarRolUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifico que este seleccionado tanto un Usuario como un Rol en sus TreeViews respectivos
                if (tvUsuarios.SelectedNode?.Tag is BE_Usuario usuarioSeleccionado &&
                    tvRoles.SelectedNode?.Tag is BE_Rol rolSeleccionado)
                {
                    //Utilizo a la BLL para asignar el Rol al Usuario
                    if (gestorPermiso.AsignarRolAUsuario(usuarioSeleccionado, rolSeleccionado))
                    {
                        MessageBox.Show("Rol asignado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTreeViews();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un usuario y un rol para asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton Remover Rol a Usuario
        private void btnRemoverRolUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifico que este seleccionado un Rol de un Usuario desde el treeview Usuarios con sus Roles y Permisos
                if (tvUsuariosPermisos.SelectedNode?.Parent != null &&
                    tvUsuariosPermisos.SelectedNode?.Parent.Tag is BE_Usuario usuarioSeleccionado &&
                    tvUsuariosPermisos.SelectedNode?.Tag is BE_Rol rolSeleccionado)
                {
                    //Utilizamos la BLL para remover el Rol del Usuario
                    if (gestorPermiso.RemoverRolDeUsuario(usuarioSeleccionado, rolSeleccionado))
                    {
                        MessageBox.Show("Rol removido con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTreeViews();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un rol para remover", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton para asignar Permiso a Usuario
        private void btnAsignarPermisoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificamos que este seleccionado un Usuario y un Permiso en cada TreeView correspondiente
                if (tvUsuarios.SelectedNode?.Tag is BE_Usuario usuarioSeleccionado &&
                    tvPermisos.SelectedNode?.Tag is BE_Permiso permisoSeleccionado)
                {
                    //Le pasamos a la BLL el usuario y el permiso seleccionado para que asigne el permiso al Usuario
                    if (gestorPermiso.AsignarPermisoUsuario(usuarioSeleccionado, permisoSeleccionado))
                    {
                        MessageBox.Show("Permiso asignado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTreeViews();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un usuario y un permiso para asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoverPermisoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (tvUsuariosPermisos.SelectedNode?.Parent != null &&
                    tvUsuariosPermisos.SelectedNode?.Parent.Tag is BE_Usuario usuarioSeleccionado &&
                    tvUsuariosPermisos.SelectedNode?.Tag is BE_Permiso permisoSeleccionado)
                {
                    if (gestorPermiso.BorrarPermisoUsuario(usuarioSeleccionado, permisoSeleccionado))
                    {
                        MessageBox.Show("Permiso removido con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTreeViews();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un permiso para remover", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tvUsuarios_AfterSelect(object sender, TreeViewEventArgs e)
        {
            BE_Usuario usuarioSeleccionado = tvUsuarios.SelectedNode?.Tag as BE_Usuario;
            txtIdUsuario.Text = usuarioSeleccionado?.ID.ToString();
            txtNombreUsuario.Text = usuarioSeleccionado?.NombreCompleto();
            txtAreaUsuario.Text = usuarioSeleccionado?.Area;
            txtPasswordUsuario.Text = Servicio.Encriptacion.DesencriptarPassword(usuarioSeleccionado?.Password);
            //ActualizarBotones();
        }

        private void tvRoles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //ActualizarBotones();
        }

        private void tvPermisos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            BE_Permiso permisoSeleccionado = tvPermisos.SelectedNode?.Tag as BE_Permiso;
            txtNombrePermiso.Text = permisoSeleccionado?.Nombre;
            //ActualizarBotones();
        }

        private void tvRolesPermisos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //ActualizarBotones();
        }

        private void tvUsuariosPermisos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //ActualizarBotones();
        }

        private void cbxCifrarPassword_CheckedChanged(object sender, EventArgs e)
        {
            BE_Usuario usuarioSeleccionado = tvUsuarios.SelectedNode?.Tag as BE_Usuario;
            
            if(cbxCifrarPassword.Checked)
            {
                txtPasswordUsuario.Text = Servicio.Encriptacion.EncriptarPassword(usuarioSeleccionado.Password);
            }
            else
            {
                txtPasswordUsuario.Text = Servicio.Encriptacion.DesencriptarPassword(usuarioSeleccionado.Password);
            }
        }
        /*
        private void ActualizarBotones()
        {
            btnEliminarRol.Enabled = tvRoles.SelectedNode?.Tag is BE_Rol;
            btnAsignarPermiso.Enabled = tvRoles.SelectedNode?.Tag is BE_Rol && tvPermisos.SelectedNode?.Tag is BE_Permiso;
            btnQuitarPermiso.Enabled = tvRolesPermisos.SelectedNode?.Tag is BE_Permiso && tvRolesPermisos.SelectedNode?.Parent != null;
            btnAsignarRolUsuario.Enabled = tvUsuarios.SelectedNode?.Tag is BE_Usuario && tvRoles.SelectedNode?.Tag is BE_Rol;
            btnRemoverRolUsuario.Enabled = tvUsuariosPermisos.SelectedNode?.Tag is BE_Rol && tvUsuariosPermisos.SelectedNode?.Parent != null;
            btnAsignarPermisoUsuario.Enabled = tvUsuarios.SelectedNode?.Tag is BE_Usuario && tvPermisos.SelectedNode?.Tag is BE_Permiso;
            btnRemoverPermisoUsuario.Enabled = tvUsuariosPermisos.SelectedNode?.Tag is BE_Permiso && tvUsuariosPermisos.SelectedNode?.Parent != null;
        }*/
    }
}
