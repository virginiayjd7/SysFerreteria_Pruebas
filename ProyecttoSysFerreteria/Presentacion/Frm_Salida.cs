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
    public partial class Frm_Salida : Form
    {
        public Frm_Salida()
        {
            InitializeComponent();
        }

        private void Frm_Salida_Load(object sender, EventArgs e)
        {
            Txtcargo.Enabled = false;
            Txtcodigo.Enabled = false;
            Txtnombre.Enabled = false;
            //DtpFecha.Enabled = false;

            EEmpleado objEEmp = new EEmpleado();
            NEmpleado objNEmp = new NEmpleado();

            DataTable dtempleado = new DataTable();
            objNEmp.Listar();

            foreach (DataRow row in dtempleado.Rows)
            {
                if (Frm_Login.ID_usuario== Convert.ToInt32(row[0].ToString()))
                {
                    Txtcodigo.Text = row[0].ToString();
                    Txtnombre.Text = row[1].ToString() + ' ' + row[2].ToString();
                    Txtcargo.Text = row[3].ToString();
                }
            }

            DateTime tiempo = DateTime.Now;
            LblAño.Text = tiempo.ToLongDateString();

            DateTime tiempo2 = DateTime.Parse(LblAño.Text);
            LblAño.Text = DtpFecha.Value.ToString("yyyy");
            LblMes.Text = tiempo2.ToString("MMMM");

            LblMarcado.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // string fecha = DtpHora.Value.ToString("dd-MM-yyyy");
           // EAsistencia objEAsi = new EAsistencia();
           // NAsistencia objNAsi = new NAsistencia();


            
           //objNAsi.Listar();


            
           //     if (Frm_Login.ID_usuario == Convert.ToInt32(row[1].ToString()) && fecha == row[3].ToString())
           //     {

           //         objEAsi.ID_Asistencia = Convert.ToInt32(row[0].ToString());
           //         objEAsi.Hora_Salida = DtpHora.Value.ToString();

           //         objNAsi.MtdModificar(objEAsi);
           //         LblMarcado.Show();
           //     }
            }
        }
    }


