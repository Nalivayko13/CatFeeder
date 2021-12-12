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
    public partial class edit_feeder : Form, Iedit_feeder
    {
        private readonly ApplicationContext _context;

        public event Action<string> Show_update;
       public event Action<string> Show_time_update;

        public edit_feeder(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public event Action Show_goback;

        private void back_btn_Click(object sender, EventArgs e)
        {
            Show_goback?.Invoke();
        }

        private void edit_feeder_Load(object sender, EventArgs e)
        {

        }

		private void save_btn_Click(object sender, EventArgs e)
		{
           
            Show_update?.Invoke(feeder_name_txtbx.Text);
            //MessageBox.Show("Updated");
        }

        private void feeder_name_txtbx_TextChanged(object sender, EventArgs e)
		{

		}

        public void update_result_response(short result_code)
        {
            switch (result_code)
            {
                case 0:
                    MessageBox.Show("Enter Feeder name");
                    break;
                case 1:
                    MessageBox.Show("Feeder name updated");
                    break;
            }

        }

        public void update_result_response1(short result_code)
        {
            switch (result_code)
            {
                case 0:
                    MessageBox.Show("Enter time");
                    break;
                case 1:
                    MessageBox.Show("Time updated");
                    break;
            }
        }


            private void choose_timetable_cmbbx_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
       
        }

		private void button1_Click(object sender, EventArgs e)
		{
            Show_time_update?.Invoke(textBox1.Text);
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
