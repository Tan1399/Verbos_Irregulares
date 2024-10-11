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
    public partial class Build : Form
    {
        public Build()
        {
            InitializeComponent();
        }

        public void burn()
        {

            Burn bn = new Burn();
            bn.Show();


        }


        public void volver()
        {

            Bring br = new Bring();
            br.Show();
           

        }



        private void iconButton2_Click(object sender, EventArgs e)
        {
            burn();
            this.Hide();


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
