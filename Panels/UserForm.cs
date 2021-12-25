using System;
using System.Windows.Forms;
using BigK.Common;

namespace BigK.Panels
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        // Load values on Form load
        private void UserForm_Load(object sender, EventArgs e)
        {
            #region Get Names
            hostGroupBox.Text = Variables.UserMods.name == "" ? "  Inactive  " : "  [Host] " + Variables.UserMods.name + "  ";

            player2GroupBox.Text = Variables.Player2Mods.name == "" ? "  Inactive  " : "  " + Variables.Player2Mods.name + "  ";
            player2GroupBox.Enabled = Variables.Player2Mods.name == "" ? false : true;

            player3GroupBox.Text = Variables.Player3Mods.name == "" ? "  Inactive  " : "  " + Variables.Player3Mods.name + "  ";
            player3GroupBox.Enabled = Variables.Player3Mods.name == "" ? false : true;

            player4GroupBox.Text = Variables.Player4Mods.name == "" ? "  Inactive  " : "  " + Variables.Player4Mods.name + "  ";
            player4GroupBox.Enabled = Variables.Player4Mods.name == "" ? false : true;

            #endregion
            godModeToggle.Checked = Variables.UserMods.godMode;
            infiniteMoneyToggle.Checked = Variables.UserMods.infMoney;
            infiniteAmmoToggle.Checked = Variables.UserMods.infAmmo;
            if (Variables.UserMods.weaponID != -1)
                weaponDropdown.SelectedIndex = Variables.UserMods.weaponID;
        }

        // Save values on Form closing
        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Variables.UserMods.godMode = godModeToggle.Checked;
            Variables.UserMods.infMoney = infiniteMoneyToggle.Checked;
            Variables.UserMods.infAmmo = infiniteAmmoToggle.Checked;
            Variables.UserMods.weaponID = weaponDropdown.SelectedIndex;
        }

        #region Main Functions
        private void godModeToggle_Click(object sender, EventArgs e)
        {
            if (godModeToggle.Checked)
            {
                Main.godMode(true, 0);
            }
            else
            {
                Main.godMode(false, 0);
            }
        }

        private void infiniteMoneyToggle_Click(object sender, EventArgs e)
        {
            if (infiniteMoneyToggle.Checked)
            {
                Variables.UserMods.infMoney = true;
            }
            else
            {
                Variables.UserMods.infMoney = false;
            }
        }

        private void infiniteAmmoToggle_Click(object sender, EventArgs e)
        {
            if (infiniteAmmoToggle.Checked)
            {
                Variables.UserMods.infAmmo = true;
            }
            else
            {
                Variables.UserMods.infAmmo = false;
            }
        }

        private void thermalToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (thermalToggle.Checked)
            {
                Main.thermalVision(true, 0);
            }
            else
            {
                Main.thermalVision(false, 0);
            }
        }

        private void freezePlayerToggle_Click(object sender, EventArgs e)
        {
            if (freezePlayerToggle.Checked)
            {
                Main.freezePlayer(true, 0);
            }
            else
            {
                Main.freezePlayer(false, 0);
            }
        }

        private void weaponDropdown_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Main.giveWeapon(0, weaponDropdown.SelectedIndex);
        }
        #endregion

        #region Telport Functions
        private void hostTeleportDropdown_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Main.teleport(0, hostTeleportDropdown.SelectedIndex);
        }

        private void player2TeleportDropdown_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Main.teleport(1, hostTeleportDropdown.SelectedIndex);
        }

        private void player3TeleportDropdown_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Main.teleport(2, hostTeleportDropdown.SelectedIndex);
        }

        private void player4TeleportDropdown_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Main.teleport(3, hostTeleportDropdown.SelectedIndex);
        }
        #endregion
    }
}