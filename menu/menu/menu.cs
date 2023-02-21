using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            playmenu pmenu = new playmenu();
            pmenu.ShowDialog();
            this.Close();
        }

        private void controlbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            controls cmenu = new controls();
            cmenu.ShowDialog();
            this.Close();
        }

        private void aboutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            about amenu = new about();
            amenu.ShowDialog();
            this.Close();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
