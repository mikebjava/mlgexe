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
    public partial class Illuminati : Form
    {
        public Illuminati()
        {
            InitializeComponent();
        }

        private void Illuminati_Load(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.illuminati1);
            soundPlayer.Play();
        }
    }
}
