using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace My_Card_Game
{
    public partial class Leaderboard_Page : Form
    {
        private List<int> _List_Time_values;
        public Leaderboard_Page()
        {
            InitializeComponent();
        }
        public Leaderboard_Page(List<int> List_Time_values )
        {
            _List_Time_values = List_Time_values;
            InitializeComponent();
            Debug.WriteLine("LeaderBoard");
            foreach (int index in List_Time_values)
            {

                Debug.WriteLine(index);

            }
        }
        private void Leaderboard_Page_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            Settings.Theme_Setter(this);
            Update_listView();
        }

        private void Return_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home To_Home = new Home(); //It is likly the home is an instance of the form class which contains instance method which is why
            To_Home.ShowDialog(); // this.ShowDialog(To_Home); works because this. is the current instance of the leaderborad form 
            this.Close();// This is why it didnt work the above code called the current instance of the leaderborad form while it was already open while inserting a TO_Home parameter it didnt need
        }

        private void Settings_Leader_Click(object sender, EventArgs e)
        {
            Settings To_Settings = new Settings();
            To_Settings.ShowDialog();
        }

        private void Update_listView() //Ingame doesnt pass values  
        {
            ////List<int> places = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////List<string> Leader = new List<string>();
            if (_List_Time_values != null)
            {
                if (listView.Items.Count < 10)
                {
                    _List_Time_values.Sort();
                    _List_Time_values.Reverse();


                    for (int index = 0; index <= _List_Time_values.Count - 1; index++)
                    {
                        int place = index + 1;

                        //ListViewItem item = new ListViewItem(_List_Time_values[index].ToString());
                        //item.SubItems.Add(place.ToString());
                        //listView.Items.Add(item);

                        ListViewItem item = new ListViewItem(place.ToString());
                        item.SubItems.Add(_List_Time_values[index].ToString());
                        listView.Items.Add(item);


                    }
                }
                else
                {
                    listView.Items.Clear();
                }
            }
            else
            {
            }
        }


        private void Update_Click(object sender, EventArgs e)
        {
            List<int> test = new List<int>() { 56, 76, 87, 5464, 67, 543 };
            if (listView.Items.Count < 10)
            {
                test.Sort();
                test.Reverse();

                for (int index = 0; index <= test.Count - 1; index++)
                {
                    int place = index + 1;

                    ListViewItem item = new ListViewItem(test[index].ToString());
                    item.SubItems.Add(place.ToString());
                    listView.Items.Add(item);
                }
            }
            else
            {
                listView.Items.Clear();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
