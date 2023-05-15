namespace TAPPavelAlexandruDaniel
{
    partial class FormInscrieri
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
            this.idInscriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInscrieriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSpecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireSpecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscrieriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet5 = new TAPPavelAlexandruDaniel.DataSet5();
            this.inscrieriTableAdapter = new TAPPavelAlexandruDaniel.DataSet5TableAdapters.InscrieriTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idInscriereDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaInitialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscrieriContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscrieriContinutTableAdapter = new TAPPavelAlexandruDaniel.DataSet5TableAdapters.InscrieriContinutTableAdapter();
            this.txtIdInscriere = new System.Windows.Forms.TextBox();
            this.btnInscriereNoua = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscrieriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscrieriContinutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInscriereDataGridViewTextBoxColumn,
            this.dataInscrieriiDataGridViewTextBoxColumn,
            this.idSpecializareDataGridViewTextBoxColumn,
            this.denumireSpecializareDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inscrieriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(683, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // idInscriereDataGridViewTextBoxColumn
            // 
            this.idInscriereDataGridViewTextBoxColumn.DataPropertyName = "IdInscriere";
            this.idInscriereDataGridViewTextBoxColumn.HeaderText = "IdInscriere";
            this.idInscriereDataGridViewTextBoxColumn.Name = "idInscriereDataGridViewTextBoxColumn";
            this.idInscriereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInscrieriiDataGridViewTextBoxColumn
            // 
            this.dataInscrieriiDataGridViewTextBoxColumn.DataPropertyName = "DataInscrierii";
            this.dataInscrieriiDataGridViewTextBoxColumn.HeaderText = "DataInscrierii";
            this.dataInscrieriiDataGridViewTextBoxColumn.Name = "dataInscrieriiDataGridViewTextBoxColumn";
            this.dataInscrieriiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSpecializareDataGridViewTextBoxColumn
            // 
            this.idSpecializareDataGridViewTextBoxColumn.DataPropertyName = "IdSpecializare";
            this.idSpecializareDataGridViewTextBoxColumn.HeaderText = "IdSpecializare";
            this.idSpecializareDataGridViewTextBoxColumn.Name = "idSpecializareDataGridViewTextBoxColumn";
            this.idSpecializareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denumireSpecializareDataGridViewTextBoxColumn
            // 
            this.denumireSpecializareDataGridViewTextBoxColumn.DataPropertyName = "DenumireSpecializare";
            this.denumireSpecializareDataGridViewTextBoxColumn.HeaderText = "DenumireSpecializare";
            this.denumireSpecializareDataGridViewTextBoxColumn.Name = "denumireSpecializareDataGridViewTextBoxColumn";
            this.denumireSpecializareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inscrieriBindingSource
            // 
            this.inscrieriBindingSource.DataMember = "Inscrieri";
            this.inscrieriBindingSource.DataSource = this.dataSet5;
            this.inscrieriBindingSource.PositionChanged += new System.EventHandler(this.inscrieriBindingSource_PositionChanged);
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inscrieriTableAdapter
            // 
            this.inscrieriTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInscriereDataGridViewTextBoxColumn1,
            this.nrcDataGridViewTextBoxColumn,
            this.idStudentDataGridViewTextBoxColumn,
            this.numeStudentDataGridViewTextBoxColumn,
            this.taxaInitialaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.inscrieriContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(47, 247);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(914, 205);
            this.dataGridView2.TabIndex = 1;
            // 
            // idInscriereDataGridViewTextBoxColumn1
            // 
            this.idInscriereDataGridViewTextBoxColumn1.DataPropertyName = "IdInscriere";
            this.idInscriereDataGridViewTextBoxColumn1.HeaderText = "IdInscriere";
            this.idInscriereDataGridViewTextBoxColumn1.Name = "idInscriereDataGridViewTextBoxColumn1";
            this.idInscriereDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            this.nrcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idStudentDataGridViewTextBoxColumn
            // 
            this.idStudentDataGridViewTextBoxColumn.DataPropertyName = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.HeaderText = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.Name = "idStudentDataGridViewTextBoxColumn";
            this.idStudentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeStudentDataGridViewTextBoxColumn
            // 
            this.numeStudentDataGridViewTextBoxColumn.DataPropertyName = "NumeStudent";
            this.numeStudentDataGridViewTextBoxColumn.HeaderText = "NumeStudent";
            this.numeStudentDataGridViewTextBoxColumn.Name = "numeStudentDataGridViewTextBoxColumn";
            this.numeStudentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxaInitialaDataGridViewTextBoxColumn
            // 
            this.taxaInitialaDataGridViewTextBoxColumn.DataPropertyName = "TaxaInitiala";
            this.taxaInitialaDataGridViewTextBoxColumn.HeaderText = "TaxaInitiala";
            this.taxaInitialaDataGridViewTextBoxColumn.Name = "taxaInitialaDataGridViewTextBoxColumn";
            this.taxaInitialaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inscrieriContinutBindingSource
            // 
            this.inscrieriContinutBindingSource.DataMember = "InscrieriContinut";
            this.inscrieriContinutBindingSource.DataSource = this.dataSet5;
            // 
            // inscrieriContinutTableAdapter
            // 
            this.inscrieriContinutTableAdapter.ClearBeforeFill = true;
            // 
            // txtIdInscriere
            // 
            this.txtIdInscriere.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscrieriBindingSource, "IdInscriere", true));
            this.txtIdInscriere.Location = new System.Drawing.Point(770, 32);
            this.txtIdInscriere.Name = "txtIdInscriere";
            this.txtIdInscriere.Size = new System.Drawing.Size(191, 20);
            this.txtIdInscriere.TabIndex = 2;
            // 
            // btnInscriereNoua
            // 
            this.btnInscriereNoua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInscriereNoua.Location = new System.Drawing.Point(770, 76);
            this.btnInscriereNoua.Name = "btnInscriereNoua";
            this.btnInscriereNoua.Size = new System.Drawing.Size(191, 32);
            this.btnInscriereNoua.TabIndex = 3;
            this.btnInscriereNoua.Text = "Inscriere Noua";
            this.btnInscriereNoua.UseVisualStyleBackColor = true;
            this.btnInscriereNoua.Click += new System.EventHandler(this.btnInscriereNoua_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificare.Location = new System.Drawing.Point(770, 140);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(191, 32);
            this.btnModificare.TabIndex = 4;
            this.btnModificare.Text = "Modificare Inscriere";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnStergere.Location = new System.Drawing.Point(770, 199);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(191, 32);
            this.btnStergere.TabIndex = 5;
            this.btnStergere.Text = "Stergere Inscriere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // FormInscrieri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 485);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnInscriereNoua);
            this.Controls.Add(this.txtIdInscriere);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormInscrieri";
            this.Text = "FormInscrieri";
            this.Load += new System.EventHandler(this.FormInscrieri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscrieriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscrieriContinutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource inscrieriBindingSource;
        private DataSet5TableAdapters.InscrieriTableAdapter inscrieriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInscriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInscrieriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSpecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireSpecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource inscrieriContinutBindingSource;
        private DataSet5TableAdapters.InscrieriContinutTableAdapter inscrieriContinutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInscriereDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaInitialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtIdInscriere;
        private System.Windows.Forms.Button btnInscriereNoua;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
    }
}