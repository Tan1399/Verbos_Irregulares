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
    public partial class Catch : Form
    {
        public Catch()
        {
            InitializeComponent();
        }

        public void cling()
        {

            Cling cl = new Cling();
            cl.Show();


        }


        public void volver()
        {

            Buy by = new Buy();
            // by.Hide();
            by.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            cling();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
