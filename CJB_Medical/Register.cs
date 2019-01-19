using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CJB_Medical
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            Hide();

        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string CHARS = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(CHARS, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string PassBuild(string key, string passSalt)
        {
            System.Security.Cryptography.SHA256 sha = System.Security.Cryptography.SHA256.Create();
            byte[] preHash = Encoding.UTF32.GetBytes(key + passSalt);
            byte[] hash = sha.ComputeHash(preHash);
            string password = Convert.ToBase64String(hash, 0, 15);
            return password;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            using (CJBMedicalDBEntities entities = new CJBMedicalDBEntities())
            {
                User user = new User();
                bool man = radioButton1.Checked;
                bool woman = radioButton2.Checked;
                user.Gender = man ? "Man" : "Woman";
                user.Name = TbImie.Text;
                user.Surname = TbNazwisko.Text;
                user.Pesel = TbPesel.Text;
                Address address = new Address();
                address.Street = TbUlica.Text;

                Int32.TryParse(TbDom.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out int dom);
                address.House = dom;

                Int32.TryParse(TbLokal.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out int lokal);
                address.Flat = lokal;

                address.City = TbMiejscowosc.Text;
                address.Postcode = TbKodPocztowy.Text;

                user.Phone = TbTelefon.Text;
                user.Email = TbEmail.Text;
                
                if (TbPassword.Text.Equals(TbPasswordConfirm.Text))
                {
                    string passSalt = RandomString(10);
                    string key = TbPassword.Text;

                    string password = PassBuild(key, passSalt);

                    user.Password = password;
                    user.Password_Salt = passSalt;
                    user.Password_Algorithm = "SHA-256";
                }
                entities.User.Add(user);
                entities.SaveChanges();

                MessageBox.Show("Uztykownik dodany");

                
            }
        }
    }
}
