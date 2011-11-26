namespace controleFinanceiro
{
    partial class CadastroUsuario
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
            this.lb_Nome = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.lb_DataNasci = new System.Windows.Forms.Label();
            this.tb_DataNascimento = new System.Windows.Forms.TextBox();
            this.lb_Endereco = new System.Windows.Forms.Label();
            this.tb_Endereco = new System.Windows.Forms.TextBox();
            this.lb_Fone = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.lb_Email = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Location = new System.Drawing.Point(24, 48);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(38, 13);
            this.lb_Nome.TabIndex = 0;
            this.lb_Nome.Text = "Nome:";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(94, 44);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(175, 20);
            this.tb_Nome.TabIndex = 1;
            // 
            // lb_DataNasci
            // 
            this.lb_DataNasci.AutoSize = true;
            this.lb_DataNasci.Location = new System.Drawing.Point(24, 102);
            this.lb_DataNasci.Name = "lb_DataNasci";
            this.lb_DataNasci.Size = new System.Drawing.Size(64, 13);
            this.lb_DataNasci.TabIndex = 0;
            this.lb_DataNasci.Text = "Data Nasc.:";
            // 
            // tb_DataNascimento
            // 
            this.tb_DataNascimento.Location = new System.Drawing.Point(94, 102);
            this.tb_DataNascimento.Name = "tb_DataNascimento";
            this.tb_DataNascimento.Size = new System.Drawing.Size(175, 20);
            this.tb_DataNascimento.TabIndex = 3;
            // 
            // lb_Endereco
            // 
            this.lb_Endereco.AutoSize = true;
            this.lb_Endereco.Location = new System.Drawing.Point(24, 74);
            this.lb_Endereco.Name = "lb_Endereco";
            this.lb_Endereco.Size = new System.Drawing.Size(56, 13);
            this.lb_Endereco.TabIndex = 0;
            this.lb_Endereco.Text = "Endereço:";
            // 
            // tb_Endereco
            // 
            this.tb_Endereco.Location = new System.Drawing.Point(94, 74);
            this.tb_Endereco.Name = "tb_Endereco";
            this.tb_Endereco.Size = new System.Drawing.Size(175, 20);
            this.tb_Endereco.TabIndex = 2;
            // 
            // lb_Fone
            // 
            this.lb_Fone.AutoSize = true;
            this.lb_Fone.Location = new System.Drawing.Point(25, 158);
            this.lb_Fone.Name = "lb_Fone";
            this.lb_Fone.Size = new System.Drawing.Size(34, 13);
            this.lb_Fone.TabIndex = 0;
            this.lb_Fone.Text = "Fone:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CPF:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 20);
            this.textBox3.TabIndex = 6;
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.Location = new System.Drawing.Point(135, 226);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bt_Cadastrar.TabIndex = 7;
            this.bt_Cadastrar.Text = "&Cadastrar";
            this.bt_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(25, 132);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(39, 13);
            this.lb_Email.TabIndex = 0;
            this.lb_Email.Text = "E-Mail:";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(95, 132);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(175, 20);
            this.tb_Email.TabIndex = 4;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 270);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.tb_Endereco);
            this.Controls.Add(this.lb_Endereco);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_Fone);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.tb_DataNascimento);
            this.Controls.Add(this.lb_DataNasci);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.lb_Nome);
            this.Name = "CadastroUsuario";
            this.Text = "Cadastro Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label lb_DataNasci;
        private System.Windows.Forms.TextBox tb_DataNascimento;
        private System.Windows.Forms.Label lb_Endereco;
        private System.Windows.Forms.TextBox tb_Endereco;
        private System.Windows.Forms.Label lb_Fone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox tb_Email;
    }
}