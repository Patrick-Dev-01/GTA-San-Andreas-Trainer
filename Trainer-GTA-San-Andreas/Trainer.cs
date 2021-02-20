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
using System.Threading;

namespace Trainer_GTA_San_Andreas
{
    public partial class Trainer : Form
    {
        public Mem m = new Mem();
        public Trainer()
        {
            InitializeComponent();
        }

        private void Trainer_Load(object sender, EventArgs e)
        {

        }

        bool ProcessOpen = false;

        private void BG_Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // impedi o uso excessivo da CPU
            while (true)
            {
                ProcessOpen = m.OpenProcess("gta-sa.exe");
                // Verificar se  o Resident evil 4 esta executando
                if (ProcessOpen)
                {
                    Thread.Sleep(1000);
                    return;
                }

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
            m.WriteMemory("gta-sa.exe+0x00FD7C,B8", "int", "999999999");
            Thread.Sleep(100);
        }

        private void InfiniteAmmo_CheckStateChanged(object sender, EventArgs e)
        {
            string[] weaponsAmmoAdress = { "gta-sa.exe+0x7FC7D8,5E4", "gta-sa.exe+0x7FC7D8,600", "gta-sa.exe+0x7FC7D8,61C", "gta-sa.exe+0x00802ECC,AC" };

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
                m.FreezeValue(lifeAdress, "float", "100");
                m.FreezeValue(armorAdress, "float", "100");
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
            string[] weaponSkilsAdress = { "gta-sa.exe+0x00172664,4", "gta-sa.exe+0x008B91E0,1A4,31C", "gta-sa.exe+0x00172664,1C", "gta-sa.exe+0x0017279C,2C"};

            for (int i = 0; i < weaponSkilsAdress.Length; i++) {
                m.WriteMemory(weaponSkilsAdress[i], "float", "1000");
            }
        }
    }
}
