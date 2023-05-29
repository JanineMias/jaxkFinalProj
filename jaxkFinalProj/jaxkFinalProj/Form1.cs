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
    public partial class wcPage : Form
    {
        public wcPage()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm_AirType = new AirlineType();
            frm_AirType.ShowDialog();
            this.Close();
        }
    }
}
