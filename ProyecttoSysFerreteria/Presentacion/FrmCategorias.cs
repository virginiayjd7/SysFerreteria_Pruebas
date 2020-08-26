using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyecttoSysFerreteria.Negocios;
using ProyecttoSysFerreteria.Entidad;
namespace ProyecttoSysFerreteria.Presentacion
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }
        public static int modificar = 0;

        private void FrmCategorias_Load(object sender, EventArgs e)
        {

            Listar();
        }
        private void Listar()
        {
            NCategoria bo = new NCategoria();
            DgvCategoria.DataSource = bo.Listar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Ingre nombre de la Categoria", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombre.Focus();
            }
            else
            {
                Guardar();
            }
        }
        private void Guardar()
        {
            ECategoria be = new ECategoria
            {
                ID = Convert.ToInt32(lblIdentificador.Text),
                Nombre = TxtNombre.Text
            };
            NCategoria bo = new NCategoria();
            if (modificar == 0)
            {
                if (bo.Agregar(be))
                {
                    TxtNombre.Text = "";
                    Listar();
                    Frm_Principal.Main.ChangeMessage("Categoria agregado correctamente", "Success");
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
                    Frm_Principal.Main.ChangeMessage("Categoria modificado correctamente", "Success");
                }
                else
                {
                    Frm_Principal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvCategoria.SelectedRows.Count > 0)
            {
                int rowindex = DgvCategoria.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        modificar = 1;
                        BtnAgregar.Text = "Guardar";
                        BtnAgregar.BackColor = Color.FromArgb(0, 166, 81);
                        BtnCancelar.Visible = true;
                        BtnEditar.Enabled = false;
                        lblIdentificador.Text = DgvCategoria.CurrentRow.Cells[0].Value.ToString();
                        TxtNombre.Text = DgvCategoria.CurrentRow.Cells[1].Value.ToString();
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

        private void DgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modificar == 1)
            {
                try
                {
                    lblIdentificador.Text = DgvCategoria.CurrentRow.Cells[0].Value.ToString();
                    TxtNombre.Text = DgvCategoria.CurrentRow.Cells[1].Value.ToString();
                }
                catch
                {
                    //
                }
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))//solo letras
            {
                e.Handled = false;
            }
            else
  if (Char.IsControl(e.KeyChar))//permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
    if (Char.IsSeparator(e.KeyChar))//permitir el espacio
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
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
