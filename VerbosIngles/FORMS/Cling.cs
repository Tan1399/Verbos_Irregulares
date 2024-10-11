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
    public partial class Cling : Form
    {
        public Cling()
        {
            InitializeComponent();
        }

        public void Catch()
        {

            Creep cp = new Creep();
            cp.Show();


        }


        public void volver()
        {
            Catch ch = new Catch();
            ch.Show();

        }


            private void iconButton2_Click(object sender, EventArgs e)
        {

            Catch();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
