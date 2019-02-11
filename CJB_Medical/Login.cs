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
#if DEBUG
            TBLogin.Text = "00000000000";
            TbPassword.Text = "administrator";
#endif
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
           
                //User user = new User();
                //user.Registration_Date = DateTime.Now();
                //user.Pesel = tb
                //entities.User.Add();
            
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
            Cursor.Current = Cursors.WaitCursor;
            using (CJBDatabaseEntities entities = new CJBDatabaseEntities())
            {
                User userCzyInstnieje = new User();
                userCzyInstnieje = entities.User.FirstOrDefault(p => p.Pesel.Equals(TBLogin.Text));
                bool exist = userCzyInstnieje != null ? true : false;
                if (exist)
                {
                    string pass = Register.PassBuild(TbPassword.Text, userCzyInstnieje.Password_Salt);

                    if (userCzyInstnieje.Password.Equals(pass))
                    {
                        if (userCzyInstnieje.Role.Id == 3)
                        {
                            PanelAdmina panelAdmina = new PanelAdmina();
                            panelAdmina.Text = "ADMINISTRATOR: " + userCzyInstnieje.Name + " " + userCzyInstnieje.Surname;
                            panelAdmina.Show();
                            Hide();
                            Cursor.Current = Cursors.Default;
                            return;
                        }

                        Main main = new Main();
                        main.Text = "PANEL GŁÓWNY - " + userCzyInstnieje.Name + " " + userCzyInstnieje.Surname; 
                        main.Show();
                        Hide();
                        Cursor.Current = Cursors.Default;
                        return;
                    }
                    else
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Login Lub hasło są nieprawidłowe", "BŁĄD", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Użytkownik o takim loginie nie istnieje. Zarejestruj nowe konto", "UWAGA", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
            } 
        }
    }
}
