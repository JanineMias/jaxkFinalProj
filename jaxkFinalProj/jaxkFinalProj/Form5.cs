using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jaxkFinalProj
{
    public partial class Destination : Form
    {
        public static double travFare;
        
        public Destination()
        {
            InitializeComponent();
        }
        public void Transaction_Load(object sender, EventArgs e)
        {
            
        }
        
            private void optA_Click(object sender, EventArgs e)
        {
            if (AirlineType.type == 1)
            {
                travFare = 8000.0;
            }
            else if (AirlineType.type == 2)
            {
                travFare = 12500.0;
            }
            else if (AirlineType.type == 3)
            {
                travFare = 3500.0;
            }

            Form frm_Pass = new Passenger();
            frm_Pass.ShowDialog();
            this.Hide();
        }
        private void optB_Click(object sender, EventArgs e)
        {
            if (AirlineType.type == 1)
            {
                travFare = 9800.0;
            }
            else if (AirlineType.type == 2)
            {
                travFare = 12950.0;
            }
            else if(AirlineType.type == 3)
            {
                travFare = 3900.0;
            }

            Form frm_Pass = new Passenger();
            frm_Pass.ShowDialog();
            this.Hide();
        }
        private void optC_Click(object sender, EventArgs e)
        {
            if (AirlineType.type == 1)
            {
                travFare = 9100.0;
            }
            else if (AirlineType.type == 2)
            {
                travFare = 10500.0;
            }
            else if (AirlineType.type == 3)
            {
                travFare = 3200.0;
            }

            Form frm_Pass = new Passenger();
            frm_Pass.ShowDialog();
            this.Hide();
        }
        private void optD_Click(object sender, EventArgs e)
        {
            if (AirlineType.type == 1)
            {
                travFare = 9850.0;
            }
            else if (AirlineType.type == 2)
            {
                travFare = 10975.0;
            }
            else if (AirlineType.type == 3)
            {
                travFare = 3575.0;
            }

            Form frm_Pass = new Passenger();
            frm_Pass.ShowDialog();
            this.Hide();
        }
        private void optE_Click(object sender, EventArgs e)
        {
            if (AirlineType.type == 1)
            {
                travFare = 27450.0;
            }
            else if (AirlineType.type == 2)
            {
                travFare = 37390.0;
            }
            else if (AirlineType.type == 3)
            {
                travFare = 12055.0;
            }

            Form frm_Pass = new Passenger();
            frm_Pass.ShowDialog();
            this.Hide();
        }
        private void optF_Click(object sender, EventArgs e)
        {
            if (AirlineType.type == 1)
            {
                travFare = 30890.0;
            }
            else if (AirlineType.type == 2)
            {
                travFare = 39650.0;
            }
            else if (AirlineType.type == 3)
            {
                travFare = 13100.0;
            }

            Form frm_Pass = new Passenger();
            frm_Pass.ShowDialog();
            this.Hide();
        }
        private void optG_Click(object sender, EventArgs e)
        {
            if (AirlineType.type == 1)
            {
                travFare = 40450.0;
            }
            else if (AirlineType.type == 2)
            {
                travFare = 45355.0;
            }
            else if (AirlineType.type == 3)
            {
                travFare = 27800.0;
            }

            Form frm_Pass = new Passenger();
            frm_Pass.ShowDialog();
            this.Hide();
        }
        private void optH_Click(object sender, EventArgs e)
        {
            if (AirlineType.type == 1)
            {
                travFare = 43855.0;
            }
            else if (AirlineType.type == 2)
            {
                travFare = 49780.0;
            }
            else if (AirlineType.type == 3)
            {
                travFare = 29400.0;
            }

            Form frm_Pass = new Passenger();
            frm_Pass.ShowDialog();
            this.Hide();
        }
        private void optI_Click(object sender, EventArgs e)
        {
            if (AirlineType.type == 1)
            {
                travFare = 8505.0;
            }
            else if (AirlineType.type == 2)
            {
                travFare = 12345.0;
            }
            else if (AirlineType.type == 3)
            {
                travFare = 3200.0;
            }

            Form frm_Pass = new Passenger();
            frm_Pass.ShowDialog();
            this.Hide();
        }
        private void optJ_Click(object sender, EventArgs e)
        {
            if (AirlineType.type == 1)
            {
                travFare = 14300.0;
            }
            else if (AirlineType.type == 2)
            {
                travFare = 16320.0;
            }
            else if (AirlineType.type == 3)
            {
                travFare = 4600.0;
            }

            Form frm_Pass = new Passenger();
            frm_Pass.ShowDialog();
            this.Hide();
        }
    }
}
