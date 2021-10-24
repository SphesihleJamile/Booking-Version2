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

namespace M2
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        
        private void addCustButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(this.customerTableAdapter.doesEmailExist(txtEmail.Text)) == 0)
            {
                if (txtAddress.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtPhone.Text == "")
                    MessageBox.Show("Fill in the missing data", "Incomplete Data");
                else
                {
                    if (txtPhone.Text.Length > 10) MessageBox.Show("A phone number cannot be more than 10 digits");
                    else
                    {
                        customerBindingSource.EndEdit();
                        customerTableAdapter.InsertQuery(txtName.Text, txtEmail.Text, txtPhone.Text, txtAddress.Text);
                        MessageBox.Show("1 Customer Successfully Added");
                    }
                }
            }
            else
            {
                MessageBox.Show("Email Already Exists");
            }
            
        }

        private void populate()
        {
            
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group11DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.group11DataSet.Customer);

        }

        private void custDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void deleteCustButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                customerTableAdapter.DeleteQuery(txtEmail.Text);

                this.customerTableAdapter.Fill(group11DataSet.Customer);
                MessageBox.Show("1 Row Successfully Deleted");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtPhone.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu menu = new M2.Menu();
            this.Hide();
            menu.Show();
        }

        private void editCustButton_Click(object sender, EventArgs e)
        {
            this.customerBindingSource.EndEdit();
            this.customerTableAdapter.Update(this.group11DataSet.Customer);
            this.customerTableAdapter.Fill(this.group11DataSet.Customer);
        }
    }
}
