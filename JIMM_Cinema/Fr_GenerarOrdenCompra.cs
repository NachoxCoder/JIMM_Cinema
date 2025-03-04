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

namespace UI
{
    public partial class Fr_GenerarOrdenCompra : Form
    {
        private Dictionary<BE_Producto, int> productosCantidad;
        private readonly BLL_OrdenCompra _gestorOrdenCompra;
        private readonly BLL_Proveedor _gestorProveedor;
        private readonly BLL_Producto _gestorProducto;

        public Fr_GenerarOrdenCompra()
        {
            InitializeComponent();
            _gestorOrdenCompra = new BLL_OrdenCompra();
            _gestorProveedor = new BLL_Proveedor();
            _gestorProducto = new BLL_Producto();
            productosCantidad = new Dictionary<BE_Producto, int>();
        }

        private void Fr_GenerarOrdenCompra_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            ActualizarTotal();
        }

        private void CargarProveedores()
        {
            try
            {
                var proveedores = _gestorProveedor.ConsultarProveedoresActivos();
                cmbProveedor.DataSource = null;
                cmbProveedor.DisplayMember = "RazonSocial";
                cmbProveedor.ValueMember = "ID";
                cmbProveedor.DataSource = proveedores;

                if (proveedores.Any())
                {
                    cmbProveedor.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var proveedor = cmbProveedor.SelectedItem as BE_Proveedor;
                if (proveedor != null && proveedor.Productos != null)
                {
                    var productos = proveedor.Productos.Where(x => x.EstaActivo).ToList();
                    cmbProducto.DataSource = null;
                    cmbProducto.DisplayMember = "NombreProducto";
                    cmbProducto.ValueMember = "ID";
                    cmbProducto.DataSource = productos;

                    if (cmbProducto.Items.Count > 0)
                    {
                        cmbProducto.SelectedIndex = 0;
                    }
                }
                else
                {
                    cmbProducto.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProducto.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (numCantidad.Value <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var producto = cmbProducto.SelectedItem as BE_Producto;
                int cantidad = (int)numCantidad.Value;

                if (producto != null)
                {
                    if (productosCantidad.ContainsKey(producto))
                    {
                        productosCantidad[producto] += cantidad;
                    }
                    else
                    {
                        productosCantidad.Add(producto, cantidad);
                    }
                }

                RefrescarGrilla();
                ActualizarTotal();
                numCantidad.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarGrilla()
        {
            dgvOrdenCompra.DataSource = null;
            dgvOrdenCompra.DataSource = productosCantidad.Select(x => new { ProductoNombre = x.Key.NombreProducto,
                PrecioUnitario = x.Key.PrecioProducto,Cantidad = x.Value, Subtotal = x.Key.PrecioProducto * x.Value}).ToList();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (productosCantidad.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbProveedor.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var ordenCompra = new BE_OrdenCompra();
                ordenCompra.Proveedor = cmbProveedor.SelectedItem as BE_Proveedor;
                ordenCompra.Items = new List<ItemOrdenCompra>();
                foreach (var kvp in productosCantidad)
                {
                    ordenCompra.Items.Add(new ItemOrdenCompra { Producto = kvp.Key, Cantidad = kvp.Value });
                }
                ordenCompra.FechaOrdenCompra = DateTime.Now;
                _gestorOrdenCompra.Alta(ordenCompra);

                MessageBox.Show("Orden de compra generada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la orden de compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarTotal()
        {
            decimal total = 0;
            foreach (var item in productosCantidad)
            {
                total += item.Key.PrecioProducto * item.Value;
            }
            lblTotal.Text = $"Total: {total:N2}";
        }

        private void LimpiarFormulario()
        {
            productosCantidad.Clear();
            dgvOrdenCompra.DataSource = null;
            numCantidad.Value = 0;
            if (cmbProveedor.Items.Count > 0)
            {
                cmbProveedor.SelectedIndex = 0;
            }
            RefrescarGrilla();
            ActualizarTotal();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvOrdenCompra.CurrentRow == null || dgvOrdenCompra.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un producto para remover", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombreProducto = dgvOrdenCompra.CurrentRow.Cells["ProductoNombre"].Value.ToString();

                var productoRemover = productosCantidad.Keys.FirstOrDefault(x => x.NombreProducto == nombreProducto);

                if(productoRemover != null)
                {
                    productosCantidad.Remove(productoRemover);
                    RefrescarGrilla();
                    ActualizarTotal();
                    MessageBox.Show("Producto removido correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al remover producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
