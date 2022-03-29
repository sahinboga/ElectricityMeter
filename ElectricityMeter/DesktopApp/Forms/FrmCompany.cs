using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using System;
using System.Windows.Forms;
namespace DesktopApp.Forms
{
	public partial class FrmCompany : Form
	{

		private ICompanyService _companyService;

		public FrmCompany()
		{
			InitializeComponent();

			_companyService = InstanceFactory.GetInstance<ICompanyService>();
		}


		private void CompanyForm_Load(object sender, EventArgs e)
		{
			LoadCompanies();
		}

		public void LoadCompanies()
		{
			var list = _companyService.GetAll().Data;
			dgwCompanyList.DataSource = list;
		}

		private void btnAddCompany_Click(object sender, EventArgs e)
		{
			var form = new FrmAddUpdateCompany(0);
			form.ShowDialog();
			LoadCompanies();
		}

		private void btnEditCompany_Click(object sender, EventArgs e)
		{
			var id = (int)dgwCompanyList.CurrentRow.Cells[0].Value;
			var form = new FrmAddUpdateCompany(id);
			form.ShowDialog();
		}
	}
}
