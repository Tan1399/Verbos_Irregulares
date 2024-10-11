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
    public partial class Lie : Form
    {
        public Lie()
        {
            InitializeComponent();
        }

        public void Overtake()
        {
            Overtake ov = new Overtake();
            ov.Show();


        }



        public void volver()
        {

            Know kn = new Know();
            kn.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Overtake();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void Lie_Load(object sender, EventArgs e)
        {

        }
    }
}
