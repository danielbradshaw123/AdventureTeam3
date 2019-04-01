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
            this.pnl_main = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_character = new System.Windows.Forms.Panel();
            this.btn_items = new System.Windows.Forms.Button();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_gold = new System.Windows.Forms.Label();
            this.lbl_luck = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_character = new System.Windows.Forms.Label();
            this.pnl_controls = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_main.SuspendLayout();
            this.pnl_character.SuspendLayout();
            this.pnl_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_main.Controls.Add(this.button1);
            this.pnl_main.Location = new System.Drawing.Point(3, 106);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(943, 657);
            this.pnl_main.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnl_character
            // 
            this.pnl_character.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_character.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_character.Controls.Add(this.btn_items);
            this.pnl_character.Controls.Add(this.lbl_score);
            this.pnl_character.Controls.Add(this.lbl_gold);
            this.pnl_character.Controls.Add(this.lbl_luck);
            this.pnl_character.Controls.Add(this.lbl_name);
            this.pnl_character.Controls.Add(this.lbl_character);
            this.pnl_character.Location = new System.Drawing.Point(952, 115);
            this.pnl_character.Name = "pnl_character";
            this.pnl_character.Size = new System.Drawing.Size(218, 642);
            this.pnl_character.TabIndex = 1;
            // 
            // btn_items
            // 
            this.btn_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_items.Location = new System.Drawing.Point(19, 347);
            this.btn_items.Name = "btn_items";
            this.btn_items.Size = new System.Drawing.Size(114, 60);
            this.btn_items.TabIndex = 6;
            this.btn_items.Text = "Items";
            this.btn_items.UseVisualStyleBackColor = true;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(12, 289);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(75, 26);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "Score:";
            // 
            // lbl_gold
            // 
            this.lbl_gold.AutoSize = true;
            this.lbl_gold.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_gold.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gold.Location = new System.Drawing.Point(12, 235);
            this.lbl_gold.Name = "lbl_gold";
            this.lbl_gold.Size = new System.Drawing.Size(64, 26);
            this.lbl_gold.TabIndex = 4;
            this.lbl_gold.Text = "Gold:";
            // 
            // lbl_luck
            // 
            this.lbl_luck.AutoSize = true;
            this.lbl_luck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_luck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_luck.Location = new System.Drawing.Point(12, 175);
            this.lbl_luck.Name = "lbl_luck";
            this.lbl_luck.Size = new System.Drawing.Size(64, 26);
            this.lbl_luck.TabIndex = 3;
            this.lbl_luck.Text = "Luck:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(12, 114);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(83, 26);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name: ";
            // 
            // lbl_character
            // 
            this.lbl_character.AutoSize = true;
            this.lbl_character.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_character.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_character.Location = new System.Drawing.Point(55, 14);
            this.lbl_character.Name = "lbl_character";
            this.lbl_character.Size = new System.Drawing.Size(134, 31);
            this.lbl_character.TabIndex = 1;
            this.lbl_character.Text = "Character";
            // 
            // pnl_controls
            // 
            this.pnl_controls.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_controls.Controls.Add(this.lbl_title);
            this.pnl_controls.Location = new System.Drawing.Point(3, 0);
            this.pnl_controls.Name = "pnl_controls";
            this.pnl_controls.Size = new System.Drawing.Size(1401, 109);
            this.pnl_controls.TabIndex = 3;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(48, 31);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(344, 31);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Awesome Adventure Game";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 760);
            this.Controls.Add(this.pnl_controls);
            this.Controls.Add(this.pnl_character);
            this.Controls.Add(this.pnl_main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_main";
            this.Text = "Awesome Adventure";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_main.ResumeLayout(false);
            this.pnl_character.ResumeLayout(false);
            this.pnl_character.PerformLayout();
            this.pnl_controls.ResumeLayout(false);
            this.pnl_controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_character;
        private System.Windows.Forms.Panel pnl_controls;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_character;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_items;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_gold;
        private System.Windows.Forms.Label lbl_luck;
        private System.Windows.Forms.Button button1;
    }
}

