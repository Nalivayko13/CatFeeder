using Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatFeeder
{
    public partial class Form1 : Form, Ilogin
    {
        private readonly ApplicationContext _context;

        public event Action<string, string> Show_login;
        public event Action Show_register_screen;

        public Form1(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Show_login?.Invoke(username_txtbx.Text, password_txtbx.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void password_txtbx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void no_account_btn_Click(object sender, EventArgs e)
        {
            Show_register_screen?.Invoke();
        }
    }
}
