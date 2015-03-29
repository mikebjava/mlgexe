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

namespace MLG.exe
{
    public partial class Sanic : Form
    {
        private int ss = 13;

        public int SanicSpeed
        {
            get { return ss; }
            set { this.ss = value; }
        }

        public Sanic()
        {
            InitializeComponent();
        }

        private void Sanic_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, Utils.RandomAxis(Axis.Vertical, this.Bounds));
            SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.sanic);
            player.Play();
            sanicTimer.Start();
        }

        private void move()
        {
            this.Location = new Point(this.Location.X + ss, this.Location.Y);
            if (this.Location.X >= (Screen.PrimaryScreen.Bounds.Width - this.Width))
            {
                onSonicCompletion();
            }
        }

        private void onSonicCompletion()
        {
            sanicTimer.Stop();
            this.Visible = false;
            new DidYouSeeThat().ShowDialog();
        }

        private void sanicTimer_Tick(object sender, EventArgs e)
        {
            move();
        }

        
    }
}
