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
    public partial class FrmClienteSeleccionar : Form
    {
        public FrmClienteSeleccionar()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(TxtBusqueda.Text);
        }

        private void FrmClienteSeleccionar_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            NCliente bo = new NCliente();
            DgvCliente.DataSource = bo.Listar();
        }
        private void Buscar(string KeyWoard)
        {
            NCliente bo = new NCliente();
            DgvCliente.DataSource = bo.Buscar(KeyWoard);
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (DgvCliente.SelectedRows.Count > 0)
            {
                int rowindex = DgvCliente.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        Frm_Registrar_Venta frm = Owner as Frm_Registrar_Venta;
                        frm.LblIDCliente.Text = DgvCliente.CurrentRow.Cells[0].Value.ToString();
                        frm.TxtNumeroDocumento.Text = DgvCliente.CurrentRow.Cells[2].Value.ToString();
                        frm.TxtNombres.Text = DgvCliente.CurrentRow.Cells[3].Value.ToString() + " " + DgvCliente.CurrentRow.Cells[4].Value.ToString();
                        string direccion = DgvCliente.CurrentRow.Cells[8].Value.ToString() + ", " + DgvCliente.CurrentRow.Cells[7].Value.ToString();
                        frm.TxtDireccion.Text = direccion;
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

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Principal frm = new Frm_Principal();
            frm.Show();
            Close();
        }
    }
}

