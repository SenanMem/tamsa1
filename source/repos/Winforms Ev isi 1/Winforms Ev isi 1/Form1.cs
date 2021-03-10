using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_Ev_isi_1
{
    public partial class BakuOrLondon : Form
    {
        public BakuOrLondon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sender is Button bt)
            {
                bt.Dispose();
                this.BackgroundImage.Dispose();
                this.BackgroundImage = Properties.Resources.Bakuu;
            } 
        }
    }
}
