namespace CJB_Medical
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TbMiejscowosc = new System.Windows.Forms.TextBox();
            this.LblHeader = new System.Windows.Forms.Label();
            this.LblFooter = new System.Windows.Forms.Label();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TbNazwisko = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbTelefon = new System.Windows.Forms.TextBox();
            this.TbKodPocztowy = new System.Windows.Forms.TextBox();
            this.TbLokal = new System.Windows.Forms.TextBox();
            this.TbDom = new System.Windows.Forms.TextBox();
            this.TbUlica = new System.Windows.Forms.TextBox();
            this.TbPesel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.TbKey = new System.Windows.Forms.TextBox();
            this.CbLekarz = new System.Windows.Forms.CheckBox();
            this.TbImie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbMiejscowosc
            // 
            this.TbMiejscowosc.Location = new System.Drawing.Point(122, 159);
            this.TbMiejscowosc.Name = "TbMiejscowosc";
            this.TbMiejscowosc.Size = new System.Drawing.Size(310, 20);
            this.TbMiejscowosc.TabIndex = 6;
            this.TbMiejscowosc.Validating += new System.ComponentModel.CancelEventHandler(this.TbMiejscowosc_Validating);
            // 
            // LblHeader
            // 
            this.LblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblHeader.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblHeader.Location = new System.Drawing.Point(0, 0);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(784, 50);
            this.LblHeader.TabIndex = 1;
            this.LblHeader.Text = "ELEKTRONICZNY SYSTEM OBSŁUGI PACJENTA";
            this.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFooter
            // 
            this.LblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblFooter.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblFooter.Location = new System.Drawing.Point(0, 532);
            this.LblFooter.Name = "LblFooter";
            this.LblFooter.Size = new System.Drawing.Size(784, 30);
            this.LblFooter.TabIndex = 4;
            this.LblFooter.Text = "LUBLIN, 2019";
            this.LblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PnlMain.Controls.Add(this.BtnCancel);
            this.PnlMain.Controls.Add(this.BtnRegister);
            this.PnlMain.Controls.Add(this.radioButton2);
            this.PnlMain.Controls.Add(this.radioButton1);
            this.PnlMain.Controls.Add(this.tableLayoutPanel1);
            this.PnlMain.Controls.Add(this.label1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 50);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(784, 482);
            this.PnlMain.TabIndex = 5;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancel.Location = new System.Drawing.Point(248, 453);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(312, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "ANULUJ";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRegister.Location = new System.Drawing.Point(248, 424);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(312, 23);
            this.BtnRegister.TabIndex = 0;
            this.BtnRegister.Text = "REJESTRUJ";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(392, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "PANI";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = global::CJB_Medical.Properties.Settings.Default.t;
            this.radioButton1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::CJB_Medical.Properties.Settings.Default, "t", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButton1.Location = new System.Drawing.Point(339, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "PAN";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.TbNazwisko, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.TbEmail, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.TbTelefon, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.TbKodPocztowy, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.TbMiejscowosc, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.TbLokal, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TbDom, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TbUlica, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TbPesel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.TbPassword, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.TbPasswordConfirm, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.TbKey, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.CbLekarz, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.TbImie, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(127, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(466, 366);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TbNazwisko
            // 
            this.TbNazwisko.Location = new System.Drawing.Point(122, 29);
            this.TbNazwisko.Name = "TbNazwisko";
            this.TbNazwisko.Size = new System.Drawing.Size(310, 20);
            this.TbNazwisko.TabIndex = 1;
            this.TbNazwisko.Validating += new System.ComponentModel.CancelEventHandler(this.TbNazwisko_Validating);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 344);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "KOD PLACÓWKI";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Visible = false;
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(122, 237);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(310, 20);
            this.TbEmail.TabIndex = 9;
            this.TbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TbEmail_Validating);
            // 
            // TbTelefon
            // 
            this.TbTelefon.Location = new System.Drawing.Point(122, 211);
            this.TbTelefon.Name = "TbTelefon";
            this.TbTelefon.Size = new System.Drawing.Size(310, 20);
            this.TbTelefon.TabIndex = 8;
            this.TbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTelefon_KeyPress);
            this.TbTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.TbTelefon_Validating);
            // 
            // TbKodPocztowy
            // 
            this.TbKodPocztowy.Location = new System.Drawing.Point(122, 185);
            this.TbKodPocztowy.Name = "TbKodPocztowy";
            this.TbKodPocztowy.Size = new System.Drawing.Size(310, 20);
            this.TbKodPocztowy.TabIndex = 7;
            this.TbKodPocztowy.Validating += new System.ComponentModel.CancelEventHandler(this.TbKodPocztowy_Validating);
            // 
            // TbLokal
            // 
            this.TbLokal.Location = new System.Drawing.Point(122, 133);
            this.TbLokal.Name = "TbLokal";
            this.TbLokal.Size = new System.Drawing.Size(310, 20);
            this.TbLokal.TabIndex = 5;
            this.TbLokal.Validating += new System.ComponentModel.CancelEventHandler(this.TbLokal_Validating);
            // 
            // TbDom
            // 
            this.TbDom.Location = new System.Drawing.Point(122, 107);
            this.TbDom.Name = "TbDom";
            this.TbDom.Size = new System.Drawing.Size(310, 20);
            this.TbDom.TabIndex = 4;
            this.TbDom.Validating += new System.ComponentModel.CancelEventHandler(this.TbDom_Validating);
            // 
            // TbUlica
            // 
            this.TbUlica.Location = new System.Drawing.Point(122, 81);
            this.TbUlica.Name = "TbUlica";
            this.TbUlica.Size = new System.Drawing.Size(310, 20);
            this.TbUlica.TabIndex = 3;
            this.TbUlica.Validating += new System.ComponentModel.CancelEventHandler(this.TbUlica_Validating);
            // 
            // TbPesel
            // 
            this.TbPesel.Location = new System.Drawing.Point(122, 55);
            this.TbPesel.MaxLength = 11;
            this.TbPesel.Name = "TbPesel";
            this.TbPesel.Size = new System.Drawing.Size(310, 20);
            this.TbPesel.TabIndex = 2;
            this.TbPesel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPesel_KeyPress);
            this.TbPesel.Validating += new System.ComponentModel.CancelEventHandler(this.TbPesel_Validating);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "IMIĘ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NAZWISKO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "PESEL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "ULICA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "DOM";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "LOKAL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "MIEJSCOWOŚĆ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "KOD POCZTOWY";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "TELEFON";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "ADRES E-MAIL";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "HASŁO";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(122, 263);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(310, 20);
            this.TbPassword.TabIndex = 10;
            this.TbPassword.UseSystemPasswordChar = true;
            this.TbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TbPassword_Validating);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "POTWIERDŹ HASŁO";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbPasswordConfirm
            // 
            this.TbPasswordConfirm.Location = new System.Drawing.Point(122, 289);
            this.TbPasswordConfirm.Name = "TbPasswordConfirm";
            this.TbPasswordConfirm.Size = new System.Drawing.Size(310, 20);
            this.TbPasswordConfirm.TabIndex = 11;
            this.TbPasswordConfirm.UseSystemPasswordChar = true;
            this.TbPasswordConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.TbPasswordConfirm_Validating);
            // 
            // TbKey
            // 
            this.TbKey.Location = new System.Drawing.Point(122, 338);
            this.TbKey.Name = "TbKey";
            this.TbKey.Size = new System.Drawing.Size(310, 20);
            this.TbKey.TabIndex = 13;
            this.TbKey.UseSystemPasswordChar = true;
            this.TbKey.Visible = false;
            this.TbKey.Validating += new System.ComponentModel.CancelEventHandler(this.TbKey_Validating);
            // 
            // CbLekarz
            // 
            this.CbLekarz.AutoSize = true;
            this.CbLekarz.Location = new System.Drawing.Point(122, 315);
            this.CbLekarz.Name = "CbLekarz";
            this.CbLekarz.Size = new System.Drawing.Size(133, 17);
            this.CbLekarz.TabIndex = 12;
            this.CbLekarz.Text = "JESTEŚ LEKARZEM?";
            this.CbLekarz.UseVisualStyleBackColor = true;
            this.CbLekarz.CheckedChanged += new System.EventHandler(this.CbLekarz_CheckedChanged);
            // 
            // TbImie
            // 
            this.TbImie.Location = new System.Drawing.Point(122, 3);
            this.TbImie.Name = "TbImie";
            this.TbImie.Size = new System.Drawing.Size(310, 20);
            this.TbImie.TabIndex = 0;
            this.TbImie.Validating += new System.ComponentModel.CancelEventHandler(this.TbImie_Validating);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "REJESTRACJA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.LblFooter);
            this.Controls.Add(this.LblHeader);
            this.DoubleBuffered = true;
            this.Name = "Register";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REJESTRACJA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Label LblFooter;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbTelefon;
        private System.Windows.Forms.TextBox TbKodPocztowy;
        private System.Windows.Forms.TextBox TbLokal;
        private System.Windows.Forms.TextBox TbDom;
        private System.Windows.Forms.TextBox TbUlica;
        private System.Windows.Forms.TextBox TbPesel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TbImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TbPasswordConfirm;
        private System.Windows.Forms.TextBox TbMiejscowosc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TbKey;
        private System.Windows.Forms.CheckBox CbLekarz;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TbNazwisko;
    }
}