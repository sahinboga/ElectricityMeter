using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
	public partial class FrmAddUpdateMeter : Form
	{
		// variables
		private IMeterService _meterService;
		private ICompanyService _companyService;
		private int curId;

		// entity
		Meter curMeter = null;


		public FrmAddUpdateMeter(int curId)
		{
			InitializeComponent();

			_meterService = InstanceFactory.GetInstance<IMeterService>();
			_companyService = InstanceFactory.GetInstance<ICompanyService>();

			LoadCompanies();

			// muhatap olduğumuz id
			this.curId = curId;

			this.Text = this.curId == 0 ? "Sayaç Ekle" : "Sayaç Güncelle";

			if (this.curId > 0)
			{
				var oMeter = _meterService.GetById(this.curId).Data;
				cmbCompany.SelectedValue = oMeter.CompanyId;
				txtMeterNo.Text = oMeter.MeterNo;
				txtSubscriberNo.Text = oMeter.SubscriberNo;
				// Todo: diğer elemanlarda basılacak
				txtMultipy.Text = (oMeter.Multipy).ToString();
				txtMeterPower.Text = (oMeter.MeterPower).ToString();

				curMeter = oMeter;
			}
		}

		// Sayaç ekleme ve güncelleme
		private void FrmAddUpdateMeter_Load(object sender, EventArgs e)
		{
			// combo ayarları
			cmbCompany.DropDownStyle = ComboBoxStyle.DropDownList;

			
		}

		// Firmaları adlarına göre comboya getirme
		private void LoadCompanies()
		{
			var companies = _companyService.GetAll().Data;
			cmbCompany.DataSource = companies;
			cmbCompany.DisplayMember = "CompanyName";
			cmbCompany.ValueMember = "Id";
		}


		// Form Temizleme
		private void FormReset()
		{
			txtMeterNo.Text = string.Empty;
			txtSubscriberNo.Text = string.Empty;
			txtMultipy.Text = string.Empty;
			txtMeterPower.Text = string.Empty;

			if (cmbCompany.Items.Count > 0)
			{
				cmbCompany.SelectedIndex = 0;
			}
		}
		private void btnSaveMeter_Click(object sender, EventArgs e)
		{
			if (curId == 0)
			{
				// add formu ise servisteki add methodunu çağır
				_meterService.Add(
						new Meter { 
							CompanyId=Convert.ToInt32(cmbCompany.SelectedValue),
							MeterNo=txtMeterNo.Text.Trim(),
							SubscriberNo=txtSubscriberNo.Text.Trim(),
							Multipy=Convert.ToInt32(txtMultipy.Text.Trim()),
							MeterPower=Convert.ToInt32(txtMeterPower.Text.Trim())
						}
					);
				FormReset();
				this.Close();
				MessageBox.Show("Sayaç Eklendi");
			}
			else
			{
				// değilse (güncelleme formuysa) servisteki update methodunu çağır
				curMeter.Id = this.curId;
				curMeter.CompanyId = Convert.ToInt32(cmbCompany.SelectedValue);
				curMeter.MeterNo = txtMeterNo.Text.Trim();
				curMeter.SubscriberNo = txtSubscriberNo.Text.Trim();
				curMeter.Multipy =int.Parse( txtMultipy.Text.Trim());
				curMeter.MeterPower = int.Parse(txtMeterPower.Text.Trim());

				var res = _meterService.Update(curMeter);

				// işlem başarılıysa
				if (res.Success)
				{
					MessageBox.Show("Sayaç Güncellendi.");
					this.Close();
				}
				else
				{
					// hata oluştu
					MessageBox.Show(res.Message);
				}
			}

		}
	}
}
