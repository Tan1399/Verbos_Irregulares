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
    public partial class Overtake : Form
    {
        public Overtake()
        {
            InitializeComponent();
        }

        public void Ride()
        {
            Ride rd = new Ride();
            rd.Show();


        }



        public void volver()
        {

            Lie le = new Lie();
            le.Show();

        }

        private void Overtake_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Ride();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
