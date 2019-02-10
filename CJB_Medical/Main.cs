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
        public Main()
        {
            InitializeComponent();
            
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
            foreach (Control item in tableLayoutPanel1.Controls)
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
    }
}
