using System;
using System.Windows.Forms;
using Negocio;


namespace Presentacion
{
    public partial class FrmCreditos : Form
    {
        public FrmCreditos()
        {
            InitializeComponent();
            CbxInteres.Enabled = false;
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void FrmCreditos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet4.TblInteres' Puede moverla o quitarla según sea necesario.
            this.tblInteresTableAdapter.Fill(this.dB_CreditosDataSet4.TblInteres);
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet3.TblPlazo' Puede moverla o quitarla según sea necesario.
            this.tblPlazoTableAdapter.Fill(this.dB_CreditosDataSet3.TblPlazo);

        }
        private void TxtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void Fnt_CalcularCuota()
        {
            Cls_Cliente_Negocio ObjCalcularCuota = new Cls_Cliente_Negocio();
            ObjCalcularCuota.Fnt_CalcularCuota(TxtMonto.Text, Convert.ToInt32(CbxPlazo.Text));
            TxtCuota.Text = Convert.ToString(ObjCalcularCuota.cuota2);
            TxtTotalCredito.Text = Convert.ToString(ObjCalcularCuota.total);
            CbxInteres.SelectedIndex = Convert.ToInt32(ObjCalcularCuota.pos);
        }


        private void TxtMonto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Fnt_CalcularCuota();
            }
        }

        private void CbxPlazo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fnt_CalcularCuota();
        }

        protected void Fnt_ConsultarCliente(String id)
        {
            Cls_Cliente_Negocio ObjConsultar = new Cls_Cliente_Negocio();
            ObjConsultar.Fnt_ConsultarCliente(id);
            TxtNombre.Text = ObjConsultar.aux[0];
        }

        private void TxtId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Fnt_ConsultarCliente(TxtId.Text);
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

        private void TxtFechaPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        protected void Fnt_GuardarCreditos(
            String id,
            String dia_pago,
            String valor_prestamo,
            int plazo,
            String cuota,
            int interes,
            String valor_total,
            String user)
        {
            Cls_Credito_Negocio ObjGuardar = new Cls_Credito_Negocio();
            ObjGuardar.Fnt_GuardarCredito(id, dia_pago, valor_prestamo, plazo, cuota, interes, valor_total, user);
            LbMensaje.Text = ObjGuardar.msn;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Fnt_GuardarCreditos(TxtId.Text, TxtDiaPago.Text, TxtMonto.Text, 
                                CbxPlazo.SelectedIndex, TxtCuota.Text,CbxInteres.SelectedIndex, 
                                TxtTotalCredito.Text, LblUsuario.Text);
        }
    }
}
