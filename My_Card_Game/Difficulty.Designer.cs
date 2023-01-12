namespace My_Card_Game
{
    partial class Difficulty
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
            this.Diff_Legend = new System.Windows.Forms.Button();
            this.Diff_Easy = new System.Windows.Forms.Button();
            this.Diff_Alright = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Diff_Legend
            // 
            this.Diff_Legend.Location = new System.Drawing.Point(585, 480);
            this.Diff_Legend.Name = "Diff_Legend";
            this.Diff_Legend.Size = new System.Drawing.Size(347, 127);
            this.Diff_Legend.TabIndex = 0;
            this.Diff_Legend.Text = "Legend";
            this.Diff_Legend.UseVisualStyleBackColor = true;
            this.Diff_Legend.Click += new System.EventHandler(this.Diff_Legend_Click);
            // 
            // Diff_Easy
            // 
            this.Diff_Easy.Location = new System.Drawing.Point(585, 129);
            this.Diff_Easy.Name = "Diff_Easy";
            this.Diff_Easy.Size = new System.Drawing.Size(347, 127);
            this.Diff_Easy.TabIndex = 1;
            this.Diff_Easy.Text = "Easy ";
            this.Diff_Easy.UseVisualStyleBackColor = true;
            this.Diff_Easy.Click += new System.EventHandler(this.Diff_Easy_Click);
            // 
            // Diff_Alright
            // 
            this.Diff_Alright.Location = new System.Drawing.Point(584, 303);
            this.Diff_Alright.Name = "Diff_Alright";
            this.Diff_Alright.Size = new System.Drawing.Size(348, 130);
            this.Diff_Alright.TabIndex = 2;
            this.Diff_Alright.Text = "Alright ";
            this.Diff_Alright.UseVisualStyleBackColor = true;
            this.Diff_Alright.Click += new System.EventHandler(this.Diff_Alright_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(501, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 86);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Difficulty ";
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 656);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Diff_Alright);
            this.Controls.Add(this.Diff_Easy);
            this.Controls.Add(this.Diff_Legend);
            this.Name = "Difficulty";
            this.Text = "Difficulty";
            this.Load += new System.EventHandler(this.Difficulty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Diff_Legend;
        private Button Diff_Easy;
        private Button Diff_Alright;
        private Label label1;
    }
}