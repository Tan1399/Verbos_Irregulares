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
    public partial class Know : Form
    {
        public Know()
        {
            InitializeComponent();
        }

        public void Lie()
        {
            Lie le = new Lie();
            le.Show();


        }



        public void volver()
        {

            Hide Hd = new Hide();
            Hd.Show();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Close();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Lie();
            this.Close();

        }
    }
}
