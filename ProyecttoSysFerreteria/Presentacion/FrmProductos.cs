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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(TxtBusqueda.Text);
        }
        private static string CarpetaImagen => "./ProductoImg";
        private void FrmProductos_Load(object sender, EventArgs e)
        {

            Listar();
        }

        private void Listar()
        {
            NProducto bo = new NProducto();
            DgvProducto.DataSource = bo.Listar();
        }
        private void Buscar(string KeyWoard)
        {
            NProducto bo = new NProducto();
            DgvProducto.DataSource = bo.Buscar(KeyWoard);
        }
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (DgvProducto.SelectedRows.Count > 0)
            {
                int rowindex = DgvProducto.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        Frm_Registrar_Venta frm = Owner as Frm_Registrar_Venta;
                        string codigoproducto = DgvProducto.CurrentRow.Cells[3].Value.ToString();
                        frm.TxtProducto.Text = codigoproducto;
                        NProducto boProducto = new NProducto();
                        EProducto producto = boProducto.Seleccionar(codigoproducto);
                        if (string.IsNullOrEmpty(producto.Codigo))
                        {
                            MessageBox.Show("No Existe Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            NInventario boInventario = new NInventario();
                            EInventario inventario = boInventario.Seleccionar(producto.Codigo);
                            if (!string.IsNullOrEmpty(inventario.Producto))
                            {
                                if (inventario.Existencias > 0)
                                {
                                    double utilidad = Frm_Principal.ValorUtilidad;
                                    double precioventa = Math.Round((inventario.ValorUnitario * utilidad), 2);
                                    frm.AddItems(producto, 1, precioventa);
                                    //Mostrar imagen
                                    if (!string.IsNullOrEmpty(producto.Imagen))
                                    {
                                        frm.PbxImgProducto.Image = Image.FromFile(CarpetaImagen + "/" + producto.Imagen);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No hay Cantidad Suficiente");
                                }
                            }
                        }
                        Close();
                    }
                    catch
                    {
                        //
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }

        private void DgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatosProducto();
        }
        private void CargarDatosProducto()
        {
            try
            {
                string codigoproducto = DgvProducto.CurrentRow.Cells[3].Value.ToString();
                NInventario boInventario = new NInventario();
                EInventario inventario = boInventario.Seleccionar(codigoproducto);
                TxtProducto.Text = DgvProducto.CurrentRow.Cells[4].Value.ToString();
                TxtExistencias.Text = inventario.Existencias.ToString();
                txtPrecioCompra.Text = inventario.ValorUnitario.ToString("N2");
                double precioventa = Math.Round((inventario.ValorUnitario * Frm_Principal.ValorUtilidad), 2);
                TxtPrecioVenta.Text = precioventa.ToString("N2");
            }
            catch
            {
                //
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Principal frm = new Frm_Principal();
            frm.Show();
            Close();
        }
    }
}
