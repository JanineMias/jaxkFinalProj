using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace jaxkFinalProj
{
    public partial class Passenger : Form
    {
        int maxCap;
        public static double insurance,BagFee,TravFee,discount, totalFee,FinalFee;
        public static String name;
        public static int age,TravType;
        public static int count;
        public static float refNum;
        public Passenger()
        {

            InitializeComponent();
        }
        // refer to form2/AirLineType for capacity;
        public void passDetails_Load(object sender, EventArgs e)
        {
            Random ran = new Random(); 
            float refNum = ran.Next(1, 1000);
            referNum.Text = refNum.ToString();

            TravType = AirlineType.type;
            BagFee = AirlineType.BagFee;
            maxCap = AirlineType.Capacity;
            

            TravFee = Destination.travFare;
            count = passCapacity.count;
            FinalFee = passCapacity.finalTotFee;
            this.Hide();
            
        }
        private void rbtnNo_Checked(object sender, EventArgs e)
        {
            insurance = 0.00;
        }
        private void rbtnYes_Checked(object sender, EventArgs e)
        {
            // use Passenger.insurance for other form
            if (AirlineType.type == 1)
            {
                insurance = 4260.0;
            }
            else if (AirlineType.type == 2)
            {
                insurance = 5700.0;
            }
            else if (AirlineType.type == 3)
            {
                insurance = 2500.0;
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm_airType = new AirlineType();
            frm_airType.ShowDialog();
            this.Hide();
        }
        private void btnPoceed_Click(object sender, EventArgs e)
        {
            

            try
            {
                //txtName Validation
                if (txtName.Text == "")
                {
                    MessageBox.Show("INPUT NECESSARY DETAILS");
                    txtAge.Clear();
                    txtName.Clear();
                    txtName.Focus();
                }
                else
                {
                    name = txtName.Text;
                }


                //txtAge Validation
                if (txtAge.Text == "")
                {
                    MessageBox.Show("INPUT NECESSARY DETAILS");
                    txtAge.Clear();
                    txtName.Clear();
                    txtName.Focus();

                }
                else
                {
                    age = int.Parse(txtAge.Text);
                }
            }



            catch
            {
                MessageBox.Show("INVALID INPUT");
                txtAge.Clear();
                txtName.Clear();
                txtName.Focus();

                Form frm_PassDet = new Passenger();
                frm_PassDet.ShowDialog();
                this.Close();
            }


            

            if (this.maxCap == 0)
            {
                MessageBox.Show("SORRY...YOU HAVE EXCEEDED THE NUMBER OF PASSENGERS REQUIRED");
                Form frm_transact = new Transaction();
                frm_transact.ShowDialog();
                this.Close();
            }
            else
            {
                if (count == 1)
                {
                    if (age < 18)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you accomapnied by at least one (1) Adult?", "Passenger accepted to board the train", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            totalFee = TravFee + insurance + BagFee;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Must be accompanied by one (1) Adult or Senior Citizen");
                            this.Close();
                        }
                        
                        
                    }
                    else if (age < 59 || age >= 19)
                    {
                MessageBox.Show("Regular Computation applies");

                totalFee = TravFee + insurance + BagFee;
                    }
                    else if (age > 59)
                    {
                        MessageBox.Show("Tax Exempted and will get on Total Travel Destination computation only and 20% discount");
                        discount = (TravFee * .20);
                        totalFee = TravFee - discount;
                    }
                }
                else
                {
                    if (age < 18)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you accomapnied by at least one (1) Adult?", "Passenger accepted to board the train", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            totalFee = FinalFee + (TravFee + insurance + BagFee);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Must be accompanied by one (1) Adult or Senior Citizen");
                            this.Close();
                        }
                        
                        
                    }
                    else if (age < 59 || age >= 19)
                    {
                //MessageBox.Show("Regular Computation applies");

                totalFee = FinalFee + (TravFee + insurance + BagFee);
                    }
                    else if (age > 59)
                    {
                        //MessageBox.Show("Tax Exempted and will get on Total Travel Destination computation only and 20% discount");
                        discount = (TravFee * .20);
                        totalFee = FinalFee + (TravFee - discount);
                    }
                }
                sql = "Insert into `receipt details` ( `Reference Number`, `NAME`, `AGE`, `Travel Type`, `Baggage Fee`, `Travel Fee`, `Insurance Fee`) values " +
                "('" + referNum.Text + "' " +
                ",'" + name + "' " +
                ",'" + age + "' " +
                ",'" + TravType + "' " +
                ",'" + BagFee + "' " +
                ",'" + TravFee + "' " +
                ",'" + insurance + "')";
                DBConnection(sql, "unable to register passenger details", "passenger details saved to database!");

                MessageBox.Show("total fee: " + totalFee);
                Form frm_PassCap = new passCapacity();
                frm_PassCap.ShowDialog();
                this.Hide();
                this.maxCap--;

            }
           
           this.Hide();
            }
           

        //DBConnection
        MySqlConnection con = new MySqlConnection("server = localhost; userid = root; password = ; database = airplane database; ");
        MySqlCommand cmd;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        MySqlDataAdapter da;
        int Result;
        string sql;

        private void DBConnection(string sql, string msg_false, string msg_true)
        {
            //Database Connection
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                Result = cmd.ExecuteNonQuery();

                if (Result > 0) {
                    MessageBox.Show(msg_true);
                }
                else
                {
                    MessageBox.Show(msg_false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

