using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Card_Game
{
    public partial class Pause_Menu : Form 
    {
        //Implementing Difficult to saved current value when restarted 
        // To pass Pause_Menu_Open normally I have to create new object form
        // // This is not practial if I don't want the user to restart the game everytime they pause 
        // That may only be a problem if I create showdialog 
        private int _value;
        private static List<int> List_Time_values = new List<int>();
        private string Saved_Diff_Value; 
        private static bool Pause_Menu_Open; //Used to check if pause form still on 
        private bool Flag_Visable_Game;
        private Form _ingame;
        private void Pause_Menu_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            Settings.Theme_Setter(this);
        }
        public Pause_Menu(bool Pause_Menu_open, string saved_diff_value, Form ingame )
        {
            _ingame = ingame;
            Pause_Menu_Open = Pause_Menu_open;
            Saved_Diff_Value = saved_diff_value;
            InitializeComponent();
        }
        public Pause_Menu(bool Pause_Menu_open, string saved_diff_value, Form ingame, int value)
        {
            List_Time_values.Add(value);
            _value = value;
            _ingame = ingame;
            Pause_Menu_Open = Pause_Menu_open;
            Saved_Diff_Value = saved_diff_value;
            InitializeComponent();
            Debug.WriteLine("Pause");
            Debug.WriteLine(value);
            foreach (int index in List_Time_values)
            {
               
                Debug.WriteLine(index);

            }
           // Debug.WriteLine(List_Time_values);
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {

            Pause_Menu_Open = false; 
            this.Close();
            
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            Settings To_Settings = new Settings();
            To_Settings.ShowDialog();
        }

        private void Difficulty_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            _ingame.Hide();
            Pause_Menu_Open = false;
            var To_Diff = new Difficulty();
            To_Diff.ShowDialog();
        }

        private void Restart_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            _ingame.Hide();
            Pause_Menu_Open = false;
            var To_Ingame = new Ingame(Saved_Diff_Value);
            To_Ingame.ShowDialog();
        }

        private void ExitGame_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            _ingame.Hide();
            var To_Home = new Home(List_Time_values);
            To_Home.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Pause_Click(object sender, EventArgs e)
        {
            Settings To_Settings = new Settings();
            To_Settings.ShowDialog();
        }

        //Praise be to the machine spirit and holy youtube scripture for the glorious static 
        public static bool Pause_Menu_Open_Set 
        {
            get { return Pause_Menu_Open; }
            set { Pause_Menu_Open = value; }
        }
    }
}
