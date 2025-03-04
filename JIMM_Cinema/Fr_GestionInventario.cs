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
    public partial class Fr_GestionInventario : Form
    {
        private readonly BLL_Producto gestorProducto;
        private readonly BLL_Proveedor gestorProveedor;
        //private readonly BLL_Bitacora gestorBitacora;
        //private readonly BE_Empleado usuarioActual;
        private BE_Producto productoSeleccionado;
        private BE_Proveedor proveedorSeleccionado;


        public Fr_GestionInventario()
        {
            InitializeComponent();
            gestorProducto = new BLL_Producto();
            gestorProveedor = new BLL_Proveedor();
            //gestorBitacora = new BLL_Bitacora();
            //usuarioActual = usuario;
            this.Load += Fr_GestionInventario_Load;
        }

        private void Fr_GestionInventario_Load(object sender, EventArgs e)
        {
            RefrescarGrilla(dgvProveedor, gestorProveedor.Consultar());
            proveedorSeleccionado = dgvProveedor.CurrentRow?.DataBoundItem as BE_Proveedor;
            if (proveedorSeleccionado != null)
            {
                RefrescarGrilla(dgvProductos, proveedorSeleccionado.Productos);
            }
            else
            {
                dgvProductos.DataSource = null;
            }
            CargarProductosBajoStock();
        }

        private void CargarProductosBajoStock()
        {
            try
            {
                var productosBajoStock = gestorProducto.ConsultarConStockBajo();

                if (productosBajoStock.Any())
                {
                    lblAlerta.Text = $"Hay {productosBajoStock.Count} productos con stock bajo";
                    lblAlerta.ForeColor = Color.Red;
                    lblAlerta.Visible = true;
                    lblAlerta.Cursor = Cursors.Hand;
                    lblAlerta.Tag = productosBajoStock;
                }
                else
                {
                    lblAlerta.Text = "No hay productos con stock bajo";
                    lblAlerta.ForeColor = Color.Green;
                    lblAlerta.Cursor = Cursors.Default;
                    lblAlerta.Tag = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProveedor.Rows.Count == 0)
                {
                    throw new Exception("Debe seleccionar una Proveedor para agregar un producto");
                }

                proveedorSeleccionado = (BE_Proveedor)dgvProveedor.CurrentRow.DataBoundItem;

                if (!ValidarDatos()) return;
                {
                    var producto = new BE_Producto
                    {
                        NombreProducto = txtNombreProducto.Text,
                        DescripcionProducto = txtDescripcionProducto.Text,
                        PrecioProducto = numPrecioProducto.Value,
                        Stock = (int)numStockProducto.Value,
                        EstaActivo = true
                    };

                    gestorProducto.Alta(producto);
                    gestorProveedor.AgregarProducto(proveedorSeleccionado, producto);
                    //gestorBitacora.Log(usuarioActual, $"Producto: {productoSeleccionado.NombreProducto} agregado");
                    MessageBox.Show("Producto creado con éxito", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    proveedorSeleccionado = gestorProveedor.ConsultarPorID(proveedorSeleccionado.ID);
                    RefrescarGrilla(dgvProductos, proveedorSeleccionado.Productos);
                    CargarProductosBajoStock();
                    LimpiarFormularioProducto();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("Ingrese un nombre para el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcionProducto.Text))
            {
                MessageBox.Show("Ingrese una descripción para el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numPrecioProducto.Value <= 0)
            {
                MessageBox.Show("Ingrese un precio mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numStockProducto.Value < 0)
            {
                MessageBox.Show("El stock NO puede ser negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void LimpiarFormularioProducto()
        {
            productoSeleccionado = null;
            txtNombreProducto.Clear();
            txtDescripcionProducto.Clear();
            numPrecioProducto.Value = 0;
            numStockProducto.Value = 0;
            btnEliminarProducto.Enabled = false;
            chkProductoActivo.Checked = true;
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (productoSeleccionado == null)
                {
                    MessageBox.Show("Seleccione un producto para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("¿Está seguro que desea eliminar el producto seleccionado?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int proveedorID = proveedorSeleccionado.ID;

                    dgvProductos.SelectionChanged -= dgvProductos_SelectionChanged;

                    gestorProveedor.RemoverProducto(proveedorSeleccionado, productoSeleccionado);
                    gestorProducto.Baja(productoSeleccionado);
                    //gestorBitacora.Log(usuarioActual, $"Producto: {productoSeleccionado.NombreProducto} eliminado");
                    MessageBox.Show("Producto eliminado con éxito", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProductos.DataSource = null;
                    proveedorSeleccionado = gestorProveedor.ConsultarPorID(proveedorID);
                    if (proveedorSeleccionado != null)
                    {
                        RefrescarGrilla(dgvProductos, proveedorSeleccionado.Productos);
                    }
                    CargarProductosBajoStock();
                    LimpiarFormularioProducto();

                    dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.CurrentRow != null && dgvProductos.DataSource != null)
                {
                    productoSeleccionado = (BE_Producto)dgvProductos.CurrentRow.DataBoundItem;
                    if (productoSeleccionado != null)
                    {
                        txtNombreProducto.Text = productoSeleccionado.NombreProducto;
                        txtDescripcionProducto.Text = productoSeleccionado.DescripcionProducto;
                        numPrecioProducto.Value = productoSeleccionado.PrecioProducto;
                        numStockProducto.Value = productoSeleccionado.Stock;
                        btnEliminarProducto.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in selection changed: {ex.Message}");
                productoSeleccionado = null;
            }

        }

        private void RefrescarGrilla(DataGridView pDgv, object pOrigen)
        {
            pDgv.DataSource = null;
            pDgv.DataSource = pOrigen;
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            LimpiarFormularioProducto();
            productoSeleccionado = null;
            txtNombreProducto.Focus();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            LimpiarFormularioProveedor();
            proveedorSeleccionado = null;
            txtRazonSocial.Focus();
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (!ValidarDatosProveedor()) return;

            try
            {
                var proveedor = new BE_Proveedor
                {
                    RazonSocial = txtRazonSocial.Text,
                    CUIT = txtCuit.Text,
                    DireccionProveedor = txtDireccionProveedor.Text,
                    EmailProveedor = txtEmailProveedor.Text,
                    EstaActivo = true
                };

                gestorProveedor.Alta(proveedor);
                //gestorBitacora.Log(usuarioActual, $"Proveedor: {proveedorSeleccionado.RazonSocial} agregado");
                MessageBox.Show("Proveedor creado con éxito", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarGrilla(dgvProveedor, gestorProveedor.Consultar());
                RefrescarGrilla(dgvProductos, proveedor.Productos);
                LimpiarFormularioProveedor();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (productoSeleccionado == null)
                {
                    MessageBox.Show("Seleccione un producto para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                productoSeleccionado.NombreProducto = txtNombreProducto.Text;
                productoSeleccionado.DescripcionProducto = txtDescripcionProducto.Text;
                productoSeleccionado.PrecioProducto = numPrecioProducto.Value;
                productoSeleccionado.Stock = (int)numStockProducto.Value;

                gestorProducto.Modificar(productoSeleccionado);
                gestorProveedor.ActualizarProductos(productoSeleccionado);
                //gestorBitacora.Log(usuarioActual, $"Producto: {productoSeleccionado.NombreProducto} modificado");
                MessageBox.Show("Producto modificado con éxito", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                proveedorSeleccionado = gestorProveedor.ConsultarPorID(proveedorSeleccionado.ID);
                RefrescarGrilla(dgvProductos, proveedorSeleccionado.Productos);
                CargarProductosBajoStock();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (proveedorSeleccionado == null)
            {
                MessageBox.Show("Seleccione un proveedor para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var productos = proveedorSeleccionado.Productos?.Count ?? 0;
            string mensaje = "¿Está seguro que desea eliminar el proveedor seleccionado?" +
                (productos > 0 ? $"\n\nSe eliminaran tambien {productos} productos asociados al proveedor" : "");

            if (MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    gestorProveedor.Baja(proveedorSeleccionado);
                    //gestorBitacora.Log(usuarioActual, $"Proveedor: {proveedorSeleccionado.RazonSocial} eliminado");
                    MessageBox.Show("Proveedor y sus productos asociados fueron eliminados con éxito", "Proveedor",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarGrilla(dgvProveedor, gestorProveedor.Consultar());
                    RefrescarGrilla(dgvProductos, proveedorSeleccionado.Productos);
                    LimpiarFormularioProveedor();
                    CargarProductosBajoStock();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProveedor_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProveedor.CurrentRow != null)
            {
                proveedorSeleccionado = (BE_Proveedor)dgvProveedor.CurrentRow.DataBoundItem;
                txtCuit.Text = proveedorSeleccionado.CUIT;
                txtRazonSocial.Text = proveedorSeleccionado.RazonSocial;
                txtDireccionProveedor.Text = proveedorSeleccionado.DireccionProveedor;
                txtEmailProveedor.Text = proveedorSeleccionado.EmailProveedor;
                btnEliminarProveedor.Enabled = true;

                RefrescarGrilla(dgvProductos, proveedorSeleccionado.Productos);
            }
            else
            {
                dgvProductos.DataSource = null;
            }
        }

        private void LimpiarFormularioProveedor()
        {
            proveedorSeleccionado = null;
            txtRazonSocial.Clear();
            txtCuit.Clear();
            txtDireccionProveedor.Clear();
            txtEmailProveedor.Clear();
            btnEliminarProveedor.Enabled = false;
            chkProveedorActivo.Checked = true;
        }

        private bool ValidarDatosProducto()
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("Ingrese un nombre para el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcionProducto.Text))
            {
                MessageBox.Show("Ingrese una descripción para el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numPrecioProducto.Value <= 0)
            {
                MessageBox.Show("Ingrese un precio mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numStockProducto.Value < 0)
            {
                MessageBox.Show("El stock NO puede ser negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidarDatosProveedor()
        {
            if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                MessageBox.Show("Ingrese una razón social para el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCuit.Text))
            {
                MessageBox.Show("Ingrese un CUIT para el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccionProveedor.Text))
            {
                MessageBox.Show("Ingrese una dirección para el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmailProveedor.Text))
            {
                MessageBox.Show("Ingrese un email para el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnGenerarOrdenCompra_Click(object sender, EventArgs e)
        {
            var frmGenerarOrdenCompra = new Fr_GenerarOrdenCompra();
            frmGenerarOrdenCompra.ShowDialog();
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (proveedorSeleccionado == null)
                {
                    MessageBox.Show("Seleccione un proveedor para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidarDatosProveedor()) return;

                proveedorSeleccionado.RazonSocial = txtRazonSocial.Text;
                proveedorSeleccionado.CUIT = txtCuit.Text;
                proveedorSeleccionado.DireccionProveedor = txtDireccionProveedor.Text;
                proveedorSeleccionado.EmailProveedor = txtEmailProveedor.Text;
                proveedorSeleccionado.EstaActivo = chkProveedorActivo.Checked;

                gestorProveedor.Modificar(proveedorSeleccionado);
                //gestorBitacora.Log(usuarioActual, $"Proveedor: {proveedorSeleccionado.RazonSocial} modificado");
                MessageBox.Show("Proveedor modificado con éxito", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarGrilla(dgvProveedor, gestorProveedor.Consultar());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar proveedor: {ex.Message}");
            }
        }

        private void lblAlerta_Click(object sender, EventArgs e)
        {
            if(lblAlerta.Tag is List<BE_Producto> productos)
            {
                StringBuilder message = new StringBuilder("Productos con bajo stock: \n\n");

                foreach (var producto in productos)
                {
                    message.AppendLine($"{producto.NombreProducto} - Stock: {producto.Stock}");
                }

                MessageBox.Show(message.ToString(), "Productos con bajo stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
