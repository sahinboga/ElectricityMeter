
namespace DesktopApp
{
	partial class FrmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.pnlMenu = new System.Windows.Forms.Panel();
			this.btnMeter = new System.Windows.Forms.Button();
			this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnCompany = new System.Windows.Forms.Button();
			this.pnlLogo = new System.Windows.Forms.Panel();
			this.pnlTitleBar = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlDesktopPanel = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCloseChildForm = new System.Windows.Forms.Button();
			this.pnlMenu.SuspendLayout();
			this.pnlTitleBar.SuspendLayout();
			this.pnlDesktopPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMenu
			// 
			this.pnlMenu.BackColor = System.Drawing.Color.MidnightBlue;
			this.pnlMenu.Controls.Add(this.btnMeter);
			this.pnlMenu.Controls.Add(this.btnCompany);
			this.pnlMenu.Controls.Add(this.pnlLogo);
			this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlMenu.Location = new System.Drawing.Point(0, 0);
			this.pnlMenu.Name = "pnlMenu";
			this.pnlMenu.Size = new System.Drawing.Size(220, 493);
			this.pnlMenu.TabIndex = 0;
			// 
			// btnMeter
			// 
			this.btnMeter.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnMeter.FlatAppearance.BorderSize = 0;
			this.btnMeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnMeter.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnMeter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMeter.ImageIndex = 0;
			this.btnMeter.ImageList = this.ımageList1;
			this.btnMeter.Location = new System.Drawing.Point(0, 132);
			this.btnMeter.Name = "btnMeter";
			this.btnMeter.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.btnMeter.Size = new System.Drawing.Size(220, 60);
			this.btnMeter.TabIndex = 2;
			this.btnMeter.Text = "   Sayaç";
			this.btnMeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMeter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMeter.UseVisualStyleBackColor = true;
			this.btnMeter.Click += new System.EventHandler(this.btnMeter_Click);
			// 
			// ımageList1
			// 
			this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
			this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ımageList1.Images.SetKeyName(0, "electric-meter.png");
			this.ımageList1.Images.SetKeyName(1, "comp.png");
			this.ımageList1.Images.SetKeyName(2, "sinerji.jpg");
			this.ımageList1.Images.SetKeyName(3, "close-button.png");
			// 
			// btnCompany
			// 
			this.btnCompany.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCompany.FlatAppearance.BorderSize = 0;
			this.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCompany.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCompany.ImageIndex = 1;
			this.btnCompany.ImageList = this.ımageList1;
			this.btnCompany.Location = new System.Drawing.Point(0, 72);
			this.btnCompany.Name = "btnCompany";
			this.btnCompany.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.btnCompany.Size = new System.Drawing.Size(220, 60);
			this.btnCompany.TabIndex = 1;
			this.btnCompany.Text = "   Firmalar";
			this.btnCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCompany.UseVisualStyleBackColor = true;
			this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
			// 
			// pnlLogo
			// 
			this.pnlLogo.BackColor = System.Drawing.Color.MidnightBlue;
			this.pnlLogo.BackgroundImage = global::DesktopApp.Properties.Resources.sinerji4;
			this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlLogo.Location = new System.Drawing.Point(0, 0);
			this.pnlLogo.Name = "pnlLogo";
			this.pnlLogo.Size = new System.Drawing.Size(220, 72);
			this.pnlLogo.TabIndex = 0;
			// 
			// pnlTitleBar
			// 
			this.pnlTitleBar.BackColor = System.Drawing.Color.MidnightBlue;
			this.pnlTitleBar.Controls.Add(this.btnCloseChildForm);
			this.pnlTitleBar.Controls.Add(this.lblTitle);
			this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitleBar.Location = new System.Drawing.Point(220, 0);
			this.pnlTitleBar.Name = "pnlTitleBar";
			this.pnlTitleBar.Size = new System.Drawing.Size(957, 72);
			this.pnlTitleBar.TabIndex = 1;
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(421, 26);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(111, 26);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "ANASAYFA";
			// 
			// pnlDesktopPanel
			// 
			this.pnlDesktopPanel.Controls.Add(this.panel6);
			this.pnlDesktopPanel.Controls.Add(this.panel5);
			this.pnlDesktopPanel.Controls.Add(this.panel4);
			this.pnlDesktopPanel.Controls.Add(this.panel3);
			this.pnlDesktopPanel.Controls.Add(this.panel2);
			this.pnlDesktopPanel.Controls.Add(this.panel1);
			this.pnlDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDesktopPanel.Location = new System.Drawing.Point(220, 72);
			this.pnlDesktopPanel.Name = "pnlDesktopPanel";
			this.pnlDesktopPanel.Size = new System.Drawing.Size(957, 421);
			this.pnlDesktopPanel.TabIndex = 2;
			// 
			// panel6
			// 
			this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
			this.panel6.Location = new System.Drawing.Point(347, 227);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(250, 160);
			this.panel6.TabIndex = 1;
			// 
			// panel5
			// 
			this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
			this.panel5.Location = new System.Drawing.Point(347, 40);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(250, 160);
			this.panel5.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BackgroundImage = global::DesktopApp.Properties.Resources.sin5;
			this.panel4.Location = new System.Drawing.Point(626, 227);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(250, 160);
			this.panel4.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel3.BackgroundImage = global::DesktopApp.Properties.Resources.sin3;
			this.panel3.Location = new System.Drawing.Point(68, 227);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(250, 160);
			this.panel3.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackgroundImage = global::DesktopApp.Properties.Resources.sin2;
			this.panel2.Location = new System.Drawing.Point(626, 40);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(250, 160);
			this.panel2.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = global::DesktopApp.Properties.Resources.sin11;
			this.panel1.Location = new System.Drawing.Point(68, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 160);
			this.panel1.TabIndex = 0;
			// 
			// btnCloseChildForm
			// 
			this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
			this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCloseChildForm.ImageIndex = 3;
			this.btnCloseChildForm.ImageList = this.ımageList1;
			this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
			this.btnCloseChildForm.Name = "btnCloseChildForm";
			this.btnCloseChildForm.Size = new System.Drawing.Size(75, 72);
			this.btnCloseChildForm.TabIndex = 1;
			this.btnCloseChildForm.UseVisualStyleBackColor = true;
			this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1177, 493);
			this.Controls.Add(this.pnlDesktopPanel);
			this.Controls.Add(this.pnlTitleBar);
			this.Controls.Add(this.pnlMenu);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SİNERJİ";
			this.pnlMenu.ResumeLayout(false);
			this.pnlTitleBar.ResumeLayout(false);
			this.pnlTitleBar.PerformLayout();
			this.pnlDesktopPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlMenu;
		private System.Windows.Forms.Button btnMeter;
		private System.Windows.Forms.Button btnCompany;
		private System.Windows.Forms.Panel pnlLogo;
		private System.Windows.Forms.Panel pnlTitleBar;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.ImageList ımageList1;
		private System.Windows.Forms.Panel pnlDesktopPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btnCloseChildForm;
	}
}

