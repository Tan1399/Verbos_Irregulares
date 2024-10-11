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
    public partial class Drink : Form
    {
        public Drink()
        {
            InitializeComponent();
        }
        public void drive()
        {
            Drive dr = new Drive();
            dr.Show();


        }



        public void volver()
        {

            Draw dw = new Draw();
            dw.Show();

        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            drive();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();
        }
    }
}
