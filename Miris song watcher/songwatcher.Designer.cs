namespace Miris_Songsaver
{
    partial class songwatcher
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(songwatcher));
            this.lbl_CurrentTitle = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.cb_voice = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CurrentTitle
            // 
            this.lbl_CurrentTitle.AutoSize = true;
            this.lbl_CurrentTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentTitle.Location = new System.Drawing.Point(14, 19);
            this.lbl_CurrentTitle.Name = "lbl_CurrentTitle";
            this.lbl_CurrentTitle.Size = new System.Drawing.Size(156, 45);
            this.lbl_CurrentTitle.TabIndex = 0;
            this.lbl_CurrentTitle.Text = "Welcome";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1037, 327);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(226, 48);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // cb_voice
            // 
            this.cb_voice.AutoSize = true;
            this.cb_voice.Checked = true;
            this.cb_voice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_voice.Location = new System.Drawing.Point(26, 105);
            this.cb_voice.Name = "cb_voice";
            this.cb_voice.Size = new System.Drawing.Size(89, 19);
            this.cb_voice.TabIndex = 4;
            this.cb_voice.Text = "voice output";
            this.cb_voice.UseVisualStyleBackColor = true;
            // 
            // songwatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1275, 387);
            this.Controls.Add(this.cb_voice);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lbl_CurrentTitle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "songwatcher";
            this.Text = "Miri`s song watcher";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CurrentTitle;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.CheckBox cb_voice;
    }
}

