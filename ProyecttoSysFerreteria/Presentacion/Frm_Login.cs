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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        public static int ID_usuario;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(TxtUsername.Text))
            {
                MessageBox.Show("Ingrese Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtUsername.Focus();
            }
            else if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Ingrese Contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPassword.Focus();
            }
            else
            {
                Login(TxtUsername.Text, TxtPassword.Text); ;
            }
        }
            private void Login(string Username, string Password)
            {
                NUsuario bo = new NUsuario();
                EUsuario be = bo.LoginUsuario(Username, Password);
                if (be.Username != Username)
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (be.Password != Password)
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (be.Estado == 0)
                {
                    MessageBox.Show("Usuario sin Acceso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    //Obtener ID del Empleado
                    NEmpleado boEmpleado = new NEmpleado();
                    int IDEmpleado = boEmpleado.ObtenerID(be.Username);
                    Frm_Principal.AccesoUsername = be.Username;
                    Frm_Principal.AccesoUsernameID = IDEmpleado;
                    Frm_Principal frm = new Frm_Principal();
                    frm.Show();
                    Hide();
                }
            }
        

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
