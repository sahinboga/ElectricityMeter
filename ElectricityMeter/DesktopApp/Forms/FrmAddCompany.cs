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

		Company company = new Company();


		private Form activeForm;
		public FrmAddCompany()
		{
			InitializeComponent();

			_companyService = InstanceFactory.GetInstance<ICompanyService>();
			_cityService = InstanceFactory.GetInstance<ICityService>();
			_districtService = InstanceFactory.GetInstance<IDistrictService>();
		}

		private void AddCompanyForm_Load(object sender, EventArgs e)
		{
			LoadCitiesAndDistricts();

			// max length ayarları
			tbxName.MaxLength = 100;
			tbxPhone.MaxLength = 14;

			// combo ayarları
			// Todo: il içinde aynısını yap
			cbxCity.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		private void LoadCitiesAndDistricts()
		{
			cbxCity.DataSource = _cityService.GetAll().Data;
			cbxCity.DisplayMember = "CityName";
			cbxCity.ValueMember = "Id";

			cbxDistrict.DataSource = _districtService.GetDistrictByCity(Convert.ToInt32(cbxCity.SelectedValue)).Data;
			cbxDistrict.DisplayMember = "DistrictName";
			cbxDistrict.ValueMember = "Id";
		}

		// Formları temizleme
		public void Reset()
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

		// Firma ekleme
		private void btnSaveCompany_Click(object sender, EventArgs e)
		{
			if (btnSaveCompany.Text == "Kaydet")
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
				this.Close();
				MessageBox.Show("Firma Eklendi.");
			}
			if (btnSaveCompany.Text == "Güncelle")
			{
				_companyService.Update(
					new Company
					{
						CompanyName = tbxName.Text,
						Email = tbxEmail.Text,
						Phone = tbxPhone.Text,
						DistrictId = Convert.ToInt32(cbxDistrict.SelectedValue),
						Address = rtbxAdress.Text
					}
				);
				this.Close();
				MessageBox.Show("Firma Güncellendi.");
			}

		}

		// Firma Güncelleme
		public void UpdateCompany()
		{
			btnSaveCompany.Text = "Güncelle";
			tbxName.Text = company.CompanyName;
			tbxEmail.Text = company.Email;
			tbxPhone.Text = company.Phone;
			cbxDistrict.SelectedValue = company.DistrictId;
			rtbxAdress.Text = company.Address;
		}

		// İl Id'ye Göre İlçe getirme
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
