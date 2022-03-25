
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
			this.lblLogo = new System.Windows.Forms.Label();
			this.pnlTitleBar = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlDesktopPanel = new System.Windows.Forms.Panel();
			this.pnlMenu.SuspendLayout();
			this.pnlLogo.SuspendLayout();
			this.pnlTitleBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMenu
			// 
			this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
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
			this.btnMeter.Location = new System.Drawing.Point(0, 120);
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
			this.btnCompany.Location = new System.Drawing.Point(0, 60);
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
			this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.pnlLogo.Controls.Add(this.lblLogo);
			this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlLogo.Location = new System.Drawing.Point(0, 0);
			this.pnlLogo.Name = "pnlLogo";
			this.pnlLogo.Size = new System.Drawing.Size(220, 60);
			this.pnlLogo.TabIndex = 0;
			// 
			// lblLogo
			// 
			this.lblLogo.AutoSize = true;
			this.lblLogo.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lblLogo.ForeColor = System.Drawing.Color.White;
			this.lblLogo.Location = new System.Drawing.Point(52, 9);
			this.lblLogo.Name = "lblLogo";
			this.lblLogo.Size = new System.Drawing.Size(114, 33);
			this.lblLogo.TabIndex = 0;
			this.lblLogo.Text = "Sinerji";
			// 
			// pnlTitleBar
			// 
			this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
			this.pnlTitleBar.Controls.Add(this.lblTitle);
			this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitleBar.Location = new System.Drawing.Point(220, 0);
			this.pnlTitleBar.Name = "pnlTitleBar";
			this.pnlTitleBar.Size = new System.Drawing.Size(638, 60);
			this.pnlTitleBar.TabIndex = 1;
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(262, 20);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(111, 26);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "ANASAYFA";
			// 
			// pnlDesktopPanel
			// 
			this.pnlDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDesktopPanel.Location = new System.Drawing.Point(220, 60);
			this.pnlDesktopPanel.Name = "pnlDesktopPanel";
			this.pnlDesktopPanel.Size = new System.Drawing.Size(638, 433);
			this.pnlDesktopPanel.TabIndex = 2;
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(858, 493);
			this.Controls.Add(this.pnlDesktopPanel);
			this.Controls.Add(this.pnlTitleBar);
			this.Controls.Add(this.pnlMenu);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SİNERJİ";
			this.pnlMenu.ResumeLayout(false);
			this.pnlLogo.ResumeLayout(false);
			this.pnlLogo.PerformLayout();
			this.pnlTitleBar.ResumeLayout(false);
			this.pnlTitleBar.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlMenu;
		private System.Windows.Forms.Button btnMeter;
		private System.Windows.Forms.Button btnCompany;
		private System.Windows.Forms.Panel pnlLogo;
		private System.Windows.Forms.Panel pnlTitleBar;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblLogo;
		private System.Windows.Forms.ImageList ımageList1;
		private System.Windows.Forms.Panel pnlDesktopPanel;
	}
}

