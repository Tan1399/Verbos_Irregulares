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
    public partial class Stinkcs : Form
    {
        public Stinkcs()
        {
            InitializeComponent();
        }


        public void Swear()
        {
            Swear sw = new Swear();
            sw.Show();


        }



        public void volver()
        {

            Steal sl= new Steal();
            sl.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Swear();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
