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
    public partial class Difficulty : Form
    {
        

        public Difficulty()
        {
            InitializeComponent();
        }
        private void Difficulty_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            Settings.Theme_Setter(this);
        }



        private void Diff_Easy_Click(object sender, EventArgs e)
        {
            string Difficulty_Value_Set = "Easy";
            this.Hide();
            Ingame To_Ingame = new Ingame(Difficulty_Value_Set);
            To_Ingame.ShowDialog();
            this.Close();
            Pause_Menu.Pause_Menu_Open_Set = false;


        }

        private void Diff_Alright_Click(object sender, EventArgs e)
        {
            string Difficulty_Value_Set = "Medium";
            this.Hide();
            Ingame To_Ingame = new Ingame(Difficulty_Value_Set);
            To_Ingame.ShowDialog();
            this.Close();
            Pause_Menu.Pause_Menu_Open_Set = false;
        }

        private void Diff_Legend_Click(object sender, EventArgs e)
        {
            string Difficulty_Value_Set = "Awesome";
            this.Hide();
            Ingame To_Ingame = new Ingame(Difficulty_Value_Set);
            To_Ingame.ShowDialog();
            this.Close();
            Pause_Menu.Pause_Menu_Open_Set = false;
        }
    }
}
