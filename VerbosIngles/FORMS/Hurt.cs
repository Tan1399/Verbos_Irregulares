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
    public partial class Hurt : Form
    {
        public Hurt()
        {
            InitializeComponent();
        }
        public void Put()
        {
            Put put = new Put();
            put.Show();


        }



        public void volver()
        {

            Hit ht = new Hit();
            ht.Show();

        }



        private void Hurt_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Put();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
