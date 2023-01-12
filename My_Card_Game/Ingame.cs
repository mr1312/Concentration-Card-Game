using Microsoft.VisualBasic;
using My_Card_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace My_Card_Game
{
    public partial class Ingame : Form
    {
        // private static bool Is_discarded; all related code is to be implemented later
        //private List<int> Timer_Values;
        private bool Will_Win = false; 
        //private static List<int> Timer_Values = new List<int>();
        private int  total_Timer_time;
        bool allowclick = false;
        PictureBox first_guess;
        Random Randon_Number = new Random();
        System.Windows.Forms.Timer clickTimer = new System.Windows.Forms.Timer(); // System.Windows.Form BS 
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer {Interval = 10};
        private string Difficulty_Value;
        private bool Timer_Running;
        private int Timer_Mirco, Timer_Second, Timer_Minute;
        private static bool Pause_Menu_Open;
        int totalTime; //Change this to depend on diffculty  
        private bool Start_button_pushed =false;

        private void start_game_timer()
        {
            timer.Start();
            timer.Tick += delegate
            {
                total_Timer_time = (Timer_Mirco / 100) + Timer_Second + (Timer_Minute * 60);
                //    Personal note = is for referencing a value to a var
                //     But == is comparing the var value to whatever is on the right
                //     === is similar to == but datatype specific the values must match in addition to datatype
                //     for example 2 == "2" is true but 2 === "2" is false
                if (Timer_Running == true && Pause_Menu.Pause_Menu_Open_Set == false)// 
                {
                    Timer_Mirco++;
                    if (Timer_Mirco >= 100) // Start moving up  
                    {
                        Timer_Second++;
                        Timer_Mirco = 0;

                        if (Timer_Second >= 60)
                        {
                            Timer_Minute++;
                            Timer_Second = 0;
                        }
                    }
                    Drawing();
                }
                if (total_Timer_time >= Diffculty_Num())
                {
                    timer.Stop();
                    Timer_Running = false;

                    MessageBox.Show("Skill Issue " +
                        " Please go to menu to restart ");
                    ResetImage();
                    Initialize_Timer();
                    Drawing();
                    // Start_Game_Button.Enabled = true;
                    Start_button_pushed = false;
                   // Timer_Value_Set.Add(total_Timer_time);
                }
            };
        }

        public Ingame(string difficulty_Value) // Constructor Value string difficulty_Value
        {
            Difficulty_Value = difficulty_Value; // The difficulty form will pass the string into the Ingame game will decide the timer length  Difficulty_Value = difficulty_Value;
            
            InitializeComponent();
        }
        private void Ingame_Load(object sender, EventArgs e)
        {//This code executes when the form is generated I think . 
            Timer_Running = false;
            ControlBox = false;
            Settings.Theme_Setter(this);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Pause_Menu_Open = true;
            //Pause_Menu.Cheat_bool = true; //This is bad summon Harry to help me fix this shit :0
            if (Will_Win == true)
            {
                var To_Pause = new Pause_Menu(Pause_Menu_Open, Difficulty_Value_Set, this, total_Timer_time);
                To_Pause.ShowDialog();
                Initialize_Timer(); // Doesnt work here work elsewhere though 

            }
            else
            {
                var To_Pause = new Pause_Menu(Pause_Menu_Open, Difficulty_Value_Set, this);
                To_Pause.ShowDialog();

            }
        }

        private void Settings_Ingame_Click(object sender, EventArgs e)
        {
            Settings To_Settings = new Settings();
            To_Settings.ShowDialog();
        }
        private void Alternate_click(object sender, EventArgs e)
        {
            Hideimages();
            allowclick= true;
            clickTimer.Stop();
        }

        private void Initialize_Timer() 
        {
            Timer_Mirco = 0;
            Timer_Second = 0;
            Timer_Minute = 0;
        }
        private void Drawing()
        {
            Label_Micro.Text = String.Format("{0:00}", Timer_Mirco); // inserted semicolan into string Probs had incorrect sytax before
            Label_Sec.Text = String.Format("{0:00}", Timer_Second);
            label_Min.Text = String.Format("{0:00}", Timer_Minute);
        }

        public string Difficulty_Value_Set
        {
            get { return Difficulty_Value; }
            set { Difficulty_Value = value; } // the value keyword is used to determine the value of the Difficulty_Value_Set which is now set to equal Difficulty_Value 
        }

        //public static bool Is_Discarded_Set
        //{
        //    get { return Is_discarded; }
        //    set { Is_discarded = value;}
        //}

        private int Diffculty_Num()
        {
            if (Difficulty_Value == "Easy")
            {
                return totalTime = 60;
            }
            else if (Difficulty_Value == "Medium")
            {
                return totalTime = 45;
            }
            else if (Difficulty_Value == "Awesome")
            {
                return totalTime = 20;
            }
            return totalTime = 60;
        }

        // This is where the card image stuff will be. Maybe to be broken off into seperate class when code is optmised 
        // Will need to add the link https://www.mooict.com/c-tutorial-create-a-picture-matching-game-with-net-in-visual-studio/ Need to remember to remove this. Version 1
        // https://www.youtube.com/watch?v=1Vh_buDuyAo Version 2 
        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray();}
        }

        private static IEnumerable<Image> images
        {
            get 
            {
                return new Image[]
                {
                    Properties.Resources.Clovers_5_black,
                    Properties.Resources.Clovers_6_black,
                    Properties.Resources.Clovers_7_black,
                    Properties.Resources.Clovers_8_black,
                    Properties.Resources.Clovers_9_black,
                    Properties.Resources.Clovers_10_black,
                    Properties.Resources.Clovers_A_black,
                    Properties.Resources.Clovers_Jack_black,
                    Properties.Resources.Clovers_King_black,
                    Properties.Resources.Clovers_Queen_black
                };
            }
        }

        private void ResetImage () 
        {
            foreach (PictureBox pic_index in pictureBoxes)
            {
                pic_index.Tag= null;
                pic_index.Visible = true; //pic_index.Image= null;
            }
            Start_button_pushed = false;
            timer.Start();
            Hideimages();
            Set_Random_Image();
        }

        private void Hideimages () 
        {
            foreach (PictureBox Pic_index in pictureBoxes) 
            {
                Pic_index.Image = Properties.Resources.Back;
                Pic_index.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private PictureBox getfreeslot ()
        {
            int num;
            do
            {
                num = Randon_Number.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null); 
            return pictureBoxes[num];
        }
        private void Set_Random_Image()
        {
            foreach (var image_index in images)
            {
                getfreeslot().Tag = image_index;
                getfreeslot().Tag = image_index;
            }
        }

        private void click_Image(object sender, EventArgs e)
        {
            if (Start_button_pushed == true)
            {
                try
                {
                    if (!allowclick)
                    {
                        return;
                    }

                    var pic = (PictureBox)sender; // Reason for the try catch 

                    if (first_guess == null)
                    {
                        first_guess = pic;
                        pic.Image = (Image)pic.Tag;
                        return;
                    }
                    pic.Image = (Image)pic.Tag;
                    if (pic.Image == first_guess.Image && pic != first_guess)
                    {
                        pic.Visible = first_guess.Visible = false;
                        {
                            first_guess = pic;
                        }
                        Hideimages();
                    }
                    else
                    {
                        allowclick = false;
                        clickTimer.Start();
                    }

                    first_guess = null;
                    if (pictureBoxes.Any(P => P.Visible))
                    {
                        return;
                    }
                    Will_Win = true;
                    MessageBox.Show("You win congrats " +
                        "Please go to menu to restart ");
                    ResetImage();
                    timer.Stop();
                    // Start_Game_Button.Enabled = true;
                    Start_button_pushed = false;
                    //Initialize_Timer();
                    Drawing();
                }
                catch
                { }
            }
        }
        private void Start_Game_Button_Click(object sender, EventArgs e)
        {
            Start_button_pushed = true;

            timer.Start();
            Timer_Running = true;
            Initialize_Timer(); //Initializ values so what happens when pause menu is opened.

            //Foreign code 
            allowclick = true;
            Hideimages();
            Set_Random_Image();// Cause code to crash don't know why fixed 
            Start_Game_Button.Enabled= false;
            start_game_timer();
            clickTimer.Interval= 100;
            clickTimer.Tick += Alternate_click;
        }

    }
}
