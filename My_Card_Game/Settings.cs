using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Card_Game
{
    public partial class Settings : Form
    {
        private string Current_Colour;
        //Useful link https://stackoverflow.com/questions/453161/how-can-i-save-application-settings-in-a-windows-forms-application
        //Another one https://www.daveoncsharp.com/2009/07/using-the-settings-file-in-csharp/
        public Settings()
        {
            InitializeComponent();
        }

        private void To_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Theme_Setter(this);
            ControlBox = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //Nocode solution lol
        }

        private void Green_Click(object sender, EventArgs e)
        {
            Current_Colour = "Green";
            Colour_Giver(Current_Colour);
            MessageBox.Show("Note changes will only take effect after restart of program");
            /*
             * 	(44,76,59)
             * 	(48,104,68) // Used
             * 	(24,44,37)
            	(69,91,85)
            	(30,69,62)
             */
        }

        private void Black_Click(object sender, EventArgs e)
        {
            Current_Colour = "Dark";
            Colour_Giver(Current_Colour);
            MessageBox.Show("Note changes will only take effect after restart of program");
            /*
             * (0,0,0)
             * (20,20,20)
             * (40,40,40)
             * (35,0,70)
             * (50,0,100)
             */
        }

        private void White_Click(object sender, EventArgs e)
        {
            Current_Colour = "White";
            Colour_Giver(Current_Colour);
            MessageBox.Show("Note changes will only take effect after restart of program");
            /*
             
             */
        }
        public static void Theme_Setter(Form value)
        {
            foreach (Button Button_index in value.Controls.OfType<Button>() ) //Error
            {
                if (Button_index.BackgroundImage == null)
                {
                    if (Properties.Settings.Default.Button_backcolour != SystemColors.Control )
                    {
                        Button_index.FlatStyle = FlatStyle.Flat;
                        Button_index.BackColor = Properties.Settings.Default.Button_backcolour;
                        Button_index.FlatAppearance.BorderColor = Properties.Settings.Default.Button_backcolour;
                    }
                    else 
                    {
                        Button_index.FlatStyle = FlatStyle.Standard;
                        Button_index.BackColor = Properties.Settings.Default.Button_backcolour;
                        Button_index.FlatAppearance.BorderColor = Properties.Settings.Default.Button_backcolour;
                    }
                }
            }
            value.BackColor = Properties.Settings.Default.Background_Colour;
        }


        private void Colour_Giver(string Colour_) // Returns necessary colours 
        {
            if (Colour_ == "White") // Will likely adjust to change more than the background  
            {
                Properties.Settings.Default.Button_backcolour = SystemColors.ControlLight;
                Properties.Settings.Default.Background_Colour = SystemColors.Control;
                Properties.Settings.Default.Save();
            }
            else if (Colour_ == "Dark")
            {
                Properties.Settings.Default.Button_backcolour = Color.FromArgb(50, 0, 100);
                Properties.Settings.Default.Background_Colour = Color.FromArgb(40, 40, 40);
                Properties.Settings.Default.Save();
            }
            else if (Colour_ == "Green")
            {
                Properties.Settings.Default.Button_backcolour = Color.FromArgb(44, 76, 59);
                Properties.Settings.Default.Background_Colour = Color.FromArgb(48, 104, 68);
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Button_backcolour = SystemColors.ControlLight;
                Properties.Settings.Default.Background_Colour = Color.White;
                Properties.Settings.Default.Save();
            }
        }
    }
}
