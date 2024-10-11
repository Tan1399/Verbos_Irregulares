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
    public partial class Break : Form
    {
        public Break()
        {
            InitializeComponent();
        }
        public void Choos()
        {
             Choose ch= new Choose();
            ch.Show();


        }



        public void volver()
        {

            Blow bl = new Blow();
            bl.Show();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Choos();
            this.Hide();

        }

        private void Break_Load(object sender, EventArgs e)
        {

        }
    }
}
