
namespace DesktopApp.Forms
{
	partial class FrmMeterDetail
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMeterDetail));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pnlMeterDetail = new System.Windows.Forms.Panel();
			this.btn = new System.Windows.Forms.Button();
			this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
			this.dgwMeterDetail = new System.Windows.Forms.DataGridView();
			this.pnlCompanyName = new System.Windows.Forms.Panel();
			this.lblCompanyName = new System.Windows.Forms.Label();
			this.pnlMeterDetail.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwMeterDetail)).BeginInit();
			this.pnlCompanyName.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMeterDetail
			// 
			this.pnlMeterDetail.Controls.Add(this.btn);
			this.pnlMeterDetail.Controls.Add(this.dgwMeterDetail);
			this.pnlMeterDetail.Controls.Add(this.pnlCompanyName);
			this.pnlMeterDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMeterDetail.Location = new System.Drawing.Point(0, 0);
			this.pnlMeterDetail.Name = "pnlMeterDetail";
			this.pnlMeterDetail.Size = new System.Drawing.Size(800, 450);
			this.pnlMeterDetail.TabIndex = 0;
			// 
			// btn
			// 
			this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn.BackColor = System.Drawing.Color.Teal;
			this.btn.FlatAppearance.BorderSize = 0;
			this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn.ForeColor = System.Drawing.Color.White;
			this.btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn.ImageKey = "electric-meter.png";
			this.btn.ImageList = this.ımageList1;
			this.btn.Location = new System.Drawing.Point(653, 58);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(135, 33);
			this.btn.TabIndex = 2;
			this.btn.Text = "    Sayaç Hesapla";
			this.btn.UseVisualStyleBackColor = false;
			// 
			// ımageList1
			// 
			this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
			this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ımageList1.Images.SetKeyName(0, "electric-meter.png");
			// 
			// dgwMeterDetail
			// 
			this.dgwMeterDetail.AllowUserToAddRows = false;
			this.dgwMeterDetail.AllowUserToDeleteRows = false;
			this.dgwMeterDetail.AllowUserToResizeRows = false;
			this.dgwMeterDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgwMeterDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwMeterDetail.BackgroundColor = System.Drawing.Color.White;
			this.dgwMeterDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgwMeterDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgwMeterDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwMeterDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgwMeterDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgwMeterDetail.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgwMeterDetail.EnableHeadersVisualStyles = false;
			this.dgwMeterDetail.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dgwMeterDetail.Location = new System.Drawing.Point(12, 97);
			this.dgwMeterDetail.Name = "dgwMeterDetail";
			this.dgwMeterDetail.ReadOnly = true;
			this.dgwMeterDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgwMeterDetail.RowHeadersVisible = false;
			this.dgwMeterDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgwMeterDetail.RowTemplate.Height = 25;
			this.dgwMeterDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgwMeterDetail.Size = new System.Drawing.Size(776, 341);
			this.dgwMeterDetail.TabIndex = 1;
			// 
			// pnlCompanyName
			// 
			this.pnlCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCompanyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
			this.pnlCompanyName.Controls.Add(this.lblCompanyName);
			this.pnlCompanyName.ForeColor = System.Drawing.Color.White;
			this.pnlCompanyName.Location = new System.Drawing.Point(12, 0);
			this.pnlCompanyName.Name = "pnlCompanyName";
			this.pnlCompanyName.Size = new System.Drawing.Size(776, 43);
			this.pnlCompanyName.TabIndex = 0;
			// 
			// lblCompanyName
			// 
			this.lblCompanyName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCompanyName.AutoSize = true;
			this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCompanyName.Location = new System.Drawing.Point(353, 9);
			this.lblCompanyName.Name = "lblCompanyName";
			this.lblCompanyName.Size = new System.Drawing.Size(135, 21);
			this.lblCompanyName.TabIndex = 1;
			this.lblCompanyName.Text = "Firma Adı Gelecek";
			// 
			// FrmMeterDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlMeterDetail);
			this.Name = "FrmMeterDetail";
			this.Text = "Sayaç Detayı";
			this.Load += new System.EventHandler(this.FrmMeterDetail_Load);
			this.pnlMeterDetail.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgwMeterDetail)).EndInit();
			this.pnlCompanyName.ResumeLayout(false);
			this.pnlCompanyName.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlMeterDetail;
		private System.Windows.Forms.Panel pnlCompanyName;
		private System.Windows.Forms.Label lblCompanyName;
		private System.Windows.Forms.DataGridView dgwMeterDetail;
		private System.Windows.Forms.Button btn;
		private System.Windows.Forms.ImageList ımageList1;
	}
}