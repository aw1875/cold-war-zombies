
namespace BigK.Panels
{
    partial class ZombiesForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tpZombiesToMeBtn = new FontAwesome.Sharp.IconButton();
            this.skipRoundsToggle = new BigK.Controls.ToggleButton();
            this.teleportCrosshairsToggle = new BigK.Controls.ToggleButton();
            this.critOnlyToggle = new BigK.Controls.ToggleButton();
            this.teleportZombiesToggle = new BigK.Controls.ToggleButton();
            this.instaKillToggle = new BigK.Controls.ToggleButton();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label6.Location = new System.Drawing.Point(43, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Zombie Mods";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Follow The Leader";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Insta Kill";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Crit Kills";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "TP to Crosshairs";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Skip Rounds";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpZombiesToMeBtn
            // 
            this.tpZombiesToMeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tpZombiesToMeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpZombiesToMeBtn.FlatAppearance.BorderSize = 0;
            this.tpZombiesToMeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tpZombiesToMeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tpZombiesToMeBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tpZombiesToMeBtn.IconColor = System.Drawing.Color.Black;
            this.tpZombiesToMeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tpZombiesToMeBtn.Location = new System.Drawing.Point(15, 302);
            this.tpZombiesToMeBtn.Name = "tpZombiesToMeBtn";
            this.tpZombiesToMeBtn.Size = new System.Drawing.Size(182, 31);
            this.tpZombiesToMeBtn.TabIndex = 45;
            this.tpZombiesToMeBtn.Text = "TP Zombies to Me";
            this.tpZombiesToMeBtn.UseVisualStyleBackColor = false;
            this.tpZombiesToMeBtn.Click += new System.EventHandler(this.tpZombiesToMeBtn_Click);
            // 
            // skipRoundsToggle
            // 
            this.skipRoundsToggle.AutoSize = true;
            this.skipRoundsToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skipRoundsToggle.Location = new System.Drawing.Point(134, 261);
            this.skipRoundsToggle.MinimumSize = new System.Drawing.Size(62, 31);
            this.skipRoundsToggle.Name = "skipRoundsToggle";
            this.skipRoundsToggle.OffBackColor = System.Drawing.Color.Gray;
            this.skipRoundsToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.skipRoundsToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.skipRoundsToggle.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.skipRoundsToggle.Size = new System.Drawing.Size(62, 31);
            this.skipRoundsToggle.Sizes = new System.Drawing.Size(62, 31);
            this.skipRoundsToggle.TabIndex = 44;
            this.skipRoundsToggle.UseVisualStyleBackColor = true;
            this.skipRoundsToggle.Click += new System.EventHandler(this.skipRoundsToggle_Click);
            // 
            // teleportCrosshairsToggle
            // 
            this.teleportCrosshairsToggle.AutoSize = true;
            this.teleportCrosshairsToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teleportCrosshairsToggle.Location = new System.Drawing.Point(134, 221);
            this.teleportCrosshairsToggle.MinimumSize = new System.Drawing.Size(62, 31);
            this.teleportCrosshairsToggle.Name = "teleportCrosshairsToggle";
            this.teleportCrosshairsToggle.OffBackColor = System.Drawing.Color.Gray;
            this.teleportCrosshairsToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.teleportCrosshairsToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.teleportCrosshairsToggle.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.teleportCrosshairsToggle.Size = new System.Drawing.Size(62, 31);
            this.teleportCrosshairsToggle.Sizes = new System.Drawing.Size(62, 31);
            this.teleportCrosshairsToggle.TabIndex = 42;
            this.teleportCrosshairsToggle.UseVisualStyleBackColor = true;
            this.teleportCrosshairsToggle.Click += new System.EventHandler(this.teleportCrosshairsToggle_Click);
            // 
            // critOnlyToggle
            // 
            this.critOnlyToggle.AutoSize = true;
            this.critOnlyToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.critOnlyToggle.Location = new System.Drawing.Point(134, 181);
            this.critOnlyToggle.MinimumSize = new System.Drawing.Size(62, 31);
            this.critOnlyToggle.Name = "critOnlyToggle";
            this.critOnlyToggle.OffBackColor = System.Drawing.Color.Gray;
            this.critOnlyToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.critOnlyToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.critOnlyToggle.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.critOnlyToggle.Size = new System.Drawing.Size(62, 31);
            this.critOnlyToggle.Sizes = new System.Drawing.Size(62, 31);
            this.critOnlyToggle.TabIndex = 40;
            this.critOnlyToggle.UseVisualStyleBackColor = true;
            this.critOnlyToggle.Click += new System.EventHandler(this.critOnlyToggle_Click);
            // 
            // teleportZombiesToggle
            // 
            this.teleportZombiesToggle.AutoSize = true;
            this.teleportZombiesToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teleportZombiesToggle.Location = new System.Drawing.Point(135, 140);
            this.teleportZombiesToggle.MinimumSize = new System.Drawing.Size(61, 31);
            this.teleportZombiesToggle.Name = "teleportZombiesToggle";
            this.teleportZombiesToggle.OffBackColor = System.Drawing.Color.Gray;
            this.teleportZombiesToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.teleportZombiesToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.teleportZombiesToggle.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.teleportZombiesToggle.Size = new System.Drawing.Size(61, 31);
            this.teleportZombiesToggle.Sizes = new System.Drawing.Size(61, 31);
            this.teleportZombiesToggle.TabIndex = 26;
            this.teleportZombiesToggle.UseVisualStyleBackColor = true;
            this.teleportZombiesToggle.Click += new System.EventHandler(this.teleportZombiesToggle_Click);
            // 
            // instaKillToggle
            // 
            this.instaKillToggle.AutoSize = true;
            this.instaKillToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instaKillToggle.Location = new System.Drawing.Point(135, 99);
            this.instaKillToggle.MinimumSize = new System.Drawing.Size(62, 31);
            this.instaKillToggle.Name = "instaKillToggle";
            this.instaKillToggle.OffBackColor = System.Drawing.Color.Gray;
            this.instaKillToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.instaKillToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.instaKillToggle.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.instaKillToggle.Size = new System.Drawing.Size(62, 31);
            this.instaKillToggle.Sizes = new System.Drawing.Size(62, 31);
            this.instaKillToggle.TabIndex = 24;
            this.instaKillToggle.UseVisualStyleBackColor = true;
            this.instaKillToggle.Click += new System.EventHandler(this.instaKillToggle_Click);
            // 
            // ZombiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(600, 375);
            this.Controls.Add(this.tpZombiesToMeBtn);
            this.Controls.Add(this.skipRoundsToggle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.teleportCrosshairsToggle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.critOnlyToggle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.teleportZombiesToggle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.instaKillToggle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZombiesForm";
            this.Text = "ZombiesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZombiesForm_FormClosing);
            this.Load += new System.EventHandler(this.ZombiesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private Controls.ToggleButton teleportZombiesToggle;
        private System.Windows.Forms.Label label2;
        private Controls.ToggleButton instaKillToggle;
        private System.Windows.Forms.Label label1;
        private Controls.ToggleButton critOnlyToggle;
        private System.Windows.Forms.Label label3;
        private Controls.ToggleButton teleportCrosshairsToggle;
        private System.Windows.Forms.Label label4;
        private Controls.ToggleButton skipRoundsToggle;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton tpZombiesToMeBtn;
    }
}