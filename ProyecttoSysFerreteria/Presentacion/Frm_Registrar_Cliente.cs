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
using System.Text.RegularExpressions;
namespace ProyecttoSysFerreteria.Presentacion
{
    public partial class Frm_Registrar_Cliente : Form
    {
        public Frm_Registrar_Cliente()
        {
            InitializeComponent();
        }
        public static int modificar = 0;
        public static bool BtnGE = false;
        public static DateTime? fechnaci = DateTime.Now;
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNumeroDocumento.Text))
            {
                MessageBox.Show("Digite Numero de Documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNumeroDocumento.Focus();
            }
            else if (string.IsNullOrEmpty(TxtNombres.Text))
            {
                MessageBox.Show("Digite Nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombres.Focus();
            }
            else if (string.IsNullOrEmpty(TxtApellidos.Text))
            {
                MessageBox.Show("Digite Apellido del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtApellidos.Focus();
            }
            else
            {
                Guardar();
            }
        }
        private void Guardar()
        {
            DateTime? fechnac = string.IsNullOrWhiteSpace(DtpFechaNacimiento.Text) ? (DateTime?)null : Convert.ToDateTime(DtpFechaNacimiento.Text);
            ECliente be = new ECliente
            {
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
            NCliente bo = new NCliente();
            if (modificar == 0)
            {
                if (bo.Agregar(be))
                {
                    Frm_Buscar_Cliente frm = Owner as Frm_Buscar_Cliente;
                    frm.Listar();
                    Close();
                    Frm_Principal.Main.ChangeMessage("Cliente agregado correctamente", "Success");
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
                    Frm_Buscar_Cliente frm = Owner as Frm_Buscar_Cliente;
                    frm.Listar();
                    Close();
                    Frm_Principal.Main.ChangeMessage("Cliente modificado correctamente", "Success");
                }
                else
                {
                    Frm_Principal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
        }

        private void Frm_Registrar_Cliente_Load(object sender, EventArgs e)
        {
            CargarTipoDocumentoIdentidad();
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

        private void CbxCumpleNull_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk.Checked)
            {
                DtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
                DtpFechaNacimiento.CustomFormat = " ";
                DtpFechaNacimiento.Enabled = false;
            }
            else
            {
                DtpFechaNacimiento.Format = DateTimePickerFormat.Short;
                DtpFechaNacimiento.Text = DateTime.Now.ToString();
                DtpFechaNacimiento.Enabled = true;
            }
        }

        private void TxtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {

        }
        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
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
                NCliente bo = new NCliente();
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

        private void TxtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //codigo para validar los campos de textos solo numeros
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            /****************************************/
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //codigo para validar los campos de textos solo numeros
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            /****************************************/
        }

        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtPais_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtCiudad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //email_bien_escrito();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Principal frm = new Frm_Principal();
            frm.Show();
            Close();
        }
    }
    
    
}
