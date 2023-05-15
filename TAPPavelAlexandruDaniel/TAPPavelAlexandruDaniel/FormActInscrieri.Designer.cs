namespace TAPPavelAlexandruDaniel
{
    partial class FormActInscrieri
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
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet6 = new TAPPavelAlexandruDaniel.DataSet6();
            this.taxaInitialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anStudiuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manevraInscriereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtNrInscriere = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSpecializari = new System.Windows.Forms.ComboBox();
            this.specializariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.specializariTableAdapter = new TAPPavelAlexandruDaniel.DataSet6TableAdapters.SpecializariTableAdapter();
            this.studentiTableAdapter = new TAPPavelAlexandruDaniel.DataSet6TableAdapters.StudentiTableAdapter();
            this.txtAnStudiu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manevraInscriereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrcDataGridViewTextBoxColumn,
            this.numeStudentDataGridViewTextBoxColumn,
            this.taxaInitialaDataGridViewTextBoxColumn,
            this.anStudiuDataGridViewTextBoxColumn,
            this.idStudentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.manevraInscriereBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 169);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            // 
            // numeStudentDataGridViewTextBoxColumn
            // 
            this.numeStudentDataGridViewTextBoxColumn.DataPropertyName = "NumeStudent";
            this.numeStudentDataGridViewTextBoxColumn.DataSource = this.studentiBindingSource;
            this.numeStudentDataGridViewTextBoxColumn.DisplayMember = "NumeStudent";
            this.numeStudentDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.numeStudentDataGridViewTextBoxColumn.HeaderText = "NumeStudent";
            this.numeStudentDataGridViewTextBoxColumn.Name = "numeStudentDataGridViewTextBoxColumn";
            this.numeStudentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numeStudentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // studentiBindingSource
            // 
            this.studentiBindingSource.DataMember = "Studenti";
            this.studentiBindingSource.DataSource = this.dataSet6;
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taxaInitialaDataGridViewTextBoxColumn
            // 
            this.taxaInitialaDataGridViewTextBoxColumn.DataPropertyName = "TaxaInitiala";
            this.taxaInitialaDataGridViewTextBoxColumn.HeaderText = "TaxaInitiala";
            this.taxaInitialaDataGridViewTextBoxColumn.Name = "taxaInitialaDataGridViewTextBoxColumn";
            // 
            // anStudiuDataGridViewTextBoxColumn
            // 
            this.anStudiuDataGridViewTextBoxColumn.DataPropertyName = "AnStudiu";
            this.anStudiuDataGridViewTextBoxColumn.HeaderText = "AnStudiu";
            this.anStudiuDataGridViewTextBoxColumn.Name = "anStudiuDataGridViewTextBoxColumn";
            // 
            // idStudentDataGridViewTextBoxColumn
            // 
            this.idStudentDataGridViewTextBoxColumn.DataPropertyName = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.HeaderText = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.Name = "idStudentDataGridViewTextBoxColumn";
            // 
            // manevraInscriereBindingSource
            // 
            this.manevraInscriereBindingSource.DataMember = "ManevraInscriere";
            this.manevraInscriereBindingSource.DataSource = this.dataSet6;
            this.manevraInscriereBindingSource.CurrentChanged += new System.EventHandler(this.manevraInscriereBindingSource_CurrentChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(42, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nr Inscriere";
            // 
            // txtNrInscriere
            // 
            this.txtNrInscriere.Location = new System.Drawing.Point(155, 45);
            this.txtNrInscriere.Name = "txtNrInscriere";
            this.txtNrInscriere.Size = new System.Drawing.Size(205, 20);
            this.txtNrInscriere.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(42, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Specializare";
            // 
            // cmbSpecializari
            // 
            this.cmbSpecializari.DataSource = this.specializariBindingSource;
            this.cmbSpecializari.DisplayMember = "DenumireSpecializare";
            this.cmbSpecializari.FormattingEnabled = true;
            this.cmbSpecializari.Location = new System.Drawing.Point(155, 124);
            this.cmbSpecializari.Name = "cmbSpecializari";
            this.cmbSpecializari.Size = new System.Drawing.Size(205, 21);
            this.cmbSpecializari.TabIndex = 17;
            this.cmbSpecializari.ValueMember = "IdSpecializare";
            // 
            // specializariBindingSource
            // 
            this.specializariBindingSource.DataMember = "Specializari";
            this.specializariBindingSource.DataSource = this.dataSet6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(42, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(714, 165);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(130, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(654, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblOp.Location = new System.Drawing.Point(593, 53);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(57, 20);
            this.lblOp.TabIndex = 12;
            this.lblOp.Text = "label1";
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmare.Location = new System.Drawing.Point(450, 45);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(117, 36);
            this.btnConfirmare.TabIndex = 11;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // specializariTableAdapter
            // 
            this.specializariTableAdapter.ClearBeforeFill = true;
            // 
            // studentiTableAdapter
            // 
            this.studentiTableAdapter.ClearBeforeFill = true;
            // 
            // txtAnStudiu
            // 
            this.txtAnStudiu.Location = new System.Drawing.Point(155, 163);
            this.txtAnStudiu.Name = "txtAnStudiu";
            this.txtAnStudiu.Size = new System.Drawing.Size(205, 20);
            this.txtAnStudiu.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(42, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "An:";
            // 
            // FormActInscrieri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 423);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAnStudiu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNrInscriere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSpecializari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormActInscrieri";
            this.Text = "FormActInscrieri";
            this.Load += new System.EventHandler(this.FormActInscrieri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manevraInscriereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource manevraInscriereBindingSource;
        private DataSet6 dataSet6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNrInscriere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSpecializari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.BindingSource specializariBindingSource;
        private DataSet6TableAdapters.SpecializariTableAdapter specializariTableAdapter;
        private System.Windows.Forms.BindingSource studentiBindingSource;
        private DataSet6TableAdapters.StudentiTableAdapter studentiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn numeStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaInitialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anStudiuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtAnStudiu;
        private System.Windows.Forms.Label label5;
    }
}