namespace FormsAdventure2
{
    partial class Location1
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
            this.button1 = new System.Windows.Forms.Button();
            this.storyBox = new System.Windows.Forms.RichTextBox();
            this.characterName = new System.Windows.Forms.RichTextBox();
            this.character = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(509, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go to location 2 to party";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // storyBox
            // 
            this.storyBox.Font = new System.Drawing.Font("Segoe UI", 26.75F);
            this.storyBox.Location = new System.Drawing.Point(12, 456);
            this.storyBox.Name = "storyBox";
            this.storyBox.ReadOnly = true;
            this.storyBox.Size = new System.Drawing.Size(996, 213);
            this.storyBox.TabIndex = 2;
            this.storyBox.Text = " Hmm. Is this on?";
            this.storyBox.TextChanged += new System.EventHandler(this.storyBox_TextChanged);
            // 
            // characterName
            // 
            this.characterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterName.Location = new System.Drawing.Point(12, 401);
            this.characterName.Name = "characterName";
            this.characterName.ReadOnly = true;
            this.characterName.Size = new System.Drawing.Size(278, 49);
            this.characterName.TabIndex = 3;
            this.characterName.Text = "   ???";
            this.characterName.TextChanged += new System.EventHandler(this.characterName_TextChanged);
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.Transparent;
            this.character.Image = global::FormsAdventure2.Properties.Resources.winston_shadow;
            this.character.Location = new System.Drawing.Point(296, 58);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(858, 873);
            this.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.character.TabIndex = 4;
            this.character.TabStop = false;
            this.character.Click += new System.EventHandler(this.character_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Location1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::FormsAdventure2.Properties.Resources.Overwatch_moon_map;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.storyBox);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.character);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Location1";
            this.Text = "Location1";
            this.Load += new System.EventHandler(this.Location1_Load);
            this.Click += new System.EventHandler(this.Location1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox storyBox;
        private System.Windows.Forms.RichTextBox characterName;
        private System.Windows.Forms.PictureBox character;
        private System.Windows.Forms.Button button2;
    }
}