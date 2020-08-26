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
    public partial class Frm_Buscar_Cliente : Form
    {
        public Frm_Buscar_Cliente()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {
            NCliente bo = new NCliente();
            DgvCiente.DataSource = bo.Buscar(TxtBusqueda.Text);
        }

        private void BtnListarTodo_Click(object sender, EventArgs e)
        {
            Listar();
        }
        public void Listar()
        {
            NCliente bo = new NCliente();
            DgvCiente.DataSource = bo.Listar();
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvCiente.SelectedRows.Count > 0)
            {
                int rowindex = DgvCiente.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        Frm_Registrar_Cliente.modificar = 1;
                        Frm_Registrar_Cliente frm = new Frm_Registrar_Cliente();
                        AddOwnedForm(frm);
                        frm.Text = "Modificar Cliente";
                        Frm_Registrar_Cliente.BtnGE = true;
                        frm.CbxTipoDocumento.Enabled = false;
                        frm.TxtNumeroDocumento.Enabled = false;
                        frm.TxtNumeroDocumento.Text = DgvCiente.CurrentRow.Cells[2].Value.ToString();
                        frm.TxtNombres.Text = DgvCiente.CurrentRow.Cells[3].Value.ToString();
                        frm.TxtApellidos.Text = DgvCiente.CurrentRow.Cells[4].Value.ToString();
                        if (DgvCiente.CurrentRow.Cells[5].Value == DBNull.Value)
                        {
                            Frm_Registrar_Cliente.fechnaci = Convert.ToDateTime(DateTime.Now);
                        }
                        else
                        {
                          Frm_Registrar_Cliente.fechnaci = Convert.ToDateTime(DgvCiente.CurrentRow.Cells[5].Value);
                        }
                        frm.TxtPais.Text = DgvCiente.CurrentRow.Cells[6].Value.ToString();
                        frm.TxtCiudad.Text = DgvCiente.CurrentRow.Cells[7].Value.ToString();
                        frm.TxtDireccion.Text = DgvCiente.CurrentRow.Cells[8].Value.ToString();
                        frm.TxtEmail.Text = DgvCiente.CurrentRow.Cells[9].Value.ToString();
                        frm.TxtTelefono.Text = DgvCiente.CurrentRow.Cells[10].Value.ToString();
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Frm_Registrar_Cliente.modificar = 0;
            Frm_Registrar_Cliente frm = new Frm_Registrar_Cliente();
            AddOwnedForm(frm);
            frm.Text = "Nuevo Cliente";
            Frm_Registrar_Cliente.BtnGE = false;
            frm.ShowDialog();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void Frm_Buscar_Cliente_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void DgvCiente_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

