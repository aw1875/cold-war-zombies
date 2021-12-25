using System;
using System.Windows.Forms;

using BigK.CustomControls;
using BigK.Common;

namespace BigK.Panels
{
    public partial class LobbyForm : Form
    {
        TextField currentTextbox;

        public LobbyForm()
        {
            InitializeComponent();
        }

        // Load values on Form load
        private void LobbyForm_Load(object sender, EventArgs e)
        {
            #region Set Names
            player2Controls.Text = Variables.Player2Mods.name == "" ? "  Inactive  " : "  " + Variables.Player2Mods.name + "  ";
            player2Controls.Enabled = Variables.Player2Mods.name == "" ? false : true;

            player3Controls.Text = Variables.Player3Mods.name == "" ? "  Inactive  " : "  " + Variables.Player3Mods.name + "  ";
            player3Controls.Enabled = Variables.Player3Mods.name == "" ? false : true;

            player4Controls.Text = Variables.Player4Mods.name == "" ? "  Inactive  " : "  " + Variables.Player4Mods.name + "  ";
            player4Controls.Enabled = Variables.Player4Mods.name == "" ? false : true;
            #endregion

            // Lobby Variables
            lobbyGodModeToggle.Checked = Variables.LobbyMods.godMode;
            lobbyInfiniteMoneyToggle.Checked = Variables.LobbyMods.infMoney;
            lobbyInfiniteAmmoToggle.Checked = Variables.LobbyMods.infAmmo;
            superspeedToggle.Checked = Variables.LobbyMods.superSpeed;
            lobbyThermalToggle.Checked = Variables.LobbyMods.thermal;

            // Player 2 Variables
            player2GodModToggle.Checked = Variables.Player2Mods.godMode;
            player2InfMoneyToggle.Checked = Variables.Player2Mods.infMoney;
            player2InfAmmoToggle.Checked = Variables.Player2Mods.infAmmo;
            if (Variables.Player2Mods.weaponID != -1)
                player2WeaponDropdown.SelectedIndex = Variables.Player2Mods.weaponID;

            // Player 3 Variables
            player3GodModToggle.Checked = Variables.Player3Mods.godMode;
            player3InfMoneyToggle.Checked = Variables.Player3Mods.infMoney;
            player3InfAmmoToggle.Checked = Variables.Player3Mods.infAmmo;
            if (Variables.Player3Mods.weaponID != -1)
                player3WeaponDropdown.SelectedIndex = Variables.Player3Mods.weaponID;

            // Player 4 Variables
            player4GodModToggle.Checked = Variables.Player4Mods.godMode;
            player4InfMoneyToggle.Checked = Variables.Player4Mods.infMoney;
            player4InfAmmoToggle.Checked = Variables.Player4Mods.infAmmo;
            if (Variables.Player4Mods.weaponID != -1)
                player4WeaponDropdown.SelectedIndex = Variables.Player4Mods.weaponID;
        }

        #region Lobby Functions
        private void lobbyGodModeToggle_Click(object sender, EventArgs e)
        {
            if (lobbyGodModeToggle.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    Main.godMode(true, i);
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    Main.godMode(false, i);
                }
            }
        }
       
        private void lobbyInfiniteMoneyToggle_Click(object sender, EventArgs e)
        {
            if (lobbyInfiniteMoneyToggle.Checked)
            {
                Variables.LobbyMods.infMoney = true;
            }
            else
            {
                Variables.LobbyMods.infMoney = false;
            }
        }

        private void lobbyInfiniteAmmoToggle_Click(object sender, EventArgs e)
        {
            if (lobbyInfiniteAmmoToggle.Checked)
            {
                Variables.LobbyMods.infAmmo = true;
            }
            else
            {
                Variables.LobbyMods.infAmmo = false;
            }
        }

        private void superspeedToggle_Click(object sender, EventArgs e)
        {
            if (superspeedToggle.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    Main.superSpeed(true, i);
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    {
                        Main.superSpeed(false, i);
                    }
                }
            }
        }

        private void lobbyThermalToggle_Click(object sender, EventArgs e)
        {
            if (lobbyThermalToggle.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    Main.thermalVision(true, i);
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    Main.thermalVision(false, i);
                }
            }
        }
        #endregion

        // Save values on Form Close
        private void LobbyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Lobby Variables
            Variables.LobbyMods.godMode = lobbyGodModeToggle.Checked;
            Variables.LobbyMods.infMoney = lobbyInfiniteMoneyToggle.Checked;
            Variables.LobbyMods.infAmmo = lobbyInfiniteAmmoToggle.Checked;
            Variables.LobbyMods.superSpeed = superspeedToggle.Checked;
            Variables.LobbyMods.thermal = lobbyThermalToggle.Checked;

            // Player 2 Variables
            Variables.Player2Mods.godMode = player2GodModToggle.Checked;
            Variables.Player2Mods.infMoney = player2InfMoneyToggle.Checked;
            Variables.Player2Mods.infAmmo = player2InfAmmoToggle.Checked;
            Variables.Player2Mods.weaponID = player4WeaponDropdown.SelectedIndex;

            // Player 3 Variables
            Variables.Player3Mods.godMode = player3GodModToggle.Checked;
            Variables.Player3Mods.infMoney = player3InfMoneyToggle.Checked;
            Variables.Player3Mods.infAmmo = player3InfAmmoToggle.Checked;
            Variables.Player3Mods.weaponID = player3WeaponDropdown.SelectedIndex;

            // Player 4 Variables
            Variables.Player4Mods.godMode = player4GodModToggle.Checked;
            Variables.Player4Mods.infMoney = player4InfMoneyToggle.Checked;
            Variables.Player4Mods.infAmmo = player4InfAmmoToggle.Checked;
            Variables.Player4Mods.weaponID = player4WeaponDropdown.SelectedIndex;
        }

        #region Player 2 Mods
        private void player2GodModToggle_Click(object sender, EventArgs e)
        {
            if (player2GodModToggle.Checked)
            {
                Main.godMode(true, 1);
            }
            else
            {
                Main.godMode(false, 1);
            }
        }

        private void player2InfAmmoToggle_Click(object sender, EventArgs e)
        {
            if (player2InfAmmoToggle.Checked)
            {
                Variables.Player2Mods.infAmmo = true;
            }
            else
            {
                Variables.Player2Mods.infAmmo = false;
            }
        }

        private void player2InfMoneyToggle_Click(object sender, EventArgs e)
        {
            if (player2InfMoneyToggle.Checked)
            {
                Variables.Player2Mods.infMoney = true;
            }
            else
            {
                Variables.Player2Mods.infMoney = false;
            }
        }

        private void player2WeaponDropdown_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Main.giveWeapon(1, player2WeaponDropdown.SelectedIndex);
        }
        #endregion

        #region Player 3 Mods
        private void player3GodModToggle_Click(object sender, EventArgs e)
        {
            if (player3GodModToggle.Checked)
            {
                Main.godMode(true, 2);
            }
            else
            {
                Main.godMode(false, 2);
            }
        }

        private void player3InfAmmoToggle_Click(object sender, EventArgs e)
        {
            if (player3InfAmmoToggle.Checked)
            {
                Variables.Player3Mods.infAmmo = true;
            }
            else
            {
                Variables.Player3Mods.infAmmo = false;
            }
        }
        
        private void player3InfMoneyToggle_Click(object sender, EventArgs e)
        {
            if (player3InfAmmoToggle.Checked)
            {
                Variables.Player3Mods.infMoney = false;
            }
            else
            {
                Variables.Player3Mods.infMoney = false;
            }
        }
        
        private void player3WeaponDropdown_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Main.giveWeapon(2, player3WeaponDropdown.SelectedIndex);
        }
        #endregion

        #region Player 4 Mods
        private void player4GodModToggle_Click(object sender, EventArgs e)
        {
            if (player4GodModToggle.Checked)
            {
                Main.godMode(true, 3);
            }
            else
            {
                Main.godMode(false, 3);
            }
        }

        private void player4InfAmmoToggle_Click(object sender, EventArgs e)
        {
            if (player4InfAmmoToggle.Checked)
            {
                Variables.Player4Mods.infAmmo = true;
            }
            else
            {
                Variables.Player4Mods.infAmmo = false;
            }
        }
        
        private void player4InfMoneyToggle_Click(object sender, EventArgs e)
        {
            if (player4InfMoneyToggle.Checked)
            {
                Variables.Player4Mods.infMoney = false;
            }
            else
            {
                Variables.Player4Mods.infMoney = false;
            }
        }
        
        private void player4WeaponDropdown_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Main.giveWeapon(3, player4WeaponDropdown.SelectedIndex);
        }
        #endregion

        private void teleportBtn_Click(object sender, EventArgs e)
        {
            Main.teleportPlayers(true);
        }
    }
}
