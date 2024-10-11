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
    public partial class See : Form
    {
        public See()
        {
            InitializeComponent();
        }

        public void Shake()
        {
            Shake sh = new Shake();
            sh.Show();


        }



        public void volver()
        {

            Rise rs = new Rise();
            rs.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            Shake();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void See_Load(object sender, EventArgs e)
        {

        }
    }
}
