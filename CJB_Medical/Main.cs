using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CJB_Medical
{
    public partial class Main : Form
    {

        User user;
        Visit visit;
        Attachment attachment;
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

            lekarzWizyty.Columns.Add("ID");
           // lekarzWizyty.Columns.Add("DATA");
            lekarzWizyty.Columns.Add("GODZINA");
            lekarzWizyty.Columns.Add("PACJENT");

            pacjentWizyty.Columns.Add("ID");
            pacjentWizyty.Columns.Add("DATA");
            pacjentWizyty.Columns.Add("GODZINA");

            dateTimePicker2.MinDate = DateTime.Now;
            dtDataUmowienie.MinDate = DateTime.Now;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            using (CJBDatabaseEntities entities = new CJBDatabaseEntities())
            {
                
                
                //cbListaLekarzy.SelectedIndex = -1;

                if (user.Role.Id == 2)
                {
                    panelLekarzaToolStripMenuItem.Visible = true;
                }
                else
                {
                    panelLekarzaToolStripMenuItem.Visible = false;
                }
                LoadData();

                
            }
        }

        public void PassUser(User userLogin)
        {
            user = userLogin;
        }

        private void LoadData()
        {
            using (CJBDatabaseEntities entities = new CJBDatabaseEntities())
            {
                BindingSource bindingSource = new BindingSource();
                BindingSource bindingSource2 = new BindingSource();
                BindingSource bindingSource3 = new BindingSource();
                BindingSource bindingSource4 = new BindingSource();
                bindingSource.DataSource = listaGodzin;
                bindingSource2.DataSource = listaGodzin;
                bindingSource3.DataSource = entities.User.Where(r => r.Role.Id == 2).ToList();

                cbFrom.DataSource = bindingSource;
                cbFrom.SelectedIndex = -1;
                cbTo.DataSource = bindingSource2;
                cbTo.SelectedIndex = -1;
                cbListaLekarzy.DataSource = bindingSource3.DataSource;

                


                lekarzWizyty.Clear();
                List<Visit> visits = new List<Visit>();

                visits = entities.Visit.Where(id => id.Doctor_Id == user.Id).ToList();

                foreach (Visit item in visits)
                {
                    if (item.From.Date == dateTimePicker3.Value.Date)
                    {
                        if (item.User == null)
                        {
                            lekarzWizyty.Rows.Add(new object[] {item.Id, /*item.From.ToShortDateString(),*/ item.From.ToShortTimeString(), "" });
                        }
                        else
                        {
                            lekarzWizyty.Rows.Add(new object[] {item.Id, /*item.From.ToShortDateString(),*/ item.From.ToShortTimeString(), item.User.Name + " " + item.User.Surname });
                        }
                    }
                }
                dgvWizyty.DataSource = lekarzWizyty;


                pacjentWizyty.Clear();
                List<Visit> visitsPacjent = new List<Visit>();

                visitsPacjent = entities.Visit.Where(id => id.User.Id == user.Id).ToList();
                foreach (Visit item in visitsPacjent)
                {
                    pacjentWizyty.Rows.Add(new object[] {item.Id, item.From.ToShortDateString(), item.From.ToShortTimeString() });
                }

                DgvVisits.DataSource = pacjentWizyty;


                dgvWizyty.DataSource = lekarzWizyty;
                dgvWizyty.Columns[0].Visible = false;
                dgvWizyty.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvWizyty.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvWizyty.ClearSelection();

                DgvVisits.DataSource = pacjentWizyty;
                DgvVisits.Columns[0].Visible = false;
                DgvVisits.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                DgvVisits.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                //DgvVisits.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;


            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Login_Form login = new Login_Form();
        //    login.Show();
        //}

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
            Cursor.Current = Cursors.WaitCursor;
            if (panelLekarzaToolStripMenuItem.Text.Equals("Panel lekarza"))
            {
                panel1.Hide();
                panel2.Show(); 
                panelLekarzaToolStripMenuItem.Text = "Panel pacjenta";
                Cursor.Current = Cursors.Default;

            }
            else
            {
                panel1.Show();
                panel2.Hide();
                panelLekarzaToolStripMenuItem.Text = "Panel lekarza";
                Cursor.Current = Cursors.Default;
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
                Cursor.Current = Cursors.WaitCursor;
                Schedule schedule = new Schedule();

                

                schedule.Doctor_Id = user.Id;
                schedule.Date = dateTimePicker2.Value;

                var schedule2 = entities.Visit.Where(v => v.From.Year == schedule.Date.Year
                                                    && v.From.Month == schedule.Date.Month
                                                    && v.From.Day == schedule.Date.Day
                                                    && v.Doctor_Id == user.Id);

                Visit visitExist = new Visit();
                foreach (var item in schedule2)
                {
                    
                    visitExist = item;
                    break;
                }

                //var schedule2 = entities.Schedule.FirstOrDefault(s => s.Date.DayOfYear == schedule.Date.DayOfYear);
                if ( visitExist.From.Date == schedule.Date.Date)
                {
                    MessageBox.Show("Harmonogram na wybrany dzień już został dodany, wybierz inną datę");
                    return;
                }
                DateTime dFrom = Convert.ToDateTime(cbFrom.SelectedValue);
                DateTime dTo = Convert.ToDateTime(cbTo.SelectedValue);

                schedule.From = dFrom + (schedule.Date.Date - dFrom.Date);
                schedule.To = dTo + (schedule.Date.Date - dTo.Date);

                if (schedule.To <= schedule.From)
                {
                    MessageBox.Show("Popraw godziny przyjęć");
                    return;
                }
          
                entities.Schedule.Add(schedule);
                entities.SaveChanges();

                MessageBox.Show("Grafik dodany", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Cursor.Current = Cursors.Default;
            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadData();
            Cursor.Current = Cursors.Default;

        }

        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void dgvWizyty_SelectionChanged(object sender, EventArgs e)
        {
            int x;
            try
            {
                int.TryParse(dgvWizyty.Rows[dgvWizyty.CurrentCell.RowIndex].Cells[0].Value.ToString(), out x);

            }
            catch (Exception ex)
            {
                return;

            }
            using (CJBDatabaseEntities entities = new CJBDatabaseEntities())
            {
                label40.Text = "";
                label38.Text = "";
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                richTextBox3.Text = "";
                lblAttachement.Text = "";
                visit = new Visit();
                var query = entities.Visit.Where(id => id.Id == x);

                foreach (Visit item in query)
                {
                    try
                    {
                        visit = item;
                        label40.Text = visit.From.ToLongDateString();
                        label38.Text = visit.User.Name + " " + visit.User.Surname + ", " + visit.User.Pesel;
                        richTextBox1.Text = visit.Description;
                        richTextBox2.Text = visit.Diagnosis;
                        richTextBox3.Text = visit.Recommendations;
                        lblAttachement.Text = visit.Attachment.Name;
                    }
                    catch (Exception ex)
                    {
                        return;

                    }
                }
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (CJBDatabaseEntities entities = new CJBDatabaseEntities())
            {
                visit.Description = richTextBox1.Text;
                visit.Diagnosis = richTextBox2.Text;
                visit.Recommendations = richTextBox3.Text;
                try
                {
                    entities.Entry(visit).State = EntityState.Modified;
                    entities.SaveChanges();
                    MessageBox.Show("Dane zapisane");
                }
                catch (Exception ex)
                {

                    return;
                }
            }
        }

        private void btnAddAttachement_Click(object sender, EventArgs e)
        {
            using (CJBDatabaseEntities entities = new CJBDatabaseEntities())
            {
                
                Visit visit2 = entities.Visit.FirstOrDefault(id => id.Id == visit.Id);
                attachment = new Attachment();
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromFile(openFileDialog.FileName);
                    MemoryStream memoryStream = new MemoryStream();
                    image.Save(memoryStream, image.RawFormat);
                    attachment.Name = "Załącznik";
                    attachment.Picture = memoryStream.ToArray();
                    entities.Attachment.Add(attachment);
                    entities.SaveChanges();
                    attachment.Visit.Add(visit2);

                    entities.SaveChanges();
                    MessageBox.Show("Dodano załącznik");
                }

            }
        }

        private void cbListaLekarzy_SelectedValueChanged(object sender, EventArgs e)
        {
            using (CJBDatabaseEntities entities = new CJBDatabaseEntities())
            {
                BindingSource source = new BindingSource();
                User lekarz = (User)cbListaLekarzy.SelectedItem;
                var dosepneGodziny = entities.Visit.Where(i => i.Doctor_Id == lekarz.Id && i.User == null)
                    .Where(d => d.From.Day == dtDataUmowienie.Value.Day
                    && d.From.Month == dtDataUmowienie.Value.Month
                    && d.From.Year == dtDataUmowienie.Value.Year);
                    

                List<Visit> lg = new List<Visit>();

                foreach (var item in dosepneGodziny)
                {
                    lg.Add(item);
                }
                source.DataSource = lg;
                
                cbGodzinaUmowienie.DataSource = source;
            }
        }

        private void dtDataUmowienie_ValueChanged(object sender, EventArgs e)
        {
            cbListaLekarzy.SelectedIndex = -1;
            cbGodzinaUmowienie.SelectedIndex = -1;
        }

        private void cbListaLekarzy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGodzinaUmowienie.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var entities = new CJBDatabaseEntities())
            {

                Visit visit = (Visit)cbGodzinaUmowienie.SelectedItem;
                Visit visit2 = entities.Visit.FirstOrDefault(v => v.Id == visit.Id);
                User user2 = entities.User.Where(u => u.Id == user.Id).FirstOrDefault();
                visit2.User = user2;
                entities.SaveChanges();
                MessageBox.Show("Wizta zarezerwowana");
                LoadData();
            }
        }

        private void DgvVisits_SelectionChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int x;
            try
            {
                int.TryParse(DgvVisits.Rows[DgvVisits.CurrentCell.RowIndex].Cells[0].Value.ToString(), out x);

            }
            catch (Exception ex)
            {
                return;

            }
            using (CJBDatabaseEntities entities = new CJBDatabaseEntities())
            {
                lData.Text = "";
                lLekarz.Text = "";
                lOpis.Text = "";
                lDiagnoza.Text = "";
                lZalecenia.Text = "";
               
                visit = entities.Visit.Where(id => id.Id == x).FirstOrDefault();
                if (visit.Attachment != null) btnPobierzZalacznik.Visible = true;
                else btnPobierzZalacznik.Visible = false;
                var lekarz = entities.User.Where(i => i.Id == visit.Doctor_Id).FirstOrDefault();
                
                    try
                    {
                        
                        lData.Text = visit.From.ToLongDateString();
                        lLekarz.Text = lekarz.Name + " " + lekarz.Surname;
                        lOpis.Text = visit.Description;
                        lDiagnoza.Text = visit.Diagnosis;
                        lZalecenia.Text = visit.Recommendations;
                       
                    }
                    catch (Exception ex)
                    {
                    Cursor.Current = Cursors.Default;

                    return;

                    }
                

            }
            Cursor.Current = Cursors.Default;

        }

        private void btnPobierzZalacznik_Click(object sender, EventArgs e)
        {
            using (CJBDatabaseEntities entities = new CJBDatabaseEntities())
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "Załącznik.JPEG";
                saveFileDialog.Filter = "JPEG (*JPEG)|*JPEG";
                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
                string fileName = saveFileDialog.FileName;
                
                var itm = entities.Visit.Where(i => i.Id == visit.Id).FirstOrDefault();
                byte[] arr = itm.Attachment.Picture;
                MemoryStream ms = new MemoryStream(arr);
                Image image = Image.FromStream(ms);
                image.Save(fileName);
                MessageBox.Show("Załącznik zapisany");
            }
        }
    }
}
