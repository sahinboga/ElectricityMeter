using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
	public partial class FrmCalculateMeter : Form
	{
		private IMeterDetailService _meterDetailService;

		int curId;
		public FrmCalculateMeter(int curId)
		{
			InitializeComponent();
			_meterDetailService = InstanceFactory.GetInstance<IMeterDetailService>();

			this.curId = curId;
		}

		private void FrmCalculateMeter_Load(object sender, EventArgs e)
		{

		}

		// Form Temizleme
		private void FormReset()
		{
			
			txtActive.Text = string.Empty;
			txtCapacitive.Text = string.Empty;
			txtInductive.Text = string.Empty;
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			if (txtActive.Text.Trim().Length == 0)
			{
				MessageBox.Show("Aktif Değer Boş Olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (txtCapacitive.Text.Trim().Length == 0)
			{
				MessageBox.Show("Kapasitif Değer Boş Olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (txtInductive.Text.Trim().Length == 0)
			{
				MessageBox.Show("Endüktif Değer Boş Olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_meterDetailService.Add(
				new MeterDetail
				{
					MeterId=this.curId,                                                                
					Active = float.Parse(txtActive.Text.Trim()),
					Capacitive = float.Parse(txtCapacitive.Text.Trim()),
					Inductive = float.Parse(txtInductive.Text.Trim()),
					ReadDate= dtpReadDate.Value
				}) ;
			FormReset();
			this.Close();
		}

		
	}
}
