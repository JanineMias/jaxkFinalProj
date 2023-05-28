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
        int travType;
        public Destination()
        {
            InitializeComponent();
        }
        public void Transaction_Load(object sender, EventArgs e)
        {
            travType = AirlineType.type;
        }

            private void optA_Click(object sender, EventArgs e)
        {
            if (travType == 1)
            {
                travFare = 8000.00;
            }
            else if (travType == 2)
            {
                travFare = 12500.00;
            }
            else if (travType == 3)
            {
                travFare = 3500.00;
            }
            Form frm_transact = new Transaction();
            frm_transact.ShowDialog();
            this.Hide();
        }
        private void optB_Click(object sender, EventArgs e)
        {
            if (travType == 1)
            {
                travFare = 9800.00;
            }
            else if (travType ==2)
            {
                travFare = 12950.00;
            }
            else if(travType == 3)
            {
                travFare = 3900.00;
            }
            Form frm_transact = new Transaction();
            frm_transact.ShowDialog();
            this.Hide();
        }
        private void optC_Click(object sender, EventArgs e)
        {
            if (travType == 1)
            {
                travFare = 9100.00;
            }
            else if (travType == 2)
            {
                travFare = 10500.00;
            }
            else if (travType == 3)
            {
                travFare = 3200.00;
            }
            Form frm_transact = new Transaction();
            frm_transact.ShowDialog();
            this.Hide();
        }
        private void optD_Click(object sender, EventArgs e)
        {
            if (travType == 1)
            {
                travFare = 9850.00;
            }
            else if (travType == 2)
            {
                travFare = 10975.00;
            }
            else if (travType == 3)
            {
                travFare = 3575.00;
            }
            Form frm_transact = new Transaction();
            frm_transact.ShowDialog();
            this.Hide();
        }
        private void optE_Click(object sender, EventArgs e)
        {
            if (travType == 1)
            {
                travFare = 27450.00;
            }
            else if (travType == 2)
            {
                travFare = 37390.00;
            }
            else if (travType == 3)
            {
                travFare = 12055.00;
            }
            Form frm_transact = new Transaction();
            frm_transact.ShowDialog();
            this.Hide();
        }
        private void optF_Click(object sender, EventArgs e)
        {
            if (travType == 1)
            {
                travFare = 30890.00;
            }
            else if (travType == 2)
            {
                travFare = 39650.00;
            }
            else if (travType == 3)
            {
                travFare = 13100.00;
            }
            Form frm_transact = new Transaction();
            frm_transact.ShowDialog();
            this.Hide();
        }
        private void optG_Click(object sender, EventArgs e)
        {
            if (travType == 1)
            {
                travFare = 40450.00;
            }
            else if (travType == 2)
            {
                travFare = 45355.00;
            }
            else if (travType == 3)
            {
                travFare = 27800.00;
            }
            Form frm_transact = new Transaction();
            frm_transact.ShowDialog();
            this.Hide();
        }
        private void optH_Click(object sender, EventArgs e)
        {
            if (travType == 1)
            {
                travFare = 43855.00;
            }
            else if (travType == 2)
            {
                travFare = 49780.00;
            }
            else if (travType == 3)
            {
                travFare = 29400.00;
            }
            Form frm_transact = new Transaction();
            frm_transact.ShowDialog();
            this.Hide();
        }
        private void optI_Click(object sender, EventArgs e)
        {
            if (travType == 1)
            {
                travFare = 8505.00;
            }
            else if (travType == 2)
            {
                travFare = 12345.00;
            }
            else if (travType == 3)
            {
                travFare = 3200.00;
            }
            Form frm_transact = new Transaction();
            frm_transact.ShowDialog();
            this.Hide();
        }
        private void optJ_Click(object sender, EventArgs e)
        {
            if (travType == 1)
            {
                travFare = 14300.00;
            }
            else if (travType == 2)
            {
                travFare = 16320.00;
            }
            else if (travType == 3)
            {
                travFare = 4600.00;
            }
            Form frm_transact = new Transaction();
            frm_transact.ShowDialog();
            this.Hide();
        }
    }
}
