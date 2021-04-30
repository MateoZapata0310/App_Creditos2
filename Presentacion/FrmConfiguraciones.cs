using System;
using Negocio;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmConfiguraciones : Form
    {
        public FrmConfiguraciones()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Fnt_CambiarClave()
        {
            Cls_Cliente_Negocio ObjCambiarClave = new Cls_Cliente_Negocio();
            ObjCambiarClave.Fnt_CambiarClave(LblUsuario.Text, TxtClaveN.Text, TxtClaveA.Text, TxtClaveC.Text);
            LblMensaje.Text = ObjCambiarClave.msn;
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            Fnt_CambiarClave();
        }
    }
}
