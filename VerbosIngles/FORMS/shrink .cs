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
    public partial class shrink : Form
    {
        public shrink()
        {
            InitializeComponent();
        }


        public void Sing()
        {
            Sing si = new Sing();
            si.Show();


        }



        public void volver()
        {

            Shake sh = new Shake();
            sh.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            Sing();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
