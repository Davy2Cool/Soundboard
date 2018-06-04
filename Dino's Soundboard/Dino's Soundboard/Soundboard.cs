using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Dino_s_Soundboard
{
    public partial class Soundboard : Form
    {
        public Soundboard()
        {
            InitializeComponent();
        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"1.wav");

            simpleSound.Play();
            
        }

        private void form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("The audio must be .wav! Also, the name should be the number of the button that you want it to be assigned to. Enjoy!", "Disclaimer!");
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"2.wav");

            simpleSound.Play();

        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"3.wav");

            simpleSound.Play();

        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"4.wav");

            simpleSound.Play();

        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"5.wav");

            simpleSound.Play();
        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"6.wav");

            simpleSound.Play();
        }

        private void flatButton7_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"7.wav");

            simpleSound.Play();
        }

        private void flatButton8_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"8.wav");

            simpleSound.Play();
        }

        private void flatButton9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The audio must be .wav! Also, the name should be the number of the button that you want it to be assigned to. Enjoy!", "Disclaimer!");
        }
    }
}
