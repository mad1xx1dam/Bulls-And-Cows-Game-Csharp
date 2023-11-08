using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace BullsAndCows
{
    public partial class GameInfo : Form
    {
        public GameInfo()
        {
            InitializeComponent();
        }
        //если форма закрывается, то из списка открытых форм она удаляется
        private void GameInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.FormDelete(new GameInfo());
        }
    }
}
