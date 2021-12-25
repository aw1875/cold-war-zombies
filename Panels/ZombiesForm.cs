using System;
using System.Windows.Forms;
using BigK.Common;

namespace BigK.Panels
{
    public partial class ZombiesForm : Form
    {
        public ZombiesForm()
        {
            InitializeComponent();
        }

        // Load values on Form Load
        private void ZombiesForm_Load(object sender, EventArgs e)
        {
            instaKillToggle.Checked = Variables.ZombieMods.instaKill;
            teleportZombiesToggle.Checked = Variables.ZombieMods.teleportZombies;
            critOnlyToggle.Checked = Variables.ZombieMods.critKills;
            teleportCrosshairsToggle.Checked = Variables.ZombieMods.teleportCrosshairs;
            skipRoundsToggle.Checked = Variables.ZombieMods.skipRounds;
        }

        // Save values on Form Close
        private void ZombiesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Variables.ZombieMods.instaKill = instaKillToggle.Checked;
            Variables.ZombieMods.teleportZombies = teleportZombiesToggle.Checked;
            Variables.ZombieMods.critKills = critOnlyToggle.Checked;
            Variables.ZombieMods.teleportCrosshairs = teleportCrosshairsToggle.Checked;
            Variables.ZombieMods.skipRounds = skipRoundsToggle.Checked;
        }

        private void teleportZombiesToggle_Click(object sender, EventArgs e)
        {
            if (teleportZombiesToggle.Checked)
            {
                Variables.ZombieMods.teleportZombies = true;
            }
            else
            {
                Variables.ZombieMods.teleportZombies = false;
            }
        }

        private void instaKillToggle_Click(object sender, EventArgs e)
        {
            Variables.ZombieMods.instaKill = true;
        }

        private void critOnlyToggle_Click(object sender, EventArgs e)
        {
            if (critOnlyToggle.Checked)
            {
                Main.critKills(true);
            }
            else
            {
                Main.critKills(false);
            }
        }

        private void teleportCrosshairsToggle_Click(object sender, EventArgs e)
        {
            if (teleportCrosshairsToggle.Checked)
            {
                //Main.teleportZombies();
                Variables.ZombieMods.teleportCrosshairs = true;
            }
            else
            {
                Variables.ZombieMods.teleportCrosshairs = false;
            }
        }

        private void skipRoundsToggle_Click(object sender, EventArgs e)
        {
            skipRoundsToggle.Checked = false;
            MessageBox.Show("Feature coming soon!", "AstolfoHook");
        }

        private void tpZombiesToMeBtn_Click(object sender, EventArgs e)
        {
            Main.zombiesToMe(Main.currentPosition(0));
        }
    }
}
