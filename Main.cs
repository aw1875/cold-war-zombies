using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Text;
using System.Reflection;

// Custom Namespaces
using FontAwesome.Sharp;
using BigK.Panels;
using BigK.Common;

// Memory
using BLAZN.UTILITIES;
using static BLAZN.UTILITIES.Vectors.Vec3;

namespace BigK
{
    internal partial class Main : Form
    {

        // Instantiate Memory class 
        private static Memory m = new Memory();

        // Create position vectors
        private static Vector3 updatedPlayerPos;
        private static Vector3 freePosition = new Vector3();

        // Create original gunID
        private static int originalGunID = 0;

        // Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form activeForm = null;

        // Instantiate roundsThread background worker
        private static BackgroundWorker roundsThread = new BackgroundWorker();

        public Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                string resource = Array.Find(this.GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };

            InitializeComponent();

            // Left panel
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            leftPanel.Controls.Add(leftBorderBtn);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ActivateButton(onlineBtn, e);
        }

        #region Custom Form Functions
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void AllowDrag(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Functions.disableAll();
            updateButton("Attach");
            this.Close();
        }

        private void attachBtn_Click(object sender, EventArgs e)
        {
            if (!mainThread.IsBusy)
            {
                mainThread.RunWorkerAsync();
            }
            else
            {
                mainThread.CancelAsync();
            }

            if (!nameThread.IsBusy)
            {
                nameThread.RunWorkerAsync();
            }
            else
            {
                nameThread.CancelAsync();
            }

            if (!zombieCounterThread.IsBusy)
            {
                zombieCounterThread.RunWorkerAsync();
            }
            else
            {
                zombieCounterThread.CancelAsync();
            }
        }
        #endregion

        #region Functions
        public static void godMode(bool YN, int clientID)
        {
            if (YN)
            {
                m.WriteInt32(Functions.PCompPtr(clientID) + Offsets.PC_GodMode, 0xA0);
            }
            else
            {
                m.WriteInt32(Functions.PCompPtr(clientID) + Offsets.PC_GodMode, 0x20);
            }
        }

        public static void infiniteMoney(int clientID)
        {
            m.WriteInt32(Functions.PCompPtr(clientID) + Offsets.PC_Points, 56120);
        }

        public static void infiniteAmmo(int clientID)
        {
            for (ulong i = 0; i < 6; i++)
            {
                m.WriteInt32(Functions.PCompPtr(clientID) + Offsets.PC_Ammo + (i * 0x4), 50);
            }
        }

        public static void thermalVision(bool YN, int clientID)
        {
            if (YN)
            {
                m.WriteInt32(Functions.PCompPtr(clientID) + Offsets.PC_InfraredVision, 0x10);
            }
            else
            {
                m.WriteInt32(Functions.PCompPtr(clientID) + Offsets.PC_InfraredVision, 0x0);
            }
        }

        public static void giveWeapon(int clientID, int weaponID)
        {
            if (Variables.weaponID[weaponID] != -1)
            {
                for (ulong i = 0; i < 6; i++)
                {
                    m.WriteInt64(Functions.PCompPtr(clientID) + Offsets.PC_SetWeaponID + (i * 0x40), Variables.weaponID[weaponID]);
                    switch (clientID)
                    {
                        case 0:
                            if (!Variables.UserMods.infAmmo && !Variables.LobbyMods.infAmmo)
                                m.WriteInt32(Functions.PCompPtr(clientID) + Offsets.PC_Ammo + (i * 0x4), 50);
                            break;
                        case 1:
                            if (!Variables.Player2Mods.infAmmo && !Variables.LobbyMods.infAmmo)
                                m.WriteInt32(Functions.PCompPtr(clientID) + Offsets.PC_Ammo + (i * 0x4), 50);
                            break;
                        case 2:
                            if (!Variables.Player3Mods.infAmmo && !Variables.LobbyMods.infAmmo)
                                m.WriteInt32(Functions.PCompPtr(clientID) + Offsets.PC_Ammo + (i * 0x4), 50);
                            break;
                        case 3:
                            if (!Variables.Player4Mods.infAmmo && !Variables.LobbyMods.infAmmo)
                                m.WriteInt32(Functions.PCompPtr(clientID) + Offsets.PC_Ammo + (i * 0x4), 50);
                            break;
                    }
                }
            }
        }
        
        public static void freezePlayer(bool YN, int clientID)
        {
            if (YN)
            {
                m.WriteFloat(Functions.PCompPtr(clientID) + Offsets.PC_RunSpeed, 0.0f);
            }
            else
            {
                m.WriteFloat(Functions.PCompPtr(clientID) + Offsets.PC_RunSpeed, 1.0f);
            }
        }

        public static string getName(int clientID)
        {
            return m.ReadString(Functions.PCompPtr(clientID) + Offsets.PC_Name);
        }

        public static void instaKill()
        {
            for (int i = 0; i < 120; i++)
            {
                var health = m.ReadFloat(Offsets.ZMBotListBase + Offsets.ZM_Bot_Health + (Offsets.ZM_Bot_ArraySize_Offset * (ulong)i));
                if (health > 0 && health < 50000)
                {
                    m.WriteInt32(Offsets.ZMBotListBase + Offsets.ZM_Bot_Health + (Offsets.ZM_Bot_ArraySize_Offset * (ulong)i), 1);
                }
            }
        }

        public static int zombiesLeft()
        {
            return m.ReadInt32(Offsets.ZMGlobalBase + Offsets.ZM_Global_ZMLeftCount);
        }

        public static void zombiesFollow()
        {
            Vector3 followPosition = new Vector3(updatedPlayerPos.X - 100, updatedPlayerPos.Y - 100, updatedPlayerPos.Z);

            for (ulong i = 0; i < 90; i++)
            {
                m.WriteVec3(Offsets.ZMBotListBase + (Offsets.ZM_Bot_ArraySize_Offset * i) + Offsets.ZM_Bot_Coords, followPosition);
            }
        }

        public static void critKills(bool YN)
        {
            if (YN)
            {
                for (int i = 0; i < 4; i++)
                {
                    m.WriteAByte(Functions.PCompPtr(i) + Offsets.PC_Crit, 255);
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    m.WriteAByte(Functions.PCompPtr(i) + Offsets.PC_Crit, 0);
                }
            }
        }

        public static void toJail(bool YN, int clientID)
        {
            // Create jail position
            Vector3 jailPosition = new Vector3((float)-1098.075, (float)-1728.992, (float)-671.875);
            
            
            if (YN)
            {
                godMode(true, clientID);
                freezePlayer(true, clientID);
                freePosition = m.ReadVector3(Functions.PPedPtr(clientID) + Offsets.PP_Coords);
                m.WriteVec3(Functions.PCompPtr(clientID) + Offsets.PC_Coords, jailPosition);

            }
            else
            {
                switch (clientID)
                {
                    case 0:
                        if (!Variables.UserMods.godMode && !Variables.LobbyMods.godMode)
                            godMode(false, clientID);
                        break;
                    case 1:
                        if (!Variables.Player2Mods.godMode && !Variables.LobbyMods.godMode)
                            godMode(false, clientID);
                        break;
                    case 2:
                        if (!Variables.Player3Mods.godMode && !Variables.LobbyMods.godMode)
                            godMode(false, clientID);
                        break;
                    case 3:
                        if (!Variables.Player4Mods.godMode && !Variables.LobbyMods.godMode)
                            godMode(false, clientID);
                        break;
                }
                freezePlayer(false, clientID);
                m.WriteVec3(Functions.PCompPtr(clientID) + Offsets.PC_Coords, freePosition);
            }
        }

        public static void toSpace(Vector3 position, int clientID)
        {
            m.WriteVec3(Functions.PCompPtr(clientID) + Offsets.PC_Coords, position);
        }

        public static void teleportZombies()
        {
            double vertical = Functions.ConvertDegreesToRadians(BitConverter.ToSingle(m.ReadBytes(Functions.PPedPtr(0) + Offsets.PP_Heading_XY, 4), 0));
            double lateral = -Functions.ConvertDegreesToRadians(BitConverter.ToSingle(m.ReadBytes(Functions.PPedPtr(0) + Offsets.PP_Heading_Z, 4), 0));

            Vector3 crossHairOffset = new Vector3((float)Convert.ToSingle(Math.Cos(vertical) * Math.Cos(lateral)), (float)Convert.ToSingle(Math.Sin(vertical) * Math.Cos(lateral)), (float)Convert.ToSingle(Math.Sin(lateral)));

            for (ulong i = 0; i < 120; i++)
            {
                m.WriteVec3(Offsets.ZMBotListBase + (Offsets.ZM_Bot_ArraySize_Offset * i) + Offsets.ZM_Bot_Coords, updatedPlayerPos + (crossHairOffset * 100));
            }
        }
        
        public static void teleportPlayers(bool lobby, int clientID = 0)
        {
            if (lobby)
            {
                for (int i = 1; i < 4; i++)
                {
                    m.WriteVec3(Functions.PCompPtr(i) + Offsets.PC_Coords, updatedPlayerPos);
                }
            }
            else
            {
                m.WriteVec3(Functions.PCompPtr(clientID) + Offsets.PC_Coords, updatedPlayerPos);
            }
        }

        public static void zombiesToMe(Vector3 freezePosition)
        {
            for (ulong i = 0; i < 120; i++)
            {
                m.WriteVec3(Offsets.ZMBotListBase + (Offsets.ZM_Bot_ArraySize_Offset * i) + Offsets.ZM_Bot_Coords, new Vector3(freezePosition.X - 100, freezePosition.Y, freezePosition.Z));
            }
        }
        
        public static void takeGun(bool YN, int clientID)
        {
            if (YN)
            {
                // Store original gun ID
                originalGunID = m.ReadInt32(Functions.PCompPtr(clientID) + Offsets.PC_SetWeaponID);

                for (ulong i = 0; i < 6; i++)
                {
                    m.WriteInt64(Functions.PCompPtr(clientID) + Offsets.PC_SetWeaponID + (i * 0x40), 0);
                    m.WriteInt32(Functions.PCompPtr(clientID) + Offsets.PC_Ammo + (i * 0x4), 0);
                }
            }
            else
            {
                for (ulong i = 0; i < 6; i++)
                {
                    m.WriteInt64(Functions.PCompPtr(clientID) + Offsets.PC_SetWeaponID + (i * 0x40), originalGunID);
                    switch (clientID)
                    {
                        case 0:
                            if (!Variables.UserMods.infAmmo && !Variables.LobbyMods.infAmmo)
                                m.WriteInt32(Functions.PCompPtr(clientID) + Offsets.PC_Ammo + (i * 0x4), 50);
                            break;
                        case 1:
                            if (!Variables.Player2Mods.infAmmo && !Variables.LobbyMods.infAmmo)
                                m.WriteInt32(Functions.PCompPtr(clientID) + Offsets.PC_Ammo + (i * 0x4), 50);
                            break;
                        case 2:
                            if (!Variables.Player3Mods.infAmmo && !Variables.LobbyMods.infAmmo)
                                m.WriteInt32(Functions.PCompPtr(clientID) + Offsets.PC_Ammo + (i * 0x4), 50);
                            break;
                        case 3:
                            if (!Variables.Player4Mods.infAmmo && !Variables.LobbyMods.infAmmo)
                                m.WriteInt32(Functions.PCompPtr(clientID) + Offsets.PC_Ammo + (i * 0x4), 50);
                            break;
                    }
                }
            }
        }

        public static void superSpeed(bool YN, int clientID)
        {
            if (YN)
            {
                m.WriteFloat(Functions.PCompPtr(clientID) + Offsets.PC_RunSpeed, 3.0f);
            }
            else
            {
                m.WriteFloat(Functions.PCompPtr(clientID) + Offsets.PC_RunSpeed, 1.0f);
            }
        }

        public static Vector3 currentPosition(int clientID)
        {
            return m.ReadVector3(Functions.PPedPtr(clientID) + Offsets.PP_Coords);
        }

        public static void teleport(int clientID, int locationID)
        {
            if (Variables.locationVectors[locationID].X != 0f)
            {
                m.WriteVec3(Functions.PCompPtr(clientID) + Offsets.PC_Coords, Variables.locationVectors[locationID]);
            }
        }

        public static void cmdBuffer(string cmd)
        {
            m.WriteXString(m.GetPointer(Offsets.BaseAddress + Offsets.CMDBufferBase), cmd);
            m.WriteBool(m.GetPointer(Offsets.BaseAddress + Offsets.CMDBufferBase) - Offsets.CMDBB_Exec, true);
        }

        // TESTING
        public static void skipRounds(bool YN)
        {
        }

        public static void superJump(bool YN, int clientID)
        {
            if (YN)
            {
                m.WriteFloat(Offsets.BaseAddress + Offsets.GameSetting + 0x8, Convert.ToSingle(599));
                //m.WriteFloat(Offsets.BaseAddress + Offsets.JumpHeight + 0x130, 599.0f);
                //cwapi.WriteProcessMemory(hProc, PlayerCompPtr + (Offsets.PC_ArraySize_Offset * clientID) + Offsets.JumpHeight, Convert.ToSingle(99), 4, out _);
            }
        }
        #endregion

        #region UI Functions
        private void ActivateButton(object senderBtn, EventArgs e)
        {
            if (senderBtn != null)
            {
                DisableButton();

                // Set active button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(32, 32, 32);
                currentBtn.ForeColor = Color.FromArgb(189, 195, 199);
                currentBtn.IconColor = Color.FromArgb(189, 195, 199);
                currentBtn.Font = new Font(currentBtn.Font, FontStyle.Bold);

                // Left panel to show active
                leftBorderBtn.BackColor = Color.FromArgb(189, 195, 199);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Show panel
                switch (currentBtn.Text)
                {
                    case "Home":
                        openChildForm(new OnlineForm());
                        break;
                    case "Lobby":
                        openChildForm(new LobbyForm());
                        break;
                    case "User":
                        openChildForm(new UserForm());
                        break;
                    case "Zombies":
                        openChildForm(new ZombiesForm());
                        break;
                    case "Trolling":
                        openChildForm(new TrollingForm());
                        break;
                }
            }
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childPanelForm.Controls.Add(childForm);
            childPanelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(24, 24, 24);
                currentBtn.ForeColor = Color.FromArgb(189, 195, 199);
                currentBtn.IconColor = Color.FromArgb(189, 195, 199);
                currentBtn.Font = new Font(currentBtn.Font, FontStyle.Regular);
            }
        }
        
        public void updateButton(string text)
        {
            if (this.InvokeRequired)
            {
                attachBtn.Invoke((MethodInvoker)delegate ()
                {
                    attachBtn.Text = text;
                    attachBtn.ForeColor = text == "Detach" ? Color.FromArgb(231, 76, 60) : Color.FromArgb(236, 240, 241);
                    attachBtn.IconColor = text == "Detach" ? Color.FromArgb(231, 76, 60) : Color.FromArgb(236, 240, 241);
                    attachBtn.IconChar = text == "Detach" ? IconChar.Unlink : IconChar.Link;
                });
            }
            else
            {
                attachBtn.Text = text;
                attachBtn.ForeColor = text == "Detach" ? Color.FromArgb(231, 76, 60) : Color.FromArgb(236, 240, 241);
                attachBtn.IconColor = text == "Detach" ? Color.FromArgb(231, 76, 60) : Color.FromArgb(236, 240, 241);
                attachBtn.IconChar = text == "Detach" ? IconChar.Unlink : IconChar.Link;
            }
        }
        #endregion

        #region Background Worker Functions
        private void mainThread_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!mainThread.CancellationPending)
            {
                try
                {
                    #region Attach Process
                    if (!m.IsOpen())
                    {
                        updateButton("Game not running.");
                        m.AttackProcess("BlackOpsColdWar");
                    }
                    else
                    {
                        Offsets.BaseAddress = (ulong)Memory.GetBaseAddress("BlackOpsColdWar");
                        m.AttackProcess("BlackOpsColdWar");

                        updateButton("Detach");

                        Offsets.PlayerCompPtr = m.ReadInt64(Offsets.BaseAddress + Offsets.PlayerBase);

                        Offsets.PlayerPedPtr = m.ReadInt64(Offsets.BaseAddress + Offsets.PlayerBase + 0x8);

                        Offsets.ZMGlobalBase = m.ReadInt64(Offsets.BaseAddress + Offsets.PlayerBase + 0x60);

                        Offsets.ZMBotBase = m.ReadInt64(Offsets.BaseAddress + Offsets.PlayerBase + 0x68);

                        Offsets.ZMBotListBase = m.ReadInt64(Offsets.ZMBotBase + Offsets.ZM_Bot_List_Offset);

                    }
                    #endregion

                    #region Lobby Mods
                    if (Variables.LobbyMods.infMoney)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            infiniteMoney(i);
                        }
                    }

                    // Check for lobby infinite ammo
                    if (Variables.LobbyMods.infAmmo)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            infiniteAmmo(i);
                        }
                    }
                    #endregion

                    #region Player 1 Mods
                    if (Variables.UserMods.infMoney)
                    {
                        infiniteMoney(0);
                    }

                    if (Variables.UserMods.infAmmo)
                    {
                        infiniteAmmo(0);
                    }
                    #endregion

                    #region Player 2 Mods
                    if (Variables.Player2Mods.infMoney)
                    {
                        infiniteMoney(1);
                    }

                    if (Variables.Player2Mods.infAmmo)
                    {
                        infiniteAmmo(1);
                    }
                    #endregion

                    #region Player 3 Mods
                    if (Variables.Player3Mods.infMoney)
                    {
                        infiniteMoney(2);
                    }

                    if (Variables.Player3Mods.infAmmo)
                    {
                        infiniteAmmo(2);
                    }
                    #endregion

                    #region Player 4 Mods
                    if (Variables.Player4Mods.infMoney)
                    {
                        infiniteMoney(3);
                    }

                    if (Variables.Player4Mods.infAmmo)
                    {
                        infiniteAmmo(3);
                    }
                    #endregion

                    #region Get Host Coordinates
                    byte[] playerCoords = new byte[12];
                    updatedPlayerPos = m.ReadVector3(Functions.PPedPtr(0) + Offsets.PP_Coords);
                    #endregion

                    #region Zombie Mods
                    if (Variables.ZombieMods.instaKill)
                    {
                        instaKill();
                    }

                    if (Variables.ZombieMods.teleportZombies)
                    {
                        zombiesFollow();
                    }

                    if (Variables.ZombieMods.teleportCrosshairs)
                    {
                        teleportZombies();
                    }
                    #endregion
                    Thread.Sleep(100);
                }
                catch (Exception err)
                {
                    Log.Write(LogEvent.Error, err.ToString());
                    nameThread.CancelAsync();
                }
            }
        }

        private void mainThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ActivateButton(onlineBtn, e);
            Functions.disableAll();
            updateButton("Attach");
        }

        private void nameThread_DoWork(object sender, DoWorkEventArgs e)
        {
            while(!nameThread.CancellationPending)
            {
                try
                {
                    Variables.UserMods.name = Encoding.UTF8.GetString(Encoding.Default.GetBytes(getName(0)));
                    Variables.Player2Mods.name = Encoding.UTF8.GetString(Encoding.Default.GetBytes(getName(1)));
                    Variables.Player3Mods.name = Encoding.UTF8.GetString(Encoding.Default.GetBytes(getName(2)));
                    Variables.Player4Mods.name = Encoding.UTF8.GetString(Encoding.Default.GetBytes(getName(3)));
                }
                catch (Exception err)
                {
                    Log.Write(LogEvent.Error, err.ToString());
                    nameThread.CancelAsync();
                }

                Thread.Sleep(1000);
            }
        }

        private  void roundsThread_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!roundsThread.CancellationPending)
            {
                m.WriteInt32(Offsets.SkipRoundSix, 0);
                //for (int i = 0; i < Offsets.skip.Length; i++)
                //{
                //    m.WriteInt32(Offsets.skip[i], 0);
                //}

                //for (int i = 0; i < Offsets.skip2.Length; i++)
                //{
                //    m.WriteInt32(Offsets.skip2[i], 0);
                //}

                //for (int i = 0; i < Offsets.skip3.Length; i++)
                //{
                //    m.WriteInt32(Offsets.skip3[i], 0);
                //}

                //for (int i = 0; i < Offsets.skip4.Length; i++)
                //{
                //    m.WriteInt32(Offsets.skip4[i], 0);
                //}

                //for (int i = 0; i < Offsets.skip5.Length; i++)
                //{
                //    m.WriteInt32(Offsets.skip5[i], 0);
                //}

                //for (int i = 0; i < Offsets.skip6.Length; i++)
                //{
                //    m.WriteInt32(Offsets.skip6[i], 0);
                //}
            }
        }

        private void zombieCounterThread_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!zombieCounterThread.CancellationPending)
            {
                try
                {
                    zombieCounterLabel.Text = "Zombies left: " + zombiesLeft().ToString();
                    Thread.Sleep(1000);
                }
                catch (Exception err)
                {
                    Log.Write(LogEvent.Error, err.ToString());
                    zombieCounterThread.CancelAsync();
                }
            }
        }

        private void zombieCounterThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            zombieCounterLabel.Text = "Zombies left: N/A";
        }
    }
    #endregion
}
