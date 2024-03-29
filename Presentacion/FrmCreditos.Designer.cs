﻿
namespace Presentacion
{
    partial class FrmCreditos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbModulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblDiaPago = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.LblMonto = new System.Windows.Forms.Label();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.dB_CreditosDataSet3 = new Presentacion.DB_CreditosDataSet3();
            this.tblPlazoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPlazoTableAdapter = new Presentacion.DB_CreditosDataSet3TableAdapters.TblPlazoTableAdapter();
            this.LblPlazo = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CbxPlazo = new System.Windows.Forms.ComboBox();
            this.CbxInteres = new System.Windows.Forms.ComboBox();
            this.tblInteresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_CreditosDataSet4 = new Presentacion.DB_CreditosDataSet4();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tblInteresTableAdapter = new Presentacion.DB_CreditosDataSet4TableAdapters.TblInteresTableAdapter();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCuota = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTotalCredito = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtDiaPago = new System.Windows.Forms.TextBox();
            this.LbMensaje = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LbUsuario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlazoBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblInteresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet4)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.LblUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LbModulo);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 123);
            this.panel1.TabIndex = 1;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.LblUsuario.Location = new System.Drawing.Point(680, 74);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(121, 32);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(572, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // LbModulo
            // 
            this.LbModulo.AutoSize = true;
            this.LbModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbModulo.ForeColor = System.Drawing.SystemColors.Window;
            this.LbModulo.Location = new System.Drawing.Point(20, 37);
            this.LbModulo.Name = "LbModulo";
            this.LbModulo.Size = new System.Drawing.Size(320, 44);
            this.LbModulo.TabIndex = 0;
            this.LbModulo.Text = "Modulo - Creditos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Controls.Add(this.LblNombre);
            this.panel3.Location = new System.Drawing.Point(413, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 38);
            this.panel3.TabIndex = 33;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.LblNombre.Location = new System.Drawing.Point(30, 8);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(81, 25);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtNombre.Location = new System.Drawing.Point(413, 208);
            this.TxtNombre.MaxLength = 300;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(707, 34);
            this.TxtNombre.TabIndex = 32;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGreen;
            this.panel4.Controls.Add(this.LblDiaPago);
            this.panel4.Location = new System.Drawing.Point(38, 283);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 38);
            this.panel4.TabIndex = 21;
            // 
            // LblDiaPago
            // 
            this.LblDiaPago.AutoSize = true;
            this.LblDiaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiaPago.ForeColor = System.Drawing.SystemColors.Window;
            this.LblDiaPago.Location = new System.Drawing.Point(30, 8);
            this.LblDiaPago.Name = "LblDiaPago";
            this.LblDiaPago.Size = new System.Drawing.Size(119, 25);
            this.LblDiaPago.TabIndex = 0;
            this.LblDiaPago.Text = "Dia de Pago";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGreen;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.LblMonto);
            this.panel5.Location = new System.Drawing.Point(413, 285);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(322, 38);
            this.panel5.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(217, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "<ENTER>";
            // 
            // LblMonto
            // 
            this.LblMonto.AutoSize = true;
            this.LblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonto.ForeColor = System.Drawing.SystemColors.Window;
            this.LblMonto.Location = new System.Drawing.Point(30, 8);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(157, 25);
            this.LblMonto.TabIndex = 0;
            this.LblMonto.Text = "Monto Solicitado";
            // 
            // TxtMonto
            // 
            this.TxtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtMonto.Location = new System.Drawing.Point(413, 323);
            this.TxtMonto.MaxLength = 300;
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(322, 34);
            this.TxtMonto.TabIndex = 35;
            this.TxtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMonto_KeyPress);
            this.TxtMonto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtMonto_KeyUp);
            // 
            // dB_CreditosDataSet3
            // 
            this.dB_CreditosDataSet3.DataSetName = "DB_CreditosDataSet3";
            this.dB_CreditosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPlazoBindingSource
            // 
            this.tblPlazoBindingSource.DataMember = "TblPlazo";
            this.tblPlazoBindingSource.DataSource = this.dB_CreditosDataSet3;
            // 
            // tblPlazoTableAdapter
            // 
            this.tblPlazoTableAdapter.ClearBeforeFill = true;
            // 
            // LblPlazo
            // 
            this.LblPlazo.AutoSize = true;
            this.LblPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlazo.ForeColor = System.Drawing.SystemColors.Window;
            this.LblPlazo.Location = new System.Drawing.Point(30, 8);
            this.LblPlazo.Name = "LblPlazo";
            this.LblPlazo.Size = new System.Drawing.Size(61, 25);
            this.LblPlazo.TabIndex = 0;
            this.LblPlazo.Text = "Plazo";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGreen;
            this.panel6.Controls.Add(this.LblPlazo);
            this.panel6.Location = new System.Drawing.Point(758, 283);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(362, 38);
            this.panel6.TabIndex = 37;
            // 
            // CbxPlazo
            // 
            this.CbxPlazo.DataSource = this.tblPlazoBindingSource;
            this.CbxPlazo.DisplayMember = "Descripcion";
            this.CbxPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxPlazo.FormattingEnabled = true;
            this.CbxPlazo.Location = new System.Drawing.Point(758, 322);
            this.CbxPlazo.Name = "CbxPlazo";
            this.CbxPlazo.Size = new System.Drawing.Size(362, 37);
            this.CbxPlazo.TabIndex = 38;
            this.CbxPlazo.ValueMember = "PKId";
            this.CbxPlazo.SelectedIndexChanged += new System.EventHandler(this.CbxPlazo_SelectedIndexChanged);
            // 
            // CbxInteres
            // 
            this.CbxInteres.DataSource = this.tblInteresBindingSource;
            this.CbxInteres.DisplayMember = "Descripcion";
            this.CbxInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxInteres.FormattingEnabled = true;
            this.CbxInteres.Location = new System.Drawing.Point(38, 427);
            this.CbxInteres.Name = "CbxInteres";
            this.CbxInteres.Size = new System.Drawing.Size(360, 37);
            this.CbxInteres.TabIndex = 40;
            this.CbxInteres.ValueMember = "PKId";
            // 
            // tblInteresBindingSource
            // 
            this.tblInteresBindingSource.DataMember = "TblInteres";
            this.tblInteresBindingSource.DataSource = this.dB_CreditosDataSet4;
            // 
            // dB_CreditosDataSet4
            // 
            this.dB_CreditosDataSet4.DataSetName = "DB_CreditosDataSet4";
            this.dB_CreditosDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGreen;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(38, 389);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(360, 38);
            this.panel7.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(30, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Interes";
            // 
            // tblInteresTableAdapter
            // 
            this.tblInteresTableAdapter.ClearBeforeFill = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkGreen;
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(413, 391);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(322, 38);
            this.panel8.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(14, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cuota";
            // 
            // TxtCuota
            // 
            this.TxtCuota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCuota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuota.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCuota.Location = new System.Drawing.Point(413, 429);
            this.TxtCuota.MaxLength = 300;
            this.TxtCuota.Name = "TxtCuota";
            this.TxtCuota.ReadOnly = true;
            this.TxtCuota.Size = new System.Drawing.Size(322, 34);
            this.TxtCuota.TabIndex = 37;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkGreen;
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(758, 391);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(362, 38);
            this.panel9.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(30, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Creditos";
            // 
            // TxtTotalCredito
            // 
            this.TxtTotalCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTotalCredito.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTotalCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalCredito.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtTotalCredito.Location = new System.Drawing.Point(758, 430);
            this.TxtTotalCredito.MaxLength = 300;
            this.TxtTotalCredito.Name = "TxtTotalCredito";
            this.TxtTotalCredito.ReadOnly = true;
            this.TxtTotalCredito.Size = new System.Drawing.Size(362, 34);
            this.TxtTotalCredito.TabIndex = 41;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(763, 483);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(362, 44);
            this.BtnGuardar.TabIndex = 42;
            this.BtnGuardar.Text = "&Guardar Credito";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(413, 483);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(322, 44);
            this.BtnCancelar.TabIndex = 43;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(38, 483);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(360, 44);
            this.BtnSalir.TabIndex = 44;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtDiaPago
            // 
            this.TxtDiaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiaPago.Location = new System.Drawing.Point(38, 321);
            this.TxtDiaPago.MaxLength = 2;
            this.TxtDiaPago.Name = "TxtDiaPago";
            this.TxtDiaPago.Size = new System.Drawing.Size(360, 34);
            this.TxtDiaPago.TabIndex = 45;
            this.TxtDiaPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFechaPago_KeyPress);
            // 
            // LbMensaje
            // 
            this.LbMensaje.AutoSize = true;
            this.LbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMensaje.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LbMensaje.Location = new System.Drawing.Point(52, 547);
            this.LbMensaje.Name = "LbMensaje";
            this.LbMensaje.Size = new System.Drawing.Size(0, 36);
            this.LbMensaje.TabIndex = 3;
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(38, 208);
            this.TxtId.MaxLength = 10;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(360, 34);
            this.TxtId.TabIndex = 19;
            this.TxtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtId_KeyPress);
            this.TxtId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtId_KeyUp);
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.LbUsuario.Location = new System.Drawing.Point(17, 8);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(125, 25);
            this.LbUsuario.TabIndex = 0;
            this.LbUsuario.Text = "Identificacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(232, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "<ENTER>";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.LbUsuario);
            this.panel2.Location = new System.Drawing.Point(38, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 38);
            this.panel2.TabIndex = 20;
            // 
            // FrmCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 615);
            this.Controls.Add(this.LbMensaje);
            this.Controls.Add(this.TxtDiaPago);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtTotalCredito);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.TxtCuota);
            this.Controls.Add(this.CbxInteres);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.CbxPlazo);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCreditos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlazoBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblInteresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet4)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbModulo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblDiaPago;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.TextBox TxtMonto;
        private DB_CreditosDataSet3 dB_CreditosDataSet3;
        private System.Windows.Forms.BindingSource tblPlazoBindingSource;
        private DB_CreditosDataSet3TableAdapters.TblPlazoTableAdapter tblPlazoTableAdapter;
        private System.Windows.Forms.Label LblPlazo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox CbxPlazo;
        private System.Windows.Forms.ComboBox CbxInteres;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private DB_CreditosDataSet4 dB_CreditosDataSet4;
        private System.Windows.Forms.BindingSource tblInteresBindingSource;
        private DB_CreditosDataSet4TableAdapters.TblInteresTableAdapter tblInteresTableAdapter;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCuota;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTotalCredito;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDiaPago;
        private System.Windows.Forms.Label LbMensaje;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LbUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
    }
}