namespace My_Card_Game
{
    partial class Leaderboard_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaderboard_Page));
            this.Settings_Leader = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Return_Menu = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.Place_Num = new System.Windows.Forms.ColumnHeader();
            this.Time = new System.Windows.Forms.ColumnHeader();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Settings_Leader
            // 
            this.Settings_Leader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settings_Leader.BackgroundImage")));
            this.Settings_Leader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Settings_Leader.FlatAppearance.BorderSize = 0;
            this.Settings_Leader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Leader.Location = new System.Drawing.Point(720, 12);
            this.Settings_Leader.Name = "Settings_Leader";
            this.Settings_Leader.Size = new System.Drawing.Size(57, 60);
            this.Settings_Leader.TabIndex = 3;
            this.Settings_Leader.UseVisualStyleBackColor = true;
            this.Settings_Leader.Click += new System.EventHandler(this.Settings_Leader_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Return_Menu
            // 
            this.Return_Menu.BackgroundImage = global::My_Card_Game.Properties.Resources.icons8_back_arrow_50;
            this.Return_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Return_Menu.FlatAppearance.BorderSize = 0;
            this.Return_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return_Menu.Location = new System.Drawing.Point(23, 12);
            this.Return_Menu.Name = "Return_Menu";
            this.Return_Menu.Size = new System.Drawing.Size(75, 60);
            this.Return_Menu.TabIndex = 5;
            this.Return_Menu.UseVisualStyleBackColor = true;
            this.Return_Menu.Click += new System.EventHandler(this.Return_Menu_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Place_Num,
            this.Time});
            this.listView.Location = new System.Drawing.Point(186, 133);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(407, 234);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Place_Num
            // 
            this.Place_Num.Text = "Place";
            this.Place_Num.Width = 200;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 210;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(518, 388);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 7;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Leaderboard_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.Return_Menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Settings_Leader);
            this.Name = "Leaderboard_Page";
            this.Text = "Leaderboard_Page";
            this.Load += new System.EventHandler(this.Leaderboard_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Settings_Leader;
        private Label label1;
        private Button Return_Menu;
        private ListView listView;
        private Button Update;
        private ColumnHeader Place_Num;
        private ColumnHeader Time;
    }
}