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
    public partial class AdministratorPanel : Form
    {

        User user;
        DataTable dataTablePacjent = new DataTable();
        DataTable dataTableLekarz = new DataTable();

        public AdministratorPanel()
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
        }

        public void PassUser(User userLogin)
        {
            user = userLogin;
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
            LoadData();
            dgvPacjenci.DataSource = dataTablePacjent;
            dgvLekarze.DataSource = dataTableLekarz;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (CJBDatabaseEntities entities = new CJBDatabaseEntities())
            {
                if (tabControl1.SelectedTab.Equals(tabPage1))
                {
                    //pacjent

                    int id = Convert.ToInt32(dgvPacjenci.Rows[dgvPacjenci.CurrentCell.RowIndex].Cells[0].Value);
                    User us = entities.User.FirstOrDefault(u => u.Id == id);
                    entities.User.Remove(us);
                    entities.SaveChanges();
                    LoadData();

                    MessageBox.Show("Pacjent usunięty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    //lekarz
                   
                    int id = Convert.ToInt32(dgvLekarze.Rows[dgvLekarze.CurrentCell.RowIndex].Cells[0].Value);
                    User us = entities.User.FirstOrDefault(u => u.Id == id);
                    entities.User.Remove(us);
                  
                    entities.SaveChanges();
                    LoadData();
                   
                    MessageBox.Show("Lekarz usunięty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnPasswordReset_Click(object sender, EventArgs e)
        {
            using (CJBDatabaseEntities entities = new CJBDatabaseEntities())
            {
                if (tabControl1.SelectedTab.Equals(tabPage1))
                {
                    //pacjent

                    int id = Convert.ToInt32(dgvPacjenci.Rows[dgvPacjenci.CurrentCell.RowIndex].Cells[0].Value);
                    User us = entities.User.FirstOrDefault(u => u.Id == id);
                    string newPass = Register.RandomString(8);
                    //string newPass = "11111111";
                    us.Password = Register.PassBuild(newPass, us.Password_Salt);
                    Clipboard.SetText(newPass);
                    entities.SaveChanges();
                    LoadData();

                    MessageBox.Show("Hasło zresetowane! Nowe hasło:\n" + newPass, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    //lekarz

                    int id = Convert.ToInt32(dgvLekarze.Rows[dgvLekarze.CurrentCell.RowIndex].Cells[0].Value);
                    User us = entities.User.FirstOrDefault(u => u.Id == id);

                    string newPass = Register.RandomString(8);
                    //string newPass = "11111111";
                    us.Password = Register.PassBuild(newPass, us.Password_Salt);
                    Clipboard.SetText(newPass);

                    entities.SaveChanges();
                    LoadData();

                    MessageBox.Show("Hasło zresetowane! Nowe hasło:\n" + newPass, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
