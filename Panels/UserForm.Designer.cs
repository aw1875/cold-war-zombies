
namespace BigK.Panels
{
    partial class UserForm
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
            this.hostPanel = new System.Windows.Forms.Panel();
            this.player4GroupBox = new System.Windows.Forms.GroupBox();
            this.player4TeleportDropdown = new BigK.Controls.Combobox();
            this.player2GroupBox = new System.Windows.Forms.GroupBox();
            this.player2TeleportDropdown = new BigK.Controls.Combobox();
            this.player3GroupBox = new System.Windows.Forms.GroupBox();
            this.player3TeleportDropdown = new BigK.Controls.Combobox();
            this.hostGroupBox = new System.Windows.Forms.GroupBox();
            this.hostTeleportDropdown = new BigK.Controls.Combobox();
            this.weaponDropdown = new BigK.Controls.Combobox();
            this.label6 = new System.Windows.Forms.Label();
            this.thermalToggle = new BigK.Controls.ToggleButton();
            this.label17 = new System.Windows.Forms.Label();
            this.freezePlayerToggle = new BigK.Controls.ToggleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.infiniteAmmoToggle = new BigK.Controls.ToggleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.infiniteMoneyToggle = new BigK.Controls.ToggleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.godModeToggle = new BigK.Controls.ToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.hostPanel.SuspendLayout();
            this.player4GroupBox.SuspendLayout();
            this.player2GroupBox.SuspendLayout();
            this.player3GroupBox.SuspendLayout();
            this.hostGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hostPanel
            // 
            this.hostPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.hostPanel.Controls.Add(this.player4GroupBox);
            this.hostPanel.Controls.Add(this.player2GroupBox);
            this.hostPanel.Controls.Add(this.player3GroupBox);
            this.hostPanel.Controls.Add(this.hostGroupBox);
            this.hostPanel.Controls.Add(this.weaponDropdown);
            this.hostPanel.Controls.Add(this.label6);
            this.hostPanel.Controls.Add(this.thermalToggle);
            this.hostPanel.Controls.Add(this.label17);
            this.hostPanel.Controls.Add(this.freezePlayerToggle);
            this.hostPanel.Controls.Add(this.label5);
            this.hostPanel.Controls.Add(this.infiniteAmmoToggle);
            this.hostPanel.Controls.Add(this.label3);
            this.hostPanel.Controls.Add(this.infiniteMoneyToggle);
            this.hostPanel.Controls.Add(this.label2);
            this.hostPanel.Controls.Add(this.godModeToggle);
            this.hostPanel.Controls.Add(this.label1);
            this.hostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostPanel.Location = new System.Drawing.Point(0, 0);
            this.hostPanel.Name = "hostPanel";
            this.hostPanel.Size = new System.Drawing.Size(600, 375);
            this.hostPanel.TabIndex = 4;
            // 
            // player4GroupBox
            // 
            this.player4GroupBox.Controls.Add(this.player4TeleportDropdown);
            this.player4GroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player4GroupBox.Location = new System.Drawing.Point(194, 276);
            this.player4GroupBox.Name = "player4GroupBox";
            this.player4GroupBox.Size = new System.Drawing.Size(394, 80);
            this.player4GroupBox.TabIndex = 1;
            this.player4GroupBox.TabStop = false;
            this.player4GroupBox.Text = "groupBox4";
            // 
            // player4TeleportDropdown
            // 
            this.player4TeleportDropdown.AutoCompleteCustomSource.AddRange(new string[] {
            "XM4",
            "AK47",
            "KRIG6",
            "QBZ83",
            "FFAR1",
            "GROZA",
            "FARA83",
            "C58",
            "MP5",
            "MILANO821",
            "AK74U",
            "KSP45",
            "BULLFROG",
            "MAC10",
            "LC10",
            "PPSH41",
            "OTS",
            "TYPE63",
            "M16",
            "AUG",
            "DMR14",
            "CARV2",
            "STONER63",
            "RPD",
            "M60",
            "MG82",
            "PELINGTON703",
            "LW3TUNDRA",
            "M82",
            "ZRG20MN",
            "K31SUISSE",
            "HAUER77",
            "GALLOSA12",
            "BALAYEUSE",
            "P1911",
            "MAGNUM",
            "DIAMATTI",
            "AMP63",
            "CIGMA2",
            "RPG7",
            "M79",
            "ARBALETTE",
            "PISTOLETCLOUE",
            "COUTEAU",
            "WAKIZASHI",
            "MASSE",
            "PELLE",
            "MACHETTE",
            "COUTEAUBALISTIQUE",
            "BATTEDEBASBALL",
            "MASSUE",
            "DCDELECTRO",
            "DCDELEC",
            "DCDCRYO",
            "DCDNOVA",
            "DCDTHERMO",
            "RAYGUN",
            "RAYGUN 2",
            "RAIK84",
            "RAIK842",
            "RAYONDUCRBRS",
            "CRBRS",
            "DIFFUSEURCRBRS",
            "DEFERLEMENTCRBRS",
            "QUITESSENCECRBRS",
            "ILLUMINATIONCRBRS",
            "CHERCHEURCRBRS",
            "DURALITECRBRS",
            "Gunship",
            "Gunship",
            "Gunship",
            "Gunship",
            "Sentry",
            "Sentry Turret",
            "Strafe Run",
            "Attack Helicopter",
            "Drone Squad",
            "Chopper Gunner",
            "Chopper Gunner",
            "Attack Helicopter",
            "Assault Pack",
            "War Machine",
            "War Machine",
            "VTOL Escort",
            "Death Machine",
            "Death Machine",
            "Chopper Gunner",
            "Strafe Run",
            "Strafe Run",
            "Cruise Missile",
            "Napalm Strike",
            "Gunship",
            "Air Patrol",
            "Snowball",
            "Razor Wire",
            "RC-XD",
            "War Machine",
            "VTOL Escort",
            "Heavy Attack Chopper",
            "Counter Spy Plane",
            "Napalm Strike",
            "Napalm Strike",
            "Napalm Strike",
            "Specimen",
            "Flamethrower",
            "Napalm Strike",
            "Herald of Woe",
            "Die Breaker",
            "Skullsplitter",
            "Doom",
            "Closing Argument",
            "Crunch Time",
            "H-ngm-n",
            "Culebre",
            "Endstation Lure",
            "Decontamination Agent",
            "Royale with Lead",
            "Coal",
            "Zjolnir",
            "Shock Charge",
            "Assault Rounds",
            "Swiss KH3353",
            "Private Eye & Femme Fatale",
            "Private Eye & Femme Fatale",
            "Succubus Stinger",
            "Fists",
            "Large Caliber",
            "Special Ammo",
            "Sharp Shooter",
            "Sharp Shooter",
            "Warden\'s Shotgun",
            "Napalm Strike",
            "La Llorona",
            "Redecorator",
            "Anathema",
            "CRBR-TRN Seeker",
            "Small Caliber",
            "Slow Burn",
            "Serket\'s Kiss",
            "DeMolisheR K14",
            "CRBR-TRN Enlightenment",
            "Napalm Strike",
            "Sniper Rounds",
            "Grisly Reaper",
            "Head Cannon"});
            this.player4TeleportDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.player4TeleportDropdown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.player4TeleportDropdown.BorderSize = 0;
            this.player4TeleportDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.player4TeleportDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.player4TeleportDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.player4TeleportDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player4TeleportDropdown.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player4TeleportDropdown.Items.AddRange(new object[] {
            "// DIE MASCHINE //",
            "",
            "SPAWN",
            "LIVING ROOM",
            "POND",
            "TRUCK",
            "TUNNEL",
            "CONTROL ROOM",
            "TRIAL COMPUTER",
            "MEDICAL BAY",
            "MAIN POWER",
            "PACK A PUNCH",
            "PARTICLE ACCELERATOR",
            "WEAPONS LAB",
            "PERK MACHINE",
            "CRASH SITE",
            "TOP OF PLANE WING",
            "",
            "// MYSTERY BOX LOCATIONS //",
            "",
            "POND",
            "CRASH SITE",
            "SPAWN",
            "PARTICLE ACCELERATOR",
            "MEDICAL BAY"});
            this.player4TeleportDropdown.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.player4TeleportDropdown.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player4TeleportDropdown.Location = new System.Drawing.Point(12, 28);
            this.player4TeleportDropdown.MinimumSize = new System.Drawing.Size(164, 31);
            this.player4TeleportDropdown.Name = "player4TeleportDropdown";
            this.player4TeleportDropdown.Size = new System.Drawing.Size(369, 31);
            this.player4TeleportDropdown.TabIndex = 28;
            this.player4TeleportDropdown.Texts = "Teleport";
            this.player4TeleportDropdown.OnSelectedIndexChanged += new System.EventHandler(this.player4TeleportDropdown_OnSelectedIndexChanged);
            // 
            // player2GroupBox
            // 
            this.player2GroupBox.Controls.Add(this.player2TeleportDropdown);
            this.player2GroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player2GroupBox.Location = new System.Drawing.Point(194, 101);
            this.player2GroupBox.Name = "player2GroupBox";
            this.player2GroupBox.Size = new System.Drawing.Size(394, 80);
            this.player2GroupBox.TabIndex = 0;
            this.player2GroupBox.TabStop = false;
            this.player2GroupBox.Text = "groupBox2";
            // 
            // player2TeleportDropdown
            // 
            this.player2TeleportDropdown.AutoCompleteCustomSource.AddRange(new string[] {
            "XM4",
            "AK47",
            "KRIG6",
            "QBZ83",
            "FFAR1",
            "GROZA",
            "FARA83",
            "C58",
            "MP5",
            "MILANO821",
            "AK74U",
            "KSP45",
            "BULLFROG",
            "MAC10",
            "LC10",
            "PPSH41",
            "OTS",
            "TYPE63",
            "M16",
            "AUG",
            "DMR14",
            "CARV2",
            "STONER63",
            "RPD",
            "M60",
            "MG82",
            "PELINGTON703",
            "LW3TUNDRA",
            "M82",
            "ZRG20MN",
            "K31SUISSE",
            "HAUER77",
            "GALLOSA12",
            "BALAYEUSE",
            "P1911",
            "MAGNUM",
            "DIAMATTI",
            "AMP63",
            "CIGMA2",
            "RPG7",
            "M79",
            "ARBALETTE",
            "PISTOLETCLOUE",
            "COUTEAU",
            "WAKIZASHI",
            "MASSE",
            "PELLE",
            "MACHETTE",
            "COUTEAUBALISTIQUE",
            "BATTEDEBASBALL",
            "MASSUE",
            "DCDELECTRO",
            "DCDELEC",
            "DCDCRYO",
            "DCDNOVA",
            "DCDTHERMO",
            "RAYGUN",
            "RAYGUN 2",
            "RAIK84",
            "RAIK842",
            "RAYONDUCRBRS",
            "CRBRS",
            "DIFFUSEURCRBRS",
            "DEFERLEMENTCRBRS",
            "QUITESSENCECRBRS",
            "ILLUMINATIONCRBRS",
            "CHERCHEURCRBRS",
            "DURALITECRBRS",
            "Gunship",
            "Gunship",
            "Gunship",
            "Gunship",
            "Sentry",
            "Sentry Turret",
            "Strafe Run",
            "Attack Helicopter",
            "Drone Squad",
            "Chopper Gunner",
            "Chopper Gunner",
            "Attack Helicopter",
            "Assault Pack",
            "War Machine",
            "War Machine",
            "VTOL Escort",
            "Death Machine",
            "Death Machine",
            "Chopper Gunner",
            "Strafe Run",
            "Strafe Run",
            "Cruise Missile",
            "Napalm Strike",
            "Gunship",
            "Air Patrol",
            "Snowball",
            "Razor Wire",
            "RC-XD",
            "War Machine",
            "VTOL Escort",
            "Heavy Attack Chopper",
            "Counter Spy Plane",
            "Napalm Strike",
            "Napalm Strike",
            "Napalm Strike",
            "Specimen",
            "Flamethrower",
            "Napalm Strike",
            "Herald of Woe",
            "Die Breaker",
            "Skullsplitter",
            "Doom",
            "Closing Argument",
            "Crunch Time",
            "H-ngm-n",
            "Culebre",
            "Endstation Lure",
            "Decontamination Agent",
            "Royale with Lead",
            "Coal",
            "Zjolnir",
            "Shock Charge",
            "Assault Rounds",
            "Swiss KH3353",
            "Private Eye & Femme Fatale",
            "Private Eye & Femme Fatale",
            "Succubus Stinger",
            "Fists",
            "Large Caliber",
            "Special Ammo",
            "Sharp Shooter",
            "Sharp Shooter",
            "Warden\'s Shotgun",
            "Napalm Strike",
            "La Llorona",
            "Redecorator",
            "Anathema",
            "CRBR-TRN Seeker",
            "Small Caliber",
            "Slow Burn",
            "Serket\'s Kiss",
            "DeMolisheR K14",
            "CRBR-TRN Enlightenment",
            "Napalm Strike",
            "Sniper Rounds",
            "Grisly Reaper",
            "Head Cannon"});
            this.player2TeleportDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.player2TeleportDropdown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.player2TeleportDropdown.BorderSize = 0;
            this.player2TeleportDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.player2TeleportDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.player2TeleportDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.player2TeleportDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player2TeleportDropdown.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player2TeleportDropdown.Items.AddRange(new object[] {
            "// DIE MASCHINE //",
            "",
            "SPAWN",
            "LIVING ROOM",
            "POND",
            "TRUCK",
            "TUNNEL",
            "CONTROL ROOM",
            "TRIAL COMPUTER",
            "MEDICAL BAY",
            "MAIN POWER",
            "PACK A PUNCH",
            "PARTICLE ACCELERATOR",
            "WEAPONS LAB",
            "PERK MACHINE",
            "CRASH SITE",
            "TOP OF PLANE WING",
            "",
            "// MYSTERY BOX LOCATIONS //",
            "",
            "POND",
            "CRASH SITE",
            "SPAWN",
            "PARTICLE ACCELERATOR",
            "MEDICAL BAY"});
            this.player2TeleportDropdown.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.player2TeleportDropdown.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player2TeleportDropdown.Location = new System.Drawing.Point(12, 28);
            this.player2TeleportDropdown.MinimumSize = new System.Drawing.Size(164, 31);
            this.player2TeleportDropdown.Name = "player2TeleportDropdown";
            this.player2TeleportDropdown.Size = new System.Drawing.Size(369, 31);
            this.player2TeleportDropdown.TabIndex = 26;
            this.player2TeleportDropdown.Texts = "Teleport";
            this.player2TeleportDropdown.OnSelectedIndexChanged += new System.EventHandler(this.player2TeleportDropdown_OnSelectedIndexChanged);
            // 
            // player3GroupBox
            // 
            this.player3GroupBox.Controls.Add(this.player3TeleportDropdown);
            this.player3GroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player3GroupBox.Location = new System.Drawing.Point(194, 187);
            this.player3GroupBox.Name = "player3GroupBox";
            this.player3GroupBox.Size = new System.Drawing.Size(394, 80);
            this.player3GroupBox.TabIndex = 0;
            this.player3GroupBox.TabStop = false;
            this.player3GroupBox.Text = "groupBox3";
            // 
            // player3TeleportDropdown
            // 
            this.player3TeleportDropdown.AutoCompleteCustomSource.AddRange(new string[] {
            "XM4",
            "AK47",
            "KRIG6",
            "QBZ83",
            "FFAR1",
            "GROZA",
            "FARA83",
            "C58",
            "MP5",
            "MILANO821",
            "AK74U",
            "KSP45",
            "BULLFROG",
            "MAC10",
            "LC10",
            "PPSH41",
            "OTS",
            "TYPE63",
            "M16",
            "AUG",
            "DMR14",
            "CARV2",
            "STONER63",
            "RPD",
            "M60",
            "MG82",
            "PELINGTON703",
            "LW3TUNDRA",
            "M82",
            "ZRG20MN",
            "K31SUISSE",
            "HAUER77",
            "GALLOSA12",
            "BALAYEUSE",
            "P1911",
            "MAGNUM",
            "DIAMATTI",
            "AMP63",
            "CIGMA2",
            "RPG7",
            "M79",
            "ARBALETTE",
            "PISTOLETCLOUE",
            "COUTEAU",
            "WAKIZASHI",
            "MASSE",
            "PELLE",
            "MACHETTE",
            "COUTEAUBALISTIQUE",
            "BATTEDEBASBALL",
            "MASSUE",
            "DCDELECTRO",
            "DCDELEC",
            "DCDCRYO",
            "DCDNOVA",
            "DCDTHERMO",
            "RAYGUN",
            "RAYGUN 2",
            "RAIK84",
            "RAIK842",
            "RAYONDUCRBRS",
            "CRBRS",
            "DIFFUSEURCRBRS",
            "DEFERLEMENTCRBRS",
            "QUITESSENCECRBRS",
            "ILLUMINATIONCRBRS",
            "CHERCHEURCRBRS",
            "DURALITECRBRS",
            "Gunship",
            "Gunship",
            "Gunship",
            "Gunship",
            "Sentry",
            "Sentry Turret",
            "Strafe Run",
            "Attack Helicopter",
            "Drone Squad",
            "Chopper Gunner",
            "Chopper Gunner",
            "Attack Helicopter",
            "Assault Pack",
            "War Machine",
            "War Machine",
            "VTOL Escort",
            "Death Machine",
            "Death Machine",
            "Chopper Gunner",
            "Strafe Run",
            "Strafe Run",
            "Cruise Missile",
            "Napalm Strike",
            "Gunship",
            "Air Patrol",
            "Snowball",
            "Razor Wire",
            "RC-XD",
            "War Machine",
            "VTOL Escort",
            "Heavy Attack Chopper",
            "Counter Spy Plane",
            "Napalm Strike",
            "Napalm Strike",
            "Napalm Strike",
            "Specimen",
            "Flamethrower",
            "Napalm Strike",
            "Herald of Woe",
            "Die Breaker",
            "Skullsplitter",
            "Doom",
            "Closing Argument",
            "Crunch Time",
            "H-ngm-n",
            "Culebre",
            "Endstation Lure",
            "Decontamination Agent",
            "Royale with Lead",
            "Coal",
            "Zjolnir",
            "Shock Charge",
            "Assault Rounds",
            "Swiss KH3353",
            "Private Eye & Femme Fatale",
            "Private Eye & Femme Fatale",
            "Succubus Stinger",
            "Fists",
            "Large Caliber",
            "Special Ammo",
            "Sharp Shooter",
            "Sharp Shooter",
            "Warden\'s Shotgun",
            "Napalm Strike",
            "La Llorona",
            "Redecorator",
            "Anathema",
            "CRBR-TRN Seeker",
            "Small Caliber",
            "Slow Burn",
            "Serket\'s Kiss",
            "DeMolisheR K14",
            "CRBR-TRN Enlightenment",
            "Napalm Strike",
            "Sniper Rounds",
            "Grisly Reaper",
            "Head Cannon"});
            this.player3TeleportDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.player3TeleportDropdown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.player3TeleportDropdown.BorderSize = 0;
            this.player3TeleportDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.player3TeleportDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.player3TeleportDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.player3TeleportDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player3TeleportDropdown.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player3TeleportDropdown.Items.AddRange(new object[] {
            "// DIE MASCHINE //",
            "",
            "SPAWN",
            "LIVING ROOM",
            "POND",
            "TRUCK",
            "TUNNEL",
            "CONTROL ROOM",
            "TRIAL COMPUTER",
            "MEDICAL BAY",
            "MAIN POWER",
            "PACK A PUNCH",
            "PARTICLE ACCELERATOR",
            "WEAPONS LAB",
            "PERK MACHINE",
            "CRASH SITE",
            "TOP OF PLANE WING",
            "",
            "// MYSTERY BOX LOCATIONS //",
            "",
            "POND",
            "CRASH SITE",
            "SPAWN",
            "PARTICLE ACCELERATOR",
            "MEDICAL BAY"});
            this.player3TeleportDropdown.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.player3TeleportDropdown.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player3TeleportDropdown.Location = new System.Drawing.Point(12, 27);
            this.player3TeleportDropdown.MinimumSize = new System.Drawing.Size(164, 31);
            this.player3TeleportDropdown.Name = "player3TeleportDropdown";
            this.player3TeleportDropdown.Size = new System.Drawing.Size(369, 31);
            this.player3TeleportDropdown.TabIndex = 27;
            this.player3TeleportDropdown.Texts = "Teleport";
            this.player3TeleportDropdown.OnSelectedIndexChanged += new System.EventHandler(this.player3TeleportDropdown_OnSelectedIndexChanged);
            // 
            // hostGroupBox
            // 
            this.hostGroupBox.Controls.Add(this.hostTeleportDropdown);
            this.hostGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.hostGroupBox.Location = new System.Drawing.Point(194, 12);
            this.hostGroupBox.Name = "hostGroupBox";
            this.hostGroupBox.Size = new System.Drawing.Size(394, 80);
            this.hostGroupBox.TabIndex = 26;
            this.hostGroupBox.TabStop = false;
            this.hostGroupBox.Text = "groupBox1";
            // 
            // hostTeleportDropdown
            // 
            this.hostTeleportDropdown.AutoCompleteCustomSource.AddRange(new string[] {
            "XM4",
            "AK47",
            "KRIG6",
            "QBZ83",
            "FFAR1",
            "GROZA",
            "FARA83",
            "C58",
            "MP5",
            "MILANO821",
            "AK74U",
            "KSP45",
            "BULLFROG",
            "MAC10",
            "LC10",
            "PPSH41",
            "OTS",
            "TYPE63",
            "M16",
            "AUG",
            "DMR14",
            "CARV2",
            "STONER63",
            "RPD",
            "M60",
            "MG82",
            "PELINGTON703",
            "LW3TUNDRA",
            "M82",
            "ZRG20MN",
            "K31SUISSE",
            "HAUER77",
            "GALLOSA12",
            "BALAYEUSE",
            "P1911",
            "MAGNUM",
            "DIAMATTI",
            "AMP63",
            "CIGMA2",
            "RPG7",
            "M79",
            "ARBALETTE",
            "PISTOLETCLOUE",
            "COUTEAU",
            "WAKIZASHI",
            "MASSE",
            "PELLE",
            "MACHETTE",
            "COUTEAUBALISTIQUE",
            "BATTEDEBASBALL",
            "MASSUE",
            "DCDELECTRO",
            "DCDELEC",
            "DCDCRYO",
            "DCDNOVA",
            "DCDTHERMO",
            "RAYGUN",
            "RAYGUN 2",
            "RAIK84",
            "RAIK842",
            "RAYONDUCRBRS",
            "CRBRS",
            "DIFFUSEURCRBRS",
            "DEFERLEMENTCRBRS",
            "QUITESSENCECRBRS",
            "ILLUMINATIONCRBRS",
            "CHERCHEURCRBRS",
            "DURALITECRBRS",
            "Gunship",
            "Gunship",
            "Gunship",
            "Gunship",
            "Sentry",
            "Sentry Turret",
            "Strafe Run",
            "Attack Helicopter",
            "Drone Squad",
            "Chopper Gunner",
            "Chopper Gunner",
            "Attack Helicopter",
            "Assault Pack",
            "War Machine",
            "War Machine",
            "VTOL Escort",
            "Death Machine",
            "Death Machine",
            "Chopper Gunner",
            "Strafe Run",
            "Strafe Run",
            "Cruise Missile",
            "Napalm Strike",
            "Gunship",
            "Air Patrol",
            "Snowball",
            "Razor Wire",
            "RC-XD",
            "War Machine",
            "VTOL Escort",
            "Heavy Attack Chopper",
            "Counter Spy Plane",
            "Napalm Strike",
            "Napalm Strike",
            "Napalm Strike",
            "Specimen",
            "Flamethrower",
            "Napalm Strike",
            "Herald of Woe",
            "Die Breaker",
            "Skullsplitter",
            "Doom",
            "Closing Argument",
            "Crunch Time",
            "H-ngm-n",
            "Culebre",
            "Endstation Lure",
            "Decontamination Agent",
            "Royale with Lead",
            "Coal",
            "Zjolnir",
            "Shock Charge",
            "Assault Rounds",
            "Swiss KH3353",
            "Private Eye & Femme Fatale",
            "Private Eye & Femme Fatale",
            "Succubus Stinger",
            "Fists",
            "Large Caliber",
            "Special Ammo",
            "Sharp Shooter",
            "Sharp Shooter",
            "Warden\'s Shotgun",
            "Napalm Strike",
            "La Llorona",
            "Redecorator",
            "Anathema",
            "CRBR-TRN Seeker",
            "Small Caliber",
            "Slow Burn",
            "Serket\'s Kiss",
            "DeMolisheR K14",
            "CRBR-TRN Enlightenment",
            "Napalm Strike",
            "Sniper Rounds",
            "Grisly Reaper",
            "Head Cannon"});
            this.hostTeleportDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.hostTeleportDropdown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.hostTeleportDropdown.BorderSize = 0;
            this.hostTeleportDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hostTeleportDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hostTeleportDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hostTeleportDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.hostTeleportDropdown.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.hostTeleportDropdown.Items.AddRange(new object[] {
            "// DIE MASCHINE //",
            "",
            "SPAWN",
            "LIVING ROOM",
            "POND",
            "TRUCK",
            "TUNNEL",
            "CONTROL ROOM",
            "TRIAL COMPUTER",
            "MEDICAL BAY",
            "MAIN POWER",
            "PACK A PUNCH",
            "PARTICLE ACCELERATOR",
            "WEAPONS LAB",
            "PERK MACHINE",
            "CRASH SITE",
            "TOP OF PLANE WING",
            "",
            "// MYSTERY BOX LOCATIONS //",
            "",
            "POND",
            "CRASH SITE",
            "SPAWN",
            "PARTICLE ACCELERATOR",
            "MEDICAL BAY"});
            this.hostTeleportDropdown.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.hostTeleportDropdown.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.hostTeleportDropdown.Location = new System.Drawing.Point(12, 27);
            this.hostTeleportDropdown.MinimumSize = new System.Drawing.Size(164, 31);
            this.hostTeleportDropdown.Name = "hostTeleportDropdown";
            this.hostTeleportDropdown.Size = new System.Drawing.Size(369, 31);
            this.hostTeleportDropdown.TabIndex = 25;
            this.hostTeleportDropdown.Texts = "Teleport";
            this.hostTeleportDropdown.OnSelectedIndexChanged += new System.EventHandler(this.hostTeleportDropdown_OnSelectedIndexChanged);
            // 
            // weaponDropdown
            // 
            this.weaponDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.weaponDropdown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.weaponDropdown.BorderSize = 0;
            this.weaponDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weaponDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weaponDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.weaponDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.weaponDropdown.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.weaponDropdown.Items.AddRange(new object[] {
            "// ARS //",
            "XM4",
            "AK47",
            "Krig 6",
            "QBZ 83",
            "FFAR1",
            "Groza",
            "FARA",
            "C58",
            "EM2",
            "GRAV",
            "",
            "// SMGS //",
            "Mp5",
            "Milano 821",
            "Ak-74u",
            "Ksp 45",
            "Bullfrog",
            "Mac 10",
            "LC10",
            "PPSH",
            "0TS 9",
            "TEC-9",
            "LAPA",
            "",
            "// TRS //",
            "Type63",
            "M16",
            "AUG",
            "DMR 14",
            "CRAV2",
            "",
            "// LMGS //",
            "Stoner 63",
            "RPD",
            "M60",
            "MG82",
            "",
            "// SNIPERS //",
            "Pelington 703",
            "Lw3-Tundra",
            "M82",
            "ZRG20",
            "K31 Suisse",
            "",
            "// PISTOLS //",
            "1911",
            "Magnum",
            "Diamatti",
            "AMP63",
            "Marshal",
            "",
            "// SHOTGUNS //",
            "Hauer 77",
            "Gallo Sa12",
            "Balayeuse",
            "410 IRONHIDE",
            "",
            "// LAUNCHERS //",
            "Cigma 2",
            "RPG",
            "ARBALETTE",
            "M79",
            "PISTOLET CLOU",
            "",
            "// MELEE //",
            "Couteau",
            "Wakizash",
            "Masse",
            "PELLE",
            "MACHETTE",
            "COUTEAU BALISTIK",
            "BATTE",
            "MASSUE",
            "CANNE",
            "SAI",
            "FAUCILLE MARTEAU",
            "HACHE DE COMBAT",
            "COUTEAU DE SCREAM",
            "",
            "// WONDER WEAPONS //",
            "Lazer",
            "DCD Onde",
            "DCD Nova",
            "DCD Electrisant",
            "DCD Cryo",
            "DCD Thermophaser",
            "Rai-k7",
            "CRBR RAYON",
            "CRBR-S",
            "CRBR-S DIFFUSEUR",
            "CRBR-S DEFERLEMENT",
            "CRBR-TNR QUINTESSENCE",
            "CRBR-TNR ILLUMINATION",
            "CRBR-TNR CHERCHEUR",
            "CRBR-TNR DUALIDER",
            "TENEBRIS ANIMA",
            "RAVAGEUR CHRYSALAX",
            "",
            "// MISC //",
            "Couverture Ether",
            "Anneau de Feu",
            "Soufle Glass",
            "Couverture de Soin",
            "Electric Violet",
            "Garde Frenetic",
            "Mine a Energie",
            "Jaune",
            "Leurre",
            "Hache",
            "Grenade",
            "Semtex",
            "Para",
            "Molotov",
            "C4",
            "Singe",
            "Viand"});
            this.weaponDropdown.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.weaponDropdown.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.weaponDropdown.Location = new System.Drawing.Point(15, 325);
            this.weaponDropdown.MinimumSize = new System.Drawing.Size(163, 31);
            this.weaponDropdown.Name = "weaponDropdown";
            this.weaponDropdown.Size = new System.Drawing.Size(163, 31);
            this.weaponDropdown.TabIndex = 23;
            this.weaponDropdown.Texts = "Select Weapon";
            this.weaponDropdown.OnSelectedIndexChanged += new System.EventHandler(this.weaponDropdown_OnSelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label6.Location = new System.Drawing.Point(45, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "User Mods";
            // 
            // thermalToggle
            // 
            this.thermalToggle.AutoSize = true;
            this.thermalToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thermalToggle.Location = new System.Drawing.Point(118, 251);
            this.thermalToggle.MinimumSize = new System.Drawing.Size(61, 31);
            this.thermalToggle.Name = "thermalToggle";
            this.thermalToggle.OffBackColor = System.Drawing.Color.Gray;
            this.thermalToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.thermalToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.thermalToggle.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.thermalToggle.Size = new System.Drawing.Size(61, 31);
            this.thermalToggle.Sizes = new System.Drawing.Size(61, 31);
            this.thermalToggle.TabIndex = 19;
            this.thermalToggle.UseVisualStyleBackColor = true;
            this.thermalToggle.CheckedChanged += new System.EventHandler(this.thermalToggle_CheckedChanged);
            // 
            // label17
            // 
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label17.Location = new System.Drawing.Point(12, 251);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 32);
            this.label17.TabIndex = 18;
            this.label17.Text = "Thermal";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // freezePlayerToggle
            // 
            this.freezePlayerToggle.AutoSize = true;
            this.freezePlayerToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.freezePlayerToggle.Location = new System.Drawing.Point(118, 214);
            this.freezePlayerToggle.MinimumSize = new System.Drawing.Size(61, 31);
            this.freezePlayerToggle.Name = "freezePlayerToggle";
            this.freezePlayerToggle.OffBackColor = System.Drawing.Color.Gray;
            this.freezePlayerToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.freezePlayerToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.freezePlayerToggle.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.freezePlayerToggle.Size = new System.Drawing.Size(61, 31);
            this.freezePlayerToggle.Sizes = new System.Drawing.Size(61, 31);
            this.freezePlayerToggle.TabIndex = 9;
            this.freezePlayerToggle.UseVisualStyleBackColor = true;
            this.freezePlayerToggle.Click += new System.EventHandler(this.freezePlayerToggle_Click);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Freeze Player";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infiniteAmmoToggle
            // 
            this.infiniteAmmoToggle.AutoSize = true;
            this.infiniteAmmoToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infiniteAmmoToggle.Location = new System.Drawing.Point(118, 175);
            this.infiniteAmmoToggle.MinimumSize = new System.Drawing.Size(61, 31);
            this.infiniteAmmoToggle.Name = "infiniteAmmoToggle";
            this.infiniteAmmoToggle.OffBackColor = System.Drawing.Color.Gray;
            this.infiniteAmmoToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.infiniteAmmoToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.infiniteAmmoToggle.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.infiniteAmmoToggle.Size = new System.Drawing.Size(61, 31);
            this.infiniteAmmoToggle.Sizes = new System.Drawing.Size(61, 31);
            this.infiniteAmmoToggle.TabIndex = 5;
            this.infiniteAmmoToggle.UseVisualStyleBackColor = true;
            this.infiniteAmmoToggle.Click += new System.EventHandler(this.infiniteAmmoToggle_Click);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Infinite Ammo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infiniteMoneyToggle
            // 
            this.infiniteMoneyToggle.AutoSize = true;
            this.infiniteMoneyToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infiniteMoneyToggle.Location = new System.Drawing.Point(117, 138);
            this.infiniteMoneyToggle.MinimumSize = new System.Drawing.Size(61, 31);
            this.infiniteMoneyToggle.Name = "infiniteMoneyToggle";
            this.infiniteMoneyToggle.OffBackColor = System.Drawing.Color.Gray;
            this.infiniteMoneyToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.infiniteMoneyToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.infiniteMoneyToggle.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.infiniteMoneyToggle.Size = new System.Drawing.Size(61, 31);
            this.infiniteMoneyToggle.Sizes = new System.Drawing.Size(61, 31);
            this.infiniteMoneyToggle.TabIndex = 3;
            this.infiniteMoneyToggle.UseVisualStyleBackColor = true;
            this.infiniteMoneyToggle.Click += new System.EventHandler(this.infiniteMoneyToggle_Click);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(11, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Infinite Money";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // godModeToggle
            // 
            this.godModeToggle.AutoSize = true;
            this.godModeToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.godModeToggle.Location = new System.Drawing.Point(117, 101);
            this.godModeToggle.MinimumSize = new System.Drawing.Size(62, 31);
            this.godModeToggle.Name = "godModeToggle";
            this.godModeToggle.OffBackColor = System.Drawing.Color.Gray;
            this.godModeToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.godModeToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.godModeToggle.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.godModeToggle.Size = new System.Drawing.Size(62, 31);
            this.godModeToggle.Sizes = new System.Drawing.Size(62, 31);
            this.godModeToggle.TabIndex = 1;
            this.godModeToggle.UseVisualStyleBackColor = true;
            this.godModeToggle.Click += new System.EventHandler(this.godModeToggle_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(11, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "God Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 375);
            this.Controls.Add(this.hostPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "HostForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.hostPanel.ResumeLayout(false);
            this.hostPanel.PerformLayout();
            this.player4GroupBox.ResumeLayout(false);
            this.player2GroupBox.ResumeLayout(false);
            this.player3GroupBox.ResumeLayout(false);
            this.hostGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel hostPanel;
        private global::BigK.Controls.ToggleButton freezePlayerToggle;
        private System.Windows.Forms.Label label5;
        private global::BigK.Controls.ToggleButton infiniteAmmoToggle;
        private System.Windows.Forms.Label label3;
        private global::BigK.Controls.ToggleButton infiniteMoneyToggle;
        private System.Windows.Forms.Label label2;
        private global::BigK.Controls.ToggleButton godModeToggle;
        private System.Windows.Forms.Label label1;
        private Controls.ToggleButton thermalToggle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private Controls.Combobox weaponDropdown;
        private Controls.Combobox hostTeleportDropdown;
        private System.Windows.Forms.GroupBox player4GroupBox;
        private Controls.Combobox player4TeleportDropdown;
        private System.Windows.Forms.GroupBox player2GroupBox;
        private Controls.Combobox player2TeleportDropdown;
        private System.Windows.Forms.GroupBox player3GroupBox;
        private Controls.Combobox player3TeleportDropdown;
        private System.Windows.Forms.GroupBox hostGroupBox;
    }
}