using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static jaxkFinalProj.Passenger;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace jaxkFinalProj
{
    public partial class Transaction : Form
    {
        public static double totalFee, payment, change;
        public static string TInformation;
        
        public static float reference;
        // initialization of Database
        public Transaction()
        {
            InitializeComponent();
            reference = Passenger.refNum;
        }
        

        public void Transaction_Load(object sender, EventArgs e)
        {
            TInformation = Destination.travInfo;
            totalFee = passCapacity.finalTotFee;
            lblTFee.Text = Convert.ToString(totalFee);
            this.Hide();

            lblTInformation.Text = TInformation;
        }
        public void btnCalc_Click(object sender, EventArgs e)
        {
            payment = Double.Parse(txtPayment.Text);
            change = payment - totalFee;
            if (change > 0)
            {
                lblChng.Text = change.ToString();
            }
            else
            {
                MessageBox.Show("You have insufficient payment. Please input necessary amount");
                txtPayment.Clear();
                txtPayment.Focus();
            }
        }
        public void btnView_Click(object sender, EventArgs e)
        {
            // start of printing data from XAMPP into ListView
            string con1 = "Data Source =localhost; Initial Catalog =airplane database; uid = root";
            MySqlConnection cnn = new MySqlConnection(con1);
            cnn.Open();

            string astralRcpt = "Select * from `receipt details`";
            MySqlCommand cmd = new MySqlCommand(astralRcpt, cnn);
            MySqlDataReader Reader = cmd.ExecuteReader();

           

            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                lv.SubItems.Add(Reader.GetString(1).ToString());
                lv.SubItems.Add(Reader.GetString(2).ToString());
                lv.SubItems.Add(Reader.GetString(3).ToString());
                lv.SubItems.Add(Reader.GetString(4).ToString());
                
                lv.SubItems.Add(Reader.GetString(6).ToString());
                lvCustomerDetails.Items.Add(lv);

            }
            Reader.Close();
        }
        public void btnCLear_CLick(object sender, EventArgs e)
        {
          
            
        }
    }
    }
