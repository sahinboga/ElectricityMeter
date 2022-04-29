using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
	public partial class FrmMeterDetail : Form
	{
		
		private IMeterDetailService _meterDetailService;
		private IMeterService _meterService;

		int curId;
		public FrmMeterDetail(int curId)
		{
			InitializeComponent();
			_meterDetailService = InstanceFactory.GetInstance<IMeterDetailService>();
			_meterService = InstanceFactory.GetInstance<IMeterService>();

			this.curId = curId;
			
		}

		private void FrmMeterDetail_Load(object sender, EventArgs e)
		{
			LoadMeterDetails();

			
			var company = _meterService.GetAllWithDetails().Data.Find(m => m.Id == this.curId).CompanyName;
			lblCompanyName.Text = company;
		}

		private void LoadMeterDetails()
		{
			var res = _meterDetailService.GetAllWithDetails(this.curId);
			dgwMeterDetail.DataSource = res.Data;

		}

		private void btnCalculateMeter_Click(object sender, EventArgs e)
		{
			var form = new FrmCalculateMeter(this.curId);
			form.ShowDialog();
			LoadMeterDetails();
		}
	}
}
