using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        protected void Fnt_ModuloCliente()
        {
            FrmCliente ObjCliente = new FrmCliente();
            ObjCliente.LblUsuario.Text = LblUsuario.Text;
            ObjCliente.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Fnt_ModuloCliente();
        }
        protected void Fnt_CerraSesion()
        {
            FrmLogin ObjLogin = new FrmLogin();
            ObjLogin.Show();
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Fnt_CerraSesion();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmCreditos ObjCreditos = new FrmCreditos();
            ObjCreditos.LblUsuario.Text = LblUsuario.Text;
            ObjCreditos.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmConfiguraciones ObjConfi = new FrmConfiguraciones();
            ObjConfi.LblUsuario.Text = LblUsuario.Text;
            ObjConfi.ShowDialog();

        }
    }
}
