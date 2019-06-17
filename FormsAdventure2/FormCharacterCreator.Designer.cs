namespace FormsAdventure2
{
    partial class FormCharacterCreator
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Gbox_Gender = new System.Windows.Forms.GroupBox();
            this.Rbo_GenderFemale = new System.Windows.Forms.RadioButton();
            this.Rbo_GenderMale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gbox_Gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(12, 20);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(53, 20);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Gbox_Gender
            // 
            this.Gbox_Gender.Controls.Add(this.Rbo_GenderFemale);
            this.Gbox_Gender.Controls.Add(this.Rbo_GenderMale);
            this.Gbox_Gender.Location = new System.Drawing.Point(12, 56);
            this.Gbox_Gender.Name = "Gbox_Gender";
            this.Gbox_Gender.Size = new System.Drawing.Size(167, 52);
            this.Gbox_Gender.TabIndex = 3;
            this.Gbox_Gender.TabStop = false;
            this.Gbox_Gender.Text = "Gender";
            // 
            // Rbo_GenderFemale
            // 
            this.Rbo_GenderFemale.AutoSize = true;
            this.Rbo_GenderFemale.Location = new System.Drawing.Point(90, 19);
            this.Rbo_GenderFemale.Name = "Rbo_GenderFemale";
            this.Rbo_GenderFemale.Size = new System.Drawing.Size(59, 17);
            this.Rbo_GenderFemale.TabIndex = 5;
            this.Rbo_GenderFemale.TabStop = true;
            this.Rbo_GenderFemale.Text = "Female";
            this.Rbo_GenderFemale.UseVisualStyleBackColor = true;
            // 
            // Rbo_GenderMale
            // 
            this.Rbo_GenderMale.AutoSize = true;
            this.Rbo_GenderMale.Location = new System.Drawing.Point(18, 19);
            this.Rbo_GenderMale.Name = "Rbo_GenderMale";
            this.Rbo_GenderMale.Size = new System.Drawing.Size(48, 17);
            this.Rbo_GenderMale.TabIndex = 4;
            this.Rbo_GenderMale.TabStop = true;
            this.Rbo_GenderMale.Text = "Male";
            this.Rbo_GenderMale.UseVisualStyleBackColor = true;
            this.Rbo_GenderMale.CheckedChanged += new System.EventHandler(this.Rbo_GenderMale_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save Character";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormsAdventure2.Properties.Resources.updated_character;
            this.pictureBox1.Location = new System.Drawing.Point(185, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormCharacterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(328, 185);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Gbox_Gender);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCharacterCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCharacterCreator_FormClosing);
            this.Load += new System.EventHandler(this.FormCharacterCreator_Load);
            this.Gbox_Gender.ResumeLayout(false);
            this.Gbox_Gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox Gbox_Gender;
        private System.Windows.Forms.RadioButton Rbo_GenderFemale;
        private System.Windows.Forms.RadioButton Rbo_GenderMale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}