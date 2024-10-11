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
    public partial class Shake : Form
    {
        public Shake()
        {
            InitializeComponent();
        }

        public void shrink()
        {
            shrink sh = new shrink();
            sh.Show();


        }



        public void volver()
        {

            See se = new See();
            se.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            shrink();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
                this.Hide();

        }

        private void Shake_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
