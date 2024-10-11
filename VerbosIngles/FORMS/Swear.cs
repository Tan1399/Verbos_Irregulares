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
    public partial class Swear : Form
    {
        public Swear()
        {
            InitializeComponent();
        }


        public void Swin()
        {
            Swin sw = new Swin();
            sw.Show();


        }



        public void volver()
        {

            Stinkcs st = new Stinkcs();
            st.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Swin();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
