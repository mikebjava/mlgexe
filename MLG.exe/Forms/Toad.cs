using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLG.exe
{
    public partial class Toad : Form
    {
        public Toad()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Location = new Point(Utils.RandomBounds(this.Bounds)[0], Utils.RandomBounds(this.Bounds)[1]);
        }

        private void Toad_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Utils.RandomBounds(this.Bounds)[0], Utils.RandomBounds(this.Bounds)[1]);
        }
    }
}
