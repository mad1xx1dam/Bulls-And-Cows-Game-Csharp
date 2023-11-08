using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCows
{
    public partial class Lose : Form
    {
        public Lose()
        {
            InitializeComponent();
        }

        private void Lose_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.FormDelete(new Lose());
        }
    }
}
