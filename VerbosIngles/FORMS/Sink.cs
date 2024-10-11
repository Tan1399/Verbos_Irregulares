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
    public partial class Sink : Form
    {
        public Sink()
        {
            InitializeComponent();
        }

        public void Speak()
        {
            Speak sp = new Speak();
            sp.Show();


        }



        public void volver()
        {

            Sing sg = new Sing();
            sg.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Speak();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void Sink_Load(object sender, EventArgs e)
        {

        }
    }
}
