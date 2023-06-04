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
        public static double insurance,BagFee,TravFee,discount;
        public static String name;
        public static int age,count,TravType;
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
            insurance = AirlineType.travIn;

            TravFee = Destination.travFare;
            this.Hide();
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


                //Age Validation
                if (age < 18)
                {
                    MessageBox.Show("Cannot travel alone and must be accompanied by at least one (1) Adult and/or Senior Citizen");
                }
                else if (age < 59 || age >= 19)
                {
                    MessageBox.Show("Regular Computation applies");
                }
                else if (age > 59)
                {
                    discount = TravFee - (TravFee * .20);
                    MessageBox.Show("Tax Exempted and will get on Total Travel Destination computation only and 20% discount");
                }

                

            }
            catch {
                MessageBox.Show("INVALID INPUT");
                txtAge.Clear();
                txtName.Clear();
                txtName.Focus();

                Form frm_PassDet = new Passenger();
                frm_PassDet.ShowDialog();
                this.Hide();
            }
            sql = "Insert into `receipt details` ( `Reference Number`, `NAME`, `AGE`, `Travel Type`, `Baggage Fee`, `Travel Fee`, `Insurance Fee`) values " +
                "('" + referNum.Text + "' " +
                ",'" +name+ "' " +
                ",'" +age+ "' " +
                ",'" +TravType+ "' " +
                ",'" +BagFee+ "' " +
                ",'" +TravFee + "' " +
                ",'" +insurance+ "')";
            DBConnection(sql, "unable to register passenger details", "passenger details saved to database!");

            if (this.maxCap == 0)
            {
                MessageBox.Show("SORRY...YOU HAVE EXCEEDED THE NUMBER OF PASSENGERS REQUIRED");
            }
            else
            {
                Form frm_PassCap = new passCapacity();
                frm_PassCap.ShowDialog();
                this.Hide();
                this.maxCap--;

            }

           this.Hide();
            }
            


            // relate this with form6 ( auto load/ display)
        

        private void rbtnNo_Checked(object sender, EventArgs e)
        {
           insurance = 0;

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
                insurance = 2500;
            }

           
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

