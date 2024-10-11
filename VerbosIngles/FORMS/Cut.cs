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
    public partial class Cut : Form
    {
        public Cut()
        {
            InitializeComponent();
        }

        public void Hit()
        {
            Hit hit = new Hit();
            hit.Show();


        }



        public void volver()
        {

            Cost ct = new Cost();
            ct.Show();

        }

        private void Cut_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Hit();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
