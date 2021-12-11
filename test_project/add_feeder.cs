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
    public partial class add_feeder : Form, Iadd_feeder
    {
        public event Action Show_goback;
        public event Action<string> Add_feeder;
        private readonly ApplicationContext _context;
        public add_feeder(ApplicationContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void add_feeder_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Show_goback?.Invoke();
        }

        private void add_feeder_btn_Click(object sender, EventArgs e)
        {
            Add_feeder?.Invoke(add_feeder_txtbx.Text);
        }

        private void add_feeder_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        public void Activation_result_response(short activation_result)
        {
            if (activation_result == 1) MessageBox.Show("Feeder is active ^-^");
            else if (activation_result == 0) MessageBox.Show("Wrong ID or Feeder has been already acrivated");
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
