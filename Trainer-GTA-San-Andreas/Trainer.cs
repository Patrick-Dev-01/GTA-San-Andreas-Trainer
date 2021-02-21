using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Runtime.InteropServices;
using System.Threading;

namespace Trainer_GTA_San_Andreas
{
    public partial class Trainer : Form
    {
        [DllImport("user32.dll")]
        //Função que irá receber as hotkeys
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        public const int WM_HOTKEY = 0x312;

        public Mem m = new Mem();
        bool ProcessOpen = false;
        public Trainer()
        {
            InitializeComponent();
        }
     
        private void Trainer_Load(object sender, EventArgs e)
        {
            RegisterHotKey(this.Handle, 0, 0, (int)Keys.D3);
        }

        private void BG_Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            while (true)
            {
                ProcessOpen = m.OpenProcess("gta-sa.exe");
                // Verificar se o GTA San Andreas esta executando
                if (ProcessOpen)
                {
                    Thread.Sleep(1000);
                    return;
                }
                // impedir o uso excessivo da CPU
                Thread.Sleep(1000);
                BgWorker.ReportProgress(0);
            }
        }
        private void Trainer_Shown(object sender, EventArgs e)
        {
            // assim que o trainer carregar ele inicia o background worker
            BgWorker.RunWorkerAsync();
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // assim que o trainer carregar ele inicia o background worker
            BgWorker.RunWorkerAsync();
        }

        private void MaxMoney_CheckStateChanged(object sender, EventArgs e)
        {
            m.WriteMemory("gta-sa.exe+0x00FD7C,B8", "int", "99999999");
            Thread.Sleep(100);
        }

        private void InfiniteAmmo_CheckStateChanged(object sender, EventArgs e)
        {
            string[] weaponsAmmoAdress = { "gta-sa.exe+0x7FC7D8,5E4", "gta-sa.exe+0x7FC7D8,600", "gta-sa.exe+0x7FC7D8,61C", "gta-sa.exe+0x00802ECC,AC", 
                "gta-sa.exe+0x7FC7D8,638"};

            if (InfiniteAmmo.Checked)
            {
                for (int i = 0; i < weaponsAmmoAdress.Length; i++) {
                    m.FreezeValue(weaponsAmmoAdress[i], "int", "999");
                }
            }

            else {
                for (int i = 0; i < weaponsAmmoAdress.Length; i++)
                {
                    m.UnfreezeValue(weaponsAmmoAdress[i]);
                }
            }
          
            Thread.Sleep(100);
        }
  
        private void godmodeCheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            string lifeAdress = "gta-sa.exe+0x007FC7D8,540";
            string armorAdress = "gta-sa.exe+0x007FC7D8,548";

            if (godmodeCheckbox.Checked)
            {
                m.FreezeValue(lifeAdress, "float", "1000");
                m.FreezeValue(armorAdress, "float", "1000");
            }

            else {
                m.UnfreezeValue(lifeAdress);
                m.UnfreezeValue(armorAdress);
            }

            Thread.Sleep(100);
        }

        private void recoveryHeatlhButton_Click(object sender, EventArgs e)
        {
            m.WriteMemory("gta-sa.exe+0x007FC7D8,540", "float", "100");
            Thread.Sleep(100);
        }

        private void ArmorRecoveryButton_Click(object sender, EventArgs e)
        {
            m.WriteMemory("gta-sa.exe+0x007FC7D8,548", "float", "100");
            Thread.Sleep(100);
        }

        private void hitmanLevelsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            string[] weaponSkilsAdress = { "gta-sa.exe+0x00172664,4", "gta-sa.exe+0x008B91E0,1A4,31C", "gta-sa.exe+0x00172664,1C", "gta-sa.exe+0x0017279C,2C" 
            , "gta-sa.exe+0x00172664,20", "gta-sa.exe+0x0016F894,138"};

            for (int i = 0; i < weaponSkilsAdress.Length; i++) {
                m.WriteMemory(weaponSkilsAdress[i], "float", "1000");
            }
            Thread.Sleep(100);
        }

        // Função que irá Processar as HotKeys: teclas que são pressionadas fora da aplicação
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_HOTKEY && msg.WParam == (IntPtr)0)
            {
                // Jump Hack
                if (jumpHackCheckbox.Checked) {
                    string jumpForceAdress = "gta-sa.exe+0x7FC7D8,4C";
                    int isDrivingMotorcycle = m.ReadByte("gta-sa.exe+0x0008BCDC,25C");
                    int isDrivingBike = m.ReadByte("gta-sa.exe+0x00050194,260");

                    if (isDrivingBike == 1 || isDrivingMotorcycle == 1)
                    {
                        m.WriteMemory(jumpForceAdress, "float", "0,4");
                    }

                    else {
                        m.WriteMemory(jumpForceAdress, "float", "1");
                    }

                   
                }   
                Thread.Sleep(200);
            }
            base.WndProc(ref msg);
        }
    }
}
