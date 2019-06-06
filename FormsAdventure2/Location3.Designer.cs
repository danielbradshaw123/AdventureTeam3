namespace FormsAdventure2
{
    partial class Location3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Location3));
            this.button1 = new System.Windows.Forms.Button();
            this.storyBox = new System.Windows.Forms.RichTextBox();
            this.characterName = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1003, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(404, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go to location 4";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // storyBox
            // 
            this.storyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyBox.Location = new System.Drawing.Point(13, 506);
            this.storyBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.storyBox.Name = "storyBox";
            this.storyBox.Size = new System.Drawing.Size(1330, 247);
            this.storyBox.TabIndex = 2;
            this.storyBox.Text = "come at me";
            this.storyBox.TextChanged += new System.EventHandler(this.storyBox_TextChanged);
            // 
            // characterName
            // 
            this.characterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.characterName.Location = new System.Drawing.Point(18, 435);
            this.characterName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(415, 73);
            this.characterName.TabIndex = 3;
            this.characterName.Text = "  Yuri";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(593, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(404, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Go back to location 3 ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Location3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 788);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.storyBox);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.button1);
            this.Name = "Location3";
            this.RightToLeftLayout = true;
            this.Text = "LocationTemplate1";
            this.Load += new System.EventHandler(this.Location3_Load);
            this.Click += new System.EventHandler(this.Location1_Click);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox storyBox;
        private System.Windows.Forms.RichTextBox characterName;
        private System.Windows.Forms.Button button2;
    }
}