
namespace DesktopApp.Forms
{
	partial class FrmAddUpdateCompany
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
			this.lblStatus = new System.Windows.Forms.Label();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.cmbCity = new System.Windows.Forms.ComboBox();
			this.lblAdress = new System.Windows.Forms.Label();
			this.lblDistrict = new System.Windows.Forms.Label();
			this.lblCity = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.btnSaveCompany = new System.Windows.Forms.Button();
			this.rtbxAdress = new System.Windows.Forms.RichTextBox();
			this.cmbDistrict = new System.Windows.Forms.ComboBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.pnlAddCompany.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlAddCompany
			// 
			this.pnlAddCompany.Controls.Add(this.lblStatus);
			this.pnlAddCompany.Controls.Add(this.cmbStatus);
			this.pnlAddCompany.Controls.Add(this.cmbCity);
			this.pnlAddCompany.Controls.Add(this.lblAdress);
			this.pnlAddCompany.Controls.Add(this.lblDistrict);
			this.pnlAddCompany.Controls.Add(this.lblCity);
			this.pnlAddCompany.Controls.Add(this.lblPhone);
			this.pnlAddCompany.Controls.Add(this.lblName);
			this.pnlAddCompany.Controls.Add(this.btnSaveCompany);
			this.pnlAddCompany.Controls.Add(this.rtbxAdress);
			this.pnlAddCompany.Controls.Add(this.cmbDistrict);
			this.pnlAddCompany.Controls.Add(this.txtPhone);
			this.pnlAddCompany.Controls.Add(this.txtName);
			this.pnlAddCompany.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAddCompany.Location = new System.Drawing.Point(0, 0);
			this.pnlAddCompany.MaximumSize = new System.Drawing.Size(0, 450);
			this.pnlAddCompany.Name = "pnlAddCompany";
			this.pnlAddCompany.Size = new System.Drawing.Size(665, 450);
			this.pnlAddCompany.TabIndex = 0;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblStatus.Location = new System.Drawing.Point(100, 192);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(105, 19);
			this.lblStatus.TabIndex = 16;
			this.lblStatus.Text = "Firma Durumu :";
			// 
			// cmbStatus
			// 
			this.cmbStatus.BackColor = System.Drawing.Color.Azure;
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Location = new System.Drawing.Point(100, 214);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(183, 23);
			this.cmbStatus.TabIndex = 14;
			// 
			// cmbCity
			// 
			this.cmbCity.BackColor = System.Drawing.Color.Azure;
			this.cmbCity.FormattingEnabled = true;
			this.cmbCity.Location = new System.Drawing.Point(100, 140);
			this.cmbCity.Name = "cmbCity";
			this.cmbCity.Size = new System.Drawing.Size(183, 23);
			this.cmbCity.TabIndex = 13;
			this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
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
			this.lblPhone.Location = new System.Drawing.Point(379, 48);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(59, 19);
			this.lblPhone.TabIndex = 9;
			this.lblPhone.Text = "Telefon :";
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
			this.rtbxAdress.Size = new System.Drawing.Size(462, 96);
			this.rtbxAdress.TabIndex = 5;
			this.rtbxAdress.Text = "";
			// 
			// cmbDistrict
			// 
			this.cmbDistrict.BackColor = System.Drawing.Color.Azure;
			this.cmbDistrict.FormattingEnabled = true;
			this.cmbDistrict.Location = new System.Drawing.Point(379, 140);
			this.cmbDistrict.Name = "cmbDistrict";
			this.cmbDistrict.Size = new System.Drawing.Size(183, 23);
			this.cmbDistrict.TabIndex = 4;
			// 
			// txtPhone
			// 
			this.txtPhone.BackColor = System.Drawing.Color.Azure;
			this.txtPhone.Location = new System.Drawing.Point(379, 70);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(183, 23);
			this.txtPhone.TabIndex = 1;
			// 
			// txtName
			// 
			this.txtName.BackColor = System.Drawing.Color.Azure;
			this.txtName.Location = new System.Drawing.Point(100, 70);
			this.txtName.MaxLength = 100;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(183, 23);
			this.txtName.TabIndex = 0;
			// 
			// FrmAddUpdateCompany
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(665, 450);
			this.Controls.Add(this.pnlAddCompany);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmAddUpdateCompany";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Firma Ekle";
			this.Load += new System.EventHandler(this.AddCompanyForm_Load);
			this.pnlAddCompany.ResumeLayout(false);
			this.pnlAddCompany.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlAddCompany;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.RichTextBox rtbxAdress;
		private System.Windows.Forms.ComboBox cmbDistrict;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Button btnSaveCompany;
		private System.Windows.Forms.Label lblAdress;
		private System.Windows.Forms.Label lblDistrict;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.ComboBox cmbCity;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ComboBox cmbStatus;
	}
}