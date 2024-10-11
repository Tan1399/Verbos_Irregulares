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
    public partial class Deal : Form
    {
        public Deal()
        {
            InitializeComponent();
        }

        public void atrás() {

            Creep cr = new Creep();
            cr.Show();
        
        
        
        }

        public void dig(){
            Dig dg = new Dig();

            dg.Show();

        
        
        
        }




        private void iconButton2_Click(object sender, EventArgs e)
        {
            dig();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            atrás();
            this.Hide();

        }
    }
}
