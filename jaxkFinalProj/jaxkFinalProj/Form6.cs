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

        
        public static float reference;
        // initialization of Database
        public Transaction()
        {
            InitializeComponent();
            reference = Passenger.refNum;
        }
        

        public void Transaction_Load(object sender, EventArgs e)
        {
            
            
            this.Hide();
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
                lv.SubItems.Add(Reader.GetString(5).ToString());
                lv.SubItems.Add(Reader.GetString(6).ToString());
                lvCustomerDetails.Items.Add(lv);

            }
            Reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }

        
    }
