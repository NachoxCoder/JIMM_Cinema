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
    public partial class Fr_GestionFacturas : Form
    {
        private readonly BLL_FacturaProveedor _gestorFacturaProveedor;
        private readonly BLL_Proveedor _gestorProveedor;
        private readonly BLL_OrdenCompra _gestorOrdenCompra;
        private BE_FacturaProveedor facturaSeleccionada;
        private BE_OrdenCompra ordenCompraSeleccionada;

        public Fr_GestionFacturas()
        {
            InitializeComponent();
            _gestorFacturaProveedor = new BLL_FacturaProveedor();
            _gestorOrdenCompra = new BLL_OrdenCompra();
            _gestorProveedor = new BLL_Proveedor();
        }

        private void Fr_GestionFacturas_Load(object sender, EventArgs e)
        {
            RefrescarGrilla(dgvOrdenesCompra, _gestorOrdenCompra.Consultar());
            ordenCompraSeleccionada = dgvOrdenesCompra.CurrentRow?.DataBoundItem as BE_OrdenCompra;
            if (ordenCompraSeleccionada != null)
            {
                RefrescarGrilla(dgvFacturas, ordenCompraSeleccionada.Facturas);
            }
            else
            {
                dgvFacturas.DataSource = null;
            }

            CargarMetodosPago();
            ConfigurarControles();
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarDatos())
                    return;

                if (ordenCompraSeleccionada == null)
                {
                    MessageBox.Show("Debe seleccionar una orden de compra", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var factura = new BE_FacturaProveedor
                {
                    NumeroFactura = txtNumeroFactura.Text,
                    Proveedor = ordenCompraSeleccionada.Proveedor,
                    Monto = decimal.Parse(txtMontoFactura.Text),
                    FechaEmision = dtpFechaFactura.Value,
                    MetodoPago = string.Empty,
                    EstaPagada = false
                };

                _gestorFacturaProveedor.Alta(factura);
                _gestorOrdenCompra.AgregarFactura(ordenCompraSeleccionada, factura);
                MessageBox.Show("Factura guardada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ordenCompraSeleccionada = _gestorOrdenCompra.ConsultarPorID(ordenCompraSeleccionada.ID);
                RefrescarGrilla(dgvFacturas, ordenCompraSeleccionada.Facturas);
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            dtpFechaFactura.Value = DateTime.Today;
        }

        private void btnModificarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (facturaSeleccionada == null)
                {
                    MessageBox.Show("Seleccione una factura para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(facturaSeleccionada.EstaPagada)
                {
                    MessageBox.Show("No se puede modificar una factura pagada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(!ValidarDatos())
                    return;

                facturaSeleccionada.NumeroFactura = txtNumeroFactura.Text;
                facturaSeleccionada.Monto = decimal.Parse(txtMontoFactura.Text);
                facturaSeleccionada.FechaEmision = dtpFechaFactura.Value;

                _gestorFacturaProveedor.Modificar(facturaSeleccionada);
                var facturaEnOrden = ordenCompraSeleccionada.Facturas.FirstOrDefault(f => f.ID == facturaSeleccionada.ID);
                if (facturaEnOrden != null)
                {
                    facturaEnOrden.NumeroFactura = txtNumeroFactura.Text;
                    facturaEnOrden.Monto = decimal.Parse(txtMontoFactura.Text);
                    facturaEnOrden.FechaEmision = dtpFechaFactura.Value;
                    _gestorOrdenCompra.Modificar(ordenCompraSeleccionada);
                }
                //gestorBitacora.Log(usuarioActual, $"Factura: {facturaSeleccionada.NumeroFactura} modificada");
                MessageBox.Show("Factura modificada con éxito", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ordenCompraSeleccionada = _gestorOrdenCompra.ConsultarPorID(ordenCompraSeleccionada.ID);
                RefrescarGrilla(dgvFacturas, ordenCompraSeleccionada.Facturas);

                foreach (DataGridViewRow row in dgvFacturas.Rows)
                {
                    var factura = row.DataBoundItem as BE_FacturaProveedor;
                    if (factura != null && factura.ID == facturaSeleccionada.ID)
                    {
                        dgvFacturas.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnPagarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (facturaSeleccionada == null)
                {
                    MessageBox.Show("Debe seleccionar una factura para pagar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (facturaSeleccionada.EstaPagada)
                {
                    MessageBox.Show("La factura ya está pagada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (cmbMetodoPago.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un método de pago", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show(
                    $"¿Está seguro que desea pagar la factura {facturaSeleccionada.NumeroFactura} por un monto de ${facturaSeleccionada.Monto:N2}?",
                    "Confirmar Pago",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                string metodoPago = cmbMetodoPago.SelectedItem.ToString();

                facturaSeleccionada = _gestorFacturaProveedor.ProcesarPago(facturaSeleccionada,metodoPago,ordenCompraSeleccionada);

                ordenCompraSeleccionada = _gestorOrdenCompra.ConsultarPorID(ordenCompraSeleccionada.ID);
                RefrescarGrilla(dgvFacturas, ordenCompraSeleccionada.Facturas);

                foreach (DataGridViewRow row in dgvFacturas.Rows)
                {
                    var factura = row.DataBoundItem as BE_FacturaProveedor;
                    if (factura != null && factura.ID == facturaSeleccionada.ID)
                    {
                        dgvFacturas.CurrentCell = row.Cells[0];
                        break;
                    }
                }

                MessageBox.Show("Pago procesado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPagarFactura.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al pagar factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarControles()
        {
            dtpFechaFactura.Value = DateTime.Today;
            btnPagarFactura.Enabled = false;
            btnModificarFactura.Enabled = false;
        }

        private void RefrescarGrilla(DataGridView pDgv, object pOrigen)
        {
            pDgv.DataSource = null;
            pDgv.DataSource = pOrigen;
        }

        private void CargarMetodosPago()
        {
            cmbMetodoPago.Items.Clear();
            cmbMetodoPago.Items.Add("Transferencia Bancaria");
            cmbMetodoPago.Items.Add("Tarjeta de Crédito");
            cmbMetodoPago.Items.Add("Tarjeta de Debito");
            cmbMetodoPago.Items.Add("Cheque");
            cmbMetodoPago.SelectedIndex = 0;
        }

        private void dgvOrdenesCompra_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrdenesCompra.CurrentRow != null)
            {
                ordenCompraSeleccionada = (BE_OrdenCompra)dgvOrdenesCompra.CurrentRow.DataBoundItem;
                RefrescarGrilla(dgvFacturas, ordenCompraSeleccionada.Facturas);
            }
            else
            {
                dgvFacturas.DataSource = null;
                ordenCompraSeleccionada = null;
            }
        }

        private void dgvFacturas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFacturas.CurrentRow != null)
            {
                facturaSeleccionada = (BE_FacturaProveedor)dgvFacturas.CurrentRow.DataBoundItem;
                if (facturaSeleccionada != null)
                {
                    MostrarDetallesFactura();
                    btnPagarFactura.Enabled = !facturaSeleccionada.EstaPagada;
                    btnModificarFactura.Enabled = !facturaSeleccionada.EstaPagada;
                }
            }
        }
        private void MostrarDetallesFactura()
        {
            txtNumeroFactura.Text = facturaSeleccionada.NumeroFactura;
            txtMontoFactura.Text = facturaSeleccionada.Monto.ToString("N2");
            dtpFechaFactura.Value = facturaSeleccionada.FechaEmision;
        }

        private void LimpiarFormulario()
        {
            txtNumeroFactura.Clear();
            txtMontoFactura.Clear();
            dtpFechaFactura.Value = DateTime.Today;
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNumeroFactura.Text))
            {
                MessageBox.Show("Debe ingresar un número de factura", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMontoFactura.Text))
            {
                MessageBox.Show("Debe ingresar un monto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal monto;
            if (!decimal.TryParse(txtMontoFactura.Text, out monto) || monto <= 0)
            {
                MessageBox.Show("El monto debe ser un valor numérico mayor a cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
