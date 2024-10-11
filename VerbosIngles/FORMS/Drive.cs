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
    public partial class Drive : Form
    {
        public Drive()
        {
            InitializeComponent();
        }

        public void Eat()
        {
            Eat et = new Eat();
            et.Show();


        }



        public void volver()
        {

            Drink dr = new Drink();
            dr.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Eat();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
