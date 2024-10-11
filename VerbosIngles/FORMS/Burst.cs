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
    public partial class Burst : Form
    {
        public Burst()
        {
            InitializeComponent();
        }

        public void Cost()
        {
            Cost cost = new Cost();
            cost.Show();


        }


        public void volver()
        {

            Broadcast br = new Broadcast();
            br.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Burst_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Cost();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
