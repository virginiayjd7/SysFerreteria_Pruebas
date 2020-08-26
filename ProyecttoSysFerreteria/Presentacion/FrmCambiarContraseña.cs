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
    public partial class FrmCambiarContraseña : Form
    {
        public FrmCambiarContraseña()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string password = TxtPasswordActual.Text;
            string newpassword = TxtPasswordNueva.Text;
            string codigo = Frm_Principal.AccesoUsername;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Escriba su contraseña actual", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPasswordActual.Focus();
            }
            else if (string.IsNullOrEmpty(newpassword))
            {
                MessageBox.Show("Escriba su contraseña nueva", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPasswordNueva.Focus();
            }
            else
            {
                ChangePassword(password, newpassword, codigo);
            }
        }
        private void ChangePassword(string password, string newpassword, string codigo)
        {
            bool response = false;
            NUsuario bo = new NUsuario();
            response = bo.ChangePassword(password, newpassword, codigo);
            if (response == true)
            {
                Close();
                Frm_Principal.Main.ChangeMessage("Contraseña cambiada correctamente", "Success");
            }
            else
            {
                Frm_Principal.Main.ChangeMessage("Algo salio mal", "Failed");
            }
        }
        private void CheckPassword()
        {
            if (TxtPasswordNueva.Text.Equals(TxtPasswordRepeat.Text))
            {
                BtnGuardar.Enabled = true;
                TxtPasswordRepeat.BackColor = Color.FromArgb(204, 255, 144);
            }
            else
            {
                BtnGuardar.Enabled = false;
                TxtPasswordRepeat.BackColor = Color.FromArgb(255, 205, 210);
            }
        }

        private void FrmCambiarContraseña_Load(object sender, EventArgs e)
        {
            BtnGuardar.Enabled = false;
        }

        private void TxtPasswordNueva_TextChanged(object sender, EventArgs e)
        {
            CheckPassword();
        }

        private void TxtPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            CheckPassword();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Principal frm = new Frm_Principal();
            frm.Show();
            Close();
        }
    }
}
