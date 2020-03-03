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
        private void search_button_Click(object sender, EventArgs e)
        {
            string value = SearchBox.Text;
            System.Windows.Forms.MessageBox.Show(value);
        }

        private void exit_button_Click(object sender, EventArgs e)
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

        private void login_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Hier komt het login form!");
        }

        private void aanmeld_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Hier komt het aanmeld form!");
        }
    }
}
