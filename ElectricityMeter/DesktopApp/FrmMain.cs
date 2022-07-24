using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopApp
{
	public partial class FrmMain : Form
	{
		private Button currentButton;
		private Random random;
		private int tempIndex;
		private Form activeForm;

		public FrmMain()
		{
			InitializeComponent();
			random = new Random();
			btnCloseChildForm.Visible = false;
		}

		private Color SelectThemeColor()
		{
			int index = random.Next(ThemeColor.ColorList.Count);
			while (tempIndex == index)
			{
				index = random.Next(ThemeColor.ColorList.Count);
			}
			tempIndex = index;
			string color = ThemeColor.ColorList[index];
			return ColorTranslator.FromHtml(color);
		}

		private void ActivateButton(object btnSender)
		{
			if (btnSender != null)
			{
				if (currentButton != (Button)btnSender)
				{
					DisableButton();
					Color color = SelectThemeColor();
					currentButton = (Button)btnSender;
					currentButton.BackColor = Color.DarkBlue;
					currentButton.ForeColor = Color.White;
					currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					pnlTitleBar.BackColor = Color.MidnightBlue;
					pnlLogo.BackColor = Color.MidnightBlue;
					btnCloseChildForm.Visible = true;
				}
			}
		}

		private void DisableButton()
		{
			foreach (Control previousBtn in pnlMenu.Controls)
			{
				if (previousBtn.GetType() == typeof(Button))
				{
					previousBtn.BackColor = Color.MidnightBlue;
					previousBtn.ForeColor = Color.Gainsboro;
					previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.pnlDesktopPanel.Controls.Add(childForm);
			this.pnlDesktopPanel.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			lblTitle.Text = currentButton.Text.ToUpper();
		}

		private void btnCompany_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Forms.FrmCompany(), sender);

		}

		private void btnMeter_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Forms.FrmMeter(),sender);
		}

		private void btnCloseChildForm_Click(object sender, EventArgs e)
		{
			if (activeForm != null)
			{
				activeForm.Close();
				Reset();
			}
		}

		private void Reset()
		{
			DisableButton();
			lblTitle.Text = "ANASAYFA";
			pnlTitleBar.BackColor = Color.MidnightBlue;
			pnlLogo.BackColor = Color.MidnightBlue;
			currentButton = null;
			btnCloseChildForm.Visible = false;
		}
	}
}
