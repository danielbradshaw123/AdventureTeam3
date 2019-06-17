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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Location1));
            this.button1 = new System.Windows.Forms.Button();
            this.storyBox = new System.Windows.Forms.RichTextBox();
            this.characterName = new System.Windows.Forms.RichTextBox();
            this.shadow = new System.Windows.Forms.PictureBox();
            this.character = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.Btn_CharacterCreator = new System.Windows.Forms.Button();
            this.Btn_Battle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shadow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // storyBox
            // 
            this.storyBox.BackColor = System.Drawing.Color.White;
            this.storyBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.storyBox.Font = new System.Drawing.Font("Segoe UI", 26.75F);
            this.storyBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.storyBox.Location = new System.Drawing.Point(12, 456);
            this.storyBox.Name = "storyBox";
            this.storyBox.ReadOnly = true;
            this.storyBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.storyBox.Size = new System.Drawing.Size(996, 213);
            this.storyBox.TabIndex = 2;
            this.storyBox.Text = " Hmm. Is this on?";
            this.storyBox.Click += new System.EventHandler(this.character_Click_1);
            this.storyBox.TextChanged += new System.EventHandler(this.storyBox_TextChanged);
            // 
            // characterName
            // 
            this.characterName.BackColor = System.Drawing.Color.White;
            this.characterName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.characterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterName.Location = new System.Drawing.Point(12, 401);
            this.characterName.Name = "characterName";
            this.characterName.ReadOnly = true;
            this.characterName.Size = new System.Drawing.Size(278, 49);
            this.characterName.TabIndex = 3;
            this.characterName.Text = "   ???";
            this.characterName.Click += new System.EventHandler(this.character_Click_1);
            this.characterName.TextChanged += new System.EventHandler(this.characterName_TextChanged);
            // 
            // shadow
            // 
            this.shadow.BackColor = System.Drawing.Color.Transparent;
            this.shadow.Image = global::FormsAdventure2.Properties.Resources.winston_shadow;
            this.shadow.Location = new System.Drawing.Point(206, 45);
            this.shadow.Name = "shadow";
            this.shadow.Size = new System.Drawing.Size(974, 638);
            this.shadow.TabIndex = 4;
            this.shadow.TabStop = false;
            this.shadow.Click += new System.EventHandler(this.character_Click_1);
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.Transparent;
            this.character.Image = global::FormsAdventure2.Properties.Resources.winston;
            this.character.Location = new System.Drawing.Point(206, 45);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(974, 638);
            this.character.TabIndex = 5;
            this.character.TabStop = false;
            this.character.Click += new System.EventHandler(this.character_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormsAdventure2.Properties.Resources.next;
            this.pictureBox2.Location = new System.Drawing.Point(936, 618);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(1015, 456);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(237, 68);
            this.yesButton.TabIndex = 8;
            this.yesButton.Text = "Yes, of course!";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(1014, 530);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(237, 68);
            this.noButton.TabIndex = 9;
            this.noButton.Text = "No. Being a hero trainer sounds too hard...";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // Btn_CharacterCreator
            // 
            this.Btn_CharacterCreator.Location = new System.Drawing.Point(391, 585);
            this.Btn_CharacterCreator.Name = "Btn_CharacterCreator";
            this.Btn_CharacterCreator.Size = new System.Drawing.Size(237, 68);
            this.Btn_CharacterCreator.TabIndex = 10;
            this.Btn_CharacterCreator.Text = "Character Creator";
            this.Btn_CharacterCreator.UseVisualStyleBackColor = true;
            this.Btn_CharacterCreator.Visible = false;
            this.Btn_CharacterCreator.Click += new System.EventHandler(this.Btn_CharacterCreator_Click);
            // 
            // Btn_Battle
            // 
            this.Btn_Battle.Location = new System.Drawing.Point(391, 585);
            this.Btn_Battle.Name = "Btn_Battle";
            this.Btn_Battle.Size = new System.Drawing.Size(237, 68);
            this.Btn_Battle.TabIndex = 11;
            this.Btn_Battle.Text = "Let\'s Battle!";
            this.Btn_Battle.UseVisualStyleBackColor = true;
            this.Btn_Battle.Visible = false;
            this.Btn_Battle.Click += new System.EventHandler(this.Btn_Battle_Click);
            // 
            // Location1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::FormsAdventure2.Properties.Resources.Overwatch_moon_map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1424, 681);
            this.Controls.Add(this.Btn_Battle);
            this.Controls.Add(this.Btn_CharacterCreator);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.storyBox);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shadow);
            this.Controls.Add(this.character);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 720);
            this.Name = "Location1";
            this.Load += new System.EventHandler(this.Location1_Load);
            this.Click += new System.EventHandler(this.Location1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.shadow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox characterName;
        private System.Windows.Forms.PictureBox shadow;
        private System.Windows.Forms.PictureBox character;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button Btn_CharacterCreator;
        private System.Windows.Forms.Button Btn_Battle;
        private System.Windows.Forms.RichTextBox storyBox;
    }
}