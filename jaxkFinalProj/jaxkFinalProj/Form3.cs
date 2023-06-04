using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jaxkFinalProj
{
    public partial class passCapacity : Form
    {
        public static double inTotFee,finalTotFee;
        public static int count=1;
        public  passCapacity()
        {
            
            InitializeComponent();
            
        }
        public void passCapacity_Load(object sender, EventArgs e)
        {
            inTotFee = Passenger.totalFee;
            count = Passenger.count;
            this.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            finalTotFee = inTotFee;
            MessageBox.Show("Final Fee:" + finalTotFee);
            Form frm_transact = new Transaction();
            frm_transact.ShowDialog();
            this.Hide();
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            count++;
            finalTotFee = finalTotFee + inTotFee;
            MessageBox.Show("Final Fee:" + finalTotFee);
            Form frm_PassDet = new Passenger();
            frm_PassDet.ShowDialog();
            this.Hide();
            
        }
    }
}
