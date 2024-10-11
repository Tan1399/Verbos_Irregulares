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
    public partial class Give : Form
    {
        public Give()
        {
            InitializeComponent();
        }

        public void Go()
        {
            Go go = new Go();
            go.Show();


        }



        public void volver()
        {

            Freeze fr = new Freeze();
            fr.Show();

        }

        private void Give_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Go();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
