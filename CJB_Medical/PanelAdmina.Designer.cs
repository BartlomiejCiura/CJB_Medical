﻿namespace CJB_Medical
{
    partial class PanelAdmina
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPacjenci = new System.Windows.Forms.DataGridView();
            this.dgvLekarze = new System.Windows.Forms.DataGridView();
            this.btnPasswordReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacjenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLekarze)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.ItemSize = new System.Drawing.Size(398, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 402);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPacjenci);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PACJENCI";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvLekarze);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LEKARZE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPacjenci
            // 
            this.dgvPacjenci.AllowUserToAddRows = false;
            this.dgvPacjenci.AllowUserToDeleteRows = false;
            this.dgvPacjenci.AllowUserToResizeColumns = false;
            this.dgvPacjenci.AllowUserToResizeRows = false;
            this.dgvPacjenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacjenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacjenci.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPacjenci.Location = new System.Drawing.Point(3, 3);
            this.dgvPacjenci.MultiSelect = false;
            this.dgvPacjenci.Name = "dgvPacjenci";
            this.dgvPacjenci.RowHeadersVisible = false;
            this.dgvPacjenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacjenci.Size = new System.Drawing.Size(786, 355);
            this.dgvPacjenci.TabIndex = 0;
            // 
            // dgvLekarze
            // 
            this.dgvLekarze.AllowUserToAddRows = false;
            this.dgvLekarze.AllowUserToDeleteRows = false;
            this.dgvLekarze.AllowUserToResizeColumns = false;
            this.dgvLekarze.AllowUserToResizeRows = false;
            this.dgvLekarze.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLekarze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLekarze.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLekarze.Location = new System.Drawing.Point(3, 3);
            this.dgvLekarze.MultiSelect = false;
            this.dgvLekarze.Name = "dgvLekarze";
            this.dgvLekarze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLekarze.Size = new System.Drawing.Size(786, 351);
            this.dgvLekarze.TabIndex = 0;
            this.dgvLekarze.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnPasswordReset
            // 
            this.btnPasswordReset.Location = new System.Drawing.Point(197, 408);
            this.btnPasswordReset.Name = "btnPasswordReset";
            this.btnPasswordReset.Size = new System.Drawing.Size(200, 30);
            this.btnPasswordReset.TabIndex = 1;
            this.btnPasswordReset.Text = "RESETUJ HASŁO";
            this.btnPasswordReset.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(403, 408);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "USUŃ UŻYTKOWNIKA";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PanelAdmina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPasswordReset);
            this.Controls.Add(this.tabControl1);
            this.Name = "PanelAdmina";
            this.ShowIcon = false;
            this.Text = "PanelAdmina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PanelAdmina_FormClosing);
            this.Load += new System.EventHandler(this.PanelAdmina_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacjenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLekarze)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPacjenci;
        private System.Windows.Forms.DataGridView dgvLekarze;
        private System.Windows.Forms.Button btnPasswordReset;
        private System.Windows.Forms.Button btnDelete;
    }
}