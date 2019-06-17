namespace FormsAdventure2
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.txt_NameBox = new System.Windows.Forms.RichTextBox();
            this.txt_Gender = new System.Windows.Forms.RichTextBox();
            this.txt_currentHero = new System.Windows.Forms.RichTextBox();
            this.txt_Score = new System.Windows.Forms.RichTextBox();
            this.txt_Credits = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_main.Location = new System.Drawing.Point(-2, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1266, 682);
            this.pnl_main.TabIndex = 0;
            this.pnl_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_main_Paint_1);
            // 
            // txt_NameBox
            // 
            this.txt_NameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NameBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_NameBox.Location = new System.Drawing.Point(1272, 111);
            this.txt_NameBox.Name = "txt_NameBox";
            this.txt_NameBox.ReadOnly = true;
            this.txt_NameBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_NameBox.Size = new System.Drawing.Size(142, 59);
            this.txt_NameBox.TabIndex = 1;
            this.txt_NameBox.Text = "Name:";
            this.txt_NameBox.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // txt_Gender
            // 
            this.txt_Gender.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_Gender.Location = new System.Drawing.Point(1272, 196);
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.ReadOnly = true;
            this.txt_Gender.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_Gender.Size = new System.Drawing.Size(142, 34);
            this.txt_Gender.TabIndex = 2;
            this.txt_Gender.Text = "Gender:";
            // 
            // txt_currentHero
            // 
            this.txt_currentHero.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_currentHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_currentHero.Location = new System.Drawing.Point(1272, 257);
            this.txt_currentHero.Name = "txt_currentHero";
            this.txt_currentHero.ReadOnly = true;
            this.txt_currentHero.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_currentHero.Size = new System.Drawing.Size(142, 35);
            this.txt_currentHero.TabIndex = 3;
            this.txt_currentHero.Text = "Hero:";
            // 
            // txt_Score
            // 
            this.txt_Score.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Score.Location = new System.Drawing.Point(1272, 320);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.ReadOnly = true;
            this.txt_Score.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_Score.Size = new System.Drawing.Size(142, 36);
            this.txt_Score.TabIndex = 4;
            this.txt_Score.Text = "Score:";
            // 
            // txt_Credits
            // 
            this.txt_Credits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Credits.Cursor = System.Windows.Forms.Cursors.Help;
            this.txt_Credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F);
            this.txt_Credits.Location = new System.Drawing.Point(1272, 383);
            this.txt_Credits.Name = "txt_Credits";
            this.txt_Credits.ReadOnly = true;
            this.txt_Credits.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_Credits.Size = new System.Drawing.Size(142, 286);
            this.txt_Credits.TabIndex = 5;
            this.txt_Credits.Text = "Developed by Jordan\nLocation by Peter\n\'Graphics\' by Samuel\nBeing There by Jerial\n" +
    "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormsAdventure2.Properties.Resources.sidebar_background;
            this.pictureBox1.Location = new System.Drawing.Point(1264, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 682);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackColor = System.Drawing.SystemColors.Control;
            this.pic_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Logo.Image = global::FormsAdventure2.Properties.Resources.small_logo;
            this.pic_Logo.Location = new System.Drawing.Point(1273, 12);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(142, 92);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Logo.TabIndex = 6;
            this.pic_Logo.TabStop = false;
            // 
            // frm_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1424, 681);
            this.Controls.Add(this.pic_Logo);
            this.Controls.Add(this.txt_Credits);
            this.Controls.Add(this.txt_Score);
            this.Controls.Add(this.txt_currentHero);
            this.Controls.Add(this.txt_Gender);
            this.Controls.Add(this.txt_NameBox);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PokéWatch | Ver. 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.RichTextBox txt_Gender;
        private System.Windows.Forms.RichTextBox txt_currentHero;
        private System.Windows.Forms.RichTextBox txt_Score;
        private System.Windows.Forms.RichTextBox txt_Credits;
        private System.Windows.Forms.PictureBox pic_Logo;
        public System.Windows.Forms.RichTextBox txt_NameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

