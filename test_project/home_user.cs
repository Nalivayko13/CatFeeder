using Model.Entity;
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
    public partial class home_user : Form, Ihome_user
    {

        Button txtBox;
        public event Action Show_add_feeder;
        public event Action Show_manage_timetables;
        public event Action Show_logout;
        public event Action<string> Show_feeder_settings;
        public event Action<string> Show_feeder_info;

        private readonly ApplicationContext _context;
        public home_user(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void home_user_Load(object sender, EventArgs e)
        {
            
        }

        private void add_feeder_btn_Click(object sender, EventArgs e)
        {
            Show_add_feeder?.Invoke();
        }

        private void manage_timetables_btn_Click(object sender, EventArgs e)
        {
            Show_manage_timetables?.Invoke();
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            Show_logout?.Invoke();
        }

        public void display_feeder_list(List<Feeder> feederlist)
        {
            if (feederlist == null) return;
            int size = feederlist.Count;
            //int size = 10;
            int i;
            List<Button> info_buttons = new List<Button>();
            List<Button> settings_buttons = new List<Button>();
            List<Label> feeder_names = new List<Label>();
            for (i = 0; i < size; i++)
            {
                info_buttons.Add(new Button());
                info_buttons[i].Tag = "FeederID: " + feederlist[i].Feeder_id + "\nTime: it's time to feed cat";
                info_buttons[i].Click += (sender, e) =>
                {
                    Button _sender = (Button)sender;
                    MessageBox.Show((string)_sender.Tag);
                };
                info_buttons[i].Location = new Point(200, 50*i);
                info_buttons[i].Width = 140;
                info_buttons[i].Visible = true;
                info_buttons[i].Text = "Info";
                Controls["feeders"].Controls.Add(info_buttons[i]);

                settings_buttons.Add(new Button());
                settings_buttons[i].Tag = feederlist[i].Feeder_id;
                settings_buttons[i].Click += (sender, e) =>
                {
                    Button _sender = (Button)sender;
                    
                    Show_feeder_settings?.Invoke((string)_sender.Tag);
                };
                settings_buttons[i].Location = new Point( 400, 50 * i);
                settings_buttons[i].Width = 140;
                settings_buttons[i].Visible = true;
                settings_buttons[i].Text = "Settings";
                Controls["feeders"].Controls.Add(settings_buttons[i]);

                feeder_names.Add(new Label());
                feeder_names[i].Location = new Point(50, 50 * i);
                feeder_names[i].Width = 140;
                feeder_names[i].Visible = true;
                feeder_names[i].Text = feederlist[i].Name;
                Controls["feeders"].Controls.Add(feeder_names[i]);
            }
        }

		private void feeders_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
