namespace $safeprojectname$
{
    partial class CarroVirtual
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
            this.grupoCadastrar = new System.Windows.Forms.GroupBox();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.comboTracao = new System.Windows.Forms.ComboBox();
            this.comboCabine = new System.Windows.Forms.ComboBox();
            this.textoAno = new System.Windows.Forms.TextBox();
            this.textoModelo = new System.Windows.Forms.TextBox();
            this.labelTracao = new System.Windows.Forms.Label();
            this.labelCabine = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.textoMarca = new System.Windows.Forms.TextBox();
            this.groupExibir = new System.Windows.Forms.GroupBox();
            this.textoExibir = new System.Windows.Forms.TextBox();
            this.botaoExibir = new System.Windows.Forms.Button();
            this.groupControlar = new System.Windows.Forms.GroupBox();
            this.labelKm = new System.Windows.Forms.Label();
            this.barraProgresso = new System.Windows.Forms.ProgressBar();
            this.labelVelo = new System.Windows.Forms.Label();
            this.botaoFreiar = new System.Windows.Forms.Button();
            this.botaoAcelerar = new System.Windows.Forms.Button();
            this.botaoDesligar = new System.Windows.Forms.Button();
            this.botaoLigar = new System.Windows.Forms.Button();
            this.grupoCadastrar.SuspendLayout();
            this.groupExibir.SuspendLayout();
            this.groupControlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoCadastrar
            // 
            this.grupoCadastrar.Controls.Add(this.botaoCadastrar);
            this.grupoCadastrar.Controls.Add(this.comboTracao);
            this.grupoCadastrar.Controls.Add(this.comboCabine);
            this.grupoCadastrar.Controls.Add(this.textoAno);
            this.grupoCadastrar.Controls.Add(this.textoModelo);
            this.grupoCadastrar.Controls.Add(this.labelTracao);
            this.grupoCadastrar.Controls.Add(this.labelCabine);
            this.grupoCadastrar.Controls.Add(this.labelAno);
            this.grupoCadastrar.Controls.Add(this.labelModelo);
            this.grupoCadastrar.Controls.Add(this.labelMarca);
            this.grupoCadastrar.Controls.Add(this.textoMarca);
            this.grupoCadastrar.Location = new System.Drawing.Point(13, 13);
            this.grupoCadastrar.Name = "grupoCadastrar";
            this.grupoCadastrar.Size = new System.Drawing.Size(260, 251);
            this.grupoCadastrar.TabIndex = 0;
            this.grupoCadastrar.TabStop = false;
            this.grupoCadastrar.Text = "Cadastrar";
            this.grupoCadastrar.Enter += new System.EventHandler(this.grupoCadastrar_Enter);
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Location = new System.Drawing.Point(62, 206);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(75, 23);
            this.botaoCadastrar.TabIndex = 10;
            this.botaoCadastrar.Text = "Cadastrar";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoCadastrar_Click);
            // 
            // comboTracao
            // 
            this.comboTracao.FormattingEnabled = true;
            this.comboTracao.Items.AddRange(new object[] {
            "Dianteira",
            "Traseira",
            "4x4"});
            this.comboTracao.Location = new System.Drawing.Point(62, 162);
            this.comboTracao.Name = "comboTracao";
            this.comboTracao.Size = new System.Drawing.Size(121, 21);
            this.comboTracao.TabIndex = 9;
            // 
            // comboCabine
            // 
            this.comboCabine.FormattingEnabled = true;
            this.comboCabine.Items.AddRange(new object[] {
            "Comum",
            "Dupla"});
            this.comboCabine.Location = new System.Drawing.Point(62, 127);
            this.comboCabine.Name = "comboCabine";
            this.comboCabine.Size = new System.Drawing.Size(121, 21);
            this.comboCabine.TabIndex = 8;
            this.comboCabine.SelectedIndexChanged += new System.EventHandler(this.comboCabine_SelectedIndexChanged);
            // 
            // textoAno
            // 
            this.textoAno.Location = new System.Drawing.Point(119, 97);
            this.textoAno.Name = "textoAno";
            this.textoAno.Size = new System.Drawing.Size(126, 20);
            this.textoAno.TabIndex = 7;
            // 
            // textoModelo
            // 
            this.textoModelo.Location = new System.Drawing.Point(62, 69);
            this.textoModelo.Name = "textoModelo";
            this.textoModelo.Size = new System.Drawing.Size(184, 20);
            this.textoModelo.TabIndex = 6;
            // 
            // labelTracao
            // 
            this.labelTracao.AutoSize = true;
            this.labelTracao.Location = new System.Drawing.Point(13, 165);
            this.labelTracao.Name = "labelTracao";
            this.labelTracao.Size = new System.Drawing.Size(44, 13);
            this.labelTracao.TabIndex = 5;
            this.labelTracao.Text = "Tração:";
            // 
            // labelCabine
            // 
            this.labelCabine.AutoSize = true;
            this.labelCabine.Location = new System.Drawing.Point(13, 130);
            this.labelCabine.Name = "labelCabine";
            this.labelCabine.Size = new System.Drawing.Size(46, 13);
            this.labelCabine.TabIndex = 4;
            this.labelCabine.Text = "Cabine: ";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(13, 100);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(100, 13);
            this.labelAno.TabIndex = 3;
            this.labelAno.Text = "Ano de Fabricação:";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(13, 69);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(45, 13);
            this.labelModelo.TabIndex = 2;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(13, 34);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 1;
            this.labelMarca.Text = "Marca:";
            this.labelMarca.Click += new System.EventHandler(this.label1_Click);
            // 
            // textoMarca
            // 
            this.textoMarca.Location = new System.Drawing.Point(62, 31);
            this.textoMarca.Name = "textoMarca";
            this.textoMarca.Size = new System.Drawing.Size(184, 20);
            this.textoMarca.TabIndex = 0;
            // 
            // groupExibir
            // 
            this.groupExibir.Controls.Add(this.textoExibir);
            this.groupExibir.Controls.Add(this.botaoExibir);
            this.groupExibir.Location = new System.Drawing.Point(313, 13);
            this.groupExibir.Name = "groupExibir";
            this.groupExibir.Size = new System.Drawing.Size(268, 251);
            this.groupExibir.TabIndex = 1;
            this.groupExibir.TabStop = false;
            this.groupExibir.Text = "Exibir";
            // 
            // textoExibir
            // 
            this.textoExibir.Location = new System.Drawing.Point(23, 66);
            this.textoExibir.Multiline = true;
            this.textoExibir.Name = "textoExibir";
            this.textoExibir.Size = new System.Drawing.Size(225, 163);
            this.textoExibir.TabIndex = 1;
            // 
            // botaoExibir
            // 
            this.botaoExibir.Location = new System.Drawing.Point(98, 28);
            this.botaoExibir.Name = "botaoExibir";
            this.botaoExibir.Size = new System.Drawing.Size(75, 23);
            this.botaoExibir.TabIndex = 0;
            this.botaoExibir.Text = "Exibir";
            this.botaoExibir.UseVisualStyleBackColor = true;
            this.botaoExibir.Click += new System.EventHandler(this.botaoExibir_Click);
            // 
            // groupControlar
            // 
            this.groupControlar.Controls.Add(this.labelKm);
            this.groupControlar.Controls.Add(this.barraProgresso);
            this.groupControlar.Controls.Add(this.labelVelo);
            this.groupControlar.Controls.Add(this.botaoFreiar);
            this.groupControlar.Controls.Add(this.botaoAcelerar);
            this.groupControlar.Controls.Add(this.botaoDesligar);
            this.groupControlar.Controls.Add(this.botaoLigar);
            this.groupControlar.Location = new System.Drawing.Point(13, 292);
            this.groupControlar.Name = "groupControlar";
            this.groupControlar.Size = new System.Drawing.Size(568, 153);
            this.groupControlar.TabIndex = 2;
            this.groupControlar.TabStop = false;
            this.groupControlar.Text = "Controlar";
            // 
            // labelKm
            // 
            this.labelKm.AutoSize = true;
            this.labelKm.Location = new System.Drawing.Point(479, 100);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(22, 13);
            this.labelKm.TabIndex = 3;
            this.labelKm.Text = "Km";
            // 
            // barraProgresso
            // 
            this.barraProgresso.Location = new System.Drawing.Point(77, 90);
            this.barraProgresso.Name = "barraProgresso";
            this.barraProgresso.Size = new System.Drawing.Size(396, 23);
            this.barraProgresso.TabIndex = 5;
            this.barraProgresso.Click += new System.EventHandler(this.barraProgresso_Click);
            // 
            // labelVelo
            // 
            this.labelVelo.AutoSize = true;
            this.labelVelo.Location = new System.Drawing.Point(13, 100);
            this.labelVelo.Name = "labelVelo";
            this.labelVelo.Size = new System.Drawing.Size(60, 13);
            this.labelVelo.TabIndex = 4;
            this.labelVelo.Text = "Velocidade";
            // 
            // botaoFreiar
            // 
            this.botaoFreiar.Location = new System.Drawing.Point(371, 41);
            this.botaoFreiar.Name = "botaoFreiar";
            this.botaoFreiar.Size = new System.Drawing.Size(75, 23);
            this.botaoFreiar.TabIndex = 3;
            this.botaoFreiar.Text = "Freiar";
            this.botaoFreiar.UseVisualStyleBackColor = true;
            this.botaoFreiar.Click += new System.EventHandler(this.botaoFreiar_Click);
            // 
            // botaoAcelerar
            // 
            this.botaoAcelerar.Location = new System.Drawing.Point(261, 41);
            this.botaoAcelerar.Name = "botaoAcelerar";
            this.botaoAcelerar.Size = new System.Drawing.Size(75, 23);
            this.botaoAcelerar.TabIndex = 2;
            this.botaoAcelerar.Text = "Acelerar";
            this.botaoAcelerar.UseVisualStyleBackColor = true;
            this.botaoAcelerar.Click += new System.EventHandler(this.botaoAcelerar_Click);
            // 
            // botaoDesligar
            // 
            this.botaoDesligar.Location = new System.Drawing.Point(152, 41);
            this.botaoDesligar.Name = "botaoDesligar";
            this.botaoDesligar.Size = new System.Drawing.Size(75, 23);
            this.botaoDesligar.TabIndex = 1;
            this.botaoDesligar.Text = "Desligar";
            this.botaoDesligar.UseVisualStyleBackColor = true;
            this.botaoDesligar.Click += new System.EventHandler(this.botaoDesligar_Click);
            // 
            // botaoLigar
            // 
            this.botaoLigar.Location = new System.Drawing.Point(38, 41);
            this.botaoLigar.Name = "botaoLigar";
            this.botaoLigar.Size = new System.Drawing.Size(75, 23);
            this.botaoLigar.TabIndex = 0;
            this.botaoLigar.Text = "Ligar";
            this.botaoLigar.UseVisualStyleBackColor = true;
            this.botaoLigar.Click += new System.EventHandler(this.botaoLigar_Click);
            // 
            // CarroVirtual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 457);
            this.Controls.Add(this.groupControlar);
            this.Controls.Add(this.groupExibir);
            this.Controls.Add(this.grupoCadastrar);
            this.Name = "CarroVirtual";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CarroVirtual_Load);
            this.grupoCadastrar.ResumeLayout(false);
            this.grupoCadastrar.PerformLayout();
            this.groupExibir.ResumeLayout(false);
            this.groupExibir.PerformLayout();
            this.groupControlar.ResumeLayout(false);
            this.groupControlar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoCadastrar;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox textoMarca;
        private System.Windows.Forms.TextBox textoAno;
        private System.Windows.Forms.TextBox textoModelo;
        private System.Windows.Forms.Label labelTracao;
        private System.Windows.Forms.Label labelCabine;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Button botaoCadastrar;
        private System.Windows.Forms.ComboBox comboTracao;
        private System.Windows.Forms.ComboBox comboCabine;
        private System.Windows.Forms.GroupBox groupExibir;
        private System.Windows.Forms.TextBox textoExibir;
        private System.Windows.Forms.Button botaoExibir;
        private System.Windows.Forms.GroupBox groupControlar;
        private System.Windows.Forms.Label labelKm;
        private System.Windows.Forms.ProgressBar barraProgresso;
        private System.Windows.Forms.Label labelVelo;
        private System.Windows.Forms.Button botaoFreiar;
        private System.Windows.Forms.Button botaoAcelerar;
        private System.Windows.Forms.Button botaoDesligar;
        private System.Windows.Forms.Button botaoLigar;
    }
}

