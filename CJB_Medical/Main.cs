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
    public partial class Main : Form
    {
        User user;
        DataTable lekarzWizyty = new DataTable();
        DataTable pacjentWizyty = new DataTable();
        string[] godziny = new string[] { "08:00", "08:15", "08:30", "08:45", "09:00", "09:15", "09:30", "09:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "12:00", "12:15", "12:30", "12:45", "13:00", "13:15", "13:30", "13:45", "14:00", "14:15", "14:30", "14:45", "15:00", "15:15", "15:30", "15:45", "16:00", "16:15", "16:30", "16:45", "17:00", "17:15", "17:30", "17:45", "18:00" };

        List<string> listaGodzin = new List<string>();

        

        public Main()
        {
            InitializeComponent();
            foreach (string item in godziny)
            {
                string date = Convert.ToDateTime(item).ToShortTimeString();
                listaGodzin.Add(date);
            }
            lekarzWizyty.Columns.Add("DATA");
            lekarzWizyty.Columns.Add("GODZINA");
            lekarzWizyty.Columns.Add("PACJENT");
        }

        public void PassUser(User userLogin)
        {
            user = userLogin;
        }

        private void LoadData()
        {
            using (CJBDatabaseEntities entities = new CJBDatabaseEntities())
            {
                lekarzWizyty.Clear();
                List<Visit> visits = new List<Visit>();

                visits = entities.Visit.Where(id => id.Doctor_Id == user.Id).ToList();

                foreach (Visit item in visits)
                {
                    if (item.From.Date == dateTimePicker3.Value.Date)
                    {
                        if (item.User == null)
                        {
                            lekarzWizyty.Rows.Add(new object[] { item.From.ToShortDateString(), item.From.ToShortTimeString(), "" });
                        }
                        else
                        {
                            lekarzWizyty.Rows.Add(new object[] { item.From.ToShortDateString(), item.From.ToShortTimeString(), item.User.Name + " " + item.User.Surname });
                        }
                    }
                }
                dgvWizyty.DataSource = lekarzWizyty;

            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form login = new Login_Form();
            login.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            BindingSource bindingSource2 = new BindingSource();
            bindingSource.DataSource = listaGodzin;
            bindingSource2.DataSource = listaGodzin;
            cbFrom.DataSource = bindingSource;
            cbFrom.SelectedIndex = -1;
            cbTo.DataSource = bindingSource2;
            cbTo.SelectedIndex = -1;

            LoadData();
            dgvWizyty.DataSource = lekarzWizyty;

        }

        private void oAplikacjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor aplikacji: Bartłomiej Ciura\nPraca inżynierska\nPromotor dr inż. Marcin Adamski", "O aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            Hide();
        }

        private void panelLekarzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelLekarzaToolStripMenuItem.Text.Equals("Panel lekarza"))
            {
                panel1.Hide();
                panel2.Show();
                panelLekarzaToolStripMenuItem.Text = "Panel pacjenta";
            }
            else
            {
                panel1.Show();
                panel2.Hide();
                panelLekarzaToolStripMenuItem.Text = "Panel lekarza";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            foreach (Control item2 in groupBox3.Controls)
            {
                if (item.Enabled == true)
                {
                    item.Enabled = false;
                }
                else
                {
                    item.Enabled = true;
                }
            }
        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {

            using (CJBDatabaseEntities entities = new CJBDatabaseEntities())
            {
                Schedule schedule = new Schedule();

                schedule.Doctor_Id = user.Id;
                schedule.Date = dateTimePicker2.Value;
                DateTime dFrom = Convert.ToDateTime(cbFrom.SelectedValue);
                DateTime dTo = Convert.ToDateTime(cbTo.SelectedValue);

                schedule.From = dFrom + (schedule.Date.Date - dFrom.Date);
                schedule.To = dTo + (schedule.Date.Date - dTo.Date);
                
          
                entities.Schedule.Add(schedule);
                entities.SaveChanges();
            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadData();
            Cursor.Current = Cursors.Default;

        }
    }
}
