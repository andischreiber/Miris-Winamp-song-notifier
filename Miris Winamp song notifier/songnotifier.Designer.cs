namespace Miris_song_watcher
{
    partial class songnotifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(songnotifier));
            this.lbl_CurrentTitle = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.cb_voice = new System.Windows.Forms.CheckBox();
            this.groupLanguage = new System.Windows.Forms.GroupBox();
            this.tb_language = new System.Windows.Forms.TextBox();
            this.but_lang_other = new System.Windows.Forms.RadioButton();
            this.but_lang_en = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.groupLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CurrentTitle
            // 
            this.lbl_CurrentTitle.AutoSize = true;
            this.lbl_CurrentTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentTitle.ForeColor = System.Drawing.Color.Gold;
            this.lbl_CurrentTitle.Location = new System.Drawing.Point(14, 18);
            this.lbl_CurrentTitle.Name = "lbl_CurrentTitle";
            this.lbl_CurrentTitle.Size = new System.Drawing.Size(158, 37);
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
            this.cb_voice.Location = new System.Drawing.Point(20, 33);
            this.cb_voice.Name = "cb_voice";
            this.cb_voice.Size = new System.Drawing.Size(110, 18);
            this.cb_voice.TabIndex = 4;
            this.cb_voice.Text = "voice output";
            this.cb_voice.UseVisualStyleBackColor = true;
            this.cb_voice.CheckedChanged += new System.EventHandler(this.cb_voice_CheckedChanged);
            // 
            // groupLanguage
            // 
            this.groupLanguage.BackColor = System.Drawing.Color.DimGray;
            this.groupLanguage.Controls.Add(this.tb_language);
            this.groupLanguage.Controls.Add(this.but_lang_other);
            this.groupLanguage.Controls.Add(this.but_lang_en);
            this.groupLanguage.Controls.Add(this.cb_voice);
            this.groupLanguage.ForeColor = System.Drawing.Color.Aqua;
            this.groupLanguage.Location = new System.Drawing.Point(22, 94);
            this.groupLanguage.Name = "groupLanguage";
            this.groupLanguage.Size = new System.Drawing.Size(148, 127);
            this.groupLanguage.TabIndex = 6;
            this.groupLanguage.TabStop = false;
            this.groupLanguage.Text = "voice section";
            // 
            // tb_language
            // 
            this.tb_language.Location = new System.Drawing.Point(105, 91);
            this.tb_language.MaxLength = 2;
            this.tb_language.Name = "tb_language";
            this.tb_language.Size = new System.Drawing.Size(25, 20);
            this.tb_language.TabIndex = 11;
            this.tb_language.Text = "de";
            this.tb_language.TextChanged += new System.EventHandler(this.tb_language_TextChanged);
            // 
            // but_lang_other
            // 
            this.but_lang_other.AutoSize = true;
            this.but_lang_other.Location = new System.Drawing.Point(20, 91);
            this.but_lang_other.Name = "but_lang_other";
            this.but_lang_other.Size = new System.Drawing.Size(60, 18);
            this.but_lang_other.TabIndex = 10;
            this.but_lang_other.TabStop = true;
            this.but_lang_other.Text = "other";
            this.but_lang_other.UseVisualStyleBackColor = true;
            this.but_lang_other.CheckedChanged += new System.EventHandler(this.but_ownlang_CheckedChanged);
            // 
            // but_lang_en
            // 
            this.but_lang_en.AutoSize = true;
            this.but_lang_en.Location = new System.Drawing.Point(20, 68);
            this.but_lang_en.Name = "but_lang_en";
            this.but_lang_en.Size = new System.Drawing.Size(74, 18);
            this.but_lang_en.TabIndex = 7;
            this.but_lang_en.TabStop = true;
            this.but_lang_en.Text = "english";
            this.but_lang_en.UseVisualStyleBackColor = true;
            this.but_lang_en.CheckedChanged += new System.EventHandler(this.but_english_CheckedChanged);
            // 
            // songnotifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1275, 361);
            this.Controls.Add(this.groupLanguage);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lbl_CurrentTitle);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Aqua;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "songnotifier";
            this.Text = "Miri`s Winamp song notifier";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.groupLanguage.ResumeLayout(false);
            this.groupLanguage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CurrentTitle;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.CheckBox cb_voice;
        private System.Windows.Forms.GroupBox groupLanguage;
        private System.Windows.Forms.RadioButton but_lang_en;
        private System.Windows.Forms.RadioButton but_lang_other;
        private System.Windows.Forms.TextBox tb_language;
    }
}

