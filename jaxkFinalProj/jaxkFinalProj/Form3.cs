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
    public partial class passCapacity : Form
    {

        public  passCapacity()
        {
            
            InitializeComponent();
            
        }
      

        private void btnNo_Click(object sender, EventArgs e)
        {
            Form frm_Desti = new Destination();
            frm_Desti.ShowDialog();
            this.Hide();
        }
        private void btnYes_Click(object sender, EventArgs e)
        {  
            
            Form frm_PassDet = new Passenger();
            frm_PassDet.ShowDialog();
            this.Hide();
            
        }
    }
}
