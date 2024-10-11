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
    public partial class Blow : Form
    {
        public Blow()
        {
            InitializeComponent();
        }

        public void Break()
        {
            Break br = new Break();
            br.Show();


        }



        public void volver()
        {

            Bit bi = new Bit();
            bi.Show();

        }

        private void Blow_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Break();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();
        }
    }
}
