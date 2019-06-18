namespace FormsAdventure2
{
    partial class Inventory
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
            this.img_Biotic = new System.Windows.Forms.PictureBox();
            this.lbl_BioticGrenade = new System.Windows.Forms.Label();
            this.lbl_BioticDesc = new System.Windows.Forms.Label();
            this.lbl_BioticAmount = new System.Windows.Forms.Label();
            this.lbl_itemless = new System.Windows.Forms.Label();
            this.Btn_closeInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_Biotic)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Biotic
            // 
            this.img_Biotic.BackColor = System.Drawing.Color.Transparent;
            this.img_Biotic.Image = global::FormsAdventure2.Properties.Resources.biotic_grenade;
            this.img_Biotic.Location = new System.Drawing.Point(81, 81);
            this.img_Biotic.Name = "img_Biotic";
            this.img_Biotic.Size = new System.Drawing.Size(48, 54);
            this.img_Biotic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Biotic.TabIndex = 0;
            this.img_Biotic.TabStop = false;
            this.img_Biotic.Click += new System.EventHandler(this.lbl_BioticGrenade_Click);
            // 
            // lbl_BioticGrenade
            // 
            this.lbl_BioticGrenade.AutoSize = true;
            this.lbl_BioticGrenade.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BioticGrenade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.lbl_BioticGrenade.ForeColor = System.Drawing.Color.White;
            this.lbl_BioticGrenade.Location = new System.Drawing.Point(135, 94);
            this.lbl_BioticGrenade.Name = "lbl_BioticGrenade";
            this.lbl_BioticGrenade.Size = new System.Drawing.Size(170, 26);
            this.lbl_BioticGrenade.TabIndex = 1;
            this.lbl_BioticGrenade.Text = "Biotic Grenade";
            this.lbl_BioticGrenade.Click += new System.EventHandler(this.lbl_BioticGrenade_Click);
            // 
            // lbl_BioticDesc
            // 
            this.lbl_BioticDesc.AutoSize = true;
            this.lbl_BioticDesc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BioticDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BioticDesc.ForeColor = System.Drawing.Color.White;
            this.lbl_BioticDesc.Location = new System.Drawing.Point(311, 104);
            this.lbl_BioticDesc.Name = "lbl_BioticDesc";
            this.lbl_BioticDesc.Size = new System.Drawing.Size(121, 13);
            this.lbl_BioticDesc.TabIndex = 2;
            this.lbl_BioticDesc.Text = "Instantly replenish 25HP";
            this.lbl_BioticDesc.Click += new System.EventHandler(this.lbl_BioticGrenade_Click);
            // 
            // lbl_BioticAmount
            // 
            this.lbl_BioticAmount.AutoSize = true;
            this.lbl_BioticAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BioticAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.lbl_BioticAmount.ForeColor = System.Drawing.Color.White;
            this.lbl_BioticAmount.Location = new System.Drawing.Point(38, 94);
            this.lbl_BioticAmount.Name = "lbl_BioticAmount";
            this.lbl_BioticAmount.Size = new System.Drawing.Size(37, 26);
            this.lbl_BioticAmount.TabIndex = 3;
            this.lbl_BioticAmount.Text = "1x";
            this.lbl_BioticAmount.Click += new System.EventHandler(this.lbl_BioticGrenade_Click);
            // 
            // lbl_itemless
            // 
            this.lbl_itemless.AutoSize = true;
            this.lbl_itemless.BackColor = System.Drawing.Color.Transparent;
            this.lbl_itemless.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemless.ForeColor = System.Drawing.Color.White;
            this.lbl_itemless.Location = new System.Drawing.Point(67, 182);
            this.lbl_itemless.Name = "lbl_itemless";
            this.lbl_itemless.Size = new System.Drawing.Size(365, 25);
            this.lbl_itemless.TabIndex = 4;
            this.lbl_itemless.Text = "Uh oh! Looks like you\'re out of items.";
            this.lbl_itemless.Visible = false;
            // 
            // Btn_closeInventory
            // 
            this.Btn_closeInventory.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_closeInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Btn_closeInventory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_closeInventory.Location = new System.Drawing.Point(210, 288);
            this.Btn_closeInventory.Name = "Btn_closeInventory";
            this.Btn_closeInventory.Size = new System.Drawing.Size(95, 32);
            this.Btn_closeInventory.TabIndex = 5;
            this.Btn_closeInventory.Text = "Close";
            this.Btn_closeInventory.UseVisualStyleBackColor = false;
            this.Btn_closeInventory.Click += new System.EventHandler(this.Btn_closeInventory_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormsAdventure2.Properties.Resources.inventory_screen;
            this.ClientSize = new System.Drawing.Size(495, 347);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_closeInventory);
            this.Controls.Add(this.lbl_itemless);
            this.Controls.Add(this.lbl_BioticAmount);
            this.Controls.Add(this.lbl_BioticDesc);
            this.Controls.Add(this.lbl_BioticGrenade);
            this.Controls.Add(this.img_Biotic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inventory_FormClosing);
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Biotic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_Biotic;
        private System.Windows.Forms.Label lbl_BioticGrenade;
        private System.Windows.Forms.Label lbl_BioticDesc;
        private System.Windows.Forms.Label lbl_BioticAmount;
        private System.Windows.Forms.Label lbl_itemless;
        private System.Windows.Forms.Button Btn_closeInventory;
    }
}