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
    public partial class Booking : Form
    {
        

        public Booking()
        {
            InitializeComponent();
        }

        public string TodaysDate()
        {
            return DateTime.Now.ToString("MM/dd/yyyy");
        }
        public string TodaysYear()
        {
            return TodaysDate().Substring(6, 4);
        }
        public string TodaysMonth()
        {
            return TodaysDate().Substring(0, 2);
        }
        public string TodaysDay()
        {
            return TodaysDate().Substring(3, 2);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        public string Tables()
        {
            string tables = "";
            if (chkCCTable.Checked) tables += "Conference Centre, ";
            if (chkChapelTables.Checked) tables += "Chapel, ";
            if (chkCLCTable.Checked) tables += "Christian Life Centre, ";
            if (chkJDTables.Checked) tables += "Jesus Dome, ";

            if (tables.Length > 2)
                return tables.Substring(0, tables.Length - 2);
            else
                return tables;
        }

        public string Lights()
        {
            string lights = "";
            if(chkCCLight.Checked) lights += "Conference Centre, ";
            if (chkChapelLight.Checked) lights += "Chapel, ";
            if (chkCLCLight.Checked) lights += "Christian Life Centre, ";
            if (chkJDLight.Checked) lights += "Jesus Dome, ";

            if (lights.Length > 2)
                return lights.Substring(0, lights.Length - 2);
            else
                return lights;
        }
        public int GetHour(string t)
        {
            string val = t.Substring(0, 2);
            return Convert.ToInt16(val);
        }

        private bool isDoubleBooked()
        {
            DateTime today = Convert.ToDateTime(date.Text);
            int x = Convert.ToInt16(this.bookingTableAdapter1.isDoubleBooked(today).ToString());
            if (x > 0 || x < 0)
            {
                string v = this.bookingTableAdapter1.getVenue(today).ToString();
                if (cmbVenue.Text == v)
                {
                    int dataStart = GetHour((this.bookingTableAdapter1.getStartTimeFromDate(today)).ToString());
                    int currentStart = GetHour(startTime.Text);

                    int dataEnd = GetHour((this.bookingTableAdapter1.getEndTimeFromDate(today)).ToString());
                    int currentEnd = GetHour(endTime.Text);

                    if (currentStart >= dataStart && currentStart <= dataEnd)
                        return true;
                    else if (currentEnd <= dataEnd && currentEnd >= dataStart)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool didBookDayAhead()
        {
            DateTime dateBooked = Convert.ToDateTime(date.Text);
            int todaysDay = Convert.ToInt16(TodaysDay()); 
            int todaysMonth = Convert.ToInt16(TodaysMonth());
            int todaysYear = Convert.ToInt16(TodaysYear());

            int dayBooked = Convert.ToInt16(dateBooked.Day.ToString());
            int monthBooked = Convert.ToInt16(dateBooked.Month.ToString());
            int yearBooked = Convert.ToInt16(dateBooked.Year.ToString());

            if (todaysYear < yearBooked)
                return true;
            else if (todaysYear > yearBooked)
                return false;
            else
            {
                if (todaysMonth < monthBooked)
                    return true;
                else if (todaysMonth > monthBooked)
                    return false;
                else
                {
                    if (todaysDay < dayBooked)
                        return true;
                    else if (todaysDay > dayBooked)
                        return false;
                    else return false;
                }
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DateTime currentDate = Convert.ToDateTime(date.Text);
            



            if (!didBookDayAhead()) MessageBox.Show("You cannot book a previous day, or the current day");
            else if (isDoubleBooked()) MessageBox.Show("This day has already been booked");
            else
            {
                string eventType = "";
                if (radFuneral.Checked) eventType = "Funeral";
                else if (radOther.Checked) eventType = "Other";
                else if (radSeminar.Checked) eventType = "Seminar";
                else if (radWedding.Checked) eventType = "Wedding";
                int custID = -1;
                try
                {
                    custID = Convert.ToInt16(this.customerTableAdapter1.getCustID(txtName.Text).ToString());
                }
                catch
                {
                    MessageBox.Show("This customer does not exist");
                }


                int numberOfGuests = Convert.ToInt16(txtNoOfGuests.Text);

                int sound = 0;
                if (chkSoundEquipment.Checked) sound = 1;
                else sound = 0;

                string tables = Tables();
                string lights = Lights();
                double total = Convert.ToDouble(txtBalance.Text);
                if (custID != -1)
                {
                    try
                    {
                        this.bookingTableAdapter1.InsertQuery(custID, currentDate, startTime.Text, endTime.Text, eventType, cmbVenue.Text, numberOfGuests, (sound == 1), tables, lights, total);
                        MessageBox.Show("You have successfully booked the " + date.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu m = new M2.Menu();
            this.Hide();
            m.Show();
        }

        private double CalculateTax(double value)
        {
            return value * 0.14;
        }
        private void cmbVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVenue.SelectedIndex == 0)
            {
                txtTotal.Text = (Convert.ToDouble(txtTotal.Text) + 40000).ToString();
                txtVatIncluded.Text = (Convert.ToDouble(txtVatIncluded.Text) + CalculateTax(40000)).ToString();
                txtNoOfGuests.Text = "4000";
            }
            if (cmbVenue.SelectedIndex == 1)
            {
                txtTotal.Text = (Convert.ToDouble(txtTotal.Text) + 25000).ToString();
                txtVatIncluded.Text = (Convert.ToDouble(txtVatIncluded.Text) + CalculateTax(25000)).ToString();
                txtNoOfGuests.Text = "2000";
            }
            if(cmbVenue.SelectedIndex == 2)
            {
                txtTotal.Text = (Convert.ToDouble(txtTotal.Text) + 7500).ToString();
                txtVatIncluded.Text = (Convert.ToDouble(txtVatIncluded.Text) + CalculateTax(7500)).ToString();
                txtNoOfGuests.Text = "800";
            }
            if(cmbVenue.SelectedIndex == 3)
            {
                txtTotal.Text = (Convert.ToDouble(txtTotal.Text) + 3500).ToString();
                txtVatIncluded.Text = (Convert.ToDouble(txtVatIncluded.Text) + CalculateTax(3500)).ToString();
                txtNoOfGuests.Text = "400";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            chkCCLight.Checked = false;
            chkChapelLight.Checked = false;
            chkChapelTables.Checked = false;
            chkCLCLight.Checked = false;
            chkCLCTable.Checked = false;
            chkJDLight.Checked = false;
            chkJDTables.Checked = false;
            chkSoundEquipment.Checked = false;
            chkCCTable.Checked = false;

            txtDeposit.Text = "0";
            txtBalance.Text = "0";
            txtDeposit.Text = "0";
            txtDiscount.Text = "0";
            txtName.Clear();
            txtNoOfGuests.Text = "0";
            txtTotal.Text = "0";
            txtVatIncluded.Text = "0";
            
            cmbVenue.Text = "";

            if (radFuneral.Checked)
                radFuneral.Checked = false;
            else if (radOther.Checked)
                radOther.Checked = false;
            else if (radSeminar.Checked)
                radSeminar.Checked = false;
            else if (radWedding.Checked)
                radWedding.Checked = false;
        }

        private void chkJDLight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJDLight.Checked == true)
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtJDLightPrice.Text)));
                double amount = Convert.ToDouble(txtJDLightPrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) + vat;
                double total = Convert.ToDouble(txtTotal.Text) + amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();
                


            }
            else
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtJDLightPrice.Text)));
                double amount = Convert.ToDouble(txtJDLightPrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) - vat;
                double total = Convert.ToDouble(txtTotal.Text) - amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();
                

            }
        }

        private void chkCLCLight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCLCLight.Checked == true)
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtCLCLightPrice.Text)));
                double amount = Convert.ToDouble(txtCLCLightPrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) + vat;
                double total = Convert.ToDouble(txtTotal.Text) + amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();
                
            }
            else
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtCLCLightPrice.Text)));
                double amount = Convert.ToDouble(txtCLCLightPrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) - vat;
                double total = Convert.ToDouble(txtTotal.Text) - amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();
                
            }
        }

        private void chkCCLight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCCLight.Checked == true)
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtCCLightPrice.Text)));
                double amount = Convert.ToDouble(txtCCLightPrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) + vat;
                double total = Convert.ToDouble(txtTotal.Text) + amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();
                
            }
            else
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtCCLightPrice.Text)));
                double amount = Convert.ToDouble(txtCCLightPrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) - vat;
                double total = Convert.ToDouble(txtTotal.Text) - amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();
                
            }
        }

        private void chkChapelLight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChapelLight.Checked == true)
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtChapelLightPrice.Text)));
                double amount = Convert.ToDouble(txtChapelLightPrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) + vat;
                double total = Convert.ToDouble(txtTotal.Text) + amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();
            }
            else
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtChapelLightPrice.Text)));
                double amount = Convert.ToDouble(txtChapelLightPrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) - vat;
                double total = Convert.ToDouble(txtTotal.Text) - amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();
            }
        }

        private void chkJDTables_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJDTables.Checked == true)
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtJDTablePrice.Text)));
                double amount = Convert.ToDouble(txtJDTablePrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) + vat;
                double total = Convert.ToDouble(txtTotal.Text) + amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();

            }
            else
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtJDTablePrice.Text)));
                double amount = Convert.ToDouble(txtJDTablePrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) - vat;
                double total = Convert.ToDouble(txtTotal.Text) - amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();

                
            }
        }

        private void chkCLCTable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCLCTable.Checked == true)
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtCLCTablePrice.Text)));
                double amount = Convert.ToDouble(txtCLCTablePrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) + vat;
                double total = Convert.ToDouble(txtTotal.Text) + amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();
                
            }
            else
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtCLCTablePrice.Text)));
                double amount = Convert.ToDouble(txtCLCTablePrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) - vat;
                double total = Convert.ToDouble(txtTotal.Text) - amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();
            }
        }

        private void chkCCTable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCCTable.Checked == true)
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtCCTablePrice.Text)));
                double amount = Convert.ToDouble(txtCCTablePrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) + vat;
                double total = Convert.ToDouble(txtTotal.Text) + amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();
            }
            else
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtCCTablePrice.Text)));
                double amount = Convert.ToDouble(txtCCTablePrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) - vat;
                double total = Convert.ToDouble(txtTotal.Text) - amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();
            }
        }

        private void chkChapelTables_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChapelTables.Checked == true)
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtChapTablePrice.Text)));
                double amount = Convert.ToDouble(txtChapTablePrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) + vat;
                double total = Convert.ToDouble(txtTotal.Text) + amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();
            }
            else
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtChapTablePrice.Text)));
                double amount = Convert.ToDouble(txtChapTablePrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) - vat;
                double total = Convert.ToDouble(txtTotal.Text) - amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();
            }
        }

        private void chkSoundEquipment_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSoundEquipment.Checked == true)
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtSoundPrice.Text)));
                double amount = Convert.ToDouble(txtSoundPrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) + vat;
                double total = Convert.ToDouble(txtTotal.Text) + amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();
            }
            else
            {
                double vat = Convert.ToDouble(CalculateTax(Convert.ToDouble(txtSoundPrice.Text)));
                double amount = Convert.ToDouble(txtSoundPrice.Text);

                double vatIncluded = Convert.ToDouble(txtVatIncluded.Text) - vat;
                double total = Convert.ToDouble(txtTotal.Text) - amount;

                txtVatIncluded.Text = vatIncluded.ToString();
                txtTotal.Text = total.ToString();
            }
        }

        private void txtJDLightPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(!(txtTotal.Text=="" && txtTotal.Text=="" && txtDiscount.Text==""))
            {
                try
                {
                    double total = Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtDiscount.Text) - Convert.ToDouble(txtDeposit.Text);
                    if(total<0)
                    {
                        MessageBox.Show("Balance Cannot Be Less Than 0");
                    }
                    else
                    {
                        txtBalance.Text = total.ToString();
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(txtTotal.Text==""))
            {
                try
                {
                    txtDiscount.Text = (Convert.ToDouble(txtTotal.Text) * 0.15).ToString();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
