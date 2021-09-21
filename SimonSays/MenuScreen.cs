using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace SimonSays
{

    public partial class MenuScreen : UserControl
    {

        public MenuScreen()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //TODO: remove this screen and start the GameScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gameScreen = new GameScreen();
            f.Controls.Add(gameScreen);

        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            //TODO: end the application
            SoundPlayer end = new SoundPlayer(Properties.Resources.end);
            end.Play();
            Application.Exit();
           
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            SoundPlayer themeSong = new SoundPlayer(Properties.Resources.themeMusic);
            themeSong.Play();
        }
    }
}
