using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model.Entity;
using Presenter;

namespace CatFeeder
{
    public partial class manage_timetables : Form, Imanage_timetables
    {
        private readonly ApplicationContext _context;
        public event Action Show_goback;
        public event Action<string> Show_edit_timetable;
        public event Action<string> Remove_timetable;
        public event Action Add_timetable;

        public manage_timetables(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void manage_timetables_Load(object sender, EventArgs e)
        {
            
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Show_goback?.Invoke();
        }

        public void display_timetable_list(List<Timetable> timetablelist)
        {
            if (timetablelist == null) return;
          
            int size = timetablelist.Count;
           // MessageBox.Show(Convert.ToString(size));

            int i;
            List<Button> export_buttons = new List<Button>();
            List<Button> remove_buttons = new List<Button>();
            List<Button> edit_buttons = new List<Button>();
            List<Label> timetable_names = new List<Label>();

            for (i = 0; i < size; i++)
            {
                timetable_names.Add(new Label());
                timetable_names[i].Location = new Point(50, 50 * i);
                timetable_names[i].Width = 100;
                timetable_names[i].Visible = true;
                // timetable_names[i].Text = timetablelist[i].name;
                timetable_names[i].Text = "hello";
                Controls["timetables"].Controls.Add(timetable_names[i]);

                export_buttons.Add(new Button());
                export_buttons[i].Tag = timetablelist[i].TimetableId;
                export_buttons[i].Click += (sender, e) =>
                {
                    Button _sender = (Button)sender;
                    //Export_timetable?.Invoke((string)_sender.Tag);
                };
                export_buttons[i].Location = new Point(180, 50 * i);
                export_buttons[i].Width = 80;
                export_buttons[i].Visible = true;
                export_buttons[i].Text = "Export";
                Controls["timetables"].Controls.Add(export_buttons[i]);

                edit_buttons.Add(new Button());
                edit_buttons[i].Tag = timetablelist[i].TimetableId;
                edit_buttons[i].Click += (sender, e) =>
                {
                    Button _sender = (Button)sender;
                    Show_edit_timetable?.Invoke((string)_sender.Tag);
                };
                edit_buttons[i].Location = new Point(280, 50 * i);
                edit_buttons[i].Width = 80;
                edit_buttons[i].Visible = true;
                edit_buttons[i].Text = "Edit";
                Controls["timetables"].Controls.Add(edit_buttons[i]);

                remove_buttons.Add(new Button());
                remove_buttons[i].Tag = timetablelist[i].TimetableId;
                remove_buttons[i].Click += (sender, e) =>
                {
                    Button _sender = (Button)sender;
                    Remove_timetable?.Invoke((string)_sender.Tag);
                };
                remove_buttons[i].Location = new Point(380, 50 * i);
                remove_buttons[i].Width = 80;
                remove_buttons[i].Visible = true;
                remove_buttons[i].Text = "Remove";
                Controls["timetables"].Controls.Add(remove_buttons[i]);


            }
        }

        private void add_timetable_btn_Click(object sender, EventArgs e)
        {
            Add_timetable?.Invoke();
        }

		private void timetables_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}
	}
}
