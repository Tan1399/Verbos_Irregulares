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
    public partial class Wear : Form
    {
        public Wear()
        {
            InitializeComponent();
        }


        public void Write()
        {
            Write wr = new Write();
            wr.Show();


        }



        public void volver()
        {

            Wake wk = new Wake();
            wk.Show();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Write();
            this.Hide();

        }
    }
}
