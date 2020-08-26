using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyecttoSysFerreteria.Entidad;
using ProyecttoSysFerreteria.Negocios;
namespace ProyecttoSysFerreteria.Presentacion
{
    public partial class Frm_RegistrarCompra : Form
    {
        public Frm_RegistrarCompra()
        {
            InitializeComponent();
        }
        public static double Compra_SubTotal = 0;
        public static double Compra_Igv = 0;
        public static double Compra_Total = 0;
        private void BtnGuardarCompra_Click(object sender, EventArgs e)
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
            else if (string.IsNullOrEmpty(DtpFecha.Text))
            {
                MessageBox.Show("Seleccione Fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DtpFecha.Focus();
            }
            else if (string.IsNullOrEmpty(TxtRucProveedor.Text))
            {
                MessageBox.Show("Ingrese un Proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtRucProveedor.Focus();
            }
            else if (string.IsNullOrEmpty(TxtRazonSocial.Text))
            {
                MessageBox.Show("Proveedor Incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtRucProveedor.Focus();
            }
            else if (MLVDetalle.Items.Count == 0)
            {
                MessageBox.Show("El detalle no puede estar vacío, agrege items", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCodigo.Focus();
            }
            else
            {
                GuardarCompra();
            }
        
    }
        private void GuardarCompra()
        {
            ECompra beCompra = new ECompra
            {
                Proveedor = Convert.ToInt32(LblIDProveedor.Text),
                Empleado = Frm_Principal.AccesoUsernameID,
                TipoComprobante = CbxTipoComprobante.SelectedValue.ToString(),
                Serie = TxtSerie.Text,
                Numero = TxtNumero.Text,
                Fecha = Convert.ToDateTime(DtpFecha.Text),
                SubTotal = Compra_SubTotal,
                Igv = Compra_Igv,
                Total = Compra_Total,
                Estado = 1
            };
            NCompra boCompra = new NCompra();
            if (boCompra.Agregar(beCompra) == true)
            {
                if (MLVDetalle.Items.Count > 0)
                {
                    NDetalleCompra boDetalleCompra = new NDetalleCompra();
                    foreach (ListViewItem items in MLVDetalle.Items)
                    {
                        EDetalleCompra beDetalleCompra = new EDetalleCompra
                        {
                            Serie = beCompra.Serie,
                            Numero = beCompra.Numero,
                            Producto = items.SubItems[0].Text,
                            PrecioUnitario = Convert.ToDouble(items.SubItems[3].Text),
                            Cantidad = Convert.ToInt32(items.SubItems[4].Text),
                            PrecioTotal = Convert.ToDouble(items.SubItems[5].Text)
                        };
                        //Agregar dettalle compra
                        if (boDetalleCompra.Agregar(beDetalleCompra) == true)
                        {
                            int cantidadfinal = 0;
                            double costounitariofinal = 0;
                            double costototalfinal = 0;
                            //Obteniendo Ultimo Movimiento
                            NMovimiento boM = new NMovimiento();
                            EMovimiento datos = boM.SeleccionarUltimoMovimientoProducto(beDetalleCompra.Producto);
                            if (string.IsNullOrEmpty(datos.Producto))
                            {
                                cantidadfinal = beDetalleCompra.Cantidad;
                                costounitariofinal = beDetalleCompra.PrecioUnitario;
                                costototalfinal = beDetalleCompra.PrecioTotal;
                            }
                            else
                            {
                                //Si hay datos
                                cantidadfinal = datos.CantidadFinal + beDetalleCompra.Cantidad;
                                costototalfinal = datos.CostoTotalFinal + beDetalleCompra.PrecioTotal;
                                costounitariofinal = Math.Round((costototalfinal / cantidadfinal), 2);
                            }
                            EMovimiento beMovimiento = new EMovimiento
                            {
                                Fecha = DateTime.Now,
                                TipoComprobante = beCompra.TipoComprobante,
                                Serie = beCompra.Serie,
                                Numero = beCompra.Numero,
                                TipoOperacion = "02",
                                Producto = beDetalleCompra.Producto,
                                CantidadEntrada = beDetalleCompra.Cantidad,
                                CostoUnitarioEntrada = beDetalleCompra.PrecioUnitario,
                                CostoTotalEntrada = beDetalleCompra.PrecioTotal,
                                CantidadSalida = 0,
                                CostoUnitarioSalida = 0,
                                CostoTotalSalida = 0,
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
                //message
                Frm_Buscar_Compra frm = Owner as Frm_Buscar_Compra;
                frm.Listar();
                Close();
                Frm_Principal.Main.ChangeMessage("La Compra se ingreso correctamente", "Success");
            }
            else
            {
                Frm_Principal.Main.ChangeMessage("Algo salio mal", "Failed");
            }
        }

        private void Frm_RegistrarCompra_Load(object sender, EventArgs e)
        {
            InitListaDetalle();
            CargarTipoComprobanteFB();
            BtnAgregar.Enabled = false;
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
                double precio = Convert.ToDouble(MLVDetalle.SelectedItems[0].SubItems[3].Text);
                int cantidad = Convert.ToInt32(MLVDetalle.SelectedItems[0].SubItems[4].Text);
                if (operation.Equals("Aumentar"))
                {
                    cantidad += quantity;
                }
                else if (operation.Equals("Disminuir"))
                {
                    cantidad -= quantity;
                }
                else if (operation.Equals("Nueva"))
                {
                    cantidad = quantity;
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
            Compra_SubTotal = Math.Round(SubTotal, 2);
            Compra_Igv = Math.Round(Igv, 2);
            Compra_Total = Math.Round(Total, 2);
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
        private void BtnAumentarItem_Click(object sender, EventArgs e)
        {
            ActualizarCantidad("Aumentar");
        }

        private void MLVDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MLVDetalle.SelectedItems.Count > 0)
            {
                TxtCantidadItem.Text = MLVDetalle.SelectedItems[0].SubItems[4].Text;
                BtnDisminuirItem.Enabled = true;
            }
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

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (string.IsNullOrEmpty(TxtCodigo.Text))
                {
                    MessageBox.Show("Ingrese Código del Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    NProducto boProducto = new NProducto();
                    EProducto producto = boProducto.Seleccionar(TxtCodigo.Text);
                    BtnAgregar.Enabled = true;
                    if (string.IsNullOrEmpty(producto.Codigo))
                    {
                        MessageBox.Show("No Existe Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        BtnAgregar.Enabled = false;
                    }
                    TxtNombre.Text = producto.Nombre;
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCodigo.Text))
            {
                MessageBox.Show("Ingrese Código del Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(TxtValorUnitario.Text))
            {
                MessageBox.Show("Ingrese Valor Unitario del Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                NProducto boProducto = new NProducto();
                EProducto producto = boProducto.Seleccionar(TxtCodigo.Text);
                double valorunitario = Convert.ToDouble(TxtValorUnitario.Text);
                AddItems(producto, 1, valorunitario);
                //Textos vacios
                TxtCodigo.Text = "";
                TxtNombre.Text = "";
                TxtValorUnitario.Text = "";
            }
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            RemoverItem();
        }
        private void TxtRucProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (string.IsNullOrEmpty(TxtRucProveedor.Text))
                {
                    MessageBox.Show("Ingrese Código del Proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    NProveedor boProducto = new NProveedor();
                    EProveedor proveedor = boProducto.Seleccionar(TxtRucProveedor.Text);
                    if (string.IsNullOrEmpty(proveedor.Ruc))
                    {
                        MessageBox.Show("No Existe Proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    LblIDProveedor.Text = proveedor.ID.ToString();
                    TxtRazonSocial.Text = proveedor.RazonSocial;
                }
            }
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            Frm_Buscar_Productos frm = new Frm_Buscar_Productos();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            BtnAgregar.Enabled = false;
            TxtNombre.Text = "";
            TxtValorUnitario.Text = "";
        }

        private void BtnSearchProveedor_Click(object sender, EventArgs e)
        {

        }
        private void TxtValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < TxtValorUnitario.Text.Length; i++)
            {
                if (TxtValorUnitario.Text[i] == ',')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 44)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        private void TxtRucProveedor_TextChanged(object sender, EventArgs e)
        {
            TxtRazonSocial.Text = "";
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
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
