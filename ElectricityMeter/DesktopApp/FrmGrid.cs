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

namespace DesktopApp
{
	public partial class FrmGrid : Form
	{
		public FrmGrid()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			List<Company> companies = new List<Company>();
			companies.Add(new Company()
			{
				CompanyName = "asad",
				Address = "sdsdsds",
				DistrictId = 2,
				Phone = "2112121",
				Id = 1
			});
			dataGridView1.DataSource = companies;
		}
	}
}
