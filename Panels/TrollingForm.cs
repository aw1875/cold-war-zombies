using System;
using System.Windows.Forms;
using BigK.Common;
using static BLAZN.UTILITIES.Vectors.Vec3;

namespace BigK.Panels
{
    public partial class TrollingForm : Form
    {
        Vector3 P2CP;
        Vector3 P3CP;
        Vector3 P4CP;

        public TrollingForm()
        {
            InitializeComponent();
        }

        private void TrollingForm_Load(object sender, EventArgs e)
        {
            #region Set Names
            player2Controls.Text = Variables.Player2Mods.name == "" ? "  Inactive  " : "  " + Variables.Player2Mods.name + "  ";
            player2Controls.Enabled = Variables.Player2Mods.name == "" ? false : true;

            player3Controls.Text = Variables.Player3Mods.name == "" ? "  Inactive  " : "  " + Variables.Player3Mods.name + "  ";
            player3Controls.Enabled = Variables.Player3Mods.name == "" ? false : true;

            player4Controls.Text = Variables.Player4Mods.name == "" ? "  Inactive  " : "  " + Variables.Player4Mods.name + "  ";
            player4Controls.Enabled = Variables.Player4Mods.name == "" ? false : true;
            #endregion

            // Player 2 Variables
            player2ToJailToggle.Checked = Variables.Player2Mods.toJail;
            player2FreezeToggle.Checked = Variables.Player2Mods.freeze;
            player2TakeGunToggle.Checked = Variables.Player2Mods.takeGun;

            // Player 3 Variables
            player3ToJailToggle.Checked = Variables.Player3Mods.toJail;
            player3FreezeToggle.Checked = Variables.Player3Mods.freeze;
            player3TakeGunToggle.Checked = Variables.Player3Mods.takeGun;

            // Player 4 Variables
            player4ToJailToggle.Checked = Variables.Player4Mods.toJail;
            player4FreezeToggle.Checked = Variables.Player4Mods.freeze;
            player4TakeGunToggle.Checked = Variables.Player4Mods.takeGun;
        }

        private void TrollingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Player 2 Variables
            Variables.Player2Mods.toJail = player2ToJailToggle.Checked;
            Variables.Player2Mods.freeze = player2FreezeToggle.Checked;
            Variables.Player2Mods.takeGun = player2TakeGunToggle.Checked;

            // Player 3 Variables
            Variables.Player3Mods.toJail = player3ToJailToggle.Checked;
            Variables.Player3Mods.freeze = player3FreezeToggle.Checked;
            Variables.Player3Mods.takeGun = player3TakeGunToggle.Checked;

            // Player 4 Variables
            Variables.Player4Mods.toJail = player4ToJailToggle.Checked;
            Variables.Player4Mods.freeze = player4FreezeToggle.Checked;
            Variables.Player4Mods.takeGun = player4TakeGunToggle.Checked;
        }

        #region Player 2 Mods
        private void player2ToJailToggle_Click(object sender, EventArgs e)
        {

            if (player2ToJailToggle.Checked)
            {
                Main.toJail(true, 1);
            }
            else
            {
                Main.toJail(false, 1);
            }
        }

        private void player2ToSpaceBtn_Click(object sender, EventArgs e)
        {
            Vector3 tempPP = Main.currentPosition(1);
            P2CP = new Vector3((float)tempPP.X, (float)tempPP.Y, (float)tempPP.Z + 400000);
            Main.toSpace(P2CP, 1);
        }

        private void player2FreezeToggle_Click(object sender, EventArgs e)
        {
            if (player2FreezeToggle.Checked)
            {
                Main.freezePlayer(true, 1);
            }
            else
            {
                Main.freezePlayer(false, 1);
            }
        }

        private void player2TakeGunToggle_Click(object sender, EventArgs e)
        {
            if (player2TakeGunToggle.Checked)
            {
                Main.takeGun(true, 1);
            }
            else
            {
                Main.takeGun(false, 1);
            }
        }
        
        private void player2KickBtn_Click(object sender, EventArgs e)
        {
            Main.cmdBuffer("kick " + Variables.Player2Mods.name + ";");
        }

        private void player2ToMeBtn_Click(object sender, EventArgs e)
        {
            Main.teleportPlayers(false, 1);
        }
        #endregion

        #region Player 3 Mods
        private void player3ToJailToggle_Click(object sender, EventArgs e)
        {
            if (player3ToJailToggle.Checked)
            {
                Main.toJail(true, 2);
            }
            else
            {
                Main.toJail(false, 2);
            }
        }

        private void player3ToSpaceBtn_Click(object sender, EventArgs e)
        {
            Vector3 tempPP = Main.currentPosition(2);
            P3CP = new Vector3((float)tempPP.X, (float)tempPP.Y, (float)tempPP.Z + 400000);
            Main.toSpace(P3CP, 2);
        }
        
        private void player3FreezeToggle_Click(object sender, EventArgs e)
        {
            if (player3FreezeToggle.Checked)
            {
                Main.freezePlayer(true, 2);
            }
            else
            {
                Main.freezePlayer(false, 2);
            }
        }
        
        private void player3TakeGunToggle_Click(object sender, EventArgs e)
        {
            if (player3TakeGunToggle.Checked)
            {
                Main.takeGun(true, 2);
            }
            else
            {
                Main.takeGun(false, 2);
            }
        }
        
        private void player3KickBtn_Click(object sender, EventArgs e)
        {
            Main.cmdBuffer("kick " + Variables.Player3Mods.name + ";");
        }

        private void player3ToMeBtn_Click(object sender, EventArgs e)
        {
            Main.teleportPlayers(false, 2);
        }
        #endregion

        #region Player 4 Mods
        private void player4ToJailToggle_Click(object sender, EventArgs e)
        {
            if (player4ToJailToggle.Checked)
            {
                Main.toJail(true, 3);
            }
            else
            {
                Main.toJail(false, 3);
            }
        }

        private void player4ToSpaceBtn_Click(object sender, EventArgs e)
        {
            Vector3 tempPP = Main.currentPosition(3);
            P4CP = new Vector3((float)tempPP.X, (float)tempPP.Y, (float)tempPP.Z + 400000);
            Main.toSpace(P4CP, 3);
        }

        private void player4FreezeToggle_Click(object sender, EventArgs e)
        {
            if (player4FreezeToggle.Checked)
            {
                Main.freezePlayer(true, 3);
            }
            else
            {
                Main.freezePlayer(false, 3);
            }
        }

        private void player4TakeGunToggle_MouseClick(object sender, MouseEventArgs e)
        {
            if (player4TakeGunToggle.Checked)
            {
                Main.takeGun(true, 3);
            }
            else
            {
                Main.takeGun(false, 3);
            }
        }

        private void player4KickBtn_Click(object sender, EventArgs e)
        {
            Main.cmdBuffer("kick " + Variables.Player4Mods.name + ";");
        }

        private void player4ToMeBtn_Click(object sender, EventArgs e)
        {
            Main.teleportPlayers(false, 3);
        }
        #endregion
    }
}
