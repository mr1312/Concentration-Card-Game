using System.Diagnostics;

namespace My_Card_Game
{
    public partial class Home : Form
    {
        private List<int> _List_Time_values;
        public Home()
        {
           //bool Home_Open = true; Never used this 
            InitializeComponent();
        }
        public Home(List<int> List_Time_values)
        {
            _List_Time_values = List_Time_values;
            //bool Home_Open = true; Never used this 
            InitializeComponent();
            Debug.WriteLine("Home Con");
            foreach (int index in List_Time_values)
            {
                Debug.WriteLine(index);

            }
        }
        private void Home_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            Settings.Theme_Setter(this);
        }
        private void Leaderboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (_List_Time_values != null)
            {
                foreach (int index in _List_Time_values)
                {
                    Debug.WriteLine(index);
                }
                var To_Game = new Leaderboard_Page(_List_Time_values);
                To_Game.ShowDialog();
                this.Close();
            }
            else
            {
                var To_Game = new Leaderboard_Page();
                To_Game.ShowDialog();
                this.Close();
            }

        }
        

        private void Start_Buttons_Click(object sender, EventArgs e)
        {
            this.Hide();
            var To_Difficulty = new Difficulty();
            To_Difficulty.ShowDialog();
            this.Close();
        }
        private void QuitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Setting_Home_Click(object sender, EventArgs e)
        {
            Settings To_Settings = new Settings();
            To_Settings.ShowDialog();
        }
    }
}