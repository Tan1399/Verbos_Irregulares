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
    public partial class Draw : Form
    {
        public Draw()
        {
            InitializeComponent();
        }

        public void drink()
        {
            Drink dr = new Drink();
            dr.Show();


        }



        public void volver()
        {

            Do d = new Do();
            d.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            drink();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void Draw_Load(object sender, EventArgs e)
        {

        }
    }
}
