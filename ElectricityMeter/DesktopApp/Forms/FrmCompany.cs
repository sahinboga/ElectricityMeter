using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
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
			// combo ayarları
			cmbCompanyStatus.DropDownStyle = ComboBoxStyle.DropDownList;

			List<string> companyStatus = new List<string>() {
																"Tüm Firmalar",
																"Aktif Firmalar",
																"Pasif Firmalar"
															};
			cmbCompanyStatus.DataSource = companyStatus;

			// gridi doldur
			LoadCompaniesByFirmaTipi();
		}

		private void btnAddCompany_Click(object sender, EventArgs e)
		{
			// firma ekle
			var form = new FrmAddUpdateCompany(0);
			form.ShowDialog();
			LoadCompaniesByFirmaTipi();
		}

		private void btnEditCompany_Click(object sender, EventArgs e)
		{
			// firma edit
			var id = (int)dgwCompanyList.CurrentRow.Cells[0].Value;
			var form = new FrmAddUpdateCompany(id);
			form.ShowDialog();
			LoadCompaniesByFirmaTipi();
		}


		private void btnDeleteCompany_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Silmek istiyor musun?", "Bilgilendirme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
			{
				// todo: yapılacak
				//try
				//{
				var id = (int)dgwCompanyList.CurrentRow.Cells[0].Value;
				//}
				//catch (Exception exception)
				//{
				//	MessageBox.Show(exception.Message);
				//}


			}


		}

		// firma tipi değiştiğinde
		private void cmbCompanyStatus_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadCompaniesByFirmaTipi();
		}

		// LoadCompaniesByFirmaTipi - compay statusuna göre gridi filtreleyen method
		private void LoadCompaniesByFirmaTipi()
		{
			switch (cmbCompanyStatus.SelectedIndex)
			{
				case 0: // all firmalar
					{
						dgwCompanyList.DataSource = _companyService.GetAllWithDetails(FirmaTipiEnum.All).Data;
						break;
					}
				case 1: // aktif firmalar
					{
						dgwCompanyList.DataSource = _companyService.GetAllWithDetails(FirmaTipiEnum.Aktif).Data;
						break;
					}
				case 2: // pasif firmalar
					{
						dgwCompanyList.DataSource = _companyService.GetAllWithDetails(FirmaTipiEnum.Pasif).Data;
						break;
					}
				default:
					break;
			}
		}
	}
}

