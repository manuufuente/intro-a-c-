namespace clase_5
{
    partial class Form1
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtEjer3 = new System.Windows.Forms.TextBox();
            this.rbtnMayus = new System.Windows.Forms.RadioButton();
            this.rbtnMinus = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbOpcion = new System.Windows.Forms.ComboBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbtnMinus);
            this.groupBox5.Controls.Add(this.rbtnMayus);
            this.groupBox5.Controls.Add(this.txtEjer3);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(461, 121);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ejercicio 3";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // txtEjer3
            // 
            this.txtEjer3.Location = new System.Drawing.Point(6, 35);
            this.txtEjer3.Name = "txtEjer3";
            this.txtEjer3.Size = new System.Drawing.Size(235, 20);
            this.txtEjer3.TabIndex = 0;
            // 
            // rbtnMayus
            // 
            this.rbtnMayus.AutoSize = true;
            this.rbtnMayus.Location = new System.Drawing.Point(367, 35);
            this.rbtnMayus.Name = "rbtnMayus";
            this.rbtnMayus.Size = new System.Drawing.Size(76, 17);
            this.rbtnMayus.TabIndex = 1;
            this.rbtnMayus.TabStop = true;
            this.rbtnMayus.Text = "Mayuscula";
            this.rbtnMayus.UseVisualStyleBackColor = true;
            this.rbtnMayus.CheckedChanged += new System.EventHandler(this.rbtnMayus_CheckedChanged);
            // 
            // rbtnMinus
            // 
            this.rbtnMinus.AutoSize = true;
            this.rbtnMinus.Location = new System.Drawing.Point(367, 76);
            this.rbtnMinus.Name = "rbtnMinus";
            this.rbtnMinus.Size = new System.Drawing.Size(69, 17);
            this.rbtnMinus.TabIndex = 2;
            this.rbtnMinus.TabStop = true;
            this.rbtnMinus.Text = "Miniscula";
            this.rbtnMinus.UseVisualStyleBackColor = true;
            this.rbtnMinus.CheckedChanged += new System.EventHandler(this.rbtnMinus_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnJugar);
            this.groupBox6.Controls.Add(this.cmbOpcion);
            this.groupBox6.Location = new System.Drawing.Point(12, 139);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(461, 180);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ejercicio 4";
            // 
            // cmbOpcion
            // 
            this.cmbOpcion.FormattingEnabled = true;
            this.cmbOpcion.Items.AddRange(new object[] {
            "opcion 1",
            "opcion 2",
            "opcion 3"});
            this.cmbOpcion.Location = new System.Drawing.Point(51, 54);
            this.cmbOpcion.Name = "cmbOpcion";
            this.cmbOpcion.Size = new System.Drawing.Size(147, 21);
            this.cmbOpcion.TabIndex = 0;
            this.cmbOpcion.Text = "Ingrese una opcion";
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(312, 34);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(131, 59);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(485, 409);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "Form1";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEjercicio1;
        private System.Windows.Forms.TextBox txtEjercicio1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox eje;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbtnMinus;
        private System.Windows.Forms.RadioButton rbtnMayus;
        private System.Windows.Forms.TextBox txtEjer3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.ComboBox cmbOpcion;
    }
}

