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
    public partial class Ring : Form
    {
        public Ring()
        {
            InitializeComponent();
        }

        public void Rise()
        {
            Rise rs = new Rise();
            rs.Show();


        }



        public void volver()
        {

            Ride rd = new Ride();
            rd.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Rise();
                this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void Ring_Load(object sender, EventArgs e)
        {

        }
    }
}
