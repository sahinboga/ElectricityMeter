using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
	public partial class FrmAddUpdateCompany : Form
	{
		// variables
		private ICompanyService _companyService;
		private ICityService _cityService;
		private IDistrictService _districtService;
		private int curId;

		// entity
		Company curCompany = null;

		public FrmAddUpdateCompany(int curId)
		{
			InitializeComponent();

			_companyService = InstanceFactory.GetInstance<ICompanyService>();
			_cityService = InstanceFactory.GetInstance<ICityService>();
			_districtService = InstanceFactory.GetInstance<IDistrictService>();

			LoadCitiesAndDistricts();

			// muhatap olduğumuz Id
			this.curId = curId;

			this.Text = this.curId == 0 ? "Firma Ekle" : "Firma Güncelle";

			// eğer güncelleme formu ise ilgili id li kaydı çağır ekrana bas
			if (this.curId > 0)
			{
				var oCompany = _companyService.GetById(this.curId);
				txtName.Text = oCompany.Data.CompanyName;
				txtEmail.Text = oCompany.Data.Email;
				txtPhone.Text = oCompany.Data.Phone;
				rtbxAdress.Text = oCompany.Data.Address;
				cmbStatus.SelectedValue = oCompany.Data.Status;
				LoadCityAndDistrictByIds(oCompany.Data.DistrictId);
				curCompany = oCompany.Data;
			}
		}

		private void AddCompanyForm_Load(object sender, EventArgs e)
		{

			// max length ayarları
			txtName.MaxLength = 100;
			txtPhone.MaxLength = 14;

			// combo ayarları
			cmbCity.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;

			// status combosuna veri ekleme
			List<StatusDto> status = new List<StatusDto>();
			status.Add(new StatusDto
			{
				Value = true,
				Display = "Aktif"

			});
			status.Add(new StatusDto
			{
				Value = false,
				Display = "Pasif"

			});
			cmbStatus.DataSource = status;
			cmbStatus.DisplayMember = "Display";
			cmbStatus.ValueMember = "Value";
		}

		// güncelleme yapılacak firmanın il ve ilçesini combolara getirme
		private void LoadCityAndDistrictByIds(int districtId)
		{
			var district = _districtService.GetById(districtId).Data;
			cmbCity.SelectedValue = district.CityId;
			cmbDistrict.SelectedValue = districtId;
		}

		private void LoadCitiesAndDistricts()
		{
			cmbCity.DataSource = _cityService.GetAll().Data;
			cmbCity.DisplayMember = "CityName";
			cmbCity.ValueMember = "Id";

			cmbDistrict.DataSource = _districtService.GetDistrictByCity(Convert.ToInt32(cmbCity.SelectedValue)).Data;
			cmbDistrict.DisplayMember = "DistrictName";
			cmbDistrict.ValueMember = "Id";
		}

		// Formları temizleme
		public void FormReset()
		{
			txtName.Text = string.Empty;
			txtEmail.Text = string.Empty;
			txtPhone.Text = string.Empty;
			cmbCity.SelectedIndex = 0;
			if (cmbDistrict.Items.Count > 0)
			{
				cmbDistrict.SelectedIndex = 0;
			}
			rtbxAdress.Text = string.Empty;
		}

		// Firma ekleme ve güncelleme
		private void btnSaveCompany_Click(object sender, EventArgs e)
		{
			// email girişi doğruluğu yap
			Regex rEmail = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
			if (!rEmail.IsMatch(txtEmail.Text))
			{
				MessageBox.Show("Geçerli bir e-Mail giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtEmail.Focus();
				return;
			}

			// Validate işlemleri
			if (txtName.Text.Trim().Length <= 5)
			{
				MessageBox.Show("Firma Adı En Az 5 Karakterli Olmalıdır!","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (txtPhone.Text.Trim().Length <= 10)
			{
				MessageBox.Show("Telefon Numarası Geçersizdir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (this.curId == 0)
			{
				// add formu ise servisteki add methodunu çağır
				_companyService.Add(
					new Company
					{
						CompanyName = txtName.Text.Trim(),
						Email = txtEmail.Text.Trim(),
						Phone = txtPhone.Text.Trim(),
						DistrictId = Convert.ToInt32(cmbDistrict.SelectedValue),
						Address = rtbxAdress.Text.Trim(),
						Status=Convert.ToBoolean(cmbStatus.SelectedValue)
					}
				);
				FormReset();
				this.Close();
				MessageBox.Show("Firma Eklendi.");
			}
			else
			{
				// değilse (güncelleme formuysa) servisteki update methodunu çağır
				curCompany.Id = this.curId;
				curCompany.CompanyName = txtName.Text.Trim();
				curCompany.Email = txtEmail.Text.Trim();
				curCompany.Phone = txtPhone.Text.Trim();
				curCompany.DistrictId = Convert.ToInt32(cmbDistrict.SelectedValue);
				curCompany.Address = rtbxAdress.Text.Trim();
				curCompany.Status = Convert.ToBoolean(cmbStatus.SelectedValue);

				var res = _companyService.Update(curCompany);

				// işlem başarılıysa
				if (res.Success)
				{			
					MessageBox.Show("Firma Güncellendi.");
					this.Close();
				}
				else
				{
					// hata oluştu
					MessageBox.Show(res.Message);
				}
			}

		}

		// İl Id'ye Göre İlçe getirme
		private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				cmbDistrict.DataSource = _districtService.GetDistrictByCity(Convert.ToInt32(cmbCity.SelectedValue)).Data;
			}
			catch
			{


			}
		}

	}
}
