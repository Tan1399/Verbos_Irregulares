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
    public partial class Shut : Form
    {
        public Shut()
        {
            InitializeComponent();
        }


        public void Spread()
        {
            Spread sp = new Spread();
            sp.Show();


        }



        public void volver()
        {

            Shed sh = new Shed();
            sh.Show();

        }


        private void Shut_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Spread();
            this.Hide();
                
                }

        private void iconButton1_Click(object sender, EventArgs e) {
            volver();
            this.Hide();

        }
    }
}
