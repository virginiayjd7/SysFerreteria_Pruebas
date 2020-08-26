using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyecttoSysFerreteria.Presentacion;
using ProyecttoSysFerreteria.Entidad;
using ProyecttoSysFerreteria.Negocios;
using MaterialSkin;
using System.Threading;

namespace ProyecttoSysFerreteria.Presentacion
{
    public partial class Frm_Principal : Form
    {
        public static Frm_Principal Main;
        public Frm_Principal()
        {
            InitializeComponent();
            Main = this;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;


        }
        public static string AccesoUsername;
        public static int AccesoUsernameID;

        public static double ValorUtilidad = 1.30;
        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            //ChangeHeaderTitle("Dashboard");
            //OpenForm(new FrmDashboard());
            FechaSistema();
           
            CargarPerfilBasico();
        }
        public void CargarPerfilBasico()
        {
            NUsuario boUsuario = new NUsuario();
            if (boUsuario.ObtenerPerfilBasico(AccesoUsername) != null)
            {
                DataRow row = boUsuario.ObtenerPerfilBasico(AccesoUsername);
                LblUNombre.Text = row["Nombre"].ToString() + " " + row["Apellido"].ToString();
                LblUDescripcion.Text = row["Descripcion"].ToString();
            }
        }

        private void OpenForm(object formulario)
        {
            if (PanelContainer.Controls.Count > 0)
            {
                PanelContainer.Controls.RemoveAt(0);
            }
            Form frm = formulario as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Size = ClientSize;
            PanelContainer.Controls.Add(frm);
            PanelContainer.Tag = frm;
            frm.Show();
        }

        private void ChangeHeaderTitle(string title)
        {
            LblHeaderTitle.Text = title;
        }
        private void FechaSistema()
        {
            DateTime fm = DateTime.Now;
            LblFecha.Text = fm.ToLongDateString();
        }
        public void ChangeMessage(string message, string response)
        {
            LblMessage.Visible = true;
            switch (response)
            {
                case "Success":
                    PanelState.BackColor = Color.FromArgb(0, 230, 118);
                    LblMessage.ForeColor = Color.FromArgb(26, 26, 26);
                    break;
                case "Failed":
                    PanelState.BackColor = Color.FromArgb(229, 57, 53);
                    LblMessage.ForeColor = Color.White;
                    break;
                case "State":
                    PanelState.BackColor = Color.FromArgb(191, 194, 199);
                    LblMessage.ForeColor = Color.Black;
                    break;
                default:
                    LblMessage.Visible = false;
                    PanelState.BackColor = Color.FromArgb(191, 194, 199);
                    LblMessage.ForeColor = Color.Black;
                    break;
            }
            LblMessage.Text = message;
            Thread t = new Thread(new ThreadStart(MessageTheread));
            t.Start();
        }
        private void MessageTheread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(500);
                if (i == 9)
                {
                    MethodInvoker setM = () => LblMessage.Visible = false;
                    MethodInvoker setP = () => PanelState.BackColor = Color.FromArgb(191, 194, 199);
                    LblMessage.BeginInvoke(setM);
                    LblMessage.BeginInvoke(setP);
                }
            }

        }

        private void btnAddMiembro_Click(object sender, EventArgs e)
        {

        }

        private void PanelNavegacionn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Frm_Login frm = new Frm_Login();
                frm.Show();
                Close();
            }
        }

        private void PbbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PbbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PbbMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            PbbMaximizar.Visible = false;
            PbbRestaurar.Visible = true;
        }
        int posY = 0;
        int posX = 0;
        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Ventas");
            OpenForm(new Frm_Buscar_venta());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Compras");
            OpenForm(new Frm_Buscar_Compra());
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Productos");
            OpenForm(new Frm_Buscar_Productos());
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Clientes");
            OpenForm(new Frm_Buscar_Cliente());
        }

        private void btnAddMiembro_Click_1(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Personal");
            OpenForm(new Frm_Buscar_Empleado());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Personal");
            OpenForm(new Frm_ReportesFerreteria());
        }

        private void PbbPerfil_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("perfil");
            OpenForm(new Frm_Registrar_Usuario());
        }
    }
}
