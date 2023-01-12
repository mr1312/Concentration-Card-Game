namespace My_Card_Game
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.To_Home = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(281, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // To_Home
            // 
            this.To_Home.BackgroundImage = global::My_Card_Game.Properties.Resources.icons8_back_arrow_50;
            this.To_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.To_Home.FlatAppearance.BorderSize = 0;
            this.To_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.To_Home.Location = new System.Drawing.Point(12, 12);
            this.To_Home.Name = "To_Home";
            this.To_Home.Size = new System.Drawing.Size(75, 55);
            this.To_Home.TabIndex = 2;
            this.To_Home.UseVisualStyleBackColor = true;
            this.To_Home.Click += new System.EventHandler(this.To_Home_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(281, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Green";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Green_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Black";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Black_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(281, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "White";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.White_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(203, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Background Colour Theme";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.To_Home);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button To_Home;
        private Button button3;
        private Button button2;
        private Button button4;
        private Label label2;
    }
}