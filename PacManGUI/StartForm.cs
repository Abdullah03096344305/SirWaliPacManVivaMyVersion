using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacManGUI
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width = panel2.Width + 5;
            if(panel2.Width == 1360)
            {
                Form form1 = new Form1();
                form1.Show();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
