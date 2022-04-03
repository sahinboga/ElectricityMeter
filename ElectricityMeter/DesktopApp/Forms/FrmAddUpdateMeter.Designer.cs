
namespace DesktopApp.Forms
{
	partial class FrmAddUpdateMeter
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
			this.pnlAddMeter = new System.Windows.Forms.Panel();
			this.lblMeterPower = new System.Windows.Forms.Label();
			this.lblMultipy = new System.Windows.Forms.Label();
			this.lblSubscriberNo = new System.Windows.Forms.Label();
			this.lblMeterNo = new System.Windows.Forms.Label();
			this.lblCompany = new System.Windows.Forms.Label();
			this.btnSaveMeter = new System.Windows.Forms.Button();
			this.txtMeterPower = new System.Windows.Forms.TextBox();
			this.txtMultipy = new System.Windows.Forms.TextBox();
			this.txtSubscriberNo = new System.Windows.Forms.TextBox();
			this.txtMeterNo = new System.Windows.Forms.TextBox();
			this.cmbCompany = new System.Windows.Forms.ComboBox();
			this.pnlAddMeter.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlAddMeter
			// 
			this.pnlAddMeter.Controls.Add(this.lblMeterPower);
			this.pnlAddMeter.Controls.Add(this.lblMultipy);
			this.pnlAddMeter.Controls.Add(this.lblSubscriberNo);
			this.pnlAddMeter.Controls.Add(this.lblMeterNo);
			this.pnlAddMeter.Controls.Add(this.lblCompany);
			this.pnlAddMeter.Controls.Add(this.btnSaveMeter);
			this.pnlAddMeter.Controls.Add(this.txtMeterPower);
			this.pnlAddMeter.Controls.Add(this.txtMultipy);
			this.pnlAddMeter.Controls.Add(this.txtSubscriberNo);
			this.pnlAddMeter.Controls.Add(this.txtMeterNo);
			this.pnlAddMeter.Controls.Add(this.cmbCompany);
			this.pnlAddMeter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAddMeter.Location = new System.Drawing.Point(0, 0);
			this.pnlAddMeter.MaximumSize = new System.Drawing.Size(0, 450);
			this.pnlAddMeter.Name = "pnlAddMeter";
			this.pnlAddMeter.Size = new System.Drawing.Size(665, 450);
			this.pnlAddMeter.TabIndex = 0;
			// 
			// lblMeterPower
			// 
			this.lblMeterPower.AutoSize = true;
			this.lblMeterPower.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblMeterPower.Location = new System.Drawing.Point(337, 217);
			this.lblMeterPower.Name = "lblMeterPower";
			this.lblMeterPower.Size = new System.Drawing.Size(86, 19);
			this.lblMeterPower.TabIndex = 12;
			this.lblMeterPower.Text = "Sayaç Gücü :";
			// 
			// lblMultipy
			// 
			this.lblMultipy.AutoSize = true;
			this.lblMultipy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblMultipy.Location = new System.Drawing.Point(119, 217);
			this.lblMultipy.Name = "lblMultipy";
			this.lblMultipy.Size = new System.Drawing.Size(101, 19);
			this.lblMultipy.TabIndex = 11;
			this.lblMultipy.Text = "Sayaç Çarpanı :";
			// 
			// lblSubscriberNo
			// 
			this.lblSubscriberNo.AutoSize = true;
			this.lblSubscriberNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblSubscriberNo.Location = new System.Drawing.Point(337, 130);
			this.lblSubscriberNo.Name = "lblSubscriberNo";
			this.lblSubscriberNo.Size = new System.Drawing.Size(78, 19);
			this.lblSubscriberNo.TabIndex = 10;
			this.lblSubscriberNo.Text = "Abone No :";
			// 
			// lblMeterNo
			// 
			this.lblMeterNo.AutoSize = true;
			this.lblMeterNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblMeterNo.Location = new System.Drawing.Point(119, 130);
			this.lblMeterNo.Name = "lblMeterNo";
			this.lblMeterNo.Size = new System.Drawing.Size(72, 19);
			this.lblMeterNo.TabIndex = 9;
			this.lblMeterNo.Text = "Sayaç No :";
			// 
			// lblCompany
			// 
			this.lblCompany.AutoSize = true;
			this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCompany.Location = new System.Drawing.Point(119, 46);
			this.lblCompany.Name = "lblCompany";
			this.lblCompany.Size = new System.Drawing.Size(74, 19);
			this.lblCompany.TabIndex = 8;
			this.lblCompany.Text = "Firma Adı :";
			// 
			// btnSaveMeter
			// 
			this.btnSaveMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSaveMeter.BackColor = System.Drawing.Color.Teal;
			this.btnSaveMeter.FlatAppearance.BorderSize = 0;
			this.btnSaveMeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveMeter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSaveMeter.ForeColor = System.Drawing.Color.White;
			this.btnSaveMeter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSaveMeter.ImageKey = "plus (1).png";
			this.btnSaveMeter.Location = new System.Drawing.Point(119, 325);
			this.btnSaveMeter.Name = "btnSaveMeter";
			this.btnSaveMeter.Size = new System.Drawing.Size(115, 33);
			this.btnSaveMeter.TabIndex = 7;
			this.btnSaveMeter.Text = "Kaydet";
			this.btnSaveMeter.UseVisualStyleBackColor = false;
			this.btnSaveMeter.Click += new System.EventHandler(this.btnSaveMeter_Click);
			// 
			// txtMeterPower
			// 
			this.txtMeterPower.Location = new System.Drawing.Point(337, 239);
			this.txtMeterPower.Name = "txtMeterPower";
			this.txtMeterPower.Size = new System.Drawing.Size(200, 23);
			this.txtMeterPower.TabIndex = 4;
			// 
			// txtMultipy
			// 
			this.txtMultipy.Location = new System.Drawing.Point(119, 239);
			this.txtMultipy.Name = "txtMultipy";
			this.txtMultipy.Size = new System.Drawing.Size(200, 23);
			this.txtMultipy.TabIndex = 3;
			// 
			// txtSubscriberNo
			// 
			this.txtSubscriberNo.Location = new System.Drawing.Point(337, 152);
			this.txtSubscriberNo.Name = "txtSubscriberNo";
			this.txtSubscriberNo.Size = new System.Drawing.Size(200, 23);
			this.txtSubscriberNo.TabIndex = 2;
			// 
			// txtMeterNo
			// 
			this.txtMeterNo.Location = new System.Drawing.Point(119, 152);
			this.txtMeterNo.Name = "txtMeterNo";
			this.txtMeterNo.Size = new System.Drawing.Size(200, 23);
			this.txtMeterNo.TabIndex = 1;
			// 
			// cmbCompany
			// 
			this.cmbCompany.FormattingEnabled = true;
			this.cmbCompany.Location = new System.Drawing.Point(119, 68);
			this.cmbCompany.Name = "cmbCompany";
			this.cmbCompany.Size = new System.Drawing.Size(418, 23);
			this.cmbCompany.TabIndex = 0;
			// 
			// FrmAddUpdateMeter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(665, 450);
			this.Controls.Add(this.pnlAddMeter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmAddUpdateMeter";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sayaç Ekle";
			this.Load += new System.EventHandler(this.FrmAddUpdateMeter_Load);
			this.pnlAddMeter.ResumeLayout(false);
			this.pnlAddMeter.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlAddMeter;
		private System.Windows.Forms.TextBox txtMeterPower;
		private System.Windows.Forms.TextBox txtMultipy;
		private System.Windows.Forms.TextBox txtSubscriberNo;
		private System.Windows.Forms.TextBox txtMeterNo;
		private System.Windows.Forms.ComboBox cmbCompany;
		private System.Windows.Forms.Button btnSaveMeter;
		private System.Windows.Forms.Label lblCompany;
		private System.Windows.Forms.Label lblMeterPower;
		private System.Windows.Forms.Label lblMultipy;
		private System.Windows.Forms.Label lblSubscriberNo;
		private System.Windows.Forms.Label lblMeterNo;
	}
}