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
    public partial class Ride : Form
    {
        public Ride()
        {
            InitializeComponent();
        }

        public void Ring()
        {
            Ring rg = new Ring();
            rg.Show();


        }



        public void volver()
        {

            Overtake ov = new Overtake();
            ov.Show();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            volver();
            this.Hide();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Ring();
            this.Hide();

        }

        private void Ride_Load(object sender, EventArgs e)
        {

        }
    }
}
