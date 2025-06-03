namespace Petshop
{
    partial class frmCadastroBicho
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.txtBicho = new System.Windows.Forms.TextBox();
            this.numidade = new System.Windows.Forms.NumericUpDown();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lstBicho = new System.Windows.Forms.ListBox();
            this.lBlNomeBicho = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numidade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdcionar
            // 
            this.btnAdcionar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdcionar.Location = new System.Drawing.Point(199, 130);
            this.btnAdcionar.Name = "btnAdcionar";
            this.btnAdcionar.Size = new System.Drawing.Size(177, 34);
            this.btnAdcionar.TabIndex = 0;
            this.btnAdcionar.Text = "Adcionar bicho";
            this.btnAdcionar.UseVisualStyleBackColor = false;
            this.btnAdcionar.Click += new System.EventHandler(this.btnAdcionar_Click);
            // 
            // txtBicho
            // 
            this.txtBicho.Location = new System.Drawing.Point(199, 32);
            this.txtBicho.Name = "txtBicho";
            this.txtBicho.Size = new System.Drawing.Size(177, 22);
            this.txtBicho.TabIndex = 1;
            // 
            // numidade
            // 
            this.numidade.Location = new System.Drawing.Point(256, 60);
            this.numidade.Name = "numidade";
            this.numidade.Size = new System.Drawing.Size(120, 22);
            this.numidade.TabIndex = 2;
            this.numidade.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(256, 88);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(120, 24);
            this.cmbTipo.TabIndex = 3;
            // 
            // lstBicho
            // 
            this.lstBicho.FormattingEnabled = true;
            this.lstBicho.ItemHeight = 16;
            this.lstBicho.Location = new System.Drawing.Point(113, 305);
            this.lstBicho.Name = "lstBicho";
            this.lstBicho.Size = new System.Drawing.Size(263, 116);
            this.lstBicho.TabIndex = 4;
            // 
            // lBlNomeBicho
            // 
            this.lBlNomeBicho.AutoSize = true;
            this.lBlNomeBicho.Location = new System.Drawing.Point(196, 13);
            this.lBlNomeBicho.Name = "lBlNomeBicho";
            this.lBlNomeBicho.Size = new System.Drawing.Size(100, 16);
            this.lBlNomeBicho.TabIndex = 5;
            this.lBlNomeBicho.Text = "Nome do Bicho";
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Location = new System.Drawing.Point(196, 66);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(42, 16);
            this.lblidade.TabIndex = 6;
            this.lblidade.Text = "Idade";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(196, 91);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(38, 16);
            this.lbltipo.TabIndex = 7;
            this.lbltipo.Text = "Tipo:";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(199, 164);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(177, 23);
            this.btnLocalizar.TabIndex = 8;
            this.btnLocalizar.Text = "LocalizarBicho";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(199, 188);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(177, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "ModificarBicho";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(199, 217);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(177, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "EliminarBicho";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "ExibirBichos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "teste";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmCadastroBicho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblidade);
            this.Controls.Add(this.lBlNomeBicho);
            this.Controls.Add(this.lstBicho);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.numidade);
            this.Controls.Add(this.txtBicho);
            this.Controls.Add(this.btnAdcionar);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "frmCadastroBicho";
            this.Text = "Cadastro de Bicho";
            ((System.ComponentModel.ISupportInitialize)(this.numidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdcionar;
        private System.Windows.Forms.TextBox txtBicho;
        private System.Windows.Forms.NumericUpDown numidade;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ListBox lstBicho;
        private System.Windows.Forms.Label lBlNomeBicho;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

