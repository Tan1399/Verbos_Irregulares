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
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        public void DO()
        {
            Do d = new Do();
            d.Show();


        }



        public void volver()
        {

            Break br = new Break();
            br.Show();

        }

        private void Choose_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            volver();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DO();
            this.Hide();

        }
    }
}
