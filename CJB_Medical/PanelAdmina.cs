using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CJB_Medical
{
    public partial class PanelAdmina : Form
    {
        DataTable dataTablePacjent = new DataTable();
        DataTable dataTableLekarz = new DataTable();

        public PanelAdmina()
        {
            InitializeComponent();
            dataTablePacjent.Columns.Add("ID");
            dataTablePacjent.Columns.Add("PESEL");
            dataTablePacjent.Columns.Add("IMIĘ");
            dataTablePacjent.Columns.Add("NAZWISKO");

            dataTableLekarz.Columns.Add("ID");
            dataTableLekarz.Columns.Add("PESEL");
            dataTableLekarz.Columns.Add("IMIĘ");
            dataTableLekarz.Columns.Add("NAZWISKO");

            LoadData();

        }

        private void LoadData()
        {
            dataTablePacjent.Clear();
            dataTableLekarz.Clear();

            using (CJBDatabaseEntities entities = new CJBDatabaseEntities())
            {
                List<User> pacjenci = entities.User.Where(a => a.Role.Id == 1).ToList();
                foreach (User pacjent in pacjenci)
                {
                    dataTablePacjent.Rows.Add(new object[] { pacjent.Id, pacjent.Pesel, pacjent.Name, pacjent.Surname });
                }
                dgvPacjenci.DataSource = dataTablePacjent;

                List<User> lekarze = entities.User.Where(a => a.Role.Id == 2).ToList();
                foreach (User lekarz in lekarze)
                {
                    dataTableLekarz.Rows.Add(new object[] { lekarz.Id, lekarz.Pesel, lekarz.Name, lekarz.Surname });
                }

            }
        }

        private void PanelAdmina_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Wyjście z aplikacji?", "Wyjście", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                Program.login.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PanelAdmina_Load(object sender, EventArgs e)
        {
            dgvPacjenci.DataSource = dataTablePacjent;
            dgvLekarze.DataSource = dataTableLekarz;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Equals(tabPage1))
            {
                //pacjent
                using (CJBDatabaseEntities entities = new CJBDatabaseEntities())
                {
                    int id = Convert.ToInt32(dgvPacjenci.Rows[dgvPacjenci.CurrentCell.RowIndex].Cells[0].Value);
                    User us = entities.User.FirstOrDefault(u => u.Id == id);
                    entities.User.Remove(us);
                    entities.SaveChanges();
                    LoadData();
                }
                



                MessageBox.Show("pac");
            }
            else
            {
                //lekarz
            }
        }
    }
}
