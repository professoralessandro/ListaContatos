namespace ListaContatos
{
    partial class Form1
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
            this.textId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.listBoxBuscar = new System.Windows.Forms.ListBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.labelContatos = new System.Windows.Forms.Label();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(156, 58);
            this.textId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(343, 22);
            this.textId.TabIndex = 0;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(52, 63);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(60, 17);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "Codigo :";
            this.labelId.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(156, 410);
            this.buttonGravar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(149, 57);
            this.buttonGravar.TabIndex = 5;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonIncluir_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Location = new System.Drawing.Point(465, 410);
            this.buttonDeletar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(149, 57);
            this.buttonDeletar.TabIndex = 6;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(611, 343);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(149, 57);
            this.buttonBuscar.TabIndex = 7;
            this.buttonBuscar.Text = "Listar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(52, 142);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 17);
            this.labelNome.TabIndex = 10;
            this.labelNome.Text = "Nome :";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(156, 137);
            this.textNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(343, 22);
            this.textNome.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(52, 224);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(50, 17);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "Email :";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(156, 219);
            this.textEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(343, 22);
            this.textEmail.TabIndex = 2;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(52, 311);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(72, 17);
            this.labelTelefone.TabIndex = 12;
            this.labelTelefone.Text = "Telefone :";
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(156, 306);
            this.textTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(343, 22);
            this.textTelefone.TabIndex = 3;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(3, 410);
            this.buttonNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(149, 57);
            this.buttonNovo.TabIndex = 4;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // listBoxBuscar
            // 
            this.listBoxBuscar.FormattingEnabled = true;
            this.listBoxBuscar.ItemHeight = 16;
            this.listBoxBuscar.Location = new System.Drawing.Point(549, 13);
            this.listBoxBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxBuscar.Name = "listBoxBuscar";
            this.listBoxBuscar.Size = new System.Drawing.Size(261, 324);
            this.listBoxBuscar.TabIndex = 8;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Location = new System.Drawing.Point(561, 58);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(0, 17);
            this.labelBuscar.TabIndex = 13;
            // 
            // labelContatos
            // 
            this.labelContatos.AutoSize = true;
            this.labelContatos.Location = new System.Drawing.Point(327, 11);
            this.labelContatos.Name = "labelContatos";
            this.labelContatos.Size = new System.Drawing.Size(72, 17);
            this.labelContatos.TabIndex = 14;
            this.labelContatos.Text = "Contatos :";
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(311, 410);
            this.buttonPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(149, 57);
            this.buttonPesquisar.TabIndex = 15;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 481);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.labelContatos);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.listBoxBuscar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.ListBox listBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.Label labelContatos;
        private System.Windows.Forms.Button buttonPesquisar;
    }
}

