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
    public partial class Hide : Form
    {
        public Hide()
        {
            InitializeComponent();
        }

        public void know()
        {
            Know  kw=  new Know();
            kw.Show();


        }



        public void volver()
        {

            Grow gw = new Grow();
            gw.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            know();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void Hide_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
