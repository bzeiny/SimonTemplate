using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //TODO: create guess variable to track what part of the pattern the user is at
        public static int userGuess;
        Random randGen = new Random();
        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //TODO: clear the pattern list from form1, refresh, pause for a bit, and run ComputerTurn()
            Form1.pattern1.Clear();
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            
            //TODO: get rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list
            Form1.pattern1.Add(randGen.Next(0, 4));

            //TODO: create a for loop that shows each value in the pattern by lighting up approriate button
            for (int i = 0; i < Form1.pattern1.Count; i++)
            {
                if (Form1.pattern1[i] == 0)
                {
                    greenButton.BackColor = Color.Lime;
                    SoundPlayer cpuButton = new SoundPlayer(Properties.Resources.bing);
                    cpuButton.Play();
                    Refresh(); 
                    Thread.Sleep(1000); 
                    greenButton.BackColor = Color.DarkGreen;
                    Refresh();
                    Thread.Sleep(500);
                }
                else if (Form1.pattern1[i] == 1)
                {
                    redButton.BackColor = Color.Red;
                    SoundPlayer cpuButton = new SoundPlayer(Properties.Resources.bing);
                    cpuButton.Play();
                    Refresh(); 
                    Thread.Sleep(1000); 
                    redButton.BackColor = Color.DarkRed;
                    Refresh();
                    Thread.Sleep(500);
                }
                else if (Form1.pattern1[i] == 2)
                {
                    yellowButton.BackColor = Color.Yellow;
                    SoundPlayer cpuButton = new SoundPlayer(Properties.Resources.bing);
                    cpuButton.Play();
                    Refresh(); 
                    Thread.Sleep(1000); 
                    yellowButton.BackColor = Color.Goldenrod;
                    Refresh();
                    Thread.Sleep(500);
                }
                else if (Form1.pattern1[i] == 3)
                {
                    blueButton.BackColor = Color.LightBlue;
                    SoundPlayer cpuButton = new SoundPlayer(Properties.Resources.bing);
                    cpuButton.Play();
                    Refresh();
                    Thread.Sleep(1000); 
                    blueButton.BackColor = Color.DarkBlue;
                    Refresh();
                    Thread.Sleep(500);
                }

            }
            //TODO: get guess index value back to 0
            userGuess = 0;
        
        }

        public void GameOver()
        {
            //TODO: Play a game over sound
            SoundPlayer gameOverSound = new SoundPlayer(Properties.Resources.gameover);
            gameOverSound.Play();
            //TODO: close this screen and open the GameOverScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameOverScreen gameOverScreen = new GameOverScreen();
            f.Controls.Add(gameOverScreen);

        }

        //TODO: create one of these event methods for each button
        private void greenButton_Click(object sender, EventArgs e)
        {
            //TODO: is the value at current guess index equal to a green. If so:
            // light up button, play sound, and pause
            // set button colour back to original
            // add one to the guess index
            // check to see if we are at the end of the pattern. If so:
            // call ComputerTurn() method
            // else call GameOver method

            if (Form1.pattern1[userGuess] == 0)
            {
                greenButton.BackColor = Color.Lime;
                SoundPlayer greenLightSound = new SoundPlayer(Properties.Resources.green);
                greenLightSound.Play();
                Refresh();
                Thread.Sleep(1000);
                greenButton.BackColor = Color.DarkGreen;
                Refresh();
                Thread.Sleep(500);
                userGuess++;
            }
            else
            {
                GameOver();
            }
            if (userGuess == Form1.pattern1.Count)
            {
                ComputerTurn();
            }

        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern1[userGuess] == 1)
            {
                redButton.BackColor = Color.Red;
                SoundPlayer greenLightSound = new SoundPlayer(Properties.Resources.red);
                greenLightSound.Play();
                Refresh();
                Thread.Sleep(1000);
                redButton.BackColor = Color.DarkRed;
                Refresh();
                Thread.Sleep(500);
                userGuess++;
            }
            else
            {
                GameOver();
            }
            if (userGuess == Form1.pattern1.Count)
            {
                ComputerTurn();
            }
      
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern1[userGuess] == 2)
            {
                yellowButton.BackColor = Color.Yellow;
                SoundPlayer greenLightSound = new SoundPlayer(Properties.Resources.yellow);
                greenLightSound.Play();
                Refresh();
                Thread.Sleep(1000);
                yellowButton.BackColor = Color.Goldenrod;
                Refresh();
                Thread.Sleep(500);
                userGuess++;
            }
            else
            {
                GameOver();
            }
            if (userGuess == Form1.pattern1.Count)
            {
                ComputerTurn();
            }
       
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern1[userGuess] == 3)
            {
                blueButton.BackColor = Color.LightBlue;
                SoundPlayer greenLightSound = new SoundPlayer(Properties.Resources.blue);
                greenLightSound.Play();
                Refresh();
                Thread.Sleep(1000);
                blueButton.BackColor = Color.DarkBlue;
                Refresh();
                Thread.Sleep(500);
                userGuess++;
            }
            else
            {
                GameOver();
            }
            if (userGuess == Form1.pattern1.Count)
            {
                ComputerTurn();
            }
       
        }
    }
}
