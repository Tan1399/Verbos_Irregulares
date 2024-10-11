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
    public partial class Fall : Form
    {
        public Fall()
        {
            InitializeComponent();
        }
        public void Fly()
        {
            Fly fl = new Fly();
            fl.Show();


        }



        public void volver()
        {

            Eat et = new Eat();
            et.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Fly();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();
        }
    }
}
