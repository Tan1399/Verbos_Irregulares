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
    public partial class Throw : Form
    {
        public Throw()
        {
            InitializeComponent();
        }


        public void Wake()
        {
            Wake wk = new Wake();
            wk.Show();


        }



        public void volver()
        {

            Tear tr = new Tear();
            tr.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Wake();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
