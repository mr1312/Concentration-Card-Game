namespace My_Card_Game
{
    partial class Pause_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pause_Menu));
            this.Return_Button = new System.Windows.Forms.Button();
            this.Difficulty_Button = new System.Windows.Forms.Button();
            this.Settings_Pause = new System.Windows.Forms.Button();
            this.Restart_Button = new System.Windows.Forms.Button();
            this.ExitGame_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Return_Button
            // 
            this.Return_Button.BackgroundImage = global::My_Card_Game.Properties.Resources.icons8_back_arrow_50;
            this.Return_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Return_Button.FlatAppearance.BorderSize = 0;
            this.Return_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return_Button.Location = new System.Drawing.Point(12, 7);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(52, 55);
            this.Return_Button.TabIndex = 0;
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // Difficulty_Button
            // 
            this.Difficulty_Button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Difficulty_Button.Location = new System.Drawing.Point(308, 192);
            this.Difficulty_Button.Name = "Difficulty_Button";
            this.Difficulty_Button.Size = new System.Drawing.Size(227, 30);
            this.Difficulty_Button.TabIndex = 1;
            this.Difficulty_Button.Text = "Change difficulty";
            this.Difficulty_Button.UseVisualStyleBackColor = false;
            this.Difficulty_Button.Click += new System.EventHandler(this.Difficulty_Button_Click);
            // 
            // Settings_Pause
            // 
            this.Settings_Pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settings_Pause.BackgroundImage")));
            this.Settings_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Settings_Pause.FlatAppearance.BorderSize = 0;
            this.Settings_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Pause.Location = new System.Drawing.Point(781, 7);
            this.Settings_Pause.Name = "Settings_Pause";
            this.Settings_Pause.Size = new System.Drawing.Size(52, 55);
            this.Settings_Pause.TabIndex = 2;
            this.Settings_Pause.UseVisualStyleBackColor = true;
            this.Settings_Pause.Click += new System.EventHandler(this.Settings_Pause_Click);
            // 
            // Restart_Button
            // 
            this.Restart_Button.Location = new System.Drawing.Point(308, 264);
            this.Restart_Button.Name = "Restart_Button";
            this.Restart_Button.Size = new System.Drawing.Size(227, 30);
            this.Restart_Button.TabIndex = 3;
            this.Restart_Button.Text = "Restart Game ";
            this.Restart_Button.UseVisualStyleBackColor = true;
            this.Restart_Button.Click += new System.EventHandler(this.Restart_Button_Click);
            // 
            // ExitGame_Button
            // 
            this.ExitGame_Button.Location = new System.Drawing.Point(308, 329);
            this.ExitGame_Button.Name = "ExitGame_Button";
            this.ExitGame_Button.Size = new System.Drawing.Size(227, 30);
            this.ExitGame_Button.TabIndex = 4;
            this.ExitGame_Button.Text = "Exit Game ";
            this.ExitGame_Button.UseVisualStyleBackColor = true;
            this.ExitGame_Button.Click += new System.EventHandler(this.ExitGame_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(317, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Main Menu ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pause_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(845, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitGame_Button);
            this.Controls.Add(this.Restart_Button);
            this.Controls.Add(this.Settings_Pause);
            this.Controls.Add(this.Difficulty_Button);
            this.Controls.Add(this.Return_Button);
            this.Name = "Pause_Menu";
            this.Text = "Pause_Menu";
            this.Load += new System.EventHandler(this.Pause_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Return_Button;
        private Button Difficulty_Button;
        private Button Settings_Pause;
        private Button Restart_Button;
        private Button ExitGame_Button;
        private Label label1;
    }
}