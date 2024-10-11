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
    public partial class Take : Form
    {
        public Take()
        {
            InitializeComponent();
        }


        public void Tear()
        {
            Tear tr = new Tear();
            tr.Show();


        }



        public void volver()
        {

            Swin sw = new Swin();
            sw.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Tear();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
