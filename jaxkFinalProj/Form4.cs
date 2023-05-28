using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jaxkFinalProj
{
    public partial class Passenger : Form
    {
        int maxCap;
        double insurance;
        public Passenger()
        {
            
            InitializeComponent();
        }
        // refer to form2/AirLineType for capacity;
        public void passDetails_Load(object sender, EventArgs e)
        {
             
            maxCap = AirlineType.Capacity;
            insurance = AirlineType.travIn;
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
        }

        private void rbtnNo_Checked(object sender, EventArgs e)
        {
            this.insurance = 0;
        }
        private void rbtnYes_Checked(object sender, EventArgs e)
        {
            
        }
    }
}
