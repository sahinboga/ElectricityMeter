
namespace DesktopApp.Forms
{
	partial class FrmMeter
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMeter));
			this.pnlMeter = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgwMeterList = new System.Windows.Forms.DataGridView();
			this.btnAddMeter = new System.Windows.Forms.Button();
			this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnEditMeter = new System.Windows.Forms.Button();
			this.pnlMeter.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwMeterList)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlMeter
			// 
			this.pnlMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlMeter.Controls.Add(this.panel1);
			this.pnlMeter.Controls.Add(this.btnAddMeter);
			this.pnlMeter.Controls.Add(this.btnEditMeter);
			this.pnlMeter.Location = new System.Drawing.Point(12, 25);
			this.pnlMeter.Name = "pnlMeter";
			this.pnlMeter.Size = new System.Drawing.Size(776, 424);
			this.pnlMeter.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.dgwMeterList);
			this.panel1.Location = new System.Drawing.Point(3, 42);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(770, 344);
			this.panel1.TabIndex = 3;
			// 
			// dgwMeterList
			// 
			this.dgwMeterList.AllowUserToAddRows = false;
			this.dgwMeterList.AllowUserToDeleteRows = false;
			this.dgwMeterList.AllowUserToResizeRows = false;
			this.dgwMeterList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwMeterList.BackgroundColor = System.Drawing.Color.White;
			this.dgwMeterList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgwMeterList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgwMeterList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwMeterList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgwMeterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgwMeterList.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgwMeterList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgwMeterList.EnableHeadersVisualStyles = false;
			this.dgwMeterList.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dgwMeterList.Location = new System.Drawing.Point(0, 0);
			this.dgwMeterList.MinimumSize = new System.Drawing.Size(770, 344);
			this.dgwMeterList.Name = "dgwMeterList";
			this.dgwMeterList.ReadOnly = true;
			this.dgwMeterList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgwMeterList.RowHeadersVisible = false;
			this.dgwMeterList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgwMeterList.RowTemplate.Height = 25;
			this.dgwMeterList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgwMeterList.Size = new System.Drawing.Size(770, 344);
			this.dgwMeterList.TabIndex = 0;
			// 
			// btnAddMeter
			// 
			this.btnAddMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddMeter.BackColor = System.Drawing.Color.Teal;
			this.btnAddMeter.FlatAppearance.BorderSize = 0;
			this.btnAddMeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddMeter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnAddMeter.ForeColor = System.Drawing.Color.White;
			this.btnAddMeter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddMeter.ImageKey = "plus (1).png";
			this.btnAddMeter.ImageList = this.ımageList1;
			this.btnAddMeter.Location = new System.Drawing.Point(522, 3);
			this.btnAddMeter.Name = "btnAddMeter";
			this.btnAddMeter.Size = new System.Drawing.Size(115, 33);
			this.btnAddMeter.TabIndex = 1;
			this.btnAddMeter.Text = "  Sayaç Ekle";
			this.btnAddMeter.UseVisualStyleBackColor = false;
			this.btnAddMeter.Click += new System.EventHandler(this.btnAddMeter_Click);
			// 
			// ımageList1
			// 
			this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
			this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ımageList1.Images.SetKeyName(0, "edit.png");
			this.ımageList1.Images.SetKeyName(1, "plus (1).png");
			// 
			// btnEditMeter
			// 
			this.btnEditMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditMeter.BackColor = System.Drawing.Color.ForestGreen;
			this.btnEditMeter.FlatAppearance.BorderSize = 0;
			this.btnEditMeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditMeter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnEditMeter.ForeColor = System.Drawing.Color.White;
			this.btnEditMeter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditMeter.ImageKey = "edit.png";
			this.btnEditMeter.ImageList = this.ımageList1;
			this.btnEditMeter.Location = new System.Drawing.Point(658, 3);
			this.btnEditMeter.Name = "btnEditMeter";
			this.btnEditMeter.Size = new System.Drawing.Size(115, 33);
			this.btnEditMeter.TabIndex = 2;
			this.btnEditMeter.Text = "   Güncelle";
			this.btnEditMeter.UseVisualStyleBackColor = false;
			this.btnEditMeter.Click += new System.EventHandler(this.btnEditMeter_Click);
			// 
			// FrmMeter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(800, 461);
			this.Controls.Add(this.pnlMeter);
			this.Name = "FrmMeter";
			this.Text = "Sayaçlar";
			this.Load += new System.EventHandler(this.FrmMeter_Load);
			this.pnlMeter.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgwMeterList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwMeterList;
		private System.Windows.Forms.Panel pnlMeter;
		private System.Windows.Forms.Button btnEditMeter;
		private System.Windows.Forms.ImageList ımageList1;
		private System.Windows.Forms.Button btnAddMeter;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}