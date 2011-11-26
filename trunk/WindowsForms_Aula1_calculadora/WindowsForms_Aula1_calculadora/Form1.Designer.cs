namespace WindowsForms_Aula1_calculadora
{
    partial class Form1
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
            this.tbContas = new System.Windows.Forms.TextBox();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_8 = new System.Windows.Forms.Button();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_9 = new System.Windows.Forms.Button();
            this.bt_soma = new System.Windows.Forms.Button();
            this.bt_0 = new System.Windows.Forms.Button();
            this.bt_subtracao = new System.Windows.Forms.Button();
            this.bt_multiplicacao = new System.Windows.Forms.Button();
            this.bt_divisao = new System.Windows.Forms.Button();
            this.bt_ponto = new System.Windows.Forms.Button();
            this.bt_igual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbContas
            // 
            this.tbContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContas.Location = new System.Drawing.Point(56, 38);
            this.tbContas.Name = "tbContas";
            this.tbContas.Size = new System.Drawing.Size(320, 38);
            this.tbContas.TabIndex = 0;
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(56, 104);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(51, 54);
            this.bt_1.TabIndex = 2;
            this.bt_1.Text = "1";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(143, 104);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(51, 54);
            this.bt_2.TabIndex = 3;
            this.bt_2.Text = "2";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_5
            // 
            this.bt_5.Location = new System.Drawing.Point(143, 189);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(51, 54);
            this.bt_5.TabIndex = 4;
            this.bt_5.Text = "5";
            this.bt_5.UseVisualStyleBackColor = true;
            this.bt_5.Click += new System.EventHandler(this.bt_5_Click);
            // 
            // bt_3
            // 
            this.bt_3.Location = new System.Drawing.Point(228, 104);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(51, 54);
            this.bt_3.TabIndex = 5;
            this.bt_3.Text = "3";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_4
            // 
            this.bt_4.Location = new System.Drawing.Point(56, 189);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(51, 54);
            this.bt_4.TabIndex = 6;
            this.bt_4.Text = "4";
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_6
            // 
            this.bt_6.Location = new System.Drawing.Point(228, 189);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(51, 54);
            this.bt_6.TabIndex = 7;
            this.bt_6.Text = "6";
            this.bt_6.UseVisualStyleBackColor = true;
            this.bt_6.Click += new System.EventHandler(this.bt_6_Click);
            // 
            // bt_8
            // 
            this.bt_8.Location = new System.Drawing.Point(143, 269);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(51, 54);
            this.bt_8.TabIndex = 8;
            this.bt_8.Text = "8";
            this.bt_8.UseVisualStyleBackColor = true;
            this.bt_8.Click += new System.EventHandler(this.bt_8_Click);
            // 
            // bt_7
            // 
            this.bt_7.Location = new System.Drawing.Point(56, 267);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(51, 54);
            this.bt_7.TabIndex = 9;
            this.bt_7.Text = "7";
            this.bt_7.UseVisualStyleBackColor = true;
            this.bt_7.Click += new System.EventHandler(this.bt_7_Click);
            // 
            // bt_9
            // 
            this.bt_9.Location = new System.Drawing.Point(228, 267);
            this.bt_9.Name = "bt_9";
            this.bt_9.Size = new System.Drawing.Size(51, 54);
            this.bt_9.TabIndex = 10;
            this.bt_9.Text = "9";
            this.bt_9.UseVisualStyleBackColor = true;
            this.bt_9.Click += new System.EventHandler(this.bt_9_Click);
            // 
            // bt_soma
            // 
            this.bt_soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_soma.Location = new System.Drawing.Point(310, 104);
            this.bt_soma.Name = "bt_soma";
            this.bt_soma.Size = new System.Drawing.Size(51, 54);
            this.bt_soma.TabIndex = 11;
            this.bt_soma.Text = "+";
            this.bt_soma.UseVisualStyleBackColor = true;
            this.bt_soma.Click += new System.EventHandler(this.bt_soma_Click);
            // 
            // bt_0
            // 
            this.bt_0.Location = new System.Drawing.Point(56, 348);
            this.bt_0.Name = "bt_0";
            this.bt_0.Size = new System.Drawing.Size(51, 54);
            this.bt_0.TabIndex = 14;
            this.bt_0.Text = "0";
            this.bt_0.UseVisualStyleBackColor = true;
            this.bt_0.Click += new System.EventHandler(this.bt_0_Click);
            // 
            // bt_subtracao
            // 
            this.bt_subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_subtracao.Location = new System.Drawing.Point(310, 189);
            this.bt_subtracao.Name = "bt_subtracao";
            this.bt_subtracao.Size = new System.Drawing.Size(51, 54);
            this.bt_subtracao.TabIndex = 15;
            this.bt_subtracao.Text = "-";
            this.bt_subtracao.UseVisualStyleBackColor = true;
            this.bt_subtracao.Click += new System.EventHandler(this.bt_subtracao_Click);
            // 
            // bt_multiplicacao
            // 
            this.bt_multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_multiplicacao.Location = new System.Drawing.Point(310, 269);
            this.bt_multiplicacao.Name = "bt_multiplicacao";
            this.bt_multiplicacao.Size = new System.Drawing.Size(51, 54);
            this.bt_multiplicacao.TabIndex = 16;
            this.bt_multiplicacao.Text = "x";
            this.bt_multiplicacao.UseVisualStyleBackColor = true;
            this.bt_multiplicacao.Click += new System.EventHandler(this.bt_multiplicacao_Click);
            // 
            // bt_divisao
            // 
            this.bt_divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_divisao.Location = new System.Drawing.Point(310, 350);
            this.bt_divisao.Name = "bt_divisao";
            this.bt_divisao.Size = new System.Drawing.Size(51, 54);
            this.bt_divisao.TabIndex = 17;
            this.bt_divisao.Text = "÷";
            this.bt_divisao.UseVisualStyleBackColor = true;
            this.bt_divisao.Click += new System.EventHandler(this.bt_divisao_Click);
            // 
            // bt_ponto
            // 
            this.bt_ponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ponto.Location = new System.Drawing.Point(143, 348);
            this.bt_ponto.Name = "bt_ponto";
            this.bt_ponto.Size = new System.Drawing.Size(51, 54);
            this.bt_ponto.TabIndex = 18;
            this.bt_ponto.Text = ".";
            this.bt_ponto.UseVisualStyleBackColor = true;
            this.bt_ponto.Click += new System.EventHandler(this.bt_ponto_Click);
            // 
            // bt_igual
            // 
            this.bt_igual.Location = new System.Drawing.Point(228, 350);
            this.bt_igual.Name = "bt_igual";
            this.bt_igual.Size = new System.Drawing.Size(51, 54);
            this.bt_igual.TabIndex = 19;
            this.bt_igual.Text = "=";
            this.bt_igual.UseVisualStyleBackColor = true;
            this.bt_igual.Click += new System.EventHandler(this.bt_igual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 438);
            this.Controls.Add(this.bt_igual);
            this.Controls.Add(this.bt_ponto);
            this.Controls.Add(this.bt_divisao);
            this.Controls.Add(this.bt_multiplicacao);
            this.Controls.Add(this.bt_subtracao);
            this.Controls.Add(this.bt_0);
            this.Controls.Add(this.bt_soma);
            this.Controls.Add(this.bt_9);
            this.Controls.Add(this.bt_7);
            this.Controls.Add(this.bt_8);
            this.Controls.Add(this.bt_6);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_5);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.tbContas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbContas;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_9;
        private System.Windows.Forms.Button bt_soma;
        private System.Windows.Forms.Button bt_0;
        private System.Windows.Forms.Button bt_subtracao;
        private System.Windows.Forms.Button bt_multiplicacao;
        private System.Windows.Forms.Button bt_divisao;
        private System.Windows.Forms.Button bt_ponto;
        private System.Windows.Forms.Button bt_igual;
    }
}

