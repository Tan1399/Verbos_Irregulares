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
    public partial class Breed : Form
    {
        public Breed()
        {
            InitializeComponent();
        }

        public void bring()
        {

            Bring bg = new Bring();
            bg.Show();


        }


        public void volver()
        {

            Bleed bl = new Bleed();
            bl.Show();
       

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            bring();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
