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
    public partial class Grow : Form
    {
        public Grow()
        {
            InitializeComponent();
        }

        public void Hid()
        {
            Hide Hd = new Hide();
            Hd.Show();


        }



        public void volver()
        {

            Go go = new Go();
            go.Show();

        }

        private void Grow_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Hid();
            this.Hide();


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
