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
    public partial class Frm_Registrar_Proveedor : Form
    {
        public Frm_Registrar_Proveedor()
        {
            InitializeComponent();
        }
        public static int modificar = 0;
        private void Frm_Registrar_Proveedor_Load(object sender, EventArgs e)
        {

            BotonesEnables(true);
            Listar();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            modificar = 0;
            CamposReadOnly(false);
            TxtRuc.Focus();
            BotonesEnables(false);
            LimpiarCampos();
            TxtRuc.Enabled = true;
        }
        private void BotonesEnables(bool x)
        {
            BtnNuevo.Enabled = x;
            BtnModificar.Enabled = x;
            BtnGuardar.Enabled = !x;
        }
        private void CamposReadOnly(bool x)
        {
            TxtRuc.ReadOnly = x;
            TxtRazonSocial.ReadOnly = x;
            TxtCiudad.ReadOnly = x;
            TxtDireccion.ReadOnly = x;
            TxtEmail.ReadOnly = x;
            TxtTelefono.ReadOnly = x;
        }

        private void LimpiarCampos()
        {
            TxtRuc.Text = "";
            TxtRazonSocial.Text = "";
            TxtCiudad.Text = "";
            TxtDireccion.Text = "";
            TxtEmail.Text = "";
            TxtTelefono.Text = "";
        }
        private void Listar()
        {
            NProveedor bo = new NProveedor();
            DgvProveedor.DataSource = bo.Listar();
        }
        private void Guardar()
        {
            EProveedor be = new EProveedor
            {
                Ruc = TxtRuc.Text,
                RazonSocial = TxtRazonSocial.Text,
                Ciudad = TxtCiudad.Text,
                Direccion = TxtDireccion.Text,
                Email = TxtEmail.Text,
                Telefono = TxtTelefono.Text
            };
            NProveedor bo = new NProveedor();
            if (modificar == 0)
            {
                if (bo.Agregar(be))
                {
                    Listar();
                    Frm_Principal.Main.ChangeMessage("Proveedor se guardo correctamente", "Success");
                    CamposReadOnly(true);
                    BotonesEnables(true);
                }
                else
                {
                    Frm_Principal.Main.ChangeMessage("Ocurrió algún error", "Failed");
                }
            }
            else if (modificar == 1)
            {
                if (bo.Modificar(be))
                {
                    Listar();
                    Frm_Principal.Main.ChangeMessage("Proveedor se modificó correctamente", "Success");
                    CamposReadOnly(true);
                    BotonesEnables(true);
                }
                else
                {
                    Frm_Principal.Main.ChangeMessage("Ocurrió algún error", "Failed");
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtRuc.Text))
            {
                MessageBox.Show("Digite Ruc", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtRuc.Focus();
            }
            else if (string.IsNullOrEmpty(TxtRazonSocial.Text))
            {
                MessageBox.Show("Digite Razon Social", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtRazonSocial.Focus();
            }
            else if (string.IsNullOrEmpty(TxtCiudad.Text))
            {
                MessageBox.Show("Digite Ciudad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCiudad.Focus();
            }
            else if (string.IsNullOrEmpty(TxtDireccion.Text))
            {
                MessageBox.Show("Digite Dirección", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtDireccion.Focus();
            }
            else if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show("Digite Correo Electrónico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtEmail.Focus();
            }
            else if (string.IsNullOrEmpty(TxtTelefono.Text))
            {
                MessageBox.Show("Digite Teléfono", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtTelefono.Focus();
            }
            else
            {
                Guardar();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvProveedor.SelectedRows.Count > 0)
            {
                int rowindex = DgvProveedor.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        modificar = 1;
                        CamposReadOnly(false);
                        BotonesEnables(false);
                        TxtRuc.Enabled = false;
                        TxtRazonSocial.Focus();
                        //llenando campos
                        TxtRuc.Text = DgvProveedor.CurrentRow.Cells[1].Value.ToString();
                        TxtRazonSocial.Text = DgvProveedor.CurrentRow.Cells[2].Value.ToString();
                        TxtCiudad.Text = DgvProveedor.CurrentRow.Cells[3].Value.ToString();
                        TxtDireccion.Text = DgvProveedor.CurrentRow.Cells[4].Value.ToString();
                        TxtEmail.Text = DgvProveedor.CurrentRow.Cells[5].Value.ToString();
                        TxtTelefono.Text = DgvProveedor.CurrentRow.Cells[6].Value.ToString();
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

        private void DgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtRuc.Text = DgvProveedor.CurrentRow.Cells[1].Value.ToString();
                TxtRazonSocial.Text = DgvProveedor.CurrentRow.Cells[2].Value.ToString();
                TxtCiudad.Text = DgvProveedor.CurrentRow.Cells[3].Value.ToString();
                TxtDireccion.Text = DgvProveedor.CurrentRow.Cells[4].Value.ToString();
                TxtEmail.Text = DgvProveedor.CurrentRow.Cells[5].Value.ToString();
                TxtTelefono.Text = DgvProveedor.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {
                //
            }
        }
        private void Buscar(string KeyWoard)
        {
            NProveedor bo = new NProveedor();
            DgvProveedor.DataSource = bo.Buscar(KeyWoard);
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(TxtBusqueda.Text);
        }

        private void BtnListarTodo_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Principal frm = new Frm_Principal();
            frm.Show();
            Close();
        }
    }
}
