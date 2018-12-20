namespace CJB_Medical
{
    partial class Login_Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblHeader = new System.Windows.Forms.Label();
            this.LblFooter = new System.Windows.Forms.Label();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblHeader
            // 
            this.LblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblHeader.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblHeader.Location = new System.Drawing.Point(0, 0);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(784, 50);
            this.LblHeader.TabIndex = 0;
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
            this.LblFooter.TabIndex = 3;
            this.LblFooter.Text = "LUBLIN, 2018";
            this.LblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnlMain.Controls.Add(this.BtnRegister);
            this.PnlMain.Controls.Add(this.label2);
            this.PnlMain.Controls.Add(this.BtnLogin);
            this.PnlMain.Controls.Add(this.TbPassword);
            this.PnlMain.Controls.Add(this.TBLogin);
            this.PnlMain.Controls.Add(this.label1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 50);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(784, 482);
            this.PnlMain.TabIndex = 4;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.Location = new System.Drawing.Point(273, 265);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(260, 23);
            this.BtnRegister.TabIndex = 5;
            this.BtnRegister.Text = "REJESTRACJA";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(1, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(784, 59);
            this.label2.TabIndex = 4;
            this.label2.Text = "JESTEŚ NOWYM UŻYTKOWNIKIEM?\r\nZAREJESTRUJ SIĘ I JUŻ DZIŚ ZACZNIJ KOŻYSTAĆ Z NASZYC" +
    "H USŁUG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Location = new System.Drawing.Point(273, 115);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(260, 23);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "ZALOGUJ";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TbPassword
            // 
            this.TbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbPassword.Location = new System.Drawing.Point(273, 89);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(260, 20);
            this.TbPassword.TabIndex = 2;
            this.TbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbPassword.UseSystemPasswordChar = true;
            this.TbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbPassword_KeyDown);
            // 
            // TBLogin
            // 
            this.TBLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBLogin.Location = new System.Drawing.Point(273, 63);
            this.TBLogin.MaxLength = 11;
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(260, 20);
            this.TBLogin.TabIndex = 1;
            this.TBLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBLogin.WordWrap = false;
            this.TBLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBLogin_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZALOGUJ SIĘ DO SYSTEMU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.LblFooter);
            this.Controls.Add(this.LblHeader);
            this.DoubleBuffered = true;
            this.Name = "Login_Form";
            this.ShowIcon = false;
            this.Text = "LOGOWANIE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_Form_FormClosing);
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Label LblFooter;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label label2;
    }
}

