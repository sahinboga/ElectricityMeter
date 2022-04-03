using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using System;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
	public partial class FrmMeter : Form
	{
		private IMeterService _meterService;
		public FrmMeter()
		{
			InitializeComponent();

			_meterService = InstanceFactory.GetInstance<IMeterService>();
		}

		private void FrmMeter_Load(object sender, EventArgs e)
		{
			LoadMeters();
		}

		private void LoadMeters()
		{
			var list = _meterService.GetAllWithDetails().Data;
			dgwMeterList.DataSource = list;
		}

		private void btnAddMeter_Click(object sender, EventArgs e)
		{
			var form = new FrmAddUpdateMeter(0);
			form.ShowDialog();
			LoadMeters();
		}

		private void btnEditMeter_Click(object sender, EventArgs e)
		{
			var id = (int)dgwMeterList.CurrentRow.Cells[0].Value;
			var form = new FrmAddUpdateMeter(id);
			form.ShowDialog();
			LoadMeters();
		}
	}
}
