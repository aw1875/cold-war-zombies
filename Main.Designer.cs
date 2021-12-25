
namespace BigK
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.trollingBtn = new FontAwesome.Sharp.IconButton();
            this.zombieBtn = new FontAwesome.Sharp.IconButton();
            this.userBtn = new FontAwesome.Sharp.IconButton();
            this.lobbyBtn = new FontAwesome.Sharp.IconButton();
            this.onlineBtn = new FontAwesome.Sharp.IconButton();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.zombieCounterLabel = new System.Windows.Forms.Label();
            this.attachBtn = new FontAwesome.Sharp.IconButton();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.mainThread = new System.ComponentModel.BackgroundWorker();
            this.childPanelForm = new System.Windows.Forms.Panel();
            this.nameThread = new System.ComponentModel.BackgroundWorker();
            this.zombieCounterThread = new System.ComponentModel.BackgroundWorker();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.leftPanel.Controls.Add(this.trollingBtn);
            this.leftPanel.Controls.Add(this.zombieBtn);
            this.leftPanel.Controls.Add(this.userBtn);
            this.leftPanel.Controls.Add(this.lobbyBtn);
            this.leftPanel.Controls.Add(this.onlineBtn);
            this.leftPanel.Controls.Add(this.logoPicture);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 425);
            this.leftPanel.TabIndex = 0;
            this.leftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllowDrag);
            // 
            // trollingBtn
            // 
            this.trollingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trollingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.trollingBtn.FlatAppearance.BorderSize = 0;
            this.trollingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trollingBtn.Font = new System.Drawing.Font("Souses", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trollingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.trollingBtn.IconChar = FontAwesome.Sharp.IconChar.GrinSquintTears;
            this.trollingBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.trollingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.trollingBtn.IconSize = 32;
            this.trollingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trollingBtn.Location = new System.Drawing.Point(0, 365);
            this.trollingBtn.Name = "trollingBtn";
            this.trollingBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.trollingBtn.Size = new System.Drawing.Size(200, 60);
            this.trollingBtn.TabIndex = 9;
            this.trollingBtn.Text = "Trolling";
            this.trollingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trollingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.trollingBtn.UseVisualStyleBackColor = true;
            this.trollingBtn.Click += new System.EventHandler(this.ActivateButton);
            // 
            // zombieBtn
            // 
            this.zombieBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zombieBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.zombieBtn.FlatAppearance.BorderSize = 0;
            this.zombieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zombieBtn.Font = new System.Drawing.Font("Souses", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zombieBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.zombieBtn.IconChar = FontAwesome.Sharp.IconChar.Biohazard;
            this.zombieBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.zombieBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.zombieBtn.IconSize = 32;
            this.zombieBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zombieBtn.Location = new System.Drawing.Point(0, 305);
            this.zombieBtn.Name = "zombieBtn";
            this.zombieBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.zombieBtn.Size = new System.Drawing.Size(200, 60);
            this.zombieBtn.TabIndex = 7;
            this.zombieBtn.Text = "Zombies";
            this.zombieBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zombieBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.zombieBtn.UseVisualStyleBackColor = true;
            this.zombieBtn.Click += new System.EventHandler(this.ActivateButton);
            // 
            // userBtn
            // 
            this.userBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.userBtn.FlatAppearance.BorderSize = 0;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Font = new System.Drawing.Font("Souses", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.userBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.userBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.userBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userBtn.IconSize = 32;
            this.userBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userBtn.Location = new System.Drawing.Point(0, 245);
            this.userBtn.Name = "userBtn";
            this.userBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.userBtn.Size = new System.Drawing.Size(200, 60);
            this.userBtn.TabIndex = 6;
            this.userBtn.Text = "User";
            this.userBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.ActivateButton);
            // 
            // lobbyBtn
            // 
            this.lobbyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lobbyBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lobbyBtn.FlatAppearance.BorderSize = 0;
            this.lobbyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lobbyBtn.Font = new System.Drawing.Font("Souses", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lobbyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lobbyBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.lobbyBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lobbyBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lobbyBtn.IconSize = 32;
            this.lobbyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lobbyBtn.Location = new System.Drawing.Point(0, 185);
            this.lobbyBtn.Name = "lobbyBtn";
            this.lobbyBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.lobbyBtn.Size = new System.Drawing.Size(200, 60);
            this.lobbyBtn.TabIndex = 2;
            this.lobbyBtn.Text = "Lobby";
            this.lobbyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lobbyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lobbyBtn.UseVisualStyleBackColor = true;
            this.lobbyBtn.Click += new System.EventHandler(this.ActivateButton);
            // 
            // onlineBtn
            // 
            this.onlineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onlineBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.onlineBtn.FlatAppearance.BorderSize = 0;
            this.onlineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onlineBtn.Font = new System.Drawing.Font("Souses", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.onlineBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.onlineBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.onlineBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.onlineBtn.IconSize = 32;
            this.onlineBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.onlineBtn.Location = new System.Drawing.Point(0, 125);
            this.onlineBtn.Name = "onlineBtn";
            this.onlineBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.onlineBtn.Size = new System.Drawing.Size(200, 60);
            this.onlineBtn.TabIndex = 8;
            this.onlineBtn.Text = "Home";
            this.onlineBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.onlineBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.onlineBtn.UseVisualStyleBackColor = true;
            this.onlineBtn.Click += new System.EventHandler(this.ActivateButton);
            // 
            // logoPicture
            // 
            this.logoPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.logoPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPicture.Image = global::AstolfoHook.Properties.Resources.Astolfo_Agartha;
            this.logoPicture.Location = new System.Drawing.Point(0, 0);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(200, 125);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            this.logoPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllowDrag);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.topPanel.Controls.Add(this.zombieCounterLabel);
            this.topPanel.Controls.Add(this.attachBtn);
            this.topPanel.Controls.Add(this.closeBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(200, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(600, 50);
            this.topPanel.TabIndex = 1;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllowDrag);
            // 
            // zombieCounterLabel
            // 
            this.zombieCounterLabel.AutoSize = true;
            this.zombieCounterLabel.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zombieCounterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.zombieCounterLabel.Location = new System.Drawing.Point(363, 15);
            this.zombieCounterLabel.Name = "zombieCounterLabel";
            this.zombieCounterLabel.Size = new System.Drawing.Size(146, 20);
            this.zombieCounterLabel.TabIndex = 2;
            this.zombieCounterLabel.Text = "Zombies Left: N/A";
            // 
            // attachBtn
            // 
            this.attachBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attachBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.attachBtn.FlatAppearance.BorderSize = 0;
            this.attachBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attachBtn.Font = new System.Drawing.Font("Souses", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.attachBtn.IconChar = FontAwesome.Sharp.IconChar.Link;
            this.attachBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.attachBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.attachBtn.IconSize = 32;
            this.attachBtn.Location = new System.Drawing.Point(0, 0);
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.Size = new System.Drawing.Size(195, 50);
            this.attachBtn.TabIndex = 1;
            this.attachBtn.Text = "Attach";
            this.attachBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.attachBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.attachBtn.UseVisualStyleBackColor = true;
            this.attachBtn.Click += new System.EventHandler(this.attachBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.closeBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 32;
            this.closeBtn.Location = new System.Drawing.Point(550, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(50, 50);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // mainThread
            // 
            this.mainThread.WorkerSupportsCancellation = true;
            this.mainThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.mainThread_DoWork);
            this.mainThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.mainThread_RunWorkerCompleted);
            // 
            // childPanelForm
            // 
            this.childPanelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.childPanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childPanelForm.Location = new System.Drawing.Point(200, 50);
            this.childPanelForm.Name = "childPanelForm";
            this.childPanelForm.Size = new System.Drawing.Size(600, 375);
            this.childPanelForm.TabIndex = 2;
            // 
            // nameThread
            // 
            this.nameThread.WorkerSupportsCancellation = true;
            this.nameThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.nameThread_DoWork);
            // 
            // zombieCounterThread
            // 
            this.zombieCounterThread.WorkerSupportsCancellation = true;
            this.zombieCounterThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.zombieCounterThread_DoWork);
            this.zombieCounterThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.zombieCounterThread_RunWorkerCompleted);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.childPanelForm);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AstolfoHook";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllowDrag);
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private FontAwesome.Sharp.IconButton closeBtn;
        private System.Windows.Forms.PictureBox logoPicture;
        private FontAwesome.Sharp.IconButton attachBtn;
        private FontAwesome.Sharp.IconButton trollingBtn;
        private FontAwesome.Sharp.IconButton onlineBtn;
        private FontAwesome.Sharp.IconButton zombieBtn;
        private FontAwesome.Sharp.IconButton userBtn;
        private FontAwesome.Sharp.IconButton lobbyBtn;
        private System.ComponentModel.BackgroundWorker mainThread;
        private System.Windows.Forms.Panel childPanelForm;
        private System.ComponentModel.BackgroundWorker nameThread;
        private System.Windows.Forms.Label zombieCounterLabel;
        private System.ComponentModel.BackgroundWorker zombieCounterThread;
    }
}