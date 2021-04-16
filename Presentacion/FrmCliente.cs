using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmCliente : Form
    {
        String var;
        int contador = 0;
        public FrmCliente()
        {
            InitializeComponent();
        }


        private void Btn1_Click(object sender, EventArgs e)
        {
            if (contador == 12)
            {
                return;
            }
            else
            {
                var = var + "1";
                TxtId.Text = var;
                contador++;
            }
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (contador == 12)
            {
                return;
            }
            else
            {
                var = var + "2";
                TxtId.Text = var;
                contador++;
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (contador == 12)
            {
                return;
            }
            else
            {
                var = var + "3";
                TxtId.Text = var;
                contador++;
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (contador == 12)
            {
                return;
            }
            else
            {
                var = var + "4";
                TxtId.Text = var;
                contador++;
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (contador == 12)
            {
                return;
            }
            else
            {
                var = var + "5";
                TxtId.Text = var;
                contador++;
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (contador == 12)
            {
                return;
            }
            else
            {
                var = var + "6";
                TxtId.Text = var;
                contador++;
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (contador == 12)
            {
                return;
            }
            else
            {
                var = var + "7";
                TxtId.Text = var;
                contador++;
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (contador == 12)
            {
                return;
            }
            else
            {
                var = var + "8";
                TxtId.Text = var;
                contador++;
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (contador == 12)
            {
                return;
            }
            else
            {
                var = var + "9";
                TxtId.Text = var;
                contador++;
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (contador == 12)
            {
                return;
            }
            else
            {
                var = var + "0";
                TxtId.Text = var;
                contador++;
            }
        }

        protected void Fnt_LimpiarConntroles()
        {
            TxtNombre.Clear();
            TxtContacto.Clear();
            TxtCorreo.Clear();
            TxtEdad.Clear();
            TxtEmpresa.Clear();
            TxtContactEmpre.Clear();
            TxtIngresos.Clear();
            CbxEstadoCivil.SelectedIndex = 0;
            CbxSexo.SelectedIndex = 0;
            TxtId.Clear();
            contador = 0;
            var = "";
            Fnt_HabilitarTeclado();
            TxtId.Focus();

        }

        protected void Fnt_HabilitarTeclado()
        {
            Btn0.Enabled = true;
            Btn1.Enabled = true;
            Btn2.Enabled = true;
            Btn3.Enabled = true;
            Btn4.Enabled = true;
            Btn5.Enabled = true;
            Btn6.Enabled = true;
            Btn7.Enabled = true;
            Btn8.Enabled = true;
            Btn9.Enabled = true;
            BtnEnter.Enabled = true;
            TxtNombre.Enabled = true;
            CbxSexo.Enabled = true;

        }

        private void BtnSupr_Click(object sender, EventArgs e)
        {
            
            Fnt_LimpiarConntroles();
        }
        protected void Fnt_ConsultarCliente()
        {
            Cls_Cliente_Negocio ObjConsultar = new Cls_Cliente_Negocio();
            ObjConsultar.Fnt_ConsultarCliente(TxtId.Text);
            TxtNombre.Text = ObjConsultar.aux[0];
            TxtContacto.Text = ObjConsultar.aux[1];
            TxtCorreo.Text = ObjConsultar.aux[2];
            TxtEdad.Text = ObjConsultar.aux[3];
            TxtIngresos.Text = ObjConsultar.aux[4];
            TxtEmpresa.Text = ObjConsultar.aux[5];
            TxtContactEmpre.Text = ObjConsultar.aux[6];
            CbxSexo.SelectedIndex = Convert.ToInt32(ObjConsultar.aux[7]);
            CbxEstadoCivil.SelectedIndex = Convert.ToInt32(ObjConsultar.aux[8]);
            lblMensaje.Text = ObjConsultar.msn;
            if (lblMensaje.Text == "")
            {
                Fnt_BloqueoTeclado();
            }

        }

        protected void Fnt_BloqueoTeclado()
        {
            Btn0.Enabled = false;
            Btn1.Enabled = false;
            Btn2.Enabled = false;
            Btn3.Enabled = false;
            Btn4.Enabled = false;
            Btn5.Enabled = false;
            Btn6.Enabled = false;
            Btn7.Enabled = false;
            Btn8.Enabled = false;
            Btn9.Enabled = false;
            BtnEnter.Enabled = false;
            TxtNombre.Enabled = false;
            CbxSexo.Enabled = false;
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            Fnt_ConsultarCliente();
        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtContactEmpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet2.TblSexo' Puede moverla o quitarla según sea necesario.
            this.tblSexoTableAdapter.Fill(this.dB_CreditosDataSet2.TblSexo);
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet1.TblEstadoCivil' Puede moverla o quitarla según sea necesario.
            this.tblEstadoCivilTableAdapter.Fill(this.dB_CreditosDataSet1.TblEstadoCivil);

        }

        protected void Fnt_AgregarCLiente()
        {
            Cls_Cliente_Negocio ObjCliente = new Cls_Cliente_Negocio();
            ObjCliente.Fnt_AgregarCliente(TxtId.Text, TxtNombre.Text, TxtContacto.Text, TxtCorreo.Text, TxtEdad.Text, TxtIngresos.Text,
                TxtEmpresa.Text, TxtContactEmpre.Text, 
                Convert.ToString(CbxSexo.SelectedValue), 
                Convert.ToString(CbxEstadoCivil.SelectedValue));
                lblMensaje.Text = ObjCliente.msn;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fnt_AgregarCLiente();
           
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fnt_LimpiarConntroles();
        }

        protected void Fnt_ActualizarCliente()
        {
            Cls_Cliente_Negocio objActualizar = new Cls_Cliente_Negocio();
            objActualizar.Fnt_Actualizar
                (
                    TxtId.Text, TxtContacto.Text, TxtCorreo.Text, TxtEdad.Text, TxtIngresos.Text,
                    TxtEmpresa.Text, TxtContactEmpre.Text,
                    Convert.ToString(CbxEstadoCivil.SelectedValue)
                );
            lblMensaje.Text = objActualizar.msn;

        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fnt_ActualizarCliente();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
