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
    public partial class controls : Form
    {
        public controls()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.ShowDialog();
            this.Close();
        }
    }
}
