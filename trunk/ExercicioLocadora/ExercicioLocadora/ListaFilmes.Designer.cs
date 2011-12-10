namespace ExercicioLocadora
{
    partial class ListaFilmes
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
            this.components = new System.ComponentModel.Container();
            this.filmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmeTableAdapter = new ExercicioLocadora.locadora2DataSetTableAdapters.FilmeTableAdapter();
            this.tableAdapterManager = new ExercicioLocadora.locadora2DataSetTableAdapters.TableAdapterManager();
            this.locadora2DataSet2 = new ExercicioLocadora.locadora2DataSet2();
            this.filmeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.filmeTableAdapter1 = new ExercicioLocadora.locadora2DataSet2TableAdapters.FilmeTableAdapter();
            this.tableAdapterManager1 = new ExercicioLocadora.locadora2DataSet2TableAdapters.TableAdapterManager();
            this.filmeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locadora2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filmeTableAdapter
            // 
            this.filmeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmeTableAdapter = this.filmeTableAdapter;
            this.tableAdapterManager.UpdateOrder = ExercicioLocadora.locadora2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // locadora2DataSet2
            // 
            this.locadora2DataSet2.DataSetName = "locadora2DataSet2";
            this.locadora2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmeBindingSource1
            // 
            this.filmeBindingSource1.DataMember = "Filme";
            this.filmeBindingSource1.DataSource = this.locadora2DataSet2;
            // 
            // filmeTableAdapter1
            // 
            this.filmeTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.FilmeTableAdapter = this.filmeTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = ExercicioLocadora.locadora2DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // filmeDataGridView
            // 
            this.filmeDataGridView.AutoGenerateColumns = false;
            this.filmeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.filmeDataGridView.DataSource = this.filmeBindingSource1;
            this.filmeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.filmeDataGridView.Name = "filmeDataGridView";
            this.filmeDataGridView.Size = new System.Drawing.Size(628, 341);
            this.filmeDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idFilme";
            this.dataGridViewTextBoxColumn1.HeaderText = "idFilme";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "categoria";
            this.dataGridViewTextBoxColumn3.HeaderText = "categoria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "foto";
            this.dataGridViewTextBoxColumn4.HeaderText = "foto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ano";
            this.dataGridViewTextBoxColumn5.HeaderText = "ano";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ListaFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 341);
            this.Controls.Add(this.filmeDataGridView);
            this.Name = "ListaFilmes";
            this.Text = "Lista de Filmes";
            this.Load += new System.EventHandler(this.ListaFilmes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locadora2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource filmeBindingSource;
        private locadora2DataSetTableAdapters.FilmeTableAdapter filmeTableAdapter;
        private locadora2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private locadora2DataSet2 locadora2DataSet2;
        private System.Windows.Forms.BindingSource filmeBindingSource1;
        private locadora2DataSet2TableAdapters.FilmeTableAdapter filmeTableAdapter1;
        private locadora2DataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView filmeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}