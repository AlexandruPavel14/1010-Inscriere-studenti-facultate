using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPPavelAlexandruDaniel
{
    public partial class FStudenti : Form
    {
        public FStudenti()
        {
            InitializeComponent();
        }

        private void FStudenti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Studenti' table. You can move, or remove it, as needed.
            //this.studentiTableAdapter.Fill(this.dataSet1.Studenti);
            A1();

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();

        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();

        }

        private void txtCNP_Leave(object sender, EventArgs e)
        {
            A5(txtCNP);
        }

        private void txtSpImagine_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            A6();

        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A8();
        }

        private void A1()
        {
            studentiTableAdapter.Fill(dataSet1.Studenti);
            PB.SizeMode = PictureBoxSizeMode.StretchImage;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            txtIdStudent.ReadOnly = true;
            A3();
        }

        private void A2()
        {
            configureazaButoane(false);
            legareControale(false);
            protectiePanel(false);
            lblOp.Text = "ADAUGARE";
            txtNume.Focus();
            golireCampuri();
        }

        private void A3()
        {
           
            lblOp.Text = "";
            configureazaButoane(true);
            protectiePanel(true);
            legareControale(true);
        }

        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;

                adauga_inregistrare();
                golireCampuri();

                //Pune cursor pe primul camp
                txtNume.Focus();
                refresh_grid(studentiBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(studentiBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if (btnRenuntare.Focused) return;


            if (txtB == txtCNP)
            {
                // Validare numericitate
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
                con.ConnectionString = studentiTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;

                if (lblOp.Text == "ADAUGARE")
                {
                    cmd.CommandText = "Select NumeStudent From Studenti where CNP='" + txtCNP.Text + "'";
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("CNP deja existent");
                        txtCNP.Focus();
                    }
                    con.Close();
                }

                else if (lblOp.Text == "MODIFICARE")
                {
                    cmd.CommandText = "Select NumeStudent From Studenti where CNP='" + txtCNP.Text +
                                      "' and IdStudent  <> " + txtIdStudent.Text;
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("CNP deja existent");
                        txtCNP.Focus();
                    }
                    con.Close();
                }
            }

            if (txtB == txtTelefon)
            {
                // Validare numericitate
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
                con.ConnectionString = studentiTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;

                if (lblOp.Text == "ADAUGARE")
                {
                    cmd.CommandText = "Select NumeStudent From Studenti where NrTelefon='" + txtTelefon.Text + "'";
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("Nr Telefon deja existent");
                        txtTelefon.Focus();
                    }
                    con.Close();
                }

                else if (lblOp.Text == "MODIFICARE")
                {
                    cmd.CommandText = "Select NumeStudent From Studenti where NrTelefon='" + txtTelefon.Text +
                                      "' and IdStudent  <> " + txtIdStudent.Text;
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("Nr Telefon deja existent");
                        txtTelefon.Focus();
                    }
                    con.Close();
                }
            }

        }

        private void A6()
        {
            if (lblOp.Text == "")
                return;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSpImagine.Text = openFileDialog1.FileName;
                PB.ImageLocation = txtSpImagine.Text;
            }
        }

        private void A7()
        {
            configureazaButoane(false);
            legareControale(false);
            protectiePanel(false);
            lblOp.Text = "MODIFICARE";
            txtNume.Focus();
        }

        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = studentiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Delete From Studenti Where IdStudent = " + txtIdStudent.Text;
            //MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refresh_grid(studentiBindingSource.Position);
        }

        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;
            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtNume.DataBindings.Add("Text", studentiBindingSource, "NumeStudent");
                txtCNP.DataBindings.Add("Text", studentiBindingSource, "CNP");
                txtTelefon.DataBindings.Add("Text", studentiBindingSource, "NrTelefon");
                txtSpImagine.DataBindings.Add("Text", studentiBindingSource, "SpImagine");
                txtIdStudent.DataBindings.Add("Text", studentiBindingSource, "IdStudent");
                PB.DataBindings.Add("ImageLocation", studentiBindingSource, "SpImagine");
            }
            else
            {
                txtNume.DataBindings.Clear();
                txtCNP.DataBindings.Clear();
                txtTelefon.DataBindings.Clear();
                txtSpImagine.DataBindings.Clear();
                txtIdStudent.DataBindings.Clear();
                PB.DataBindings.Clear();
            }
        }

        private void protectiePanel(bool v)
        {
            txtNume.ReadOnly = v;
            txtCNP.ReadOnly = v;
            txtTelefon.ReadOnly = v;
            txtSpImagine.ReadOnly = v;
        }

        private void golireCampuri()
        {
            txtNume.Text = "";
            txtCNP.Text = "";
            txtIdStudent.Text = "";
            txtTelefon.Text = "";
            txtSpImagine.Text = "";
            PB.ImageLocation = "";
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate
            if (txtNume.Text == "")
            {
                MessageBox.Show("Completati Nume !");
                txtNume.Focus();
                return false;
            }
            if (txtCNP.Text == "")
            {
                MessageBox.Show("Completati CNP !");
                txtCNP.Focus();
                return false;
            }
            if (txtTelefon.Text == "")
            {
                MessageBox.Show("Completati numarul de telefon !");
                txtTelefon.Focus();
                return false;
            }
            
            return true;
        }

        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = studentiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "NumeStudent, CNP, NrTelefon, SpImagine";
            listaValori = "'" + txtNume.Text + "'" +
            ",'" + txtCNP.Text + "'" +
            ",'" + txtTelefon.Text +
           ",'" +
           ",'" + txtSpImagine.Text + "'";
            cmd.CommandText = "Insert into Studenti(" + listaCampuri + ") " +
            "Select " + listaValori;
            //MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void refresh_grid(int p)
        {
            studentiTableAdapter.Fill(dataSet1.Studenti);
            studentiBindingSource.Position = p;
        }

        private void modifica_inregistrare()
        {
            string listaSet;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = studentiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaSet = "NumeStudent = '" + txtNume.Text + "'," +
            "CNP = '" + txtCNP.Text + "'," +
            "NrTelefon = '" + txtTelefon.Text + "'," +
           
            "SpImagine = '" + txtSpImagine.Text + "'";

            cmd.CommandText = "Update Studenti Set " + listaSet + " Where IdStudent=" +
           txtIdStudent.Text;
            //MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void txtTelefon_Leave(object sender, EventArgs e)
        {
            A5(txtTelefon);
        }
    }
}
