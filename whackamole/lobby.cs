using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace whackamole
{
    public partial class lobby : Form
    {
        public SoundPlayer backsound;

        public lobby()
        {
            InitializeComponent();
            backsound = new SoundPlayer(whackamole.Properties.Resources.music_whack_mole);
            backsound.PlayLooping();
        }
        public void stop()
        {
            backsound.Stop();
        }


        private void mulai_Click(object sender, EventArgs e)
        {
            level level = new level();
            level.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
