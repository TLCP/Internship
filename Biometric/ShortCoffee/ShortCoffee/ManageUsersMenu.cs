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
    public partial class ManageUsersMenu : Form
    {
        public ManageUsersMenu()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Main ss = new Main();
            ss.Show();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUser_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUserMenu ss = new AddUserMenu();
            ss.Show();
        }
    }
}
