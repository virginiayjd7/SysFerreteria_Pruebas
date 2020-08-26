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
    public partial class Frm_Registrar_Cargo : Form
    {
        public Frm_Registrar_Cargo()
        {
            InitializeComponent();
        }
        public static int modificar = 0;

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDescripcion.Text))
            {
                MessageBox.Show("Ingre descripción del Cargo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtDescripcion.Focus();
            }
            else
            {
                Guardar();
            }
        }
        private void Listar()
        {
            NCargo bo = new NCargo();
            DgvCargo.DataSource = bo.Listar();
        }
        private void Guardar()
        {
            ECargo be = new ECargo
            {
                ID = Convert.ToInt32(lblIdentificador.Text),
                Descripcion = TxtDescripcion.Text
            };
            NCargo bo = new NCargo();
            if (modificar == 0)
            {
                if (bo.Agregar(be))
                {
                    TxtDescripcion.Text = "";
                    Listar();
                    Frm_Principal.Main.ChangeMessage("Cargo agregado correctamente", "Success");
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
                    Listar();
                    Frm_Principal.Main.ChangeMessage("Cargo modificado correctamente", "Success");
                }
                else
                {
                    Frm_Principal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
        }

        private void Frm_Registrar_Cargo_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvCargo.SelectedRows.Count > 0)
            {
                int rowindex = DgvCargo.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        modificar = 1;
                        BtnAgregar.Text = "Guardar";
                        BtnAgregar.BackColor = Color.FromArgb(0, 166, 81);
                        BtnCancelar.Visible = true;
                        BtnEditar.Enabled = false;
                        lblIdentificador.Text = DgvCargo.CurrentRow.Cells[0].Value.ToString();
                        TxtDescripcion.Text = DgvCargo.CurrentRow.Cells[1].Value.ToString();
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            modificar = 0;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.BackColor = Color.FromArgb(66, 139, 202);
            TxtDescripcion.Text = "";
            BtnCancelar.Visible = false;
            BtnEditar.Enabled = true;
        }

        private void DgvCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modificar == 1)
            {
                try
                {
                    lblIdentificador.Text = DgvCargo.CurrentRow.Cells[0].Value.ToString();
                    TxtDescripcion.Text = DgvCargo.CurrentRow.Cells[1].Value.ToString();
                }
                catch
                {
                    //
                }
            }
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Principal frm = new Frm_Principal();
            frm.Show();
            Close();
        }
    }
 }

