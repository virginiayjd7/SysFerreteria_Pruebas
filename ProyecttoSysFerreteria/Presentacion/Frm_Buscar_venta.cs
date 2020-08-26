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
    public partial class Frm_Buscar_venta : Form
    {
        public Frm_Buscar_venta()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DateTime desde = Convert.ToDateTime(DtpFirstDate.Text);
            DateTime hasta = Convert.ToDateTime(DtpLastDate.Text);
            BuscarxFecha(desde, hasta);

            Listar();
        }

        public void Listar()
        {
            NVenta bo = new NVenta();
            DgvVenta.DataSource = bo.Listar();
        }
        private void BuscarxFecha(DateTime FirstDate, DateTime LastDate)
        {
            NVenta bo = new NVenta();
            DgvVenta.DataSource = bo.BuscarxFecha(FirstDate, LastDate);
        }
        private void Frm_Buscar_venta_Load(object sender, EventArgs e)
        {

            Listar();
        }

       


        private void BtnNuevaVenta_Click(object sender, EventArgs e)
        {
            Frm_Registrar_Venta frm = new Frm_Registrar_Venta();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void BtnListarTodo_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void PanelActions_Paint(object sender, PaintEventArgs e)
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
