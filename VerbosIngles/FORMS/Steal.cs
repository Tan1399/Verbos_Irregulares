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
    public partial class Steal : Form
    {
        public Steal()
        {
            InitializeComponent();
        }


        public void Stinkcs()
        {
            Stinkcs st = new Stinkcs();
            st.Show();


        }



        public void volver()
        {

            Speak sp = new Speak();
            sp.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Stinkcs();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
