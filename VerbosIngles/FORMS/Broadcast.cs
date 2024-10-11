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
    public partial class Broadcast : Form
    {
        public Broadcast()
        {
            InitializeComponent();
        }

        public void Burst() {
            Burst burst = new Burst();
            burst.Show();
        
        
        }


        public void volver() {

            bet bt = new bet();
            bt.Show();
        
        }

        private void Broadcast_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Burst();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
