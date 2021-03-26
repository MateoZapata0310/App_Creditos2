
namespace Presentacion
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.CbxUsuario = new System.Windows.Forms.ComboBox();
            this.tblCredencialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_CreditosDataSet = new Presentacion.DB_CreditosDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbUsuario = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChMostrar = new System.Windows.Forms.CheckBox();
            this.LbClave = new System.Windows.Forms.Label();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnSupr = new System.Windows.Forms.Button();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblCredencialesTableAdapter = new Presentacion.DB_CreditosDataSetTableAdapters.TblCredencialesTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblCredencialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxUsuario
            // 
            this.CbxUsuario.DataSource = this.tblCredencialesBindingSource;
            this.CbxUsuario.DisplayMember = "PKCorreo";
            this.CbxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxUsuario.FormattingEnabled = true;
            this.CbxUsuario.Location = new System.Drawing.Point(10, 41);
            this.CbxUsuario.Name = "CbxUsuario";
            this.CbxUsuario.Size = new System.Drawing.Size(433, 37);
            this.CbxUsuario.TabIndex = 0;
            this.CbxUsuario.ValueMember = "PKCorreo";
            // 
            // tblCredencialesBindingSource
            // 
            this.tblCredencialesBindingSource.DataMember = "TblCredenciales";
            this.tblCredencialesBindingSource.DataSource = this.dB_CreditosDataSet;
            // 
            // dB_CreditosDataSet
            // 
            this.dB_CreditosDataSet.DataSetName = "DB_CreditosDataSet";
            this.dB_CreditosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.LbUsuario);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 43);
            this.panel1.TabIndex = 1;
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.LbUsuario.Location = new System.Drawing.Point(30, 8);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(181, 25);
            this.LbUsuario.TabIndex = 0;
            this.LbUsuario.Text = "Seleccione Usuario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.ChMostrar);
            this.panel2.Controls.Add(this.LbClave);
            this.panel2.Location = new System.Drawing.Point(-1, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 38);
            this.panel2.TabIndex = 3;
            // 
            // ChMostrar
            // 
            this.ChMostrar.AutoSize = true;
            this.ChMostrar.ForeColor = System.Drawing.SystemColors.Window;
            this.ChMostrar.Location = new System.Drawing.Point(269, 8);
            this.ChMostrar.Name = "ChMostrar";
            this.ChMostrar.Size = new System.Drawing.Size(78, 21);
            this.ChMostrar.TabIndex = 1;
            this.ChMostrar.Text = "Mostrar";
            this.ChMostrar.UseVisualStyleBackColor = true;
            this.ChMostrar.CheckedChanged += new System.EventHandler(this.ChMostrar_CheckedChanged);
            // 
            // LbClave
            // 
            this.LbClave.AutoSize = true;
            this.LbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbClave.ForeColor = System.Drawing.SystemColors.Window;
            this.LbClave.Location = new System.Drawing.Point(30, 8);
            this.LbClave.Name = "LbClave";
            this.LbClave.Size = new System.Drawing.Size(148, 25);
            this.LbClave.TabIndex = 0;
            this.LbClave.Text = "Ingrese la clave";
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(10, 182);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(73, 46);
            this.Btn1.TabIndex = 4;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            this.Btn1.MouseLeave += new System.EventHandler(this.Btn1_MouseLeave);
            this.Btn1.MouseHover += new System.EventHandler(this.Btn1_MouseHover);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(82, 182);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(73, 46);
            this.Btn2.TabIndex = 5;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            this.Btn2.MouseLeave += new System.EventHandler(this.Btn2_MouseLeave);
            this.Btn2.MouseHover += new System.EventHandler(this.Btn2_MouseHover);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(154, 182);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(73, 46);
            this.Btn3.TabIndex = 6;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            this.Btn3.MouseLeave += new System.EventHandler(this.Btn3_MouseLeave);
            this.Btn3.MouseHover += new System.EventHandler(this.Btn3_MouseHover);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(154, 227);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(73, 46);
            this.Btn6.TabIndex = 9;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            this.Btn6.MouseLeave += new System.EventHandler(this.Btn6_MouseLeave);
            this.Btn6.MouseHover += new System.EventHandler(this.Btn6_MouseHover);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(82, 227);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(73, 46);
            this.Btn5.TabIndex = 8;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            this.Btn5.MouseLeave += new System.EventHandler(this.Btn5_MouseLeave);
            this.Btn5.MouseHover += new System.EventHandler(this.Btn5_MouseHover);
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(10, 227);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(73, 46);
            this.Btn4.TabIndex = 7;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            this.Btn4.MouseLeave += new System.EventHandler(this.Btn4_MouseLeave);
            this.Btn4.MouseHover += new System.EventHandler(this.Btn4_MouseHover);
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(154, 272);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(73, 46);
            this.Btn9.TabIndex = 12;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            this.Btn9.MouseLeave += new System.EventHandler(this.Btn9_MouseLeave);
            this.Btn9.MouseHover += new System.EventHandler(this.Btn9_MouseHover);
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(82, 272);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(73, 46);
            this.Btn8.TabIndex = 11;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            this.Btn8.MouseLeave += new System.EventHandler(this.Btn8_MouseLeave);
            this.Btn8.MouseHover += new System.EventHandler(this.Btn8_MouseHover);
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(10, 272);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(73, 46);
            this.Btn7.TabIndex = 10;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            this.Btn7.MouseLeave += new System.EventHandler(this.Btn7_MouseLeave);
            this.Btn7.MouseHover += new System.EventHandler(this.Btn7_MouseHover);
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(82, 317);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(73, 46);
            this.Btn0.TabIndex = 13;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            this.Btn0.MouseLeave += new System.EventHandler(this.Btn0_MouseLeave);
            this.Btn0.MouseHover += new System.EventHandler(this.Btn0_MouseHover);
            // 
            // BtnSupr
            // 
            this.BtnSupr.BackColor = System.Drawing.Color.Red;
            this.BtnSupr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupr.Location = new System.Drawing.Point(10, 317);
            this.BtnSupr.Name = "BtnSupr";
            this.BtnSupr.Size = new System.Drawing.Size(73, 46);
            this.BtnSupr.TabIndex = 14;
            this.BtnSupr.Text = "Supr";
            this.BtnSupr.UseVisualStyleBackColor = false;
            this.BtnSupr.Click += new System.EventHandler(this.BtnSupr_Click);
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.Green;
            this.BtnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnter.Location = new System.Drawing.Point(154, 317);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(73, 46);
            this.BtnEnter.TabIndex = 15;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // TxtClave
            // 
            this.TxtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.Location = new System.Drawing.Point(-1, 124);
            this.TxtClave.MaxLength = 4;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '®';
            this.TxtClave.ReadOnly = true;
            this.TxtClave.Size = new System.Drawing.Size(455, 34);
            this.TxtClave.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // tblCredencialesTableAdapter
            // 
            this.tblCredencialesTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(389, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(452, 373);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.BtnSupr);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CbxUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo-Credenciales";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCredencialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LbClave;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnSupr;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ChMostrar;
        private DB_CreditosDataSet dB_CreditosDataSet;
        private System.Windows.Forms.BindingSource tblCredencialesBindingSource;
        private DB_CreditosDataSetTableAdapters.TblCredencialesTableAdapter tblCredencialesTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}