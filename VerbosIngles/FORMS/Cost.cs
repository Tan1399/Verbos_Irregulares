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
    public partial class Cost : Form
    {
        public Cost()
        {
            InitializeComponent();
        }


        public void Cut()
        {
            Cut cut = new Cut();
            cut.Show();


        }



        public void volver()
        {

            Burst br = new Burst();
            br.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cost_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            Cut();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
