using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace VerbosIngles.FORMS
{
    public partial class Bind : Form
    {

        private WMPLib.WindowsMediaPlayer Player;
        private WindowsMediaPlayer player;
        public Bind()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
        }
    

        public void bleed()
        {

            Bleed bl = new Bleed();
            bl.Show();


        }

        public string bind()
        {





            try
            {
                string carpeta = "Audios";
                string archivo = "Bind.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }
        }


        public string Bound()
        {


            try
            {
                string carpeta = "Audios";
                string archivo = "Bound.mp3";
                string rutaDinamica = Path.Combine(Directory.GetCurrentDirectory(), carpeta, archivo);



                return rutaDinamica;




            }

            catch

            {

                MessageBox.Show("AUDIO NO ENCONTRADO");
                return string.Empty;

            }

        }


        public void volver()
        {

            Bent bt = new Bent();
            bt.Show();
           

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            bleed();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void Bind_Load(object sender, EventArgs e)
        {

        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = Bound();
            player.URL = ruta;
            player.controls.play();



        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = Bound();
            player.URL = ruta;
            player.controls.play();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            string ruta = bind();
            player.URL = ruta;
            player.controls.play();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
