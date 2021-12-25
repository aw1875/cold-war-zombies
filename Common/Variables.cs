using static BLAZN.UTILITIES.Vectors.Vec3;

namespace BigK.Common
{
    class Variables
    {
        #region OnlineMods
        public struct OnlineMods
        {

        }
        #endregion

        #region LobbyMods
        public struct LobbyMods
        {
            public static bool godMode;
            public static bool infMoney;
            public static bool infAmmo;
            public static bool rapidFire;
            public static bool superJump;
            public static bool superSpeed;
            public static bool thermal;
        }
        #endregion

        #region UserMods
        public struct UserMods
        {
            public static bool godMode;
            public static bool infAmmo;
            public static bool infMoney;
            public static bool rapidFire;
            public static bool freezePlayer;
            public static bool thermal;
            public static int weaponID = -1;
            public static string name = "";
        }
        #endregion

        #region PlayerMods
        public struct Player2Mods
        {
            public static bool godMode;
            public static bool infAmmo;
            public static bool infMoney;
            public static int weaponID = -1;
            public static string name = "";

            // Trolling
            public static bool toJail;
            public static bool freeze;
            public static bool takeGun;
        }
        
        public struct Player3Mods
        {
            public static bool godMode;
            public static bool infAmmo;
            public static bool infMoney;
            public static int weaponID = -1;
            public static string name = "";

            // Trolling
            public static bool toJail;
            public static bool freeze;
            public static bool takeGun;
        }
        
        public struct Player4Mods
        {
            public static bool godMode;
            public static bool infAmmo;
            public static bool infMoney;
            public static int weaponID = -1;
            public static string name = "";

            // Trolling
            public static bool toJail;
            public static bool freeze;
            public static bool takeGun;
        }
        #endregion

        #region ZombieMods
        public struct ZombieMods
        {
            public static bool instaKill;
            public static bool teleportZombies;
            public static bool critKills;
            public static bool teleportCrosshairs;
            public static bool skipRounds;
        }
        #endregion

        #region Weapons
        //public static int[] weaponID = new int[] { -1, 70, 8, 16, 66, 39, -1, -1, 52, 76, 56, 26, 20, -1, -1, 45, 49, 48, -1, -1, 5, 59, 80, -1, -1, 41, 61, 7, -1, -1, 23, 28, 37, -1, -1, 46, 68, -1, -1, 31, 15, -1, -1, 13, -1, -1, 18, -1, -1, 65, 42, 47, 58, 55, 63, 17, 44, 4, 69, 67, 38, 12, 78, 40, 36, 6, 14, 33, 21, 24, 62, 10, 54, 22, 60, 72 };
        //public static int[] weaponID = new int[] { -1, 333, 346, 315, 347, 350, -1, -1, 422, 409, 448, 438, 366, -1, -1, 424, 445, 293, -1, -1, 389, 441, 344, -1, -1, 373, 312, 463, -1, -1, 320, 311, 466, -1, -1, 421, 465, -1, -1, 372, 334, -1, -1, 44, -1, -1, 459, -1, -1, 388, 395, 364, 450, 309, 328, 439, 323, 335, 463, 308, 406, 449, 285, 365, 414, 433, 430, 361, 301, 458, 390, 317, 54, 404, 353, 349, -1, -1, 428, 296, 351, 342, 316, 324 };
        public static int[] weaponID = new int[] { -1, 363, 377, 343, 378, 386, 426, 428, 400, 388, 326, -1, -1, 465, 449, 493, 483, 402, 495, 334, 357, 484, 384, 408, -1, -1, 467, 490, 317, 352, 365, -1, -1, 427, 486, 375, 509, -1, -1, 410, 340, 372, 333, 444, -1, -1, 385, 338, 476, 494, 442, -1, -1, 488, 476, 309, 370, -1, -1, 409, 364, 345, 474, 371, -1, -1, 505, 401, 454, 478, 473, 397, 325, 503, 428, 382, 477, 448, 379, -1, -1, 83, 43, 321, 469, 480, 445, 58, 2, 3, 11, 89, 344, 353, 373, 387, 334, 13, -1, -1, 314, 330, 394, 406, 416, 425, 438, 467, 15, 23, 31, 40, 61, 65, 75, 87, 497 };
        #endregion

        #region Spawn Locations
        public static Vector3[] locationVectors = new Vector3[]
        {
            new Vector3(0f, 0f, 0f),
            new Vector3(0f, 0f, 0f),
            new Vector3((float)1026.479, (float)-119.0791, (float)31.72773),
            new Vector3((float)30.51227, (float)-104.3433, (float)10.14705),
            new Vector3((float)-1228.808, (float)220.7215, (float)-38.83881),
            new Vector3((float)-675.4692, (float)225.9666, (float)16.39506),
            new Vector3((float)-1369.4, (float)1830.137, (float)-85.09624),
            new Vector3((float)-779.1058, (float)1216.973, (float)-279.875),
            new Vector3((float)-197.2296, (float)645.5873, (float)-279.875),
            new Vector3((float)283.927, (float)1692.468, (float)-415.875),
            new Vector3((float)1022.18, (float)-687.1146, (float)-255.875),
            new Vector3((float)573.6108, (float)-124.8955, (float)-543.875),
            new Vector3((float)331.2513, (float)134.4783, (float)-671.875),
            new Vector3((float)-1408.134, (float)482.0242, (float)-382.875),
            new Vector3((float)163.1014, (float)832.6141, (float)293.125),
            new Vector3((float)524.9474, (float)1947.043, (float)388.0641),
            new Vector3((float)-185.0556, (float)1616.27, (float)332.1445),
            new Vector3(0f, 0f, 0f),
            new Vector3(0f, 0f, 0f),
            new Vector3(0f, 0f, 0f),
            new Vector3((float)-1116.466, (float)364.2412, (float)-38.32543),
            new Vector3((float)204.6461, (float)2277.219, (float)218.6982),
            new Vector3((float)926.6042, (float)80.14916, (float)58.46823),
            new Vector3((float)520.3193, (float)-375.9803, (float)-671.875),
            new Vector3((float)742.5349, (float)1887.628, (float)-287.875)
        };
        #endregion

    }
}
