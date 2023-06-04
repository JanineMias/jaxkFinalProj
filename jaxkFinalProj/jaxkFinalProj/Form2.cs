using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace jaxkFinalProj
{
    public partial class AirlineType : Form
    {
        public static int Capacity,type;
        public static double transFee, travTax,travIn,BagFee;
       
        public AirlineType()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        public void btnPri_Click(object sender, EventArgs e)
        {
            type = 1;
            Capacity = 14;
            transFee = 550.0;
            travTax = 4260.0;
            travIn = 4500.0;
            BagFee = 1250.0;
            Form frm_PassDet = new Destination();
            frm_PassDet.ShowDialog();
            this.Hide();
            
        }
        public  void btnBus_Click(object sender, EventArgs e)
        {
            type = 2;
            Capacity = 23;
            transFee = 550.0;
            travTax = 5700.0;
            travIn = 6500.0;
            BagFee = 2850.0;
            Form frm_PassDet = new Destination();
            frm_PassDet.ShowDialog();
            this.Hide();

        }
        public  void btnReg_Click(object sender, EventArgs e)
        {
            type = 3;
            Capacity = 48;
            transFee = 255.0;
            travTax = 2500.0;
            travIn = 950.0;
            BagFee = 950;
            Form frm_PassDet = new Destination();
            frm_PassDet.ShowDialog();
            this.Hide();

        }
      

    }
}
