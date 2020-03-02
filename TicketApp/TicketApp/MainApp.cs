using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //richTextBox1.AppendText("Aan het zoeken");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void info_button_click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Made by:\n" +
                "\n"+
                "Brian Vaartjes.\n" +
                "Glenn Visser.\n" +
                "Jeroen Struijk.\n" +
                "Jeroen Uijtdewilligen.\n" +
                "Sam Birahij.");
        }

        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {   
            //popup 
            //var formPopup = new Form();
            //formPopup.Show(this);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
