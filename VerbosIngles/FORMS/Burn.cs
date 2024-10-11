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
    public partial class Burn : Form
    {
        public Burn()
        {
            InitializeComponent();
        }
        //creacion de funciones
        public void buy()
        {

            Buy by = new Buy();
            by.Show();


        }

        public void volver()
        {

            Build bl = new Build();
            // bl.Hide();
            bl.Show();

        }

        //ejecucion de botones
        private void iconButton2_Click(object sender, EventArgs e)
        {
            buy();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
