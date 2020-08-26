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
    public partial class Frm_Registrar_Empleado : Form
    {
        public Frm_Registrar_Empleado()
        {
            InitializeComponent();
        }
        public static int modificar = 0;
        public static bool BtnGE = false;
        public static DateTime? fechnaci = DateTime.Now;
        public static int cbxcargoselected = 0;

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNumeroDocumento.Text))
            {
                MessageBox.Show("Digite Numero de Documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNumeroDocumento.Focus();
            }
            else if (string.IsNullOrEmpty(TxtNombres.Text))
            {
                MessageBox.Show("Digite Nombre del empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombres.Focus();
            }
            else if (string.IsNullOrEmpty(TxtApellidos.Text))
            {
                MessageBox.Show("Digite Apellido del empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtApellidos.Focus();
            }
            else if (string.IsNullOrEmpty(CbxCargo.Text))
            {
                MessageBox.Show("Seleccione Cargo del empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtApellidos.Focus();
            }
            else
            {
                Guardar();
            }
        }

        private void Frm_Registrar_Empleado_Load(object sender, EventArgs e)
        {
            CargarTipoDocumentoIdentidad();
            CargarCargo();
           
            DtpFechaNacimiento.Text = fechnaci.ToString();
            BtnGuardar.Enabled = BtnGE;
        }
        private void CargarTipoDocumentoIdentidad()
        {
            NTipoDocumentoIdentidad bo = new NTipoDocumentoIdentidad();
            if (bo.CuadroCombinado().Count > 0)
            {
                CbxTipoDocumento.DataSource = new BindingSource(bo.CuadroCombinado(), null);
                CbxTipoDocumento.ValueMember = "Key";
                CbxTipoDocumento.DisplayMember = "Value";
            }
            CbxTipoDocumento.SelectedValue = "1";
        }
        private void CargarCargo()
        {
            NCargo bo = new NCargo();
            if (bo.CuadroCombinado().Count > 0)
            {
                CbxCargo.DataSource = new BindingSource(bo.CuadroCombinado(), null);
                CbxCargo.ValueMember = "Key";
                CbxCargo.DisplayMember = "Value";
            }
            if (cbxcargoselected != 0)
            {
                CbxCargo.SelectedValue = cbxcargoselected;
            }
        }
        private void Guardar()
        {
            DateTime? fechnac = string.IsNullOrWhiteSpace(DtpFechaNacimiento.Text) ? (DateTime?)null : Convert.ToDateTime(DtpFechaNacimiento.Text);
            EEmpleado be = new EEmpleado
            {
                Cargo = Convert.ToInt32(CbxCargo.SelectedValue),
                TipoDocumento = CbxTipoDocumento.SelectedValue.ToString(),
                NumeroDocumento = TxtNumeroDocumento.Text,
                Nombre = TxtNombres.Text,
                Apellido = TxtApellidos.Text,
                FechaNacimiento = fechnac,
                Pais = TxtPais.Text,
                Ciudad = TxtCiudad.Text,
                Direccion = TxtDireccion.Text,
                Email = TxtEmail.Text,
                Telefono = TxtTelefono.Text,
                Estado = 1
            };
            NEmpleado bo = new NEmpleado();
            if (modificar == 0)
            {
                if (bo.Agregar(be))
                {
                    Frm_Buscar_Empleado frm = Owner as Frm_Buscar_Empleado;
                    frm.Listar();
                    Close();
                    Frm_Principal.Main.ChangeMessage("Empleado agregado correctamente", "Success");
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
                    Frm_Buscar_Empleado frm = Owner as Frm_Buscar_Empleado;
                    frm.Listar();
                    Close();
                    Frm_Principal.Main.ChangeMessage("Empleado modificado correctamente", "Success");
                }
                else
                {
                    Frm_Principal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
        }
        private void TxtNumeroDocumento_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNumeroDocumento.Text))
            {
                BtnGuardar.Enabled = false;
                TxtNumeroDocumento.Focus();
            }
            else
            {
                NEmpleado bo = new NEmpleado();
                if (bo.VerificarNumeroDocumento(TxtNumeroDocumento.Text))
                {
                    BtnGuardar.Enabled = true;
                    TxtNumeroDocumento.BackColor = Color.FromArgb(126, 225, 154);
                }
                else
                {
                    BtnGuardar.Enabled = false;
                    TxtNumeroDocumento.BackColor = Color.FromArgb(241, 115, 117);
                    TxtNumeroDocumento.Focus();
                }
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
