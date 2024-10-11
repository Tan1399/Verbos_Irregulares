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
    public partial class Eat : Form
    {
        public Eat()
        {
            InitializeComponent();
        }
        public void Fall()
        {
            Fall Fl = new Fall();
            Fl.Show();


        }



        public void volver()
        {

            Drive dr = new Drive();
            dr.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Fall();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
