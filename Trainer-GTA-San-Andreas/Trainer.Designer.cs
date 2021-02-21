
namespace Trainer_GTA_San_Andreas
{
    partial class Trainer
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainer));
            this.BgWorker = new System.ComponentModel.BackgroundWorker();
            this.MaxMoney = new System.Windows.Forms.CheckBox();
            this.InfiniteAmmo = new System.Windows.Forms.CheckBox();
            this.godmodeCheckbox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ArmorRecoveryButton = new System.Windows.Forms.Button();
            this.recoveryHeatlhButton = new System.Windows.Forms.Button();
            this.hitmanLevelsCheckbox = new System.Windows.Forms.CheckBox();
            this.jumpHackCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BgWorker
            // 
            this.BgWorker.WorkerReportsProgress = true;
            this.BgWorker.WorkerSupportsCancellation = true;
            this.BgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BG_Worker_DoWork);
            this.BgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgWorker_ProgressChanged);
            this.BgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWorker_RunWorkerCompleted);
            // 
            // MaxMoney
            // 
            this.MaxMoney.AutoSize = true;
            this.MaxMoney.Location = new System.Drawing.Point(432, 31);
            this.MaxMoney.Name = "MaxMoney";
            this.MaxMoney.Size = new System.Drawing.Size(101, 21);
            this.MaxMoney.TabIndex = 0;
            this.MaxMoney.Text = "Max money";
            this.MaxMoney.UseVisualStyleBackColor = true;
            this.MaxMoney.CheckStateChanged += new System.EventHandler(this.MaxMoney_CheckStateChanged);
            // 
            // InfiniteAmmo
            // 
            this.InfiniteAmmo.AutoSize = true;
            this.InfiniteAmmo.Location = new System.Drawing.Point(432, 58);
            this.InfiniteAmmo.Name = "InfiniteAmmo";
            this.InfiniteAmmo.Size = new System.Drawing.Size(114, 21);
            this.InfiniteAmmo.TabIndex = 1;
            this.InfiniteAmmo.Text = "Infinite Ammo";
            this.InfiniteAmmo.UseVisualStyleBackColor = true;
            this.InfiniteAmmo.CheckStateChanged += new System.EventHandler(this.InfiniteAmmo_CheckStateChanged);
            // 
            // godmodeCheckbox
            // 
            this.godmodeCheckbox.AutoSize = true;
            this.godmodeCheckbox.Location = new System.Drawing.Point(432, 85);
            this.godmodeCheckbox.Name = "godmodeCheckbox";
            this.godmodeCheckbox.Size = new System.Drawing.Size(96, 21);
            this.godmodeCheckbox.TabIndex = 5;
            this.godmodeCheckbox.Text = "God Mode";
            this.godmodeCheckbox.UseVisualStyleBackColor = true;
            this.godmodeCheckbox.CheckStateChanged += new System.EventHandler(this.godmodeCheckbox_CheckStateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ArmorRecoveryButton
            // 
            this.ArmorRecoveryButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ArmorRecoveryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArmorRecoveryButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ArmorRecoveryButton.Location = new System.Drawing.Point(659, 190);
            this.ArmorRecoveryButton.Name = "ArmorRecoveryButton";
            this.ArmorRecoveryButton.Size = new System.Drawing.Size(101, 39);
            this.ArmorRecoveryButton.TabIndex = 7;
            this.ArmorRecoveryButton.Text = "Armor";
            this.ArmorRecoveryButton.UseVisualStyleBackColor = false;
            this.ArmorRecoveryButton.Click += new System.EventHandler(this.ArmorRecoveryButton_Click);
            // 
            // recoveryHeatlhButton
            // 
            this.recoveryHeatlhButton.BackColor = System.Drawing.Color.Red;
            this.recoveryHeatlhButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recoveryHeatlhButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.recoveryHeatlhButton.Location = new System.Drawing.Point(432, 190);
            this.recoveryHeatlhButton.Name = "recoveryHeatlhButton";
            this.recoveryHeatlhButton.Size = new System.Drawing.Size(96, 39);
            this.recoveryHeatlhButton.TabIndex = 8;
            this.recoveryHeatlhButton.Text = "Heatlh";
            this.recoveryHeatlhButton.UseVisualStyleBackColor = false;
            this.recoveryHeatlhButton.Click += new System.EventHandler(this.recoveryHeatlhButton_Click);
            // 
            // hitmanLevelsCheckbox
            // 
            this.hitmanLevelsCheckbox.AutoSize = true;
            this.hitmanLevelsCheckbox.Location = new System.Drawing.Point(432, 112);
            this.hitmanLevelsCheckbox.Name = "hitmanLevelsCheckbox";
            this.hitmanLevelsCheckbox.Size = new System.Drawing.Size(190, 21);
            this.hitmanLevelsCheckbox.TabIndex = 9;
            this.hitmanLevelsCheckbox.Text = "All Weapons Hitman level";
            this.hitmanLevelsCheckbox.UseVisualStyleBackColor = true;
            this.hitmanLevelsCheckbox.CheckedChanged += new System.EventHandler(this.hitmanLevelsCheckbox_CheckedChanged);
            // 
            // jumpHackCheckbox
            // 
            this.jumpHackCheckbox.AutoSize = true;
            this.jumpHackCheckbox.Location = new System.Drawing.Point(432, 140);
            this.jumpHackCheckbox.Name = "jumpHackCheckbox";
            this.jumpHackCheckbox.Size = new System.Drawing.Size(100, 21);
            this.jumpHackCheckbox.TabIndex = 10;
            this.jumpHackCheckbox.Text = "Jump Hack";
            this.jumpHackCheckbox.UseVisualStyleBackColor = true;
            // 
            // Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 469);
            this.Controls.Add(this.jumpHackCheckbox);
            this.Controls.Add(this.hitmanLevelsCheckbox);
            this.Controls.Add(this.recoveryHeatlhButton);
            this.Controls.Add(this.ArmorRecoveryButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.godmodeCheckbox);
            this.Controls.Add(this.InfiniteAmmo);
            this.Controls.Add(this.MaxMoney);
            this.Name = "Trainer";
            this.Text = "GTA San Andreas Trainer";
            this.Load += new System.EventHandler(this.Trainer_Load);
            this.Shown += new System.EventHandler(this.Trainer_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BgWorker;
        private System.Windows.Forms.CheckBox MaxMoney;
        private System.Windows.Forms.CheckBox InfiniteAmmo;
        private System.Windows.Forms.CheckBox godmodeCheckbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ArmorRecoveryButton;
        private System.Windows.Forms.Button recoveryHeatlhButton;
        private System.Windows.Forms.CheckBox hitmanLevelsCheckbox;
        private System.Windows.Forms.CheckBox jumpHackCheckbox;
    }
}

