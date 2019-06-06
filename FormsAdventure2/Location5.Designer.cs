namespace FormsAdventure2
{
    partial class Location5
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(764, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(404, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go to location 2 to party";
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
            this.storyBox.Text = "Ima goina get ya";
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
            this.characterName.Text = "That one Gummy bear";
            // 
            // Location5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::FormsAdventure2.Properties.Resources.download__9_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 788);
            this.Controls.Add(this.storyBox);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.button1);
            this.Name = "Location5";
            this.Text = "LocationTemplate2";
            this.Click += new System.EventHandler(this.Location1_Click);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox storyBox;
        private System.Windows.Forms.RichTextBox characterName;
    }
}