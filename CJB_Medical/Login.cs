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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void TBLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            Hide();
            using (CJBMedicalDBEntities entities = new CJBMedicalDBEntities())
            {
                //User user = new User();
                //user.Registration_Date = DateTime.Now();
                //user.Pesel = tb
                //entities.User.Add();
            }
        }

        private void Login_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void TbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(this, EventArgs.Empty);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
