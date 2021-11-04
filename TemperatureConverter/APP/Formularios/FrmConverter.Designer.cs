
namespace APP.Formularios
{
    partial class FrmConverter
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
            this.txtingresa = new System.Windows.Forms.TextBox();
            this.lblCovertir = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Grados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoTemperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConversionG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConversionTem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.cmbEleccionIngresa2 = new System.Windows.Forms.ComboBox();
            this.cmbEleccionIngresa = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtingresa
            // 
            this.txtingresa.Location = new System.Drawing.Point(151, 54);
            this.txtingresa.Multiline = true;
            this.txtingresa.Name = "txtingresa";
            this.txtingresa.Size = new System.Drawing.Size(140, 32);
            this.txtingresa.TabIndex = 0;
            this.txtingresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtingresa.TextChanged += new System.EventHandler(this.txtingresa_TextChanged);
            // 
            // lblCovertir
            // 
            this.lblCovertir.AutoSize = true;
            this.lblCovertir.Location = new System.Drawing.Point(68, 137);
            this.lblCovertir.Name = "lblCovertir";
            this.lblCovertir.Size = new System.Drawing.Size(64, 13);
            this.lblCovertir.TabIndex = 6;
            this.lblCovertir.Text = "Convertir a: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSalida);
            this.groupBox1.Controls.Add(this.cmbEleccionIngresa2);
            this.groupBox1.Controls.Add(this.cmbEleccionIngresa);
            this.groupBox1.Controls.Add(this.lblCovertir);
            this.groupBox1.Controls.Add(this.txtingresa);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 487);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grados,
            this.TipoTemperatura,
            this.ConversionG,
            this.ConversionTem});
            this.dataGridView1.Location = new System.Drawing.Point(59, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(414, 168);
            this.dataGridView1.TabIndex = 13;
            // 
            // Grados
            // 
            this.Grados.HeaderText = "Grados";
            this.Grados.Name = "Grados";
            this.Grados.ReadOnly = true;
            // 
            // TipoTemperatura
            // 
            this.TipoTemperatura.HeaderText = "Tipo Temperatura";
            this.TipoTemperatura.Name = "TipoTemperatura";
            this.TipoTemperatura.ReadOnly = true;
            // 
            // ConversionG
            // 
            this.ConversionG.HeaderText = "Conversion Grados";
            this.ConversionG.Name = "ConversionG";
            this.ConversionG.ReadOnly = true;
            // 
            // ConversionTem
            // 
            this.ConversionTem.HeaderText = "Conversion Temperatura";
            this.ConversionTem.Name = "ConversionTem";
            this.ConversionTem.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingresa los grados";
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(296, 134);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(140, 32);
            this.txtSalida.TabIndex = 10;
            this.txtSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbEleccionIngresa2
            // 
            this.cmbEleccionIngresa2.FormattingEnabled = true;
            this.cmbEleccionIngresa2.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.cmbEleccionIngresa2.Location = new System.Drawing.Point(151, 137);
            this.cmbEleccionIngresa2.Name = "cmbEleccionIngresa2";
            this.cmbEleccionIngresa2.Size = new System.Drawing.Size(121, 21);
            this.cmbEleccionIngresa2.TabIndex = 9;
            this.cmbEleccionIngresa2.SelectedIndexChanged += new System.EventHandler(this.cmbConverter_SelectedIndexChanged);
            // 
            // cmbEleccionIngresa
            // 
            this.cmbEleccionIngresa.FormattingEnabled = true;
            this.cmbEleccionIngresa.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.cmbEleccionIngresa.Location = new System.Drawing.Point(315, 62);
            this.cmbEleccionIngresa.Name = "cmbEleccionIngresa";
            this.cmbEleccionIngresa.Size = new System.Drawing.Size(121, 21);
            this.cmbEleccionIngresa.TabIndex = 8;
            this.cmbEleccionIngresa.SelectedIndexChanged += new System.EventHandler(this.cmbEleccion_SelectedIndexChanged);
            // 
            // FrmConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 529);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConverter";
            this.Text = "Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtingresa;
        private System.Windows.Forms.Label lblCovertir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEleccionIngresa;
        private System.Windows.Forms.ComboBox cmbEleccionIngresa2;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grados;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTemperatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConversionG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConversionTem;
    }
}