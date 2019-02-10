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
            if (ValidateForm())
            {

                using (CJBEntities entities = new CJBEntities())
                {




                    User user = new User();
                    bool man = radioButton1.Checked;
                    bool woman = radioButton2.Checked;
                    user.Gender = man ? "Meżczyzna" : "Kobieta";
                    user.Name = TbImie.Text;
                    user.Surname = TbNazwisko.Text;
                    user.Pesel = TbPesel.Text;

                    Address address = new Address();
                    address.Street = TbUlica.Text;


                   // address.House = TbDom.Text;


                    //address.Flat = TbLokal.Text;

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
                        user.Registration_Date = DateTime.Now;
                        
                    }

                    //var data = entities.Role;
                    //foreach (var item in data)
                    //{

                    //   MessageBox.Show($"Id: {item.Id}, nazwa {item.Name}");
                    //}

                    //string serializedUser = XMLSerializer.Serialize(user);
                    //serializedUser = serializedUser.Replace("<", "zxc").Replace(">", "cxz");

                   // WebService.service.AddUser(serializedUser);

                    Role role = entities.Role.Single(a => a.Id == 1);
                    role.User.Add(user);
                    entities.User.Add(user);
                    entities.SaveChanges();

                    MessageBox.Show("Uztykownik dodany");
                }
            }
        }

        private bool ValidateForm()
        {
            bool ret = true;
            bool validNazwisko = ValidateNazwisko();
            bool validImie = ValidateImie();
            bool validPesel = ValidatePesel();
            bool validUlica = ValidateUlica();
            bool validDom = ValidateDom();
            bool validLokal = ValidateLokal();
            bool validMiejscowosc = ValidateMiejscowosc();
            bool validKodPocztowy = ValidateKodPocztowy();
            bool validTelefon = ValidateTelefon();
            bool validEmail = ValidateEmail();
            bool validHaslo = ValidateHaslo();
            bool validHasloValid = ValidateHasloValid();


            if (validNazwisko && validImie && validPesel && validUlica && validDom && validLokal 
                && validMiejscowosc && validKodPocztowy && validTelefon && validEmail && validHaslo 
                && validHasloValid) { }
            else
            {
                ret = false;
                MessageBox.Show("Popraw dane");
            }
            return ret;
        }

        private void CbLekarz_CheckedChanged(object sender, EventArgs e)
        {
            if (CbLekarz.Checked == true)
            {
                label15.Visible = true;
                TbKey.Visible = true;
            }
            else
            {
                label15.Visible = false;
                TbKey.Visible = false;

            }
        }

        private void TbPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbNazwisko_Validating(object sender, CancelEventArgs e)
        {
            ValidateNazwisko();
        }

        private bool ValidateNazwisko()
        {
            bool status = true;
            if (TbNazwisko.Text.Equals(""))
            {
                errorProvider1.SetError(TbNazwisko, "Wprowadź nazwisko");
                status = false;
            }
            else
            {
                errorProvider1.SetError(TbNazwisko, "");
            }
            return status;
        }

        private void TbImie_Validating(object sender, CancelEventArgs e)
        {
            ValidateImie();
        }

        private bool ValidateImie()
        {
            bool status = true;
            if (TbImie.Text.Equals(""))
            {
                errorProvider1.SetError(TbImie, "Wprowadź imię");
                status = false;
            }
            else
            {
                errorProvider1.SetError(TbImie, "");
            }
            return status;
        }

        private void TbPesel_Validating(object sender, CancelEventArgs e)
        {
            ValidatePesel();
        }

        private bool ValidatePesel()
        {
            bool status = true;
            if (TbPesel.Text.Length < 11)
            {
                errorProvider1.SetError(TbPesel, "Wprowadź poprawny numer pesel");
                status = false;
            }
            else
            {
                errorProvider1.SetError(TbPesel, "");
            }
            return status;
        }

        private void TbUlica_Validating(object sender, CancelEventArgs e)
        {
            ValidateUlica();
        }

        private bool ValidateUlica()
        {
            bool status = true;
            if (TbUlica.Text.Equals(""))
            {
                errorProvider1.SetError(TbUlica, "Wprowadź poprawną nazwę ulicy");
                status = false;
            }
            else
            {
                errorProvider1.SetError(TbUlica, "");
            }
            return status;
        }

        private void TbDom_Validating(object sender, CancelEventArgs e)
        {
            ValidateDom();
        }

        private bool ValidateDom()
        {
            bool status = true;
            if (TbDom.Text.Equals(""))
            {
                errorProvider1.SetError(TbDom, "Wprowadź poprawny numer domu");
                status = false;
            }
            else
            {
                errorProvider1.SetError(TbDom, "");
            }
            return status;
        }

        private void TbLokal_Validating(object sender, CancelEventArgs e)
        {
            ValidateLokal();
        }

        private bool ValidateLokal()
        {
            bool status = true;
            if (TbLokal.Text.Equals(""))
            {
                errorProvider1.SetError(TbLokal, "Wprowadź poprawny numer lokalu");
                status = false;
            }
            else
            {
                errorProvider1.SetError(TbLokal, "");
            }
            return status;
        }

        private void TbMiejscowosc_Validating(object sender, CancelEventArgs e)
        {
            ValidateMiejscowosc();
        }

        private bool ValidateMiejscowosc()
        {
            bool status = true;
            if (TbMiejscowosc.Text.Equals(""))
            {
                errorProvider1.SetError(TbMiejscowosc, "Wprowadź poprawną nazwę miejscowości");
                status = false;
            }
            else
            {
                errorProvider1.SetError(TbMiejscowosc, "");
            }
            return status;
        }

        private void TbKodPocztowy_Validating(object sender, CancelEventArgs e)
        {
            ValidateKodPocztowy();
        }

        private bool ValidateKodPocztowy()
        {
            bool status = true;
            if (TbKodPocztowy.Text.Equals(""))
            {
                errorProvider1.SetError(TbKodPocztowy, "Wprowadź poprawny kod pocztowy w formacie 00-000");
                status = false;
            }
            else
            {
                errorProvider1.SetError(TbKodPocztowy, "");
            }
            return status;
        }

        private void TbTelefon_Validating(object sender, CancelEventArgs e)
        {
            ValidateTelefon();
        }

        private bool ValidateTelefon()
        {
            bool status = true;
            if (TbTelefon.Text.Equals(""))
            {
                errorProvider1.SetError(TbTelefon, "Wprowadź poprawny numer telefonu");
                status = false;
            }
            else
            {
                errorProvider1.SetError(TbTelefon, "");
            }
            return status;
        }

        private void TbEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmail();
        }

        private bool ValidateEmail()
        {
            bool status = true;
            if (TbEmail.Text.Equals(""))
            {
                errorProvider1.SetError(TbEmail, "Wprowadź poprawny adres e-mail");
                status = false;
            }
            else
            {
                errorProvider1.SetError(TbEmail, "");
            }
            return status;
        }

        private void TbPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateHaslo();
        }

        private bool ValidateHaslo()
        {
            bool status = true;
            if (TbPassword.Text.Equals("") || TbPassword.Text.Length < 8)
            {
                errorProvider1.SetError(TbPassword, "Hasło musi mieć co najmniej 8 znaków");
                status = false;
            }
            else
            {
                errorProvider1.SetError(TbPassword, "");
            }
            return status;
        }

        private void TbPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            ValidateHasloValid();
        }

        private bool ValidateHasloValid()
        {
            bool status = true;
            if (!TbPasswordConfirm.Text.Equals(TbPassword.Text))
            {
                errorProvider1.SetError(TbPasswordConfirm, "Podane dane są niezgodne, wprowadź jeszcze raz hasło");
                status = false;
            }
            else
            {
                errorProvider1.SetError(TbPasswordConfirm, "");
            }
            return status;
        }

        private void TbKey_Validating(object sender, CancelEventArgs e)
        {
            if (CbLekarz.Checked == true)
            {

            ValidateKey();
            }
        }

        private bool ValidateKey()
        {
            bool status = true;
            if (!TbKey.Text.Equals("Tajny kod"))
            {
                errorProvider1.SetError(TbKey, "Klucz placówki niepoprawny");
                status = false;
            }
            else
            {
                errorProvider1.SetError(TbKey, "");
            }
            return status;
        }

        private void TbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
