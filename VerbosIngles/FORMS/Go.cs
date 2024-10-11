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
    public partial class Go : Form
    {
        public Go()
        {
            InitializeComponent();
        }

        public void Grow()
        {
            Grow Gr = new Grow();
            Gr.Show();


        }



        public void volver()
        {

            Give gv = new Give();
            gv.Show();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Grow();
            this.Hide();

        }

        private void Go_Load(object sender, EventArgs e)
        {

        }
    }
}
