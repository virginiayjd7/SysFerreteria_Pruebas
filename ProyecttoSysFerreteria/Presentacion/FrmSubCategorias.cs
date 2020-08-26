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
    public partial class FrmSubCategorias : Form
    {
        public FrmSubCategorias()
        {
            InitializeComponent();
        }
        public static int modificar = 0;
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Ingre nombre de la Sub Categoria", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombre.Focus();
            }
            else
            {
                Guardar();
            }
        }
        private void Guardar()
        {
            ESubCategoria be = new ESubCategoria
            {
                ID = Convert.ToInt32(lblIdentificador.Text),
                Categoria = Convert.ToInt32(CbxCategoria.SelectedValue),
                Nombre = TxtNombre.Text
            };
            NSubCategoria bo = new NSubCategoria();
            if (modificar == 0)
            {
                if (bo.Agregar(be))
                {
                    TxtNombre.Text = "";
                    Listar();
                    Frm_Principal.Main.ChangeMessage("Sub Categoria agregado correctamente", "Success");
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
                    Listar();
                    Frm_Principal.Main.ChangeMessage("Sub Categoria modificado correctamente", "Success");
                }
                else
                {
                    Frm_Principal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
        }
        private void FrmSubCategorias_Load(object sender, EventArgs e)
        {

            Listar();
            CargarCategoria();
        }
        private void Listar()
        {
            NSubCategoria bo = new NSubCategoria();
            DgvSubCategoria.DataSource = bo.Listar();
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
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvSubCategoria.SelectedRows.Count > 0)
            {
                int rowindex = DgvSubCategoria.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        modificar = 1;
                        BtnAgregar.Text = "Guardar";
                        BtnAgregar.BackColor = Color.FromArgb(0, 166, 81);
                        BtnCancelar.Visible = true;
                        BtnEditar.Enabled = false;
                        lblIdentificador.Text = DgvSubCategoria.CurrentRow.Cells[1].Value.ToString();
                        CbxCategoria.SelectedValue = Convert.ToInt32(DgvSubCategoria.CurrentRow.Cells[0].Value);
                        TxtNombre.Text = DgvSubCategoria.CurrentRow.Cells[2].Value.ToString();
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            modificar = 0;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.BackColor = Color.FromArgb(66, 139, 202);
            TxtNombre.Text = "";
            BtnCancelar.Visible = false;
            BtnEditar.Enabled = true;
        }

        private void DgvSubCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modificar == 1)
            {
                try
                {
                    lblIdentificador.Text = DgvSubCategoria.CurrentRow.Cells[1].Value.ToString();
                    CbxCategoria.SelectedValue = Convert.ToInt32(DgvSubCategoria.CurrentRow.Cells[0].Value);
                    TxtNombre.Text = DgvSubCategoria.CurrentRow.Cells[2].Value.ToString(); ;
                }
                catch
                {
                    //
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Principal frm = new Frm_Principal();
            frm.Show();
            Close();
        }

        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DgvSubCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
