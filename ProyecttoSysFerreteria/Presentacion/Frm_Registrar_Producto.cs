using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using ProyecttoSysFerreteria.Entidad;
using ProyecttoSysFerreteria.Negocios;
namespace ProyecttoSysFerreteria.Presentacion
{
    public partial class Frm_Registrar_Producto : Form
    {
        public Frm_Registrar_Producto()
        {
            InitializeComponent();
        }
        public static int modificar = 0;
        public static bool BotonGuardar = false;
        private static string CarpetaImagen => "./ProductoImg";
        //combobox selected
        public static int cbxcategoriaselected = 0;
        public static int cbxsubcategoriaselected = 0;
        public static int cbxmarcaselected = 0;
        public static string cbxtipoexistenciaselected = "";
        public static string cbxunidadmedidaselected = "";
        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCodigo.Text))
            {
                MessageBox.Show("Ingrese Código del producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCodigo.Focus();
            }
            else if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Ingrese Nombre del Producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombre.Focus();
            }
            else
            {
                Guardar();
            }
        }
        private void Guardar()
        {
            string filename = PtbImagen.Image != null ? TxtCodigo.Text + ".jpg" : "default.jpg";
            EProducto be = new EProducto
            {
                Categoria = Convert.ToInt32(CbxCategoria.SelectedValue),
                SubCategoria = Convert.ToInt32(CbxSubCategoria.SelectedValue),
                Codigo = TxtCodigo.Text,
                Nombre = TxtNombre.Text,
                Imagen = filename,
                TipoExistencia = CbxTipoExistencia.SelectedValue.ToString(),
                UnidadMedida = CbxUnidadMedida.SelectedValue.ToString(),
                Marca = Convert.ToInt32(CbxMarca.SelectedValue),
                Estado = 1
            };
            NProducto bo = new NProducto();
            if (modificar == 0)
            {
                if (bo.Agregar(be))
                {
                    GuardarImagen(be.Codigo);
                    Frm_Buscar_Productos frm = Owner as Frm_Buscar_Productos;
                    frm.Listar();
                    Close();
                    Frm_Principal.Main.ChangeMessage("Producto agregado correctamente", "Success");
                }
                else
                {
                    Frm_Principal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
            else if (modificar == 1)
            {
                if (bo.Modificar(be))
                {
                    GuardarImagen(be.Codigo);
                    Frm_Buscar_Productos frm = Owner as Frm_Buscar_Productos;
                    frm.Listar();
                    Close();
                    Frm_Principal.Main.ChangeMessage("Producto modificado correctamente", "Success");
                }
                else
                {
                    Frm_Principal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
        }
        private void PtbImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Abrir = new OpenFileDialog();
                Abrir.Filter = "jpg files (*.jpg)|*.jpg";
                Abrir.Title = "Upload an Image File";
                if (Abrir.ShowDialog() == DialogResult.OK)
                {
                    string imagen = Abrir.FileName;
                    PtbImagen.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void BtnRemoverImagen_Click(object sender, EventArgs e)
        {
            try
            {
                PtbImagen.Image = null;
            }
            catch
            {
                Console.WriteLine("Algo salio mal");
            }
        }
        private void TxtCodigo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCodigo.Text))
            {
                btnguardar.Enabled = false;
                TxtCodigo.Focus();
            }
            else
            {
                NProducto bo = new NProducto();
                if (bo.VerificarCodigo(TxtCodigo.Text))
                {
                    btnguardar.Enabled = true;
                    TxtCodigo.BackColor = Color.FromArgb(126, 225, 154);
                }
                else
                {
                   btnguardar.Enabled = false;
                    TxtCodigo.BackColor = Color.FromArgb(241, 115, 117);
                    TxtCodigo.Focus();
                }
            }
        }

        private void Frm_Registrar_Producto_Load(object sender, EventArgs e)
        {
            CargarCategoria();
            CargarTipoExistencia();
            CargarUnidadMedida();
            CargarMarca();
            btnguardar.Enabled = BotonGuardar;
        }
        private void CargarCategoria()
        {
            NCategoria bo = new NCategoria();
            if (bo.CuadroCombinado().Count > 0)
            {
                CbxCategoria.DataSource = new BindingSource(bo.CuadroCombinado(), null);
                CbxCategoria.ValueMember = "Key";
                CbxCategoria.DisplayMember = "Value";
            }
            if (cbxcategoriaselected != 0)
            {
                CbxCategoria.SelectedValue = cbxcategoriaselected;
            }
        }

        private void CargarSubCategoria(int categoria)
        {
            NSubCategoria bo = new NSubCategoria();
            if (bo.CuadroCombinadoxCategoria(categoria).Count > 0)
            {
                CbxSubCategoria.DataSource = new BindingSource(bo.CuadroCombinadoxCategoria(categoria), null);
                CbxSubCategoria.ValueMember = "Key";
                CbxSubCategoria.DisplayMember = "Value";
            }
            if (cbxsubcategoriaselected != 0)
            {
                CbxSubCategoria.SelectedValue = cbxsubcategoriaselected;
            }
        }
        private void CargarTipoExistencia()
        {
            NTipoExistencia bo = new NTipoExistencia();
            if (bo.CuadroCombinado().Count > 0)
            {
                CbxTipoExistencia.DataSource = new BindingSource(bo.CuadroCombinado(), null);
                CbxTipoExistencia.ValueMember = "Key";
                CbxTipoExistencia.DisplayMember = "Value";
            }
            if (cbxtipoexistenciaselected != "")
            {
                CbxTipoExistencia.SelectedValue = cbxtipoexistenciaselected;
            }
        }
        private void CargarUnidadMedida()
        {
            NUnidadMedida bo = new NUnidadMedida();
            if (bo.CuadroCombinado().Count > 0)
            {
                CbxUnidadMedida.DataSource = new BindingSource(bo.CuadroCombinado(), null);
                CbxUnidadMedida.ValueMember = "Key";
                CbxUnidadMedida.DisplayMember = "Value";
            }
            CbxUnidadMedida.SelectedValue = "07";
            if (cbxunidadmedidaselected != "")
            {
                CbxUnidadMedida.SelectedValue = cbxunidadmedidaselected;
            }
        }

        private void CargarMarca()
        {
            NMarca bo = new NMarca();
            if (bo.CuadroCombinado().Count > 0)
            {
                CbxMarca.DataSource = new BindingSource(bo.CuadroCombinado(), null);
                CbxMarca.ValueMember = "Key";
                CbxMarca.DisplayMember = "Value";
            }
            if (cbxmarcaselected != 0)
            {
                CbxMarca.SelectedValue = cbxmarcaselected;
            }
        }

        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CbxCategoria.SelectedValue != null)
                {
                    CbxSubCategoria.DataSource = null;
                    int categoria = Convert.ToInt32(CbxCategoria.SelectedValue);
                    CargarSubCategoria(categoria);
                }
            }
            catch
            {
                Console.WriteLine("Algo salio mal");
            }
        }

        private void BtnUpImage_Click(object sender, EventArgs e)
        {

        }
        private void GuardarImagen(string filename)
        {
            try
            {
                if (!Directory.Exists(CarpetaImagen)) Directory.CreateDirectory(CarpetaImagen);
                string imgPath = CarpetaImagen + "/" + filename + ".jpg";
                if (PtbImagen.Image != null)
                {
                    if (modificar == 0)
                    {
                        PtbImagen.Image.Save(imgPath, ImageFormat.Jpeg);
                    }
                    else if (modificar == 1)
                    {
                        if (File.Exists(imgPath))
                        {
                            File.Delete(imgPath);
                        }Application.Exit();                        PtbImagen.Image.Save(imgPath, ImageFormat.Jpeg);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrio algun problema al guardar imagen");
                Console.WriteLine(e);
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
