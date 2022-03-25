
namespace DesktopApp.Forms
{
	partial class FrmAddCompany
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
			this.pnlAddCompany = new System.Windows.Forms.Panel();
			this.lblAdress = new System.Windows.Forms.Label();
			this.lblDistrict = new System.Windows.Forms.Label();
			this.lblCity = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.btnSaveCompany = new System.Windows.Forms.Button();
			this.rtbxAdress = new System.Windows.Forms.RichTextBox();
			this.cbxDistrict = new System.Windows.Forms.ComboBox();
			this.tbxEmail = new System.Windows.Forms.TextBox();
			this.tbxPhone = new System.Windows.Forms.TextBox();
			this.tbxName = new System.Windows.Forms.TextBox();
			this.cbxCity = new System.Windows.Forms.ComboBox();
			this.pnlAddCompany.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlAddCompany
			// 
			this.pnlAddCompany.Controls.Add(this.cbxCity);
			this.pnlAddCompany.Controls.Add(this.lblAdress);
			this.pnlAddCompany.Controls.Add(this.lblDistrict);
			this.pnlAddCompany.Controls.Add(this.lblCity);
			this.pnlAddCompany.Controls.Add(this.lblPhone);
			this.pnlAddCompany.Controls.Add(this.lblEmail);
			this.pnlAddCompany.Controls.Add(this.lblName);
			this.pnlAddCompany.Controls.Add(this.btnSaveCompany);
			this.pnlAddCompany.Controls.Add(this.rtbxAdress);
			this.pnlAddCompany.Controls.Add(this.cbxDistrict);
			this.pnlAddCompany.Controls.Add(this.tbxEmail);
			this.pnlAddCompany.Controls.Add(this.tbxPhone);
			this.pnlAddCompany.Controls.Add(this.tbxName);
			this.pnlAddCompany.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAddCompany.Location = new System.Drawing.Point(0, 0);
			this.pnlAddCompany.MaximumSize = new System.Drawing.Size(0, 450);
			this.pnlAddCompany.Name = "pnlAddCompany";
			this.pnlAddCompany.Size = new System.Drawing.Size(665, 450);
			this.pnlAddCompany.TabIndex = 0;
			// 
			// lblAdress
			// 
			this.lblAdress.AutoSize = true;
			this.lblAdress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblAdress.Location = new System.Drawing.Point(100, 255);
			this.lblAdress.Name = "lblAdress";
			this.lblAdress.Size = new System.Drawing.Size(51, 19);
			this.lblAdress.TabIndex = 12;
			this.lblAdress.Text = "Adres :";
			// 
			// lblDistrict
			// 
			this.lblDistrict.AutoSize = true;
			this.lblDistrict.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblDistrict.Location = new System.Drawing.Point(379, 118);
			this.lblDistrict.Name = "lblDistrict";
			this.lblDistrict.Size = new System.Drawing.Size(36, 19);
			this.lblDistrict.TabIndex = 11;
			this.lblDistrict.Text = "İlçe :";
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCity.Location = new System.Drawing.Point(100, 118);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(23, 19);
			this.lblCity.TabIndex = 10;
			this.lblCity.Text = "İl :";
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblPhone.Location = new System.Drawing.Point(100, 196);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(59, 19);
			this.lblPhone.TabIndex = 9;
			this.lblPhone.Text = "Telefon :";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblEmail.Location = new System.Drawing.Point(379, 48);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(63, 19);
			this.lblEmail.TabIndex = 8;
			this.lblEmail.Text = "E-posta :";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblName.Location = new System.Drawing.Point(100, 48);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(74, 19);
			this.lblName.TabIndex = 7;
			this.lblName.Text = "Firma Adı :";
			// 
			// btnSaveCompany
			// 
			this.btnSaveCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSaveCompany.BackColor = System.Drawing.Color.Teal;
			this.btnSaveCompany.FlatAppearance.BorderSize = 0;
			this.btnSaveCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveCompany.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSaveCompany.ForeColor = System.Drawing.Color.White;
			this.btnSaveCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSaveCompany.ImageKey = "plus (1).png";
			this.btnSaveCompany.Location = new System.Drawing.Point(100, 392);
			this.btnSaveCompany.Name = "btnSaveCompany";
			this.btnSaveCompany.Size = new System.Drawing.Size(115, 33);
			this.btnSaveCompany.TabIndex = 6;
			this.btnSaveCompany.Text = "Kaydet";
			this.btnSaveCompany.UseVisualStyleBackColor = false;
			this.btnSaveCompany.Click += new System.EventHandler(this.btnSaveCompany_Click);
			// 
			// rtbxAdress
			// 
			this.rtbxAdress.BackColor = System.Drawing.Color.Azure;
			this.rtbxAdress.Location = new System.Drawing.Point(100, 277);
			this.rtbxAdress.Name = "rtbxAdress";
			this.rtbxAdress.Size = new System.Drawing.Size(447, 96);
			this.rtbxAdress.TabIndex = 5;
			this.rtbxAdress.Text = "";
			// 
			// cbxDistrict
			// 
			this.cbxDistrict.BackColor = System.Drawing.Color.Azure;
			this.cbxDistrict.FormattingEnabled = true;
			this.cbxDistrict.Location = new System.Drawing.Point(379, 140);
			this.cbxDistrict.Name = "cbxDistrict";
			this.cbxDistrict.Size = new System.Drawing.Size(183, 23);
			this.cbxDistrict.TabIndex = 4;
			// 
			// tbxEmail
			// 
			this.tbxEmail.BackColor = System.Drawing.Color.Azure;
			this.tbxEmail.Location = new System.Drawing.Point(379, 70);
			this.tbxEmail.Name = "tbxEmail";
			this.tbxEmail.Size = new System.Drawing.Size(183, 23);
			this.tbxEmail.TabIndex = 2;
			// 
			// tbxPhone
			// 
			this.tbxPhone.BackColor = System.Drawing.Color.Azure;
			this.tbxPhone.Location = new System.Drawing.Point(100, 218);
			this.tbxPhone.Name = "tbxPhone";
			this.tbxPhone.Size = new System.Drawing.Size(183, 23);
			this.tbxPhone.TabIndex = 1;
			// 
			// tbxName
			// 
			this.tbxName.BackColor = System.Drawing.Color.Azure;
			this.tbxName.Location = new System.Drawing.Point(100, 70);
			this.tbxName.MaxLength = 100;
			this.tbxName.Name = "tbxName";
			this.tbxName.Size = new System.Drawing.Size(183, 23);
			this.tbxName.TabIndex = 0;
			// 
			// cbxCity
			// 
			this.cbxCity.BackColor = System.Drawing.Color.Azure;
			this.cbxCity.FormattingEnabled = true;
			this.cbxCity.Location = new System.Drawing.Point(100, 140);
			this.cbxCity.Name = "cbxCity";
			this.cbxCity.Size = new System.Drawing.Size(183, 23);
			this.cbxCity.TabIndex = 13;
			// 
			// FrmAddCompany
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(665, 450);
			this.Controls.Add(this.pnlAddCompany);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmAddCompany";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Firma Ekle";
			this.Load += new System.EventHandler(this.AddCompanyForm_Load);
			this.pnlAddCompany.ResumeLayout(false);
			this.pnlAddCompany.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlAddCompany;
		private System.Windows.Forms.TextBox tbxName;
		private System.Windows.Forms.RichTextBox rtbxAdress;
		private System.Windows.Forms.ComboBox cbxDistrict;
		private System.Windows.Forms.TextBox tbxEmail;
		private System.Windows.Forms.TextBox tbxPhone;
		private System.Windows.Forms.Button btnSaveCompany;
		private System.Windows.Forms.Label lblAdress;
		private System.Windows.Forms.Label lblDistrict;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.ComboBox cbxCity;
	}
}