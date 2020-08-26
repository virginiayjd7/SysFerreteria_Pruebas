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
    public partial class Frm_Registrar_Usuario : Form
    {
        public Frm_Registrar_Usuario()
        {
            InitializeComponent();
        }

        private void Frm_Registrar_Usuario_Load(object sender, EventArgs e)
        {

            ObtenerInformacion();
            HabilitarCampos(true);
        }
        private void HabilitarCampos(bool x)
        {
            TxtNombres.ReadOnly = x;
            TxtApellidos.ReadOnly = x;
            DtpFechaNacimiento.Enabled = !x;
            TxtPais.ReadOnly = x;
            TxtCiudad.ReadOnly = x;
            TxtDireccion.ReadOnly = x;
            TxtEmail.ReadOnly = x;
            TxtTelefono.ReadOnly = x;
        }

        private void ObtenerInformacion()
        {
            NEmpleado bo = new NEmpleado();
            if (bo.ObtenerInformacion(Frm_Principal.AccesoUsername) == null)
            {
                //
            }
            else
            {
                DataRow row = bo.ObtenerInformacion(Frm_Principal.AccesoUsername);
                TxtTipoDocumento.Text = row[0].ToString();
                TxtNumeroDocumento.Text = row[1].ToString();
                TxtCargo.Text = row[2].ToString();
                TxtNombres.Text = row[3].ToString();
                TxtApellidos.Text = row[4].ToString();
                DtpFechaNacimiento.Value = Convert.ToDateTime(row[5]);
                TxtPais.Text = row[6].ToString();
                TxtCiudad.Text = row[7].ToString();
                TxtDireccion.Text = row[8].ToString();
                TxtEmail.Text = row[9].ToString();
                TxtTelefono.Text = row[10].ToString();
            }
        }

        private void BtnCambiarClave_Click(object sender, EventArgs e)
        {
            FrmCambiarContraseña frm = new FrmCambiarContraseña();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombres.Text))
            {
                MessageBox.Show("Escriba su Nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombres.Focus();
            }
            else if (string.IsNullOrEmpty(TxtApellidos.Text))
            {
                MessageBox.Show("Escriba su Apellido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtApellidos.Focus();
            }
            else
            {
                GuardarCambios();
            }
        }
        private void GuardarCambios()
        {
            EEmpleado be = new EEmpleado
            {
                NumeroDocumento = Frm_Principal.AccesoUsername,
                Nombre = TxtNombres.Text,
                Apellido = TxtApellidos.Text,
                FechaNacimiento = Convert.ToDateTime(DtpFechaNacimiento.Text),
                Pais = TxtPais.Text,
                Ciudad = TxtCiudad.Text,
                Direccion = TxtDireccion.Text,
                Email = TxtEmail.Text,
                Telefono = TxtTelefono.Text
            };
            NEmpleado bo = new NEmpleado();
            if (bo.ModificarxUsuario(be) == true)
            {
                Frm_Principal.Main.ChangeMessage("Cambios realizados correctamente", "Success");
                BtnGuardar.Enabled = false;
                BtnModificar.Enabled = true;
                HabilitarCampos(true);
                Frm_Principal.Main.CargarPerfilBasico();
            }
            else
            {
                Frm_Principal.Main.ChangeMessage("No se pudo realizar cambios", "Failed");
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
