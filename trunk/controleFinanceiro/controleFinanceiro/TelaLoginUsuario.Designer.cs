namespace controleFinanceiro
{
    partial class TelaLoginUsuario
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
            this.lb_Login = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.lb_Senha = new System.Windows.Forms.Label();
            this.tb_Senha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Location = new System.Drawing.Point(32, 47);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(36, 13);
            this.lb_Login.TabIndex = 0;
            this.lb_Login.Text = "Login:";
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(84, 44);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(135, 20);
            this.tb_Login.TabIndex = 1;
            // 
            // lb_Senha
            // 
            this.lb_Senha.AutoSize = true;
            this.lb_Senha.Location = new System.Drawing.Point(32, 85);
            this.lb_Senha.Name = "lb_Senha";
            this.lb_Senha.Size = new System.Drawing.Size(41, 13);
            this.lb_Senha.TabIndex = 0;
            this.lb_Senha.Text = "Senha:";
            // 
            // tb_Senha
            // 
            this.tb_Senha.Location = new System.Drawing.Point(84, 82);
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.Size = new System.Drawing.Size(135, 20);
            this.tb_Senha.TabIndex = 2;
            this.tb_Senha.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Entrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TelaLoginUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Senha);
            this.Controls.Add(this.lb_Senha);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.lb_Login);
            this.Name = "TelaLoginUsuario";
            this.Text = "Login Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.Label lb_Senha;
        private System.Windows.Forms.TextBox tb_Senha;
        private System.Windows.Forms.Button button1;
    }
}