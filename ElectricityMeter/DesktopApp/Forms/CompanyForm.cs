using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Concrete;
namespace DesktopApp.Forms
{
	public partial class CompanyForm : Form
	{
		private Form activeForm;
		private Form AddCompany;

		List<Company> companies = new List<Company>
		{
			new Company
			{
				CompanyName="dsdsd",
				CityId=1,
				DistrictId=1,
				Address="dmdkfjdıkfjnı",
				Email="döwlkdwo",
				Phone="4ı304304",
				Id=1
			},
			new Company
			{
				CompanyName="dsdsd",
				CityId=1,
				DistrictId=1,
				Address="dmdkfjdıkfjnı",
				Email="döwlkdwo",
				Phone="4ı304304",
				Id=1
			},new Company
			{
				CompanyName="dsdsd",
				CityId=1,
				DistrictId=1,
				Address="dmdkfjdıkfjnı",
				Email="döwlkdwo",
				Phone="4ı304304",
				Id=1
			}
		};
		
		public CompanyForm()
		{
			InitializeComponent();
			AddCompany = new AddCompanyForm();
		}


		private void OpenChildForm(Form childForm, object btnSender)
		{
			if (activeForm != null)
				activeForm.Close();
			//ActivateButton(btnSender);
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.pnlCompany.Controls.Add(childForm);
			this.pnlCompany.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void CompanyForm_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = companies;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnAddCompany_Click(object sender, EventArgs e)
		{
			OpenChildForm(AddCompany, sender);
		}
	}
}
