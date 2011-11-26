namespace WinFormAula1_Formulario
{
    partial class form_empresa
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
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.lb_cliente = new System.Windows.Forms.Label();
            this.cbox_Cliente = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(292, 62);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_editar.TabIndex = 0;
            this.bt_editar.Text = "&Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Location = new System.Drawing.Point(25, 130);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(127, 23);
            this.bt_adicionar.TabIndex = 1;
            this.bt_adicionar.Text = "&Adicionar Cliente";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // lb_cliente
            // 
            this.lb_cliente.AutoSize = true;
            this.lb_cliente.Location = new System.Drawing.Point(22, 67);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(39, 13);
            this.lb_cliente.TabIndex = 3;
            this.lb_cliente.Text = "Cliente";
            // 
            // cbox_Cliente
            // 
            this.cbox_Cliente.FormattingEnabled = true;
            this.cbox_Cliente.Location = new System.Drawing.Point(67, 62);
            this.cbox_Cliente.Name = "cbox_Cliente";
            this.cbox_Cliente.Size = new System.Drawing.Size(204, 21);
            this.cbox_Cliente.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbox_Cliente);
            this.Controls.Add(this.lb_cliente);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.bt_editar);
            this.Name = "form_empresa";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Label lb_cliente;
        private System.Windows.Forms.ComboBox cbox_Cliente;
        private System.Windows.Forms.Button button1;
    }
}

