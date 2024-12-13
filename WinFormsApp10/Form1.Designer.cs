namespace WinFormsApp10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblConversor = new Label();
            lblDigiteValor = new Label();
            mstbValor = new MaskedTextBox();
            lblEscolha = new Label();
            cbbMoedas = new ComboBox();
            pcbDinheiro = new PictureBox();
            btnConverter = new Button();
            lblValorConvertido = new Label();
            txtValorConvertido = new TextBox();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbDinheiro).BeginInit();
            SuspendLayout();
            // 
            // lblConversor
            // 
            lblConversor.AutoSize = true;
            lblConversor.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblConversor.Location = new Point(219, 9);
            lblConversor.Name = "lblConversor";
            lblConversor.Size = new Size(377, 47);
            lblConversor.TabIndex = 0;
            lblConversor.Text = "Conversor de Moedas";
            // 
            // lblDigiteValor
            // 
            lblDigiteValor.AutoSize = true;
            lblDigiteValor.Location = new Point(74, 98);
            lblDigiteValor.Name = "lblDigiteValor";
            lblDigiteValor.Size = new Size(113, 15);
            lblDigiteValor.TabIndex = 1;
            lblDigiteValor.Text = "Digite o Valor em R$";
            // 
            // mstbValor
            // 
            mstbValor.Location = new Point(196, 99);
            mstbValor.Name = "mstbValor";
            mstbValor.Size = new Size(114, 23);
            mstbValor.TabIndex = 2;
            // 
            // lblEscolha
            // 
            lblEscolha.AutoSize = true;
            lblEscolha.Location = new Point(74, 145);
            lblEscolha.Name = "lblEscolha";
            lblEscolha.Size = new Size(114, 15);
            lblEscolha.TabIndex = 3;
            lblEscolha.Text = "Escolha uma Moeda";
            // 
            // cbbMoedas
            // 
            cbbMoedas.FormattingEnabled = true;
            cbbMoedas.Items.AddRange(new object[] { "Euro", "Dólar", "Yuhan-Renminbi", "lene", "Libra Esterlina" });
            cbbMoedas.Location = new Point(198, 147);
            cbbMoedas.Name = "cbbMoedas";
            cbbMoedas.Size = new Size(121, 23);
            cbbMoedas.TabIndex = 4;
            // 
            // pcbDinheiro
            // 
            pcbDinheiro.Location = new Point(547, 80);
            pcbDinheiro.Name = "pcbDinheiro";
            pcbDinheiro.Size = new Size(140, 132);
            pcbDinheiro.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbDinheiro.TabIndex = 5;
            pcbDinheiro.TabStop = false;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(138, 271);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(99, 88);
            btnConverter.TabIndex = 6;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // lblValorConvertido
            // 
            lblValorConvertido.AutoSize = true;
            lblValorConvertido.Location = new Point(74, 197);
            lblValorConvertido.Name = "lblValorConvertido";
            lblValorConvertido.Size = new Size(95, 15);
            lblValorConvertido.TabIndex = 7;
            lblValorConvertido.Text = "Valor Convertido";
            // 
            // txtValorConvertido
            // 
            txtValorConvertido.Location = new Point(198, 194);
            txtValorConvertido.Name = "txtValorConvertido";
            txtValorConvertido.Size = new Size(127, 23);
            txtValorConvertido.TabIndex = 8;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(452, 271);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(98, 88);
            btnSair.TabIndex = 9;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(txtValorConvertido);
            Controls.Add(lblValorConvertido);
            Controls.Add(btnConverter);
            Controls.Add(pcbDinheiro);
            Controls.Add(cbbMoedas);
            Controls.Add(lblEscolha);
            Controls.Add(mstbValor);
            Controls.Add(lblDigiteValor);
            Controls.Add(lblConversor);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pcbDinheiro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConversor;
        private Label lblDigiteValor;
        private MaskedTextBox mstbValor;
        private Label lblEscolha;
        private ComboBox cbbMoedas;
        private PictureBox pcbDinheiro;
        private Button btnConverter;
        private Label lblValorConvertido;
        private TextBox txtValorConvertido;
        private Button btnSair;
    }
}