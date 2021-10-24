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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            this.Hide();
            booking.Show();
        }

        private void viewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooking h = new ViewBooking();
            this.Hide();
            h.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer c = new M2.Customer();
            this.Hide();
            c.Show();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            this.Hide();
            s.Show();

        }

        
        private void sIgnInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
