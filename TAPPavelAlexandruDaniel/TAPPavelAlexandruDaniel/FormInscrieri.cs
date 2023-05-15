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
    public partial class FormInscrieri : Form
    {
        public FormInscrieri()
        {
            InitializeComponent();
        }

        private void refreshGrid()
        {
            inscrieriTableAdapter.Fill(dataSet5.Inscrieri);
            inscrieriContinutTableAdapter.Fill(dataSet5.InscrieriContinut);
        }

        private void filtreazaDetaliu()
        {
            try
            {
                inscrieriContinutBindingSource.Filter = "IdComanda=" + txtIdInscriere.Text;
            }
            catch { }
        }


        private void FormInscrieri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet5.InscrieriContinut' table. You can move, or remove it, as needed.
            //this.inscrieriContinutTableAdapter.Fill(this.dataSet5.InscrieriContinut);
            // TODO: This line of code loads data into the 'dataSet5.Inscrieri' table. You can move, or remove it, as needed.
            //this.inscrieriTableAdapter.Fill(this.dataSet5.Inscrieri);
            refreshGrid();
            try
            {
                inscrieriContinutBindingSource.Filter = "IdInscriere=" + txtIdInscriere.Text;
            }
            catch { }

        }

        private void inscrieriBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                inscrieriContinutBindingSource.Filter = "IdInscriere=" + txtIdInscriere.Text;
            }
            catch { }
        }

        private void btnInscriereNoua_Click(object sender, EventArgs e)
        {
            FormActInscrieri f = new FormActInscrieri();
            //f.completeazaTitlu("COMANDA NOUA");
            f.ShowDialog();
            refreshGrid();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = inscrieriTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            // Sterg continut comanda
            cmd.CommandText = "Delete From InscrieriContinut Where IdInscriere = " + txtIdInscriere.Text;
            //MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            // Sterg comanda
            cmd.CommandText = "Delete From Inscrieri Where IdInscriere = " + txtIdInscriere.Text;
            //MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
            con.Close();
            // Refresh grid-uri
            refreshGrid();
            filtreazaDetaliu();

        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
        }
    }
}
