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
    public partial class Frm_Buscar_Empleado : Form
    {
        public Frm_Buscar_Empleado()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            Buscar(TxtBusqueda.Text);
        }

        private void Frm_Buscar_Empleado_Load(object sender, EventArgs e)
        {
            Listar();
        }
        public void Listar()
        {
            NEmpleado bo = new NEmpleado();
            DgvPersonal.DataSource = bo.Listar();
        }

        private void Buscar(string KeyWoard)
        {
            NEmpleado bo = new NEmpleado();
            DgvPersonal.DataSource = bo.Buscar(KeyWoard);
        }

        private void BtnListarTodo_Click_1(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnNuevo_Click_1(object sender, EventArgs e)
        {
            Frm_Registrar_Empleado.modificar = 0;
            Frm_Registrar_Empleado frm = new Frm_Registrar_Empleado();
            AddOwnedForm(frm);
            frm.Text = "Nuevo Empleado";
            Frm_Registrar_Empleado.BtnGE = false;
            frm.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvPersonal.SelectedRows.Count > 0)
            {
                int rowindex = DgvPersonal.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        Frm_Registrar_Empleado.modificar = 1;
                        Frm_Registrar_Empleado frm = new Frm_Registrar_Empleado();
                        AddOwnedForm(frm);
                        frm.Text = "Modificar Empleado";
                        Frm_Registrar_Empleado.BtnGE = true;
                        Frm_Registrar_Empleado.cbxcargoselected = Convert.ToInt32(DgvPersonal.CurrentRow.Cells[0].Value);
                        frm.CbxTipoDocumento.Enabled = false;
                        frm.TxtNumeroDocumento.Enabled = false;
                        frm.TxtNumeroDocumento.Text = DgvPersonal.CurrentRow.Cells[3].Value.ToString();
                        frm.TxtNombres.Text = DgvPersonal.CurrentRow.Cells[4].Value.ToString();
                        frm.TxtApellidos.Text = DgvPersonal.CurrentRow.Cells[5].Value.ToString();
                        if (DgvPersonal.CurrentRow.Cells[6].Value == DBNull.Value)
                        {
                            Frm_Registrar_Empleado.fechnaci = Convert.ToDateTime(DateTime.Now);
                        }
                        else
                        {
                            Frm_Registrar_Empleado.fechnaci = Convert.ToDateTime(DgvPersonal.CurrentRow.Cells[6].Value);
                        }
                        frm.TxtPais.Text = DgvPersonal.CurrentRow.Cells[7].Value.ToString();
                        frm.TxtCiudad.Text = DgvPersonal.CurrentRow.Cells[8].Value.ToString();
                        frm.TxtDireccion.Text = DgvPersonal.CurrentRow.Cells[9].Value.ToString();
                        frm.TxtEmail.Text = DgvPersonal.CurrentRow.Cells[10].Value.ToString();
                        frm.TxtTelefono.Text = DgvPersonal.CurrentRow.Cells[11].Value.ToString();
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

        private void BtnCargos_Click_1(object sender, EventArgs e)
        {
            Frm_Registrar_Cargo frm = new Frm_Registrar_Cargo();
            frm.ShowDialog();
        }

        private void TxtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {

           
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvPersonal_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
