using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerbosIngles.FORMS
{
    public partial class Bleed : Form
    {
        public Bleed()
        {
            InitializeComponent();
        }


        public string bled() {
            try
            {
                string carpeta = "Audios";
                string archivo = "Bled.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }






        }

        public string bleed()
        {
            try
            {
                string carpeta = "Audios";
                string archivo = "Bleed.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }






        }



        public void breed()
        {

            Breed bd = new Breed();
            bd.Show();


        }


        public void volver()
        {

            Bind bd = new Bind();
            bd.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            breed();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Bleed_Load(object sender, EventArgs e)
        {

        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            bled();
        }
        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            bled();

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            bleed();
         
        }
    }
}
