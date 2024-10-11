using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerbosIngles.FORMS
{
    public partial class Dig : Form
    {
        public Dig()
        {
            InitializeComponent();
        }

        public void volver() {

            Deal dl = new Deal();
            dl.Show();

        }


        public void dream() {

            Dream dm = new Dream();
            dm.Show();
        
        
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            dream();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            volver();
            this.Hide();

        }
    }
}
