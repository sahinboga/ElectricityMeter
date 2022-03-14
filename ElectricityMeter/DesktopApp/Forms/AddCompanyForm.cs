using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
	public partial class AddCompanyForm : Form
	{
		private ICompanyService _companyService;
		private ICityService _cityService;
		public AddCompanyForm()
		{
			InitializeComponent();

			_companyService = InstanceFactory.GetInstance<ICompanyService>();
			_cityService = InstanceFactory.GetInstance<ICityService>();
			AddCompanyLoad();
		}

		private void AddCompanyLoad()
		{
			cbxCity.DataSource = _cityService.GetAll();
			cbxCity.DisplayMember = "Name";
			cbxCity.ValueMember = "Id";
		}

		private void btnSaveCompany_Click(object sender, EventArgs e)
		{
			_companyService.Add(
					new Company
					{
						CompanyName = tbxName.Text,
						Email = tbxEmail.Text,
						Phone = tbxPhone.Text,
						CityId = Convert.ToInt32(cbxCity.SelectedValue),
						DistrictId = Convert.ToInt32(cbxDistrict.SelectedValue),
						Address = rtbxAdress.Text

					}
				); 
			//MessageBox.Show("Firma Eklendi.");
		}

		
	}
}
