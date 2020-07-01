using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpw212Assignment1
{
    public partial class Oopsform : Form
    {
        public Oopsform()
        {
            InitializeComponent();
        }

        private void Clickmebutt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I guess I wasn't paying attention and made a form app",
                "Oops I Did It Again!",MessageBoxButtons.OK);
        }
    }
}
