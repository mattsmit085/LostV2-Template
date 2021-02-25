/// created by : 
/// date       : 
/// description: A basic text adventure game engine

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace LostV2
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 1;
        SoundPlayer scenesound;
        // random number generator

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            // decides what scene to go to based on the current scene and button clicked
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4;}
                else if (scene == 3) { scene = 15;}
                else if (scene == 4) { scene = 30;}
                else if (scene == 5) { scene = 98;}
                else if (scene == 6) { scene = 8;}
                else if (scene == 7) { scene = 60;}
                else if (scene == 8) { scene = 75;}
                else if (scene == 9) { scene = 1;}
                else if (scene == 10) { scene = 12;}
                else if (scene == 11) { scene = 90; }
                else if (scene == 15) { scene = 1;}
                else if (scene == 9) { scene = 10;}
                else if (scene == 12) { scene = 99;}
                else if (scene == 15) { scene = 99;}
                else if (scene == 30) { scene = 4;}
                else if (scene == 45) { scene = 99;}
                else if (scene == 60) { scene = 99;}
                else if (scene == 60) { scene = 99;}
                else if (scene == 90) { scene = 99;}
                else if (scene == 75) { scene = 99;}
                else if (scene == 76) { scene = 10; }
                else if (scene == 90) { scene = 99;}
                else if (scene == 98) { scene = 99;}
                else if (scene == 98) { scene = 99; }
                else if (scene == 97) { scene = 99; }
            }
                else if (e.KeyCode == Keys.B)  // on blue button press
                {
                if (scene == 10)
                {
                    Random randGen = new Random();
                    int value = randGen.Next(1, 11);
                    // decides what scene to go to based on the current scene and button clicked
                    // if a value between 1-5 is chosen, it does one thing, if a value 6-10 is chosen another thing happens
                    if (value <= 5) { scene = 10; }
                    else { scene = 105; }
                }
               
                else if (scene == 1) { scene = 3;}
                else if (scene == 2) { scene = 1;}
                else if (scene == 3) { scene = 97;}
                else if (scene == 4) { scene = 5;}
                else if (scene == 5) { scene = 7;}
                else if (scene == 6) { scene = 11;}
                else if (scene == 7) { scene = 45;}
                else if (scene == 8) { scene = 76;}
                else if (scene == 9) { scene = 99;}
                else if (scene == 11) { scene = 8;}
                else if (scene == 12) { scene = 1;}
                else if (scene == 15) { scene = 1;}
                else if (scene == 30) { scene = 4;}
                else if (scene == 45) { scene = 1;}
                else if (scene == 60) { scene = 1;}
                else if (scene == 90) { scene = 1;}
                else if (scene == 105) { scene = 15;}
                else if (scene == 75) { scene = 1; }
                else if (scene == 76) { scene = 9; }
                else if (scene == 90) { scene = 1; }
                else if (scene == 98) { scene = 1; }
                else if (scene == 105) { scene = 1; }
                else if (scene == 97) { scene = 1; }

            }
            if (e.KeyCode == Keys.Space)
            { 
                if (scene == 4) { scene = 6; }
            }

                /// Display text, pictures, sounds, and game options to screen based on the current scene
                switch (scene)
            {
                case 0:  //start scene  
                    break;
                case 1:
                    scenesound = new SoundPlayer(Properties.Resources.cell2);
                    scenesound.Play();
                    outputLabel.Text = "You wake up in a jail cell. There's a poster...";
                    blueLabel.Text = "Complain";
                    redLabel.Text = "Tear Down The Poster";
                    pictureBox1.Image = Properties.Resources.scene_1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.scene_2;
                    outputLabel.Text = "You tear down the poster. Behind it, a human sized hole in the wall";
                    redLabel.Text = "Climb through";
                    blueLabel.Text = "Put poster back";
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.scene_3;
                    outputLabel.Text = "You started complaining. A guard heard you and sent you to solitary confinement";
                    blueLabel.Text = "Give up";
                    redLabel.Text = "Break door";
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.scene_4;
                    outputLabel.Text = "You climb through the hole and into a vent. There are 3 directions you can crawl";
                    blueLabel.Text = "Left";
                    redLabel.Text = "Right";
                    button3.Visible = true;
                    StraightLabel.Visible = true;
                    spaceLabel.Visible = true;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.scene_5;
                    outputLabel.Text = "You make your way left. You fall through a vent into the cafeteria. You are surrounded.";
                    blueLabel.Text = "RUN!";
                    redLabel.Text = "Surrender";
                    button3.Visible = false;
                    StraightLabel.Visible = false;
                    spaceLabel.Visible = false;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.Inside_Vent;
                    button3.Visible = false;
                    StraightLabel.Visible = false;
                    spaceLabel.Visible = false;
                    outputLabel.Text = "You go straight. You cross the media room and wardens office.";
                    blueLabel.Text = "Go to the media room";
                    redLabel.Text = "Go to the wardens office";
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.scene_7;
                    outputLabel.Text = "You make a break for it. You run into the yard";
                    blueLabel.Text = "Climb the fence";
                    redLabel.Text = "Fight";
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.scene_8;
                    outputLabel.Text = "You sneak into the wardens office and find a few items";
                    blueLabel.Text = "Take Baton";
                    redLabel.Text = "Take Sandwich";
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.scene_9;
                    scenesound = new SoundPlayer(Properties.Resources.alarm);
                    scenesound.Play();
                    outputLabel.Text = "You shatter the window. The alarm goes off. \nAmidst the hassle, you book it out and across the field to the parking lot and steal a car. \n\nYOU HAVE ESCAPED!";
                    blueLabel.Text = "Play Again";
                    redLabel.Text = "Quit";
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.scene_10;
                    outputLabel.Text = "You find a shotgun";
                    blueLabel.Text = "Put it away";
                    
                    redLabel.Text = "Cause mayhem";
                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources.scene11;
                    outputLabel.Text = "You enter the media room and find a battery as well as some steelwool";
                    blueLabel.Text = "Go to the wardens room";
                    redLabel.Text = "Start a fire";
                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources.scene_12 ;
                    scenesound = new SoundPlayer(Properties.Resources.shot);
                    scenesound.Play();
                    outputLabel.Text = "You get revenge for your incarceration, but you die doing it.";
                    blueLabel.Text = "Play Again";
                    redLabel.Text = "End";
                    break;
                case 15:
                    scenesound = new SoundPlayer(Properties.Resources.choke);
                    scenesound.Play();
                    pictureBox1.Enabled = false;
                    outputLabel.Text = "You have knocked yourself out. Restart?";
                    blueLabel.Text = "Yes";
                    redLabel.Text = "No";
                    break;
                case 30:
                    pictureBox1.Image = Properties.Resources.ventend;
                    outputLabel.Text = "you crawl right, its a dead end.";
                    blueLabel.Text = "crawl back";
                    redLabel.Text = "crawl back";
                    button3.Visible = false;
                    StraightLabel.Visible = false;
                    spaceLabel.Visible = false;
                    break;
                case 45:
                    pictureBox1.Enabled = false;
                    scenesound = new SoundPlayer(Properties.Resources.shot);
                    scenesound.Play();
                    outputLabel.Text = "You climb the fence, but get shot.";
                    blueLabel.Text = "Restart";
                    redLabel.Text = "Quit";
                    break;
                case 60:
                    pictureBox1.Enabled = false;
                    scenesound = new SoundPlayer(Properties.Resources.shot);
                    scenesound.Play();
                    outputLabel.Text = "You grab a dumbbell and let loose. It doesn't go very well. You get shot.";
                    blueLabel.Text = "Restart";
                    redLabel.Text = "Quit";
                    break;
                case 75:
                    scenesound = new SoundPlayer(Properties.Resources.choke);
                    scenesound.Play();
                    pictureBox1.Image = Properties.Resources.scene_75;
                    outputLabel.Text = "You eat the sandwich. It had eggs in it. You are allergic to eggs. You are dead.";
                    blueLabel.Text = "Restart";
                    redLabel.Text = "Quit";
                    break;
                case 76:
                    pictureBox1.Image = Properties.Resources.baton;
                    outputLabel.Text = "You take the baton";
                    blueLabel.Text = "Smash the window";
                    redLabel.Text = "Break open the safe";
                    break;
                case 105:
                    scenesound = new SoundPlayer(Properties.Resources.choke);
                    scenesound.Play();
                    pictureBox1.Enabled = false;
                    outputLabel.Text = "The warden sees you, youve been shot.";
                    blueLabel.Text = "Play Again!";
                    redLabel.Text = "Quit";
                    break;
                case 97:
                    pictureBox1.Enabled = false;
                    outputLabel.Text = "Thanks for playing!";
                    blueLabel.Text = "Restart";
                    redLabel.Text = "Quit";
                    break;
                case 98:
                    pictureBox1.Enabled = false;
                    outputLabel.Text = "YOU SURRENDERED!";
                    blueLabel.Text = "Play Again!";
                    redLabel.Text = "Quit";
                    break;
                case 90:
                    pictureBox1.Enabled = false;
                    outputLabel.Text = "You started a fire. Amidst the panic, you manage to escape through the main door and run to the nearest car.\nYOUVE ESCAPED";
                    blueLabel.Text = "Play Again!";
                    redLabel.Text = "Quit";
                    break;
                case 99:
                    pictureBox1.Enabled = false;
                    outputLabel.Text = "Thanks for playing!";
                    break;
                default:
                    break;
            }
        }

        private void redImage_Click(object sender, EventArgs e)
        {

        }

        private void blueLabel_Click(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
