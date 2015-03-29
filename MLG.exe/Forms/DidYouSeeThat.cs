using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace MLG.exe
{
    public partial class DidYouSeeThat : Form
    {
        private int count = 0;

        public DidYouSeeThat()
        {
            InitializeComponent();
        }

        private void DidYouSeeThat_Load(object sender, EventArgs e)
        {
            textTimer.Start();
        }

        private void textTimer_Tick(object sender, EventArgs e)
        {
            count++;

            switch (count)
            {
                case 1:
                    butwait.Visible = true;
                    SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.illuminati1);
                    soundPlayer.Play();
                    break;
                case 2:
                    butwait.Visible = false;
                    seethat.Visible = true;
                    break;
                case 3:
                    seethat.Visible = false;
                    seethatagain.Visible = true;
                    break;
                case 4:
                    new Illuminati().ShowDialog();
                    break;
                default: break;
            }
        }
    }
}
