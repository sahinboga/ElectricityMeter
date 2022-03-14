
namespace DesktopApp.Forms
{
	partial class CompanyForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyForm));
			this.panelCompanyTable = new System.Windows.Forms.Panel();
			this.dgwCompanyList = new System.Windows.Forms.DataGridView();
			this.btnAddCompany = new System.Windows.Forms.Button();
			this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
			this.pnlCompany = new System.Windows.Forms.Panel();
			this.panelCompanyTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwCompanyList)).BeginInit();
			this.pnlCompany.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelCompanyTable
			// 
			this.panelCompanyTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelCompanyTable.Controls.Add(this.dgwCompanyList);
			this.panelCompanyTable.Location = new System.Drawing.Point(3, 42);
			this.panelCompanyTable.Name = "panelCompanyTable";
			this.panelCompanyTable.Size = new System.Drawing.Size(770, 344);
			this.panelCompanyTable.TabIndex = 0;
			// 
			// dgwCompanyList
			// 
			this.dgwCompanyList.AllowUserToAddRows = false;
			this.dgwCompanyList.AllowUserToDeleteRows = false;
			this.dgwCompanyList.AllowUserToResizeRows = false;
			this.dgwCompanyList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwCompanyList.BackgroundColor = System.Drawing.Color.White;
			this.dgwCompanyList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgwCompanyList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgwCompanyList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwCompanyList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgwCompanyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.MenuText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgwCompanyList.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgwCompanyList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgwCompanyList.EnableHeadersVisualStyles = false;
			this.dgwCompanyList.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dgwCompanyList.Location = new System.Drawing.Point(0, 0);
			this.dgwCompanyList.Name = "dgwCompanyList";
			this.dgwCompanyList.ReadOnly = true;
			this.dgwCompanyList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.MediumSpringGreen;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lime;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwCompanyList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgwCompanyList.RowHeadersVisible = false;
			this.dgwCompanyList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgwCompanyList.RowTemplate.Height = 25;
			this.dgwCompanyList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgwCompanyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgwCompanyList.Size = new System.Drawing.Size(770, 344);
			this.dgwCompanyList.TabIndex = 0;
			this.dgwCompanyList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// btnAddCompany
			// 
			this.btnAddCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddCompany.BackColor = System.Drawing.Color.Teal;
			this.btnAddCompany.FlatAppearance.BorderSize = 0;
			this.btnAddCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddCompany.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnAddCompany.ForeColor = System.Drawing.Color.White;
			this.btnAddCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddCompany.ImageKey = "plus (1).png";
			this.btnAddCompany.ImageList = this.ımageList1;
			this.btnAddCompany.Location = new System.Drawing.Point(658, 3);
			this.btnAddCompany.Name = "btnAddCompany";
			this.btnAddCompany.Size = new System.Drawing.Size(115, 33);
			this.btnAddCompany.TabIndex = 1;
			this.btnAddCompany.Text = "   Firma Ekle";
			this.btnAddCompany.UseVisualStyleBackColor = false;
			this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
			// 
			// ımageList1
			// 
			this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
			this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ımageList1.Images.SetKeyName(0, "plus.png");
			this.ımageList1.Images.SetKeyName(1, "plus (1).png");
			// 
			// pnlCompany
			// 
			this.pnlCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCompany.Controls.Add(this.btnAddCompany);
			this.pnlCompany.Controls.Add(this.panelCompanyTable);
			this.pnlCompany.Location = new System.Drawing.Point(12, 25);
			this.pnlCompany.Name = "pnlCompany";
			this.pnlCompany.Size = new System.Drawing.Size(776, 424);
			this.pnlCompany.TabIndex = 2;
			// 
			// CompanyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(800, 461);
			this.Controls.Add(this.pnlCompany);
			this.MinimumSize = new System.Drawing.Size(600, 500);
			this.Name = "CompanyForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CompanyForm";
			this.Load += new System.EventHandler(this.CompanyForm_Load);
			this.panelCompanyTable.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgwCompanyList)).EndInit();
			this.pnlCompany.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelCompanyTable;
		private System.Windows.Forms.DataGridView dgwCompanyList;
		private System.Windows.Forms.Button btnAddCompany;
		private System.Windows.Forms.ImageList ımageList1;
		private System.Windows.Forms.Panel pnlCompany;
	}
}