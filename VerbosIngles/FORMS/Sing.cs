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
    public partial class Sing : Form
    {
        public Sing()
        {
            InitializeComponent();
        }


        public void Sink()
        {
            Sink sk = new Sink();
            sk.Show();


        }



        public void volver()
        {

            shrink sh = new shrink();
            sh.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Sink();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
