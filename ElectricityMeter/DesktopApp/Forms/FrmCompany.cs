using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;
namespace DesktopApp.Forms
{
	public partial class FrmCompany : Form
	{
		private Form activeForm;
		private Form AddCompany;
		private ICompanyService _companyService;


		public FrmCompany()
		{
			InitializeComponent();
			AddCompany = new FrmAddCompany();

			_companyService = InstanceFactory.GetInstance<ICompanyService>();
		}


		private void OpenChildForm(Form childForm, object btnSender)
		{
			if (activeForm != null)
				activeForm.Close();
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
			LoadCompanies();
		}

		private void LoadCompanies()
		{
			var list = _companyService.GetAll().Data;
			dgwCompanyList.DataSource = list;
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
