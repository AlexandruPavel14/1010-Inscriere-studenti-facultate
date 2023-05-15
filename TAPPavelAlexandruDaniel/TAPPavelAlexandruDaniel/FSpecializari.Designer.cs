namespace TAPPavelAlexandruDaniel
{
    partial class FSpecializari
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idSpecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireSpecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrAniStudiuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaAnualaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new TAPPavelAlexandruDaniel.DataSet2();
            this.specializariTableAdapter = new TAPPavelAlexandruDaniel.DataSet2TableAdapters.SpecializariTableAdapter();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSpecializareDataGridViewTextBoxColumn,
            this.denumireSpecializareDataGridViewTextBoxColumn,
            this.nrAniStudiuDataGridViewTextBoxColumn,
            this.taxaAnualaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.specializariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idSpecializareDataGridViewTextBoxColumn
            // 
            this.idSpecializareDataGridViewTextBoxColumn.DataPropertyName = "IdSpecializare";
            this.idSpecializareDataGridViewTextBoxColumn.HeaderText = "IdSpecializare";
            this.idSpecializareDataGridViewTextBoxColumn.Name = "idSpecializareDataGridViewTextBoxColumn";
            // 
            // denumireSpecializareDataGridViewTextBoxColumn
            // 
            this.denumireSpecializareDataGridViewTextBoxColumn.DataPropertyName = "DenumireSpecializare";
            this.denumireSpecializareDataGridViewTextBoxColumn.HeaderText = "DenumireSpecializare";
            this.denumireSpecializareDataGridViewTextBoxColumn.Name = "denumireSpecializareDataGridViewTextBoxColumn";
            // 
            // nrAniStudiuDataGridViewTextBoxColumn
            // 
            this.nrAniStudiuDataGridViewTextBoxColumn.DataPropertyName = "NrAniStudiu";
            this.nrAniStudiuDataGridViewTextBoxColumn.HeaderText = "NrAniStudiu";
            this.nrAniStudiuDataGridViewTextBoxColumn.Name = "nrAniStudiuDataGridViewTextBoxColumn";
            // 
            // taxaAnualaDataGridViewTextBoxColumn
            // 
            this.taxaAnualaDataGridViewTextBoxColumn.DataPropertyName = "TaxaAnuala";
            this.taxaAnualaDataGridViewTextBoxColumn.HeaderText = "TaxaAnuala";
            this.taxaAnualaDataGridViewTextBoxColumn.Name = "taxaAnualaDataGridViewTextBoxColumn";
            // 
            // specializariBindingSource
            // 
            this.specializariBindingSource.DataMember = "Specializari";
            this.specializariBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specializariTableAdapter
            // 
            this.specializariTableAdapter.ClearBeforeFill = true;
            // 
            // btnActualizare
            // 
            this.btnActualizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnActualizare.Location = new System.Drawing.Point(45, 38);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(190, 36);
            this.btnActualizare.TabIndex = 1;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvare.Location = new System.Drawing.Point(255, 38);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(190, 36);
            this.btnSalvare.TabIndex = 2;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRenuntare.Location = new System.Drawing.Point(463, 38);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(190, 36);
            this.btnRenuntare.TabIndex = 3;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(255, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // FSpecializari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 367);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FSpecializari";
            this.Text = "FSpecializari";
            this.Load += new System.EventHandler(this.FSpecializari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource specializariBindingSource;
        private DataSet2TableAdapters.SpecializariTableAdapter specializariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSpecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireSpecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrAniStudiuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaAnualaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button button1;
    }
}