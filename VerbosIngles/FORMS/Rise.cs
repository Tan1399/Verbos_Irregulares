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
    public partial class Rise : Form
    {
        public Rise()
        {
            InitializeComponent();
        }

        public void See()
        {
            See se = new See();
            se.Show();


        }



        public void volver()
        {

            Ring rg = new Ring();
            rg.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            See();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void Rise_Load(object sender, EventArgs e)
        {

        }
    }
}
