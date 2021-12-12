using Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test_project
{
    public partial class adminHomePage : Form, Ihome_admin
    {
        public event Action Show_logout;
        public event Action Show_feeder_id_list;

        private readonly ApplicationContext _context;
        public adminHomePage(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void home_admin_Load(object sender, EventArgs e)
        {

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Show_logout?.Invoke();
        }

        private void Manage_feeder_ids_btn_Click(object sender, EventArgs e)
        {
            Show_feeder_id_list?.Invoke();
        }

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
