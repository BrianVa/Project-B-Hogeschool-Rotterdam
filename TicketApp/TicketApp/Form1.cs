using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TicketApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void PlaySound(string sound)
        {
            
            switch (sound)
            {
                case "beep":
                    System.Media.SystemSounds.Beep.Play();
                    break;
                case "Question":
                    System.Media.SystemSounds.Question.Play();
                    break;
                case "cough":
                    SoundPlayer splayer = new SoundPlayer(@"C:\Users\Brian V\Documents\GitHub\ProjectB\TicketApp\sounds\Cough.wav");
                    splayer.Play();
                    break;
                default:
                    System.Media.SystemSounds.Beep.Play();
                    break;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PlaySound("cough");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.checkBox1.Checked)
            {
                System.Windows.Forms.MessageBox.Show("je moet wel akkoord gaan !");
            }
            else
            {
                this.timer1.Start();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.progressBar1.Value >= 100)
            {
                this.timer1.Stop();
                PlaySound("beep");
                System.Windows.Forms.MessageBox.Show("We did it boys, Corona is no more!");
                Environment.Exit(0);
            }
            else {
                this.progressBar1.Increment(2);
            }
            
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Corona Defeat squad!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
