namespace TAPPavelAlexandruDaniel
{
    partial class FStudenti
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
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TAPPavelAlexandruDaniel.DataSet1();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.PB = new System.Windows.Forms.PictureBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSpImagine = new System.Windows.Forms.TextBox();
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.studentiTableAdapter = new TAPPavelAlexandruDaniel.DataSet1TableAdapters.StudentiTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStudentDataGridViewTextBoxColumn,
            this.numeStudentDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.nrTelefonDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(595, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // idStudentDataGridViewTextBoxColumn
            // 
            this.idStudentDataGridViewTextBoxColumn.DataPropertyName = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.HeaderText = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.Name = "idStudentDataGridViewTextBoxColumn";
            this.idStudentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idStudentDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeStudentDataGridViewTextBoxColumn
            // 
            this.numeStudentDataGridViewTextBoxColumn.DataPropertyName = "NumeStudent";
            this.numeStudentDataGridViewTextBoxColumn.HeaderText = "NumeStudent";
            this.numeStudentDataGridViewTextBoxColumn.Name = "numeStudentDataGridViewTextBoxColumn";
            this.numeStudentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrTelefonDataGridViewTextBoxColumn
            // 
            this.nrTelefonDataGridViewTextBoxColumn.DataPropertyName = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.HeaderText = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.Name = "nrTelefonDataGridViewTextBoxColumn";
            this.nrTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            this.spImagineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentiBindingSource
            // 
            this.studentiBindingSource.DataMember = "Studenti";
            this.studentiBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdaugare.Location = new System.Drawing.Point(39, 41);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(177, 32);
            this.btnAdaugare.TabIndex = 1;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificare.Location = new System.Drawing.Point(249, 41);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(177, 32);
            this.btnModificare.TabIndex = 2;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnStergere.Location = new System.Drawing.Point(457, 40);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(177, 32);
            this.btnStergere.TabIndex = 3;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmare.Location = new System.Drawing.Point(686, 41);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(177, 30);
            this.btnConfirmare.TabIndex = 4;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRenuntare.Location = new System.Drawing.Point(888, 41);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(177, 30);
            this.btnRenuntare.TabIndex = 5;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(682, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(682, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "CNP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(682, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "NrTelefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(682, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Poza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(682, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(768, 90);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(430, 20);
            this.txtNume.TabIndex = 11;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblOp.Location = new System.Drawing.Point(1082, 46);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(57, 20);
            this.lblOp.TabIndex = 12;
            this.lblOp.Text = "label6";
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(970, 125);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(228, 209);
            this.PB.TabIndex = 13;
            this.PB.TabStop = false;
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(768, 145);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(170, 20);
            this.txtCNP.TabIndex = 14;
            this.txtCNP.Leave += new System.EventHandler(this.txtCNP_Leave);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(768, 194);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(170, 20);
            this.txtTelefon.TabIndex = 15;
            this.txtTelefon.Leave += new System.EventHandler(this.txtTelefon_Leave);
            // 
            // txtSpImagine
            // 
            this.txtSpImagine.Location = new System.Drawing.Point(768, 249);
            this.txtSpImagine.Name = "txtSpImagine";
            this.txtSpImagine.Size = new System.Drawing.Size(170, 20);
            this.txtSpImagine.TabIndex = 16;
            this.txtSpImagine.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSpImagine_MouseDoubleClick);
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.Location = new System.Drawing.Point(768, 302);
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.Size = new System.Drawing.Size(170, 20);
            this.txtIdStudent.TabIndex = 17;
            // 
            // studentiTableAdapter
            // 
            this.studentiTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 376);
            this.Controls.Add(this.txtIdStudent);
            this.Controls.Add(this.txtSpImagine);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FStudenti";
            this.Text = "FStudenti";
            this.Load += new System.EventHandler(this.FStudenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource studentiBindingSource;
        private DataSet1TableAdapters.StudentiTableAdapter studentiTableAdapter;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSpImagine;
        private System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
    }
}