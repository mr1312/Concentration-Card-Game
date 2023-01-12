namespace My_Card_Game
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start_Buttons = new System.Windows.Forms.Button();
            this.Leaderboard = new System.Windows.Forms.Button();
            this.Quit_Game = new System.Windows.Forms.Button();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.Setting_Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(464, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "Concentration Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(521, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Do you have what it takes ?";
            // 
            // Start_Buttons
            // 
            this.Start_Buttons.Location = new System.Drawing.Point(583, 262);
            this.Start_Buttons.Name = "Start_Buttons";
            this.Start_Buttons.Size = new System.Drawing.Size(218, 35);
            this.Start_Buttons.TabIndex = 7;
            this.Start_Buttons.Text = "Start Game ";
            this.Start_Buttons.UseVisualStyleBackColor = true;
            this.Start_Buttons.Click += new System.EventHandler(this.Start_Buttons_Click);
            // 
            // Leaderboard
            // 
            this.Leaderboard.Location = new System.Drawing.Point(583, 318);
            this.Leaderboard.Name = "Leaderboard";
            this.Leaderboard.Size = new System.Drawing.Size(218, 35);
            this.Leaderboard.TabIndex = 8;
            this.Leaderboard.Text = "Leaderboard";
            this.Leaderboard.UseVisualStyleBackColor = true;
            this.Leaderboard.Click += new System.EventHandler(this.Leaderboard_Click);
            // 
            // Quit_Game
            // 
            this.Quit_Game.Location = new System.Drawing.Point(583, 373);
            this.Quit_Game.Name = "Quit_Game";
            this.Quit_Game.Size = new System.Drawing.Size(218, 35);
            this.Quit_Game.TabIndex = 9;
            this.Quit_Game.Text = "Quit Game";
            this.Quit_Game.UseVisualStyleBackColor = true;
            this.Quit_Game.Click += new System.EventHandler(this.QuitGame_Click);
            // 
            // Settings_Button
            // 
            this.Settings_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Settings_Button.FlatAppearance.BorderSize = 0;
            this.Settings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Button.Location = new System.Drawing.Point(1356, 21);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Size = new System.Drawing.Size(52, 55);
            this.Settings_Button.TabIndex = 10;
            this.Settings_Button.UseVisualStyleBackColor = true;
            // 
            // Setting_Home
            // 
            this.Setting_Home.BackgroundImage = global::My_Card_Game.Properties.Resources.icons8_services_50;
            this.Setting_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Setting_Home.FlatAppearance.BorderSize = 0;
            this.Setting_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting_Home.Location = new System.Drawing.Point(1348, 21);
            this.Setting_Home.Name = "Setting_Home";
            this.Setting_Home.Size = new System.Drawing.Size(60, 55);
            this.Setting_Home.TabIndex = 11;
            this.Setting_Home.UseVisualStyleBackColor = true;
            this.Setting_Home.Click += new System.EventHandler(this.Setting_Home_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 658);
            this.Controls.Add(this.Setting_Home);
            this.Controls.Add(this.Settings_Button);
            this.Controls.Add(this.Quit_Game);
            this.Controls.Add(this.Leaderboard);
            this.Controls.Add(this.Start_Buttons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Button Start_Button;
        private Button Start_Buttons;
        private Button Leaderboard;
        private Button Quit_Game;
        private Button Settings_Button;
        private Button Setting_Home;
    }
}