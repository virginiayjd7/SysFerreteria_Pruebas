using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using ProyecttoSysFerreteria.Entidad;
using ProyecttoSysFerreteria.Negocios;
namespace ProyecttoSysFerreteria.Presentacion
{
    public partial class Frm_Registrar_Venta : Form
    {
        public Frm_Registrar_Venta()
        {
            InitializeComponent();
        }
        private static string CarpetaImagen => "./ProductoImg";

        public static double Venta_SubTotal = 0;
        public static double Venta_Igv = 0;
        public static double Venta_Total = 0;
        private void BtnGuardarVenta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CbxTipoComprobante.Text))
            {
                MessageBox.Show("Seleccione Tipo de Comprobante", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CbxTipoComprobante.Focus();
            }
            else if (string.IsNullOrEmpty(TxtSerie.Text))
            {
                MessageBox.Show("Digite Serie del Documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtSerie.Focus();
            }
            else if (string.IsNullOrEmpty(TxtNumero.Text))
            {
                MessageBox.Show("Digite Número del Documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNumero.Focus();
            }
            else if (string.IsNullOrEmpty(TxtFechaEmision.Text))
            {
                MessageBox.Show("Ingrese Fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtFechaEmision.Focus();
            }
            else if (string.IsNullOrEmpty(TxtNumeroDocumento.Text))
            {
                MessageBox.Show("Ingrese un Cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNumeroDocumento.Focus();
            }
            else if (string.IsNullOrEmpty(TxtNombres.Text))
            {
                MessageBox.Show("Cliente Incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombres.Focus();
            }
            else if (MLVDetalle.Items.Count == 0)
            {
                MessageBox.Show("El detalle no puede estar vacío, agrege items", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtProducto.Focus();
            }
            else
            {
                GuardarVenta();
            }
        }
        private void GuardarVenta()
        {
            string tipocomprobante = CbxTipoComprobante.SelectedValue.ToString();
            string ventaserie = "####";
            string ventacorrelativo = "########";
            NVenta venta = new NVenta();
            if (venta.ObtenerSerieCorrelativo(tipocomprobante) != null)
            {
                DataRow row = venta.ObtenerSerieCorrelativo(tipocomprobante);
                ventaserie = row["Serie"].ToString();
                ventacorrelativo = row["Correlativo"].ToString();
            }
            EVenta beVenta = new EVenta
            {
                Cliente = Convert.ToInt32(LblIDCliente.Text),
                Empleado = Frm_Principal.AccesoUsernameID,
                TipoComprobante = tipocomprobante,
                Serie = ventaserie,
                Numero = ventacorrelativo,
                Fecha = Convert.ToDateTime(DateTime.Now),
                Hora = Convert.ToDateTime(DateTime.Now),
                SubTotal = Venta_SubTotal,
                Igv = Venta_Igv,
                Total = Venta_Total,
                Estado = 1
            };
            NVenta boVenta = new NVenta();
            if (boVenta.Agregar(beVenta) == true)
            {
                if (MLVDetalle.Items.Count > 0)
                {
                    NDetalleVenta boDetalleVenta = new NDetalleVenta();
                    foreach (ListViewItem items in MLVDetalle.Items)
                    {
                        EDetalleVenta beDetalleVenta = new EDetalleVenta
                        {
                            Serie = beVenta.Serie,
                            Numero = beVenta.Numero,
                            Producto = items.SubItems[0].Text,
                            Precio = Convert.ToDouble(items.SubItems[3].Text),
                            Cantidad = Convert.ToInt32(items.SubItems[4].Text),
                            Importe = Convert.ToDouble(items.SubItems[5].Text)
                        };
                        //Agregar dettalle compra
                        if (boDetalleVenta.Agregar(beDetalleVenta) == true)
                        {
                            int cantidadfinal = 0;
                            double costounitariofinal = 0;
                            double costototalfinal = 0;
                            //Obteniendo Ultimo Movimiento
                            NMovimiento boM = new NMovimiento();
                            EMovimiento datos = boM.SeleccionarUltimoMovimientoProducto(beDetalleVenta.Producto);
                            if (!string.IsNullOrEmpty(datos.Producto))
                            {
                                //Si hay datos
                                cantidadfinal = datos.CantidadFinal - beDetalleVenta.Cantidad;
                                costounitariofinal = datos.CostoUnitarioFinal;
                                double costofinaly = Math.Round((costounitariofinal * beDetalleVenta.Cantidad), 2);
                                costototalfinal = datos.CostoTotalFinal - costofinaly;
                                //Movimiento
                                EMovimiento beMovimiento = new EMovimiento
                                {
                                    Fecha = DateTime.Now,
                                    TipoComprobante = beVenta.TipoComprobante,
                                    Serie = beVenta.Serie,
                                    Numero = beVenta.Numero,
                                    TipoOperacion = "01",
                                    Producto = beDetalleVenta.Producto,
                                    CantidadEntrada = 0,
                                    CostoUnitarioEntrada = 0,
                                    CostoTotalEntrada = 0,

                                    CantidadSalida = beDetalleVenta.Cantidad,
                                    CostoUnitarioSalida = costounitariofinal,
                                    CostoTotalSalida = costofinaly,

                                    CantidadFinal = cantidadfinal,
                                    CostoUnitarioFinal = costounitariofinal,
                                    CostoTotalFinal = costototalfinal
                                };
                                NMovimiento boMovimiento = new NMovimiento();
                                if (boMovimiento.Agregar(beMovimiento) == true)
                                {
                                    EInventario beInventario = new EInventario
                                    {
                                        Producto = beMovimiento.Producto,
                                        ValorUnitario = beMovimiento.CostoUnitarioFinal,
                                        Existencias = beMovimiento.CantidadFinal,
                                        ValorInventario = beMovimiento.CostoTotalFinal
                                    };
                                    NInventario boInventario = new NInventario();
                                    boInventario.Modificar(beInventario);
                                }
                            }
                        }
                    }
                }
                //message
                Frm_Buscar_venta frm = Owner as Frm_Buscar_venta;
                frm.Listar();
                Close();
                Frm_Principal.Main.ChangeMessage("La Venta se ingreso correctamente", "Success");
            }
            else
            {
                Frm_Principal.Main.ChangeMessage("Algo salio mal", "Failed");
            }
        }
    
    private void Frm_Registrar_Venta_Load(object sender, EventArgs e)
        {
            InitListaDetalle();
            GbxComprobante.ForeColor = Color.White;
            GbxCliente.ForeColor = Color.White;
            GbxDetalle.ForeColor = Color.White;
            GbxResumen.ForeColor = Color.White;
            //CargarDatos
            CargarTipoComprobanteFB();
            FechaActual();
        }
        private void InitListaDetalle()
        {
            MLVDetalle.BackColor = Color.White;
            MLVDetalle.ForeColor = Color.Black;
            MLVDetalle.Dock = DockStyle.Fill;
            MLVDetalle.View = View.Details;
            MLVDetalle.FullRowSelect = true;
            MLVDetalle.Columns.Add("Código", 100, HorizontalAlignment.Left);
            MLVDetalle.Columns.Add("Descripción", 250, HorizontalAlignment.Left);
            MLVDetalle.Columns.Add("UM", 100, HorizontalAlignment.Left);
            MLVDetalle.Columns.Add("Precio", 100, HorizontalAlignment.Left);
            MLVDetalle.Columns.Add("Cantidad", 100, HorizontalAlignment.Left);
            MLVDetalle.Columns.Add("Importe", 100, HorizontalAlignment.Left);
        }

        private void CargarTipoComprobanteFB()
        {
            NTipoComprobante bo = new NTipoComprobante();
            if (bo.CuadroCombinadoFB().Count > 0)
            {
                CbxTipoComprobante.DataSource = new BindingSource(bo.CuadroCombinadoFB(), null);
                CbxTipoComprobante.ValueMember = "Key";
                CbxTipoComprobante.DisplayMember = "Value";
            }
            CbxTipoComprobante.SelectedValue = "01";
        }
        private void FechaActual()
        {
            DateTime dt = DateTime.Now;
            TxtFechaEmision.Text = dt.ToShortDateString();
        }

        public void AddItems(EProducto producto, int Existencia, double ValorUnitario)
        {
            bool nuevo = true;
            if (MLVDetalle.Items.Count > 0)
            {
                foreach (ListViewItem items in MLVDetalle.Items)
                {
                    if (items.SubItems[0].Text.Equals(producto.Codigo))
                    {
                        int cantidad = Convert.ToInt32(items.SubItems[4].Text) + Existencia;
                        items.SubItems[3].Text = ValorUnitario.ToString();
                        items.SubItems[4].Text = cantidad.ToString();
                        items.SubItems[5].Text = (ValorUnitario * cantidad).ToString();
                        nuevo = false;
                    }
                }
            }
            if (nuevo == true)
            {
                ListViewItem Items = new ListViewItem(producto.Codigo);
                Items.SubItems.Add(producto.Nombre);
                Items.SubItems.Add(producto.UnidadMedida);
                Items.SubItems.Add(ValorUnitario.ToString());
                Items.SubItems.Add(Existencia.ToString());
                Items.SubItems.Add((ValorUnitario * Existencia).ToString());
                MLVDetalle.Items.Add(Items);
            }
            ActualizarResumen();
        }
        private void ActualizarCantidad(string operation, int quantity = 1)
        {
            if (MLVDetalle.SelectedItems.Count > 0)
            {
                string codigoproducto = MLVDetalle.SelectedItems[0].SubItems[0].Text;
                NInventario boInventario = new NInventario();
                EInventario inventario = boInventario.Seleccionar(codigoproducto);
                //Datos
                double precio = Convert.ToDouble(MLVDetalle.SelectedItems[0].SubItems[3].Text);
                int cantidad = Convert.ToInt32(MLVDetalle.SelectedItems[0].SubItems[4].Text);
                if (operation.Equals("Aumentar"))
                {
                    if (cantidad < inventario.Existencias)
                        cantidad += quantity;
                    else
                        MessageBox.Show("No hay mas productos");
                }
                else if (operation.Equals("Disminuir"))
                {
                    cantidad -= quantity;
                }
                else if (operation.Equals("Nueva"))
                {
                    if (quantity <= inventario.Existencias)
                        cantidad = quantity;
                    else
                        MessageBox.Show("No hay mas productos");
                }
                double importe = precio * cantidad;
                MLVDetalle.SelectedItems[0].SubItems[4].Text = cantidad.ToString();
                MLVDetalle.SelectedItems[0].SubItems[5].Text = importe.ToString();
                TxtCantidadItem.Text = cantidad.ToString();
                ActualizarResumen();
            }
            else
            {
                MessageBox.Show("Seleccione Item");
            }
        }
        private void ActualizarResumen()
        {
            double SubTotal = 0;
            double Igv = 0;
            double Total = 0;
            if (MLVDetalle.Items.Count > 0)
            {
                foreach (ListViewItem items in MLVDetalle.Items)
                {
                    Total += Convert.ToDouble(items.SubItems[5].Text);
                }
                SubTotal = Total / 1.18;
                Igv = Total - (Total / 1.18);
                RLblSubTotal.Text = "S/. " + SubTotal.ToString("N2");
                RLblIgv.Text = "S/. " + Igv.ToString("N2");
                RLblTotal.Text = "S/. " + Total.ToString("N2");
            }
            else
            {
                RLblSubTotal.Text = "S/. " + SubTotal.ToString("N2");
                RLblIgv.Text = "S/. " + Igv.ToString("N2");
                RLblTotal.Text = "S/. " + Total.ToString("N2");
            }
            //Asignando variables
            Venta_SubTotal = Math.Round(SubTotal, 2);
            Venta_Igv = Math.Round(Igv, 2);
            Venta_Total = Math.Round(Total, 2);
        }
        private void BtnSearchCliente_Click(object sender, EventArgs e)
        {
            Frm_Buscar_Cliente frm = new Frm_Buscar_Cliente();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void MLVDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MLVDetalle_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void MLVDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MLVDetalle.SelectedItems.Count > 0)
            {
                TxtCantidadItem.Text = MLVDetalle.SelectedItems[0].SubItems[4].Text;
                BtnDisminuirItem.Enabled = true;
            }
        }
        private void BtnAumentarItem_Click(object sender, EventArgs e)
        {
            ActualizarCantidad("Aumentar");
        }

        private void BtnDisminuirItem_Click(object sender, EventArgs e)
        {
            if (MLVDetalle.SelectedItems.Count > 0)
            {
                if (Convert.ToInt32(MLVDetalle.SelectedItems[0].SubItems[4].Text) <= 1)
                {
                    RemoverItem();
                    BtnDisminuirItem.Enabled = false;
                }
                else
                {
                    ActualizarCantidad("Disminuir");
                }
            }
        }
        private void RemoverItem()
        {
            if (MLVDetalle.SelectedItems.Count > 0)
            {
                MLVDetalle.Items.Remove(MLVDetalle.SelectedItems[0]);
                ActualizarResumen();
            }
            else
            {
                MessageBox.Show("Seleccione Item");
            }
        }

        private void TxtCantidadItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != Convert.ToChar(Keys.Enter)))
            {
                //Solo se permiten numeros
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (string.IsNullOrEmpty(TxtCantidadItem.Text))
                {
                    MessageBox.Show("Ingrese valor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Convert.ToInt32(TxtCantidadItem.Text) == 0)
                    {
                        MessageBox.Show("El valor no puede ser 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        ActualizarCantidad("Nueva", Convert.ToInt32(TxtCantidadItem.Text));
                    }
                }
            }
        }

        private void MLVDetalle_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnSearchProducto_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Principal frm = new Frm_Principal();
            frm.Show();
            Close();
        }
    }
}

