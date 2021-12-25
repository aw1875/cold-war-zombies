using System;
using System.Windows.Forms;

namespace BigK.Common
{
    public class Functions
    {
        public static ulong PCompPtr(int i)
        {
            return Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)i);
        }

        public static ulong PPedPtr(int i)
        {
            return Offsets.PlayerPedPtr + (Offsets.PP_ArraySize_Offset * (ulong)i);
        }
        public static double ConvertDegreesToRadians(double degrees)
        {
            double radians = (Math.PI / 180) * degrees;
            return (radians);
        }

        public static void disableAll()
        {
            #region Lobby Mods
            Variables.LobbyMods.godMode = false;
            Variables.LobbyMods.infMoney = false;
            Variables.LobbyMods.infAmmo = false;
            Variables.LobbyMods.rapidFire = false;
            Variables.LobbyMods.superJump = false;
            Variables.LobbyMods.superSpeed = false;
            Variables.LobbyMods.thermal = false;

            for (int i = 0; i < 4; i++)
            {
                Main.godMode(false, i);
                Main.superJump(false, i);
                Main.superSpeed(false, i);
                Main.thermalVision(false, i);
            }
            #endregion

            #region User Mods
            Variables.UserMods.godMode = false;
            Variables.UserMods.infAmmo = false;
            Variables.UserMods.infMoney = false;
            Variables.UserMods.rapidFire = false;
            Variables.UserMods.freezePlayer = false;
            Variables.UserMods.thermal = false;

            Main.godMode(false, 0);
            Main.freezePlayer(false, 0);
            Main.thermalVision(false, 0);
            #endregion

            #region Player 2 Mods
            Variables.Player2Mods.godMode = false;
            Variables.Player2Mods.infAmmo = false;
            Variables.Player2Mods.infMoney = false;

            Main.godMode(false, 1);
            #endregion

            #region Player 3 Mods
            Variables.Player3Mods.godMode = false;
            Variables.Player3Mods.infAmmo = false;
            Variables.Player3Mods.infMoney = false;

            Main.godMode(false, 2);
            #endregion

            #region Player 4 Mods
            Variables.Player4Mods.godMode = false;
            Variables.Player4Mods.infAmmo = false;
            Variables.Player4Mods.infMoney = false;

            Main.godMode(false, 3);
            #endregion

            #region Zombie Mods
            Variables.ZombieMods.instaKill = false;
            Variables.ZombieMods.teleportZombies = false;
            Variables.ZombieMods.critKills = false;
            Variables.ZombieMods.teleportCrosshairs = false;
            Variables.ZombieMods.skipRounds = false;

            Main.critKills(false);
            Main.skipRounds(false);
            #endregion

            #region Trolling Section
            // Player 2
            Variables.Player2Mods.toJail = false;
            Variables.Player2Mods.takeGun = false;
            Variables.Player2Mods.freeze = false;
            Main.toJail(false, 1);

            // Player 3
            Variables.Player3Mods.toJail = false;
            Variables.Player3Mods.takeGun = false;
            Variables.Player3Mods.freeze = false;
            Main.toJail(false, 2);

            // Player 4
            Variables.Player4Mods.toJail = false;
            Variables.Player4Mods.takeGun = false;
            Variables.Player4Mods.freeze = false;
            Main.toJail(false, 3);
            #endregion
        }
    }
}
