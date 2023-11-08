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
    public partial class Authorcs : Form
    {
        public Authorcs()
        {
            InitializeComponent();
        }
        //если форма закрывается, то из списка открытых форм она удаляется
        private void Authorcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.FormDelete(new Authorcs());
        }
    }
}
