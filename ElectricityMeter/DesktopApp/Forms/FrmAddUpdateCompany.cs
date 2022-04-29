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
				txtMeterNo.Text = oCompany.Data.MeterNo;
				txtSubscriberNo.Text = oCompany.Data.SubscriberNo;
				txtTransformerPower.Text = oCompany.Data.TransformerPower.ToString();
				txtMeterMultipy.Text = oCompany.Data.MeterMultipy.ToString();
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
			txtMeterNo.Text = string.Empty;
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

			if (txtMeterNo.Text.Trim().Length == 0)
			{
				MessageBox.Show("Sayaç No Boş Olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (txtSubscriberNo.Text.Trim().Length == 0)
			{
				MessageBox.Show("Abone No Boş Olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (txtTransformerPower.Text.Trim().Length == 0)
			{
				MessageBox.Show("Trafo Gücü Boş Olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (txtMeterMultipy.Text.Trim().Length == 0)
			{
				MessageBox.Show("Sayaç Çarpanı Boş Olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (this.curId == 0)
			{
				// add formu ise servisteki add methodunu çağır
				_companyService.Add(
					new Company
					{
						CompanyName = txtName.Text.Trim(),
						MeterNo = txtMeterNo.Text.Trim(),
						SubscriberNo=txtSubscriberNo.Text.Trim(),
						TransformerPower=Convert.ToInt32(txtTransformerPower.Text.Trim()),
						MeterMultipy=Convert.ToInt32(txtMeterMultipy.Text.Trim()),
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
				curCompany.MeterNo = txtMeterNo.Text.Trim();
				curCompany.SubscriberNo = txtMeterNo.Text.Trim();
				curCompany.TransformerPower = int.Parse(txtMeterNo.Text.Trim());
				curCompany.MeterMultipy = int.Parse(txtMeterMultipy.Text.Trim());
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
