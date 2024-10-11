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
    public partial class Speak : Form
    {
        public Speak()
        {
            InitializeComponent();
        }


        public void Steal()
        {
            Steal st = new Steal();
            st.Show();


        }



        public void volver()
        {

            Sink sk = new Sink();
            sk.Show();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Steal();
            this.Hide();

        }
    }
}
