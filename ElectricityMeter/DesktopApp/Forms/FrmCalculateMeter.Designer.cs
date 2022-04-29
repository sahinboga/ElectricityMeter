
namespace DesktopApp.Forms
{
	partial class FrmCalculateMeter
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
			this.pnlCalculateMeter = new System.Windows.Forms.Panel();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.lblReadDate = new System.Windows.Forms.Label();
			this.lblCapacitive = new System.Windows.Forms.Label();
			this.lblInductive = new System.Windows.Forms.Label();
			this.lblActive = new System.Windows.Forms.Label();
			this.dtpReadDate = new System.Windows.Forms.DateTimePicker();
			this.txtCapacitive = new System.Windows.Forms.TextBox();
			this.txtInductive = new System.Windows.Forms.TextBox();
			this.txtActive = new System.Windows.Forms.TextBox();
			this.pnlCalculateMeter.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlCalculateMeter
			// 
			this.pnlCalculateMeter.Controls.Add(this.btnCalculate);
			this.pnlCalculateMeter.Controls.Add(this.lblReadDate);
			this.pnlCalculateMeter.Controls.Add(this.lblCapacitive);
			this.pnlCalculateMeter.Controls.Add(this.lblInductive);
			this.pnlCalculateMeter.Controls.Add(this.lblActive);
			this.pnlCalculateMeter.Controls.Add(this.dtpReadDate);
			this.pnlCalculateMeter.Controls.Add(this.txtCapacitive);
			this.pnlCalculateMeter.Controls.Add(this.txtInductive);
			this.pnlCalculateMeter.Controls.Add(this.txtActive);
			this.pnlCalculateMeter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlCalculateMeter.Location = new System.Drawing.Point(0, 0);
			this.pnlCalculateMeter.Name = "pnlCalculateMeter";
			this.pnlCalculateMeter.Size = new System.Drawing.Size(665, 450);
			this.pnlCalculateMeter.TabIndex = 0;
			// 
			// btnCalculate
			// 
			this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCalculate.BackColor = System.Drawing.Color.Teal;
			this.btnCalculate.FlatAppearance.BorderSize = 0;
			this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCalculate.ForeColor = System.Drawing.Color.White;
			this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCalculate.ImageKey = "plus (1).png";
			this.btnCalculate.Location = new System.Drawing.Point(108, 300);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(115, 33);
			this.btnCalculate.TabIndex = 8;
			this.btnCalculate.Text = "Hesapla";
			this.btnCalculate.UseVisualStyleBackColor = false;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// lblReadDate
			// 
			this.lblReadDate.AutoSize = true;
			this.lblReadDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblReadDate.Location = new System.Drawing.Point(355, 175);
			this.lblReadDate.Name = "lblReadDate";
			this.lblReadDate.Size = new System.Drawing.Size(104, 19);
			this.lblReadDate.TabIndex = 7;
			this.lblReadDate.Text = "Okunma Tarihi :";
			// 
			// lblCapacitive
			// 
			this.lblCapacitive.AutoSize = true;
			this.lblCapacitive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCapacitive.Location = new System.Drawing.Point(108, 178);
			this.lblCapacitive.Name = "lblCapacitive";
			this.lblCapacitive.Size = new System.Drawing.Size(109, 19);
			this.lblCapacitive.TabIndex = 6;
			this.lblCapacitive.Text = "Kapasitif (8.8.0) :";
			// 
			// lblInductive
			// 
			this.lblInductive.AutoSize = true;
			this.lblInductive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblInductive.Location = new System.Drawing.Point(355, 57);
			this.lblInductive.Name = "lblInductive";
			this.lblInductive.Size = new System.Drawing.Size(108, 19);
			this.lblInductive.TabIndex = 5;
			this.lblInductive.Text = "Endüktif (5.8.0) :";
			// 
			// lblActive
			// 
			this.lblActive.AutoSize = true;
			this.lblActive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblActive.Location = new System.Drawing.Point(108, 57);
			this.lblActive.Name = "lblActive";
			this.lblActive.Size = new System.Drawing.Size(86, 19);
			this.lblActive.TabIndex = 4;
			this.lblActive.Text = "Aktif (1.8.0) :";
			// 
			// dtpReadDate
			// 
			this.dtpReadDate.Location = new System.Drawing.Point(355, 197);
			this.dtpReadDate.Name = "dtpReadDate";
			this.dtpReadDate.Size = new System.Drawing.Size(177, 23);
			this.dtpReadDate.TabIndex = 3;
			// 
			// txtCapacitive
			// 
			this.txtCapacitive.Location = new System.Drawing.Point(108, 200);
			this.txtCapacitive.Name = "txtCapacitive";
			this.txtCapacitive.Size = new System.Drawing.Size(177, 23);
			this.txtCapacitive.TabIndex = 2;
			// 
			// txtInductive
			// 
			this.txtInductive.Location = new System.Drawing.Point(355, 79);
			this.txtInductive.Name = "txtInductive";
			this.txtInductive.Size = new System.Drawing.Size(177, 23);
			this.txtInductive.TabIndex = 1;
			// 
			// txtActive
			// 
			this.txtActive.Location = new System.Drawing.Point(108, 79);
			this.txtActive.Name = "txtActive";
			this.txtActive.Size = new System.Drawing.Size(177, 23);
			this.txtActive.TabIndex = 0;
			// 
			// FrmCalculateMeter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(665, 450);
			this.Controls.Add(this.pnlCalculateMeter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmCalculateMeter";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sayaç Hesapla";
			this.Load += new System.EventHandler(this.FrmCalculateMeter_Load);
			this.pnlCalculateMeter.ResumeLayout(false);
			this.pnlCalculateMeter.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlCalculateMeter;
		private System.Windows.Forms.Label lblReadDate;
		private System.Windows.Forms.Label lblCapacitive;
		private System.Windows.Forms.Label lblInductive;
		private System.Windows.Forms.Label lblActive;
		private System.Windows.Forms.DateTimePicker dtpReadDate;
		private System.Windows.Forms.TextBox txtCapacitive;
		private System.Windows.Forms.TextBox txtInductive;
		private System.Windows.Forms.TextBox txtActive;
		private System.Windows.Forms.Button btnCalculate;
	}
}