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
    public partial class Frm_Buscar_Compra : Form
    {
        public Frm_Buscar_Compra()
        {
            InitializeComponent();
        }

        private void Frm_Buscar_Compra_Load(object sender, EventArgs e)
        {
            Listar();
        }
        public void Listar()
        {
            NCompra bo = new NCompra();
            DgvCompra.DataSource = bo.Listar();
        }
        private void PanelActions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnNuevaCompra_Click(object sender, EventArgs e)
        {
            Frm_RegistrarCompra frm = new Frm_RegistrarCompra();
            AddOwnedForm(frm);
            frm.Text = "Nueva Compra";
            frm.ShowDialog();
        }

        private void BtnListarTodo_Click(object sender, EventArgs e)
        {
            Listar();
        }
    

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            Frm_Registrar_Proveedor frm = new Frm_Registrar_Proveedor();
            frm.ShowDialog();
        }

        private void BtnVerCompra_Click(object sender, EventArgs e)
        {
            if (DgvCompra.SelectedRows.Count > 0)
            {
                int rowindex = DgvCompra.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        string serie = DgvCompra.CurrentRow.Cells[4].Value.ToString();
                        string numero = DgvCompra.CurrentRow.Cells[5].Value.ToString();
                        //FrmVistaCompra.Serie = serie;
                        //FrmVistaCompra.Numero = numero;
                        //FrmVistaCompra frm = new FrmVistaCompra();
                        //frm.ShowDialog();
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
            DateTime desde = Convert.ToDateTime(DtpFirstDate.Text);
            DateTime hasta = Convert.ToDateTime(DtpLastDate.Text);
            BuscarxFecha(desde, hasta);
        }
        private void BuscarxFecha(DateTime FirstDate, DateTime LastDate)
        {
            NCompra bo = new NCompra();
            DgvCompra.DataSource = bo.BuscarxFecha(FirstDate, LastDate);
        }

        private void DgvCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
