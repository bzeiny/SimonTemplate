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
    //Bilal Zeineddine
    //October 18, 2021
    //Challenge your mind in this difficult memory game, remember the sequence and get the highest score possible!
    public partial class GameScreen : UserControl
    {
        //Create a guess variable to track what part of the pattern the user is at
        public static int userGuess;
        Random randGen = new Random();
        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //Clear Pattern1 list and then run ComputerTurn
            Form1.pattern1.Clear();
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            
            //Get a random number between 0 and 4 and then add it to pattern1
            Form1.pattern1.Add(randGen.Next(0, 4));

            //Create a for loop that shows each value in the pattern by lighting up approriate button
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
            //Set userguess back to 0
            userGuess = 0;
        
        }

        public void GameOver()
        {
            //Play a game over sound
            SoundPlayer gameOverSound = new SoundPlayer(Properties.Resources.gameover);
            gameOverSound.Play();
            //Close this screen and open the GameOverScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameOverScreen gameOverScreen = new GameOverScreen();
            f.Controls.Add(gameOverScreen);

        }

        
        private void greenButton_Click(object sender, EventArgs e)
        {
            //Check if pattern1 at userguess is 0. If so, set colour to green, play sound
            //Pause, , go back to original colour, pause, and add to userguess. Repeat for each colour.

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
