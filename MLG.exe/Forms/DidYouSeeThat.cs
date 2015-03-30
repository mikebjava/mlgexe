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
        private Random r = new Random();

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
                    this.Visible = false;

                    for (int i = 0; i < r.Next(10) + 10; i++)
                    {
                        BackgroundWorker workerToad = new BackgroundWorker();
                        workerToad.DoWork += spawnToad;
                        workerToad.RunWorkerAsync();
                        BackgroundWorker workerIlluminati = new BackgroundWorker();
                        workerIlluminati.DoWork += spawnIlluminati;
                        workerIlluminati.RunWorkerAsync();
                    }

                    break;
                default: break;
            }
        }

        private void spawnToad(object sender, DoWorkEventArgs e)
        {
            new Toad().ShowDialog();
        }

        private void spawnIlluminati(object sender, DoWorkEventArgs e)
        {
            new Illuminati().ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            
        }
    }
}
