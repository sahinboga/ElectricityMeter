using Business.Abstract;
using Business.DependencyResolvers.Ninject;
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
	public partial class FrmAddCompany : Form
	{
		private ICompanyService _companyService;
		private ICityService _cityService;
		private IDistrictService _districtService;

		private Form activeForm;
		public FrmAddCompany()
		{
			InitializeComponent();

			_companyService = InstanceFactory.GetInstance<ICompanyService>();
			_cityService = InstanceFactory.GetInstance<ICityService>();
			_districtService = InstanceFactory.GetInstance<IDistrictService>();

			//Company = new CompanyForm();
		}

		private void OpenChildForm(Form childForm, object btnSender)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.pnlAddCompany.Controls.Add(childForm);
			this.pnlAddCompany.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void AddCompanyForm_Load(object sender, EventArgs e)
		{
			LoadCitiesAndDistricts();
		}

		private void LoadCitiesAndDistricts()
		{
			cbxCity.DataSource = _cityService.GetAll().Data;
			cbxCity.DisplayMember = "CityName";
			cbxCity.ValueMember = "Id";

			cbxDistrict.DataSource = _districtService.GetAll().Data;
			cbxDistrict.DisplayMember = "DistrictName";
			cbxDistrict.ValueMember = "Id";
		}

		private void Reset()
		{
			tbxName.Text = "";
			tbxEmail.Text = "";
			tbxPhone.Text = "";
			cbxCity.SelectedIndex = 0;
			if (cbxDistrict.Items.Count > 0)
			{
				cbxDistrict.SelectedIndex = 0;
			}
			rtbxAdress.Text = "";
		}

		private void btnSaveCompany_Click(object sender, EventArgs e)
		{
			_companyService.Add(
					new Company
					{
						CompanyName = tbxName.Text,
						Email = tbxEmail.Text,
						Phone = tbxPhone.Text,
						DistrictId = Convert.ToInt32(cbxDistrict.SelectedValue),
						Address = rtbxAdress.Text
					}
				);
			Reset();
			OpenChildForm(new FrmCompany(), sender);
			MessageBox.Show("Firma Eklendi.");
		}

		private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				cbxDistrict.DataSource = _districtService.GetDistrictByCity(Convert.ToInt32(cbxCity.SelectedValue)).Data;
			}
			catch 
			{

				
			}
			
			
		}
	}
}
