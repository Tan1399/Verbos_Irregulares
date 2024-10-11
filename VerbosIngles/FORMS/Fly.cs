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
    public partial class Fly : Form
    {
        public Fly()
        {
            InitializeComponent();
        }

        public void Forbid()
        {
            Forbid fr = new Forbid();
            fr.Show();


        }



        public void volver()
        {

            Fall fl = new Fall();
            fl.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Forbid();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
