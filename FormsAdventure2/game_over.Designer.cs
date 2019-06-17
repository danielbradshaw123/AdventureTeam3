namespace FormsAdventure2
{
    partial class game_over
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_finalScore = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.richTextBox1.Location = new System.Drawing.Point(355, 120);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(517, 54);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "GAME OVER | Tough Luck!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormsAdventure2.Properties.Resources.sad_face;
            this.pictureBox1.Location = new System.Drawing.Point(501, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 353);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txt_finalScore
            // 
            this.txt_finalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.txt_finalScore.Location = new System.Drawing.Point(447, 539);
            this.txt_finalScore.Name = "txt_finalScore";
            this.txt_finalScore.ReadOnly = true;
            this.txt_finalScore.Size = new System.Drawing.Size(322, 54);
            this.txt_finalScore.TabIndex = 3;
            this.txt_finalScore.Text = "Final Score:";
            this.txt_finalScore.TextChanged += new System.EventHandler(this.txt_finalScore_TextChanged);
            // 
            // game_over
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 681);
            this.Controls.Add(this.txt_finalScore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "game_over";
            this.Text = "game_over";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox txt_finalScore;
    }
}