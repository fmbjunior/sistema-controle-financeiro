namespace WinFormAula1_Formulario
{
    partial class cadastroCliente
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
            this.lb_nome = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.lb_endereco = new System.Windows.Forms.Label();
            this.tb_Endereco = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(105, 88);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(38, 13);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Nome:";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(146, 85);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(220, 20);
            this.tb_Nome.TabIndex = 1;
            // 
            // lb_endereco
            // 
            this.lb_endereco.AutoSize = true;
            this.lb_endereco.Location = new System.Drawing.Point(87, 125);
            this.lb_endereco.Name = "lb_endereco";
            this.lb_endereco.Size = new System.Drawing.Size(56, 13);
            this.lb_endereco.TabIndex = 0;
            this.lb_endereco.Text = "Endereço:";
            // 
            // tb_Endereco
            // 
            this.tb_Endereco.Location = new System.Drawing.Point(146, 125);
            this.tb_Endereco.Name = "tb_Endereco";
            this.tb_Endereco.Size = new System.Drawing.Size(220, 20);
            this.tb_Endereco.TabIndex = 1;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(105, 166);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(38, 13);
            this.lb_email.TabIndex = 0;
            this.lb_email.Text = "E-mail:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(146, 163);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(220, 20);
            this.tb_email.TabIndex = 1;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Location = new System.Drawing.Point(88, 201);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(52, 13);
            this.lb_telefone.TabIndex = 0;
            this.lb_telefone.Text = "Telefone;";
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(146, 198);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(220, 20);
            this.tb_telefone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CADASTRO DE CLIENTE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.lb_telefone);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.tb_Endereco);
            this.Controls.Add(this.lb_endereco);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.lb_nome);
            this.Name = "cadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.cadastroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label lb_endereco;
        private System.Windows.Forms.TextBox tb_Endereco;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.TextBox tb_telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}