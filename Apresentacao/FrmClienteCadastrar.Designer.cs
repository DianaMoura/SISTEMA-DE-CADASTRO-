
namespace Apresentacao
{
    partial class FrmClienteCadastrar
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
            this.labelCódigo = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelLimiteCompra = new System.Windows.Forms.Label();
            this.textBoxCódigo = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.radioButtonSexoMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonSexoFeminino = new System.Windows.Forms.RadioButton();
            this.textBoxLimiteCompra = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCódigo
            // 
            this.labelCódigo.AutoSize = true;
            this.labelCódigo.Location = new System.Drawing.Point(13, 26);
            this.labelCódigo.Name = "labelCódigo";
            this.labelCódigo.Size = new System.Drawing.Size(52, 13);
            this.labelCódigo.TabIndex = 0;
            this.labelCódigo.Text = "CÓDIGO:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(9, 74);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(12, 124);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(113, 13);
            this.labelDataNascimento.TabIndex = 2;
            this.labelDataNascimento.Text = "DATA NASCIMENTO:";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(12, 173);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(39, 13);
            this.labelSexo.TabIndex = 3;
            this.labelSexo.Text = "SEXO:";
            // 
            // labelLimiteCompra
            // 
            this.labelLimiteCompra.AutoSize = true;
            this.labelLimiteCompra.Location = new System.Drawing.Point(10, 219);
            this.labelLimiteCompra.Name = "labelLimiteCompra";
            this.labelLimiteCompra.Size = new System.Drawing.Size(94, 13);
            this.labelLimiteCompra.TabIndex = 4;
            this.labelLimiteCompra.Text = "LIMITE COMPRA:";
            // 
            // textBoxCódigo
            // 
            this.textBoxCódigo.Location = new System.Drawing.Point(16, 42);
            this.textBoxCódigo.Name = "textBoxCódigo";
            this.textBoxCódigo.ReadOnly = true;
            this.textBoxCódigo.Size = new System.Drawing.Size(55, 20);
            this.textBoxCódigo.TabIndex = 5;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 90);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(615, 20);
            this.textBoxNome.TabIndex = 6;
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(13, 140);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(110, 20);
            this.dateTimePickerDataNascimento.TabIndex = 7;
            // 
            // radioButtonSexoMasculino
            // 
            this.radioButtonSexoMasculino.AutoSize = true;
            this.radioButtonSexoMasculino.Checked = true;
            this.radioButtonSexoMasculino.Location = new System.Drawing.Point(15, 189);
            this.radioButtonSexoMasculino.Name = "radioButtonSexoMasculino";
            this.radioButtonSexoMasculino.Size = new System.Drawing.Size(88, 17);
            this.radioButtonSexoMasculino.TabIndex = 8;
            this.radioButtonSexoMasculino.TabStop = true;
            this.radioButtonSexoMasculino.Text = "MASCULINO";
            this.radioButtonSexoMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonSexoFeminino
            // 
            this.radioButtonSexoFeminino.AutoSize = true;
            this.radioButtonSexoFeminino.Location = new System.Drawing.Point(128, 189);
            this.radioButtonSexoFeminino.Name = "radioButtonSexoFeminino";
            this.radioButtonSexoFeminino.Size = new System.Drawing.Size(77, 17);
            this.radioButtonSexoFeminino.TabIndex = 9;
            this.radioButtonSexoFeminino.Text = "FEMININO";
            this.radioButtonSexoFeminino.UseVisualStyleBackColor = true;
            // 
            // textBoxLimiteCompra
            // 
            this.textBoxLimiteCompra.Location = new System.Drawing.Point(13, 235);
            this.textBoxLimiteCompra.Name = "textBoxLimiteCompra";
            this.textBoxLimiteCompra.Size = new System.Drawing.Size(75, 20);
            this.textBoxLimiteCompra.TabIndex = 10;
            this.textBoxLimiteCompra.Text = "9.999.999.99";
            this.textBoxLimiteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(226, 329);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(93, 23);
            this.buttonSalvar.TabIndex = 11;
            this.buttonSalvar.Text = "SALVAR";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(346, 329);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(90, 23);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FrmClienteCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 368);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxLimiteCompra);
            this.Controls.Add(this.radioButtonSexoFeminino);
            this.Controls.Add(this.radioButtonSexoMasculino);
            this.Controls.Add(this.dateTimePickerDataNascimento);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxCódigo);
            this.Controls.Add(this.labelLimiteCompra);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelCódigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClienteCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRAR CLIENTES";
            this.Load += new System.EventHandler(this.FrmClienteCadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCódigo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelLimiteCompra;
        private System.Windows.Forms.TextBox textBoxCódigo;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNascimento;
        private System.Windows.Forms.RadioButton radioButtonSexoMasculino;
        private System.Windows.Forms.RadioButton radioButtonSexoFeminino;
        private System.Windows.Forms.TextBox textBoxLimiteCompra;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}