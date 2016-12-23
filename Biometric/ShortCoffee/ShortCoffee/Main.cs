using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortCoffee
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageUsers_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsersMenu ss = new ManageUsersMenu();
            ss.Show();
        }

        private void Monitor_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Monitor ss = new Monitor();
            ss.Show();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }
    }
}
