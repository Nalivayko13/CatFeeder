using Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CatFeeder
{
    public partial class home_admin : Form, Ihome_admin
    {
        public event Action Show_logout;
        public event Action Show_feeder_id_list;

        private readonly ApplicationContext _context;
        public home_admin(ApplicationContext context)
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

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
