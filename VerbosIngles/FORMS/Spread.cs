using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace VerbosIngles.FORMS
{
    public partial class Spread : Form
    {

        private SpeechSynthesizer synth;
        public Spread()
        {
            InitializeComponent();

            synth = new SpeechSynthesizer();

            // Configurar el evento Click para el Label
            label2.Click += new EventHandler(label2_Click);
        }

        public void inicio()
        {
            Form1 f1 = new Form1();
            f1.Show();


        }



        public void volver()
        {

            Shut sh = new Shut();
            sh.Show();

        }

        private void Spread_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            inicio();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string wordToSpeak = "Spread";

            // Pronunciar la palabra
            synth.SpeakAsync(wordToSpeak);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Liberar los recursos del sintetizador de voz
            synth.Dispose();
            base.OnFormClosing(e);
        }
    }
}
