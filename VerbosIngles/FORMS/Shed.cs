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
    public partial class Shed : Form
    {
        public Shed()
        {
            InitializeComponent();
        }


        public void Shut()
        {
            Shut sh = new Shut();
            sh.Show();


        }



        public void volver()
        {

            Set st = new Set();
            st.Show();

        }


        private void Shed_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Shut();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
