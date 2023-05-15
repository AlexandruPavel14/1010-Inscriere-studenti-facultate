namespace TAPPavelAlexandruDaniel
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
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specializariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscrieriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.studentiToolStripMenuItem.Text = "Studenti";
            this.studentiToolStripMenuItem.Click += new System.EventHandler(this.StudentiToolStripMenuItem_Click);
            // 
            // specializariToolStripMenuItem
            // 
            this.specializariToolStripMenuItem.Name = "specializariToolStripMenuItem";
            this.specializariToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.specializariToolStripMenuItem.Text = "Specializari";
            this.specializariToolStripMenuItem.Click += new System.EventHandler(this.SpecializariToolStripMenuItem_Click);
            // 
            // inscrieriToolStripMenuItem
            // 
            this.inscrieriToolStripMenuItem.Name = "inscrieriToolStripMenuItem";
            this.inscrieriToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.inscrieriToolStripMenuItem.Text = "Inscrieri";
            this.inscrieriToolStripMenuItem.Click += new System.EventHandler(this.inscrieriToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentiToolStripMenuItem,
            this.specializariToolStripMenuItem,
            this.inscrieriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(359, 203);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(221, 31);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(453, 168);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(127, 20);
            this.txtParola.TabIndex = 5;
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(453, 125);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(127, 20);
            this.txtUtilizator.TabIndex = 4;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblParola.Location = new System.Drawing.Point(355, 166);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(54, 20);
            this.lblParola.TabIndex = 3;
            this.lblParola.Text = "Parola";
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUtilizator.Location = new System.Drawing.Point(355, 123);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(71, 20);
            this.lblUtilizator.TabIndex = 2;
            this.lblUtilizator.Text = "Utilizator";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblAutor.Location = new System.Drawing.Point(208, 80);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(526, 29);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor: Pavel Alexandru-Daniel Informatica Anul 3";
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTitlu.Location = new System.Drawing.Point(83, 37);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(761, 33);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Aplicatie pentru inscrierea studentilor dintr-o facultate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 261);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUtilizator);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specializariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscrieriToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitlu;
    }
}

