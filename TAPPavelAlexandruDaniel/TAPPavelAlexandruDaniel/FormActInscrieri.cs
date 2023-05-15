using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPPavelAlexandruDaniel
{
    public partial class FormActInscrieri : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idCda;
        public FormActInscrieri()
        {
            InitializeComponent();
        }
        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }
        private void A1()
        {

            specializariTableAdapter.Fill(dataSet6.Specializari);
            studentiTableAdapter.Fill(dataSet6.Studenti);
            //Setare lblOp
            lblOp.Text = "INSCRIERE NOUA";
            // Protectie la modificare
            txtNrInscriere.ReadOnly = true;
            txtTotal.ReadOnly = true;
            nrcDataGridViewTextBoxColumn.ReadOnly = true;
            anStudiuDataGridViewTextBoxColumn.Visible = false;
            idStudentDataGridViewTextBoxColumn.ReadOnly = true;
            // Initializare cmbClient
            cmbSpecializari.SelectedIndex = -1;
        }




        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            generez_nr_cda();
            // Scriu inregistrare in Comenzi si ComenziContinut
            adaugaInregistrareInscrieri();
            cautaInregistrare();
            adaugaInregistrariInscrieriContinut();
            golireCampuri();

        }



        private void A3()
        {
            // Generare NrCrt
            DataRowView current = (DataRowView)manevraInscriereBindingSource.Current;
            if (current == null)
            {
                return;
            }
            current["Nrc"] = manevraInscriereBindingSource.Position + 1;
        }

        private void A4()
        {
            try
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    DataRowView current = (DataRowView)studentiBindingSource.Current;
                    //dataGridView1.CurrentRow.Cells[2].Value = current["UM"];
                    //dataGridView1.CurrentRow.Cells[3].Value = current["PretOferta"];
                    dataGridView1.CurrentRow.Cells[4].Value = current["IdStudent"];
                    calcTotal();
                }
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    manevraInscriereBindingSource.EndEdit();
                    calcTotal();
                }
            }
            catch { }
        }

        private void A5(DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (rezultat == DialogResult.No) e.Cancel = true;
        }

        private void FormActInscrieri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet6.Studenti' table. You can move, or remove it, as needed.
            //this.studentiTableAdapter.Fill(this.dataSet6.Studenti);
            // TODO: This line of code loads data into the 'dataSet6.Specializari' table. You can move, or remove it, as needed.
            //this.specializariTableAdapter.Fill(this.dataSet6.Specializari);
            A1();
        }

        private void manevraInscriereBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void calcTotal()
        { // Calcul total valori
            decimal t = 0;
            foreach (DataRow r in dataSet6.ManevraInscriere)
            {
                if (r["TaxaInitiala"] != DBNull.Value)
                    t += (decimal)r["TaxaInitiala"];
            }

            txtTotal.Text = Convert.ToString(t);
        }

        private void generez_nr_cda()
        {
            con.ConnectionString = studentiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Max(Inscrieri.IdInscriere) AS NrMax FROM Inscrieri";
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            txtNrInscriere.Text = Convert.ToString(rdr.GetInt32(0) + 1);
            rdr.Close();
            con.Close();
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campul Client
            if (cmbSpecializari.Text == "")
            {
                MessageBox.Show("Completati Specializare !");
                cmbSpecializari.Focus();
                return false;
            }

            if (txtAnStudiu.Text == "")
            {
                MessageBox.Show("Completati An !");
                cmbSpecializari.Focus();
                return false;
            }

            // Validare completare continut
            if (manevraInscriereBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut inscriere !");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }


        private void adaugaInregistrareInscrieri()
        {
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;

            listaCampuri = "IdInscriere,DataInscrierii, IdSpecializare,TaxaAnuala,AnStudiu";
            listaValori = Int32.Parse(txtNrInscriere.Text) +
            ",#" + Convert.ToString(d.Month) + "/"
            + Convert.ToString(d.Day) + "/"
            + Convert.ToString(d.Year) + "#,"
            + cmbSpecializari.SelectedValue + "," + Int32.Parse(txtTotal.Text) + "," + Int32.Parse(txtAnStudiu.Text);
            cmd.CommandText = "Insert into Inscrieri(" + listaCampuri + ") " +
            "Select " + listaValori;
            //MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void cautaInregistrare()
        {
            cmd.CommandText = "SELECT IdInscriere From Inscrieri Where IdInscriere = " +
            txtNrInscriere.Text;
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            idCda = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }

        private void adaugaInregistrariInscrieriContinut()
        {
            string listaCampuri = "IdInscriere, Nrc, IdStudent,TaxaInitiala";
            string listaValori;
            con.Open();
            foreach (DataRow r in dataSet6.ManevraInscriere)
            {
                listaValori = idCda + "," + r["Nrc"] + "," + r["IdStudent"] + "," +
               r["TaxaInitiala"];

                cmd.CommandText = "Insert into InscrieriContinut(" + listaCampuri + ") " +
               "Select " + listaValori;
                //MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        private void golireCampuri()
        {
            txtNrInscriere.Text = "";
            cmbSpecializari.SelectedIndex = -1;
            txtTotal.Text = "";
            dataSet6.ManevraInscriere.Clear();
        }
    }
}
