using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShortCoffee
{
    public partial class AddUserMenu : Form
    {
        public AddUserMenu()
        {
            InitializeComponent();
        }
        //Connection String. you can change this how you want. 
        string cs = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Daniel Martin\Documents\Data.mdf';Integrated Security = True; Connect Timeout = 30;";
   
        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsersMenu ss = new ManageUsersMenu();
            ss.Show();
        }

        private void AddUser_Button_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(cs);
                con.Open();
                Console.WriteLine(con.ServerVersion);
                //MessageBox.Show(con.ServerVersion);

                SqlCommand cmd = new SqlCommand();//"INSERT INTO [Table] (USERNAME VARCHAR(50), PASSWORD VARCHAR(50)) Values(@USERNAME, @PASSWORD)");

                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Table (USERNAME, PASSWORD) Values(@USERNAME, @PASSWORD)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@USERNAME", EnterUserID_BOX.Text);
                cmd.Parameters.AddWithValue("@PASSWORD", CreateAPassword_BOX.Text);
                

             
                cmd.ExecuteNonQuery();
            }

            catch
            {
                MessageBox.Show("Failed!");
            }
        }
    }
}
