namespace FormsAdventure2
{
    partial class FormBattleArena
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
            this.Hero = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.storyBox = new System.Windows.Forms.RichTextBox();
            this.Btn_Move1 = new System.Windows.Forms.Button();
            this.Btn_Move2 = new System.Windows.Forms.Button();
            this.Btn_Move3 = new System.Windows.Forms.Button();
            this.Btn_Move4 = new System.Windows.Forms.Button();
            this.heroName = new System.Windows.Forms.TextBox();
            this.heroHP = new System.Windows.Forms.TextBox();
            this.heroDmg = new System.Windows.Forms.TextBox();
            this.enemyDmg = new System.Windows.Forms.TextBox();
            this.enemyHP = new System.Windows.Forms.TextBox();
            this.enemyName = new System.Windows.Forms.TextBox();
            this.Btn_Inventory = new System.Windows.Forms.Button();
            this.img_heroStats = new System.Windows.Forms.PictureBox();
            this.img_enemyStats = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_heroStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_enemyStats)).BeginInit();
            this.SuspendLayout();
            // 
            // Hero
            // 
            this.Hero.BackColor = System.Drawing.Color.Transparent;
            this.Hero.Image = global::FormsAdventure2.Properties.Resources.tracer;
            this.Hero.Location = new System.Drawing.Point(354, 96);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(179, 326);
            this.Hero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hero.TabIndex = 0;
            this.Hero.TabStop = false;
            this.Hero.Click += new System.EventHandler(this.Poke_tracer_Click);
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Transparent;
            this.Enemy.Image = global::FormsAdventure2.Properties.Resources.widowmaker;
            this.Enemy.Location = new System.Drawing.Point(677, 0);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(247, 281);
            this.Enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy.TabIndex = 1;
            this.Enemy.TabStop = false;
            this.Enemy.Click += new System.EventHandler(this.Enemy_widow_Click);
            // 
            // storyBox
            // 
            this.storyBox.BackColor = System.Drawing.SystemColors.Control;
            this.storyBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.storyBox.Font = new System.Drawing.Font("Segoe UI", 26.75F);
            this.storyBox.Location = new System.Drawing.Point(12, 456);
            this.storyBox.Name = "storyBox";
            this.storyBox.ReadOnly = true;
            this.storyBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.storyBox.Size = new System.Drawing.Size(996, 213);
            this.storyBox.TabIndex = 3;
            this.storyBox.Text = "                                         Pick a Move";
            this.storyBox.TextChanged += new System.EventHandler(this.storyBox_TextChanged);
            // 
            // Btn_Move1
            // 
            this.Btn_Move1.Location = new System.Drawing.Point(41, 547);
            this.Btn_Move1.Name = "Btn_Move1";
            this.Btn_Move1.Size = new System.Drawing.Size(210, 86);
            this.Btn_Move1.TabIndex = 4;
            this.Btn_Move1.Text = "Pulse Pistols\r\nDamage: 25\r\nMoves Remaining: 3 / 3\r\n";
            this.Btn_Move1.UseVisualStyleBackColor = true;
            this.Btn_Move1.Click += new System.EventHandler(this.Move1_Click);
            // 
            // Btn_Move2
            // 
            this.Btn_Move2.Location = new System.Drawing.Point(284, 547);
            this.Btn_Move2.Name = "Btn_Move2";
            this.Btn_Move2.Size = new System.Drawing.Size(210, 86);
            this.Btn_Move2.TabIndex = 5;
            this.Btn_Move2.Text = "Melee\r\nDamage: 15";
            this.Btn_Move2.UseVisualStyleBackColor = true;
            this.Btn_Move2.Click += new System.EventHandler(this.Move2_Click);
            // 
            // Btn_Move3
            // 
            this.Btn_Move3.Location = new System.Drawing.Point(529, 547);
            this.Btn_Move3.Name = "Btn_Move3";
            this.Btn_Move3.Size = new System.Drawing.Size(210, 86);
            this.Btn_Move3.TabIndex = 6;
            this.Btn_Move3.Text = "Blink\r\nDamage: 200^0";
            this.Btn_Move3.UseVisualStyleBackColor = true;
            this.Btn_Move3.Click += new System.EventHandler(this.Move3_Click);
            // 
            // Btn_Move4
            // 
            this.Btn_Move4.Location = new System.Drawing.Point(770, 547);
            this.Btn_Move4.Name = "Btn_Move4";
            this.Btn_Move4.Size = new System.Drawing.Size(210, 86);
            this.Btn_Move4.TabIndex = 7;
            this.Btn_Move4.Text = "Pulse Bomb\r\nDamage: 45\r\nMoves Remaining: 2 / 2\r\n";
            this.Btn_Move4.UseVisualStyleBackColor = true;
            this.Btn_Move4.Click += new System.EventHandler(this.Move4_Click);
            // 
            // heroName
            // 
            this.heroName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.heroName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroName.Location = new System.Drawing.Point(695, 342);
            this.heroName.Name = "heroName";
            this.heroName.ReadOnly = true;
            this.heroName.Size = new System.Drawing.Size(79, 29);
            this.heroName.TabIndex = 9;
            this.heroName.Text = "Hero";
            this.heroName.TextChanged += new System.EventHandler(this.Poke_name_TextChanged);
            // 
            // heroHP
            // 
            this.heroHP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.heroHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroHP.Location = new System.Drawing.Point(789, 326);
            this.heroHP.Name = "heroHP";
            this.heroHP.ReadOnly = true;
            this.heroHP.Size = new System.Drawing.Size(74, 27);
            this.heroHP.TabIndex = 10;
            this.heroHP.Text = "HP:";
            this.heroHP.TextChanged += new System.EventHandler(this.Poke_HP_TextChanged);
            // 
            // heroDmg
            // 
            this.heroDmg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.heroDmg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroDmg.Location = new System.Drawing.Point(869, 326);
            this.heroDmg.Name = "heroDmg";
            this.heroDmg.ReadOnly = true;
            this.heroDmg.Size = new System.Drawing.Size(130, 27);
            this.heroDmg.TabIndex = 11;
            this.heroDmg.Text = "Damage:";
            this.heroDmg.TextChanged += new System.EventHandler(this.Poke_Dmg_TextChanged);
            // 
            // enemyDmg
            // 
            this.enemyDmg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.enemyDmg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyDmg.Location = new System.Drawing.Point(1122, 157);
            this.enemyDmg.Name = "enemyDmg";
            this.enemyDmg.ReadOnly = true;
            this.enemyDmg.Size = new System.Drawing.Size(130, 27);
            this.enemyDmg.TabIndex = 15;
            this.enemyDmg.Text = "Damage:";
            this.enemyDmg.TextChanged += new System.EventHandler(this.Enemy_Dmg_TextChanged);
            // 
            // enemyHP
            // 
            this.enemyHP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.enemyHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyHP.Location = new System.Drawing.Point(1042, 157);
            this.enemyHP.Name = "enemyHP";
            this.enemyHP.ReadOnly = true;
            this.enemyHP.Size = new System.Drawing.Size(74, 27);
            this.enemyHP.TabIndex = 14;
            this.enemyHP.Text = "HP:";
            this.enemyHP.TextChanged += new System.EventHandler(this.Enemy_HP_TextChanged);
            // 
            // enemyName
            // 
            this.enemyName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.enemyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyName.Location = new System.Drawing.Point(947, 173);
            this.enemyName.Name = "enemyName";
            this.enemyName.ReadOnly = true;
            this.enemyName.Size = new System.Drawing.Size(78, 29);
            this.enemyName.TabIndex = 13;
            this.enemyName.Text = "Enemy";
            // 
            // Btn_Inventory
            // 
            this.Btn_Inventory.BackColor = System.Drawing.Color.Gray;
            this.Btn_Inventory.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inventory.ForeColor = System.Drawing.Color.White;
            this.Btn_Inventory.Location = new System.Drawing.Point(1015, 456);
            this.Btn_Inventory.Name = "Btn_Inventory";
            this.Btn_Inventory.Size = new System.Drawing.Size(237, 68);
            this.Btn_Inventory.TabIndex = 16;
            this.Btn_Inventory.Text = "Inventory";
            this.Btn_Inventory.UseVisualStyleBackColor = false;
            this.Btn_Inventory.Click += new System.EventHandler(this.Btn_Inventory_Click);
            // 
            // img_heroStats
            // 
            this.img_heroStats.Image = global::FormsAdventure2.Properties.Resources.stats_background;
            this.img_heroStats.Location = new System.Drawing.Point(677, 312);
            this.img_heroStats.Name = "img_heroStats";
            this.img_heroStats.Size = new System.Drawing.Size(334, 88);
            this.img_heroStats.TabIndex = 17;
            this.img_heroStats.TabStop = false;
            // 
            // img_enemyStats
            // 
            this.img_enemyStats.Image = global::FormsAdventure2.Properties.Resources.stats_background;
            this.img_enemyStats.Location = new System.Drawing.Point(927, 143);
            this.img_enemyStats.Name = "img_enemyStats";
            this.img_enemyStats.Size = new System.Drawing.Size(334, 88);
            this.img_enemyStats.TabIndex = 18;
            this.img_enemyStats.TabStop = false;
            // 
            // FormBattleArena
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::FormsAdventure2.Properties.Resources.Kings_Row_Arena;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1424, 681);
            this.Controls.Add(this.Btn_Inventory);
            this.Controls.Add(this.enemyDmg);
            this.Controls.Add(this.enemyHP);
            this.Controls.Add(this.enemyName);
            this.Controls.Add(this.heroDmg);
            this.Controls.Add(this.heroHP);
            this.Controls.Add(this.heroName);
            this.Controls.Add(this.Btn_Move4);
            this.Controls.Add(this.Btn_Move3);
            this.Controls.Add(this.Btn_Move2);
            this.Controls.Add(this.Btn_Move1);
            this.Controls.Add(this.storyBox);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Hero);
            this.Controls.Add(this.img_heroStats);
            this.Controls.Add(this.img_enemyStats);
            this.Name = "FormBattleArena";
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_heroStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_enemyStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Hero;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.RichTextBox storyBox;
        private System.Windows.Forms.Button Btn_Move1;
        private System.Windows.Forms.Button Btn_Move2;
        private System.Windows.Forms.Button Btn_Move3;
        private System.Windows.Forms.Button Btn_Move4;
        private System.Windows.Forms.TextBox heroName;
        private System.Windows.Forms.TextBox heroDmg;
        private System.Windows.Forms.TextBox enemyDmg;
        private System.Windows.Forms.TextBox enemyName;
        private System.Windows.Forms.Button Btn_Inventory;
        private System.Windows.Forms.PictureBox img_heroStats;
        private System.Windows.Forms.PictureBox img_enemyStats;
        public System.Windows.Forms.TextBox heroHP;
        public System.Windows.Forms.TextBox enemyHP;
    }
}