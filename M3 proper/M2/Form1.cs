using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                if (txtPassword.Text != "")
                {
                    string password = "";
                    try
                    {
                        password = staffTableAdapter1.ScalarQuery(txtUsername.Text).ToString();
                    }
                    catch { }
                    if (password == "") MessageBox.Show("Your username is incorrect");
                    else
                    {
                        if (txtPassword.Text != password) MessageBox.Show("Incorrect Password");
                        else
                        {
                            txtPassword.Clear();
                            txtUsername.Clear();
                            Menu menu = new M2.Menu();
                            MessageBox.Show("LOGIN SUCCESSFUL");
                            this.Hide();
                            menu.Show();
                        }
                    }
                }
                else MessageBox.Show("Password Textbox is empty");
            }
            else MessageBox.Show("Username Textbox is empty");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
