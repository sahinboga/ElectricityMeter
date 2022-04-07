using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
	public partial class FrmMeter : Form
	{	
		private IMeterService _meterService;

		private Form activeForm;
		private Button currentButton;
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

		private void ActivateButton(object btnSender)
		{
			if (btnSender != null)
			{
				if (currentButton != (Button)btnSender)
				{
					currentButton = (Button)btnSender;
					currentButton.ForeColor = Color.White;
				}
			}
		}
		private void OpenChildForm(Form childForm, object btnSender)
		{
			if (activeForm != null)
				activeForm.Close();
			ActivateButton(btnSender);
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.pnlMeter.Controls.Add(childForm);
			this.pnlMeter.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void btnMeterDetail_Click(object sender, EventArgs e)
		{
			var form = new FrmMeterDetail();
			OpenChildForm(form, sender);
		}
	}
}
