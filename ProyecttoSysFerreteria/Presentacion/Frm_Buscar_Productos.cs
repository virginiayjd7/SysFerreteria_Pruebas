using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using ProyecttoSysFerreteria.Entidad;
using ProyecttoSysFerreteria.Negocios;
namespace ProyecttoSysFerreteria.Presentacion
{
    public partial class Frm_Buscar_Productos : Form
    {
        public Frm_Buscar_Productos()
        {
            InitializeComponent();
        }
        private static string CarpetaImagen => "./ProductoImg";
        private void Frm_Buscar_Productos_Load(object sender, EventArgs e)
        {
            Listar();
            CargarImagenSeleccionado();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Frm_Registrar_Producto.modificar = 0;
            Frm_Registrar_Producto frm = new Frm_Registrar_Producto();
            AddOwnedForm(frm);
            frm.Text = "Nuevo Producto";
            frm.ShowDialog();
        }
        public void Listar()
        {
            NProducto bo = new NProducto();
            DgvProducto.DataSource = bo.Listar();
        }
        private void Buscar(string KeyWoards)
        {
            NProducto bo = new NProducto();
            DgvProducto.DataSource = bo.Buscar(KeyWoards);
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias frm = new FrmCategorias();
            frm.ShowDialog();
        }

        private void BtnSubCategorias_Click(object sender, EventArgs e)
        {
            FrmSubCategorias frm = new FrmSubCategorias();
            frm.ShowDialog();
        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            FrmMarcas frm = new FrmMarcas();
            frm.ShowDialog();
        }

        private void DgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarImagenSeleccionado();
        }
        private void CargarImagenSeleccionado()
        {
            try
            {
                TxtCodigoImagen.Text = DgvProducto.CurrentRow.Cells[3].Value.ToString();
                string image = DgvProducto.CurrentRow.Cells[5].Value.ToString();
                if (image != null)
                {
                    SeleccionarImagen(image);
                }
                else
                {
                    SeleccionarImagen("default.jpg");
                }
            }
            catch
            {
                //
            }
        }
        private void SeleccionarImagen(string image)
        {
            string imagen = CarpetaImagen + "/" + image;
            if (File.Exists(imagen))
            {
                PtbImageProdcucto.Image = Image.FromFile(imagen);
            }
            else
            {
                PtbImageProdcucto.Image = Image.FromFile(CarpetaImagen + "/default.jpg");
            }

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvProducto.SelectedRows.Count > 0)
            {
                int rowindex = DgvProducto.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        string nameimage = DgvProducto.CurrentRow.Cells[5].Value.ToString() == null ? "default.jpg" : DgvProducto.CurrentRow.Cells[5].Value.ToString();
                        string imagen = CarpetaImagen + "/" + nameimage;
                        Frm_Registrar_Producto.modificar = 1;
                        Frm_Registrar_Producto frm = new Frm_Registrar_Producto();
                        AddOwnedForm(frm);
                        frm.Text = "Modificar Producto";
                        Frm_Registrar_Producto.BotonGuardar = true;
                        frm.TxtCodigo.Enabled = false;
                        frm.TxtNombre.Enabled = false;
                        Frm_Registrar_Producto.cbxcategoriaselected = Convert.ToInt32(DgvProducto.CurrentRow.Cells[1].Value);
                        Frm_Registrar_Producto.cbxsubcategoriaselected = Convert.ToInt32(DgvProducto.CurrentRow.Cells[2].Value);
                        frm.TxtCodigo.Text = DgvProducto.CurrentRow.Cells[3].Value.ToString();
                        frm.TxtNombre.Text = DgvProducto.CurrentRow.Cells[4].Value.ToString();
                        if (File.Exists(imagen))
                        {
                            frm.PtbImagen.Image = Image.FromFile(imagen);
                        }
                        else
                        {
                            frm.PtbImagen.Image = Image.FromFile(CarpetaImagen + "/default.jpg");
                        }
                        Frm_Registrar_Producto.cbxtipoexistenciaselected = DgvProducto.CurrentRow.Cells[6].Value.ToString();
                        Frm_Registrar_Producto.cbxunidadmedidaselected = DgvProducto.CurrentRow.Cells[7].Value.ToString();
                        Frm_Registrar_Producto.cbxmarcaselected = Convert.ToInt32(DgvProducto.CurrentRow.Cells[8].Value);
                        frm.ShowDialog();
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(TxtBusqueda.Text);
        }

        private void BtnListarTodo_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
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
