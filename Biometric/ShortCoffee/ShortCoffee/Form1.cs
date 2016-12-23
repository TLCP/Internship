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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_Password.PasswordChar='*';
        }
        //Connection String. you can change this how you want. 
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Daniel Martin\Documents\MyDatabase.mdf';Integrated Security = True; Connect Timeout = 30;";

        //when clicking the exit button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //when clicking the login button
        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("No Username and/or Password entered");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from tbl_Login where UserName=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", txt_UserName.Text);
                cmd.Parameters.AddWithValue("@password", txt_Password.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show Main form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Main fm = new Main();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    
