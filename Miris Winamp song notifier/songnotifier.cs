using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using WinampFrontEndLib;

namespace Miris_song_watcher
{
    public partial class songnotifier : Form
    {
        private string strWATitlePast;
        private string strWATitle;
        private string strWATitleTalk;
        private int WAstatus;
        private string strTTSURL;
        private string strLanguage = "en";

        public System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        WebClient wc;

        public songnotifier()
        {
            InitializeComponent();
            //Timer
            t1.Interval = 1000;                                 // Interval ms
            t1.Tick += new EventHandler(t1_Tick);               // Eventhandler timer
            t1.Start();
            axWindowsMediaPlayer1.settings.volume = 100;        // max. volume
            but_lang_en.Checked = true;                         // default
        }

        void t1_Tick(object sender, EventArgs e)
        {
            try
            {
                WAstatus = WinampLib.GetPlaybackStatus();       // Winamp states: 3=pause,1=play,0=stop
                switch (WAstatus)
                {
                    case 1:                                     // Winamp playing
                        strWATitlePast = strWATitle;
                        strWATitle = WinampLib.GetCurrentSongTitle();
                        lbl_CurrentTitle.Text = strWATitle;
                        if (strWATitle != strWATitlePast)       // new song started
                        {
                            axWindowsMediaPlayer1.URL = "none.mp3";                     // dummy input (else cannot overwrite speech.mp3 with new file)
                            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                            {
                                axWindowsMediaPlayer1.Ctlcontrols.stop();
                            }
                            axWindowsMediaPlayer1.close();
                            // URL encoding
                            strWATitleTalk = strWATitle.Replace("&", "%26");
                            strWATitleTalk = strWATitleTalk.Replace("ä", "ae");
                            strWATitleTalk = strWATitleTalk.Replace("ö", "oe");
                            strWATitleTalk = strWATitleTalk.Replace("ü", "ue");
                            strWATitleTalk = strWATitleTalk.Replace("Ä", "Ae");
                            strWATitleTalk = strWATitleTalk.Replace("Ö", "Oe");
                            strWATitleTalk = strWATitleTalk.Replace("Ü", "Ue");
                            // ...

                            strTTSURL = "http://translate.google.com/translate_tts?tl=" + strLanguage + "&q=" + strWATitleTalk;
                            //MessageBox.Show(strWATitleTalk);                          // debug

                            if ((strWATitle.Length < 100) && (cb_voice.Checked))        // max. length 100 chars
                            {
                                
                                // download voice file
                                using (wc = new WebClient())
                                {
                                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(DLCompleted);
                                    //wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                                    Uri URL = new Uri(strTTSURL);

                                    try
                                    {
                                        // download
                                        wc.DownloadFileAsync(URL, "speech.mp3");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }
                        }
                        break;
                    case 3:                                                             // Winamp paused
                        lbl_CurrentTitle.Text = "P A U S E";
                        break;
                    default:
                        strWATitle = "";
                        strWATitlePast = "";
                        strWATitleTalk = "";
                        lbl_CurrentTitle.Text = "";
                        break;
                }
            }
            catch { }
        }

        private void DLCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // download completed - now play sound
            if (e.Cancelled == true)
            {
                Console.Beep();
            }
            else
            {
                // voice output
                axWindowsMediaPlayer1.URL = "speech.mp3";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void but_english_CheckedChanged(object sender, EventArgs e)
        {
            if (but_lang_en.Checked)
            {
                but_lang_other.Checked = false;
                tb_language.Enabled = false;
                strLanguage = "en";
            }
        }

        private void but_lang_other_CheckedChanged(object sender, EventArgs e)
        {
            if (but_lang_other.Checked)
            {
                but_lang_en.Checked = false;
                tb_language.Enabled = true;
                strLanguage = tb_language.Text;
            }
        }

        private void tb_language_TextChanged(object sender, EventArgs e)
        {
            strLanguage = tb_language.Text;
        }

        private void cb_voice_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_voice.Checked)
            {
                but_lang_en.Checked = false;
                but_lang_other.Checked = false;
                tb_language.Enabled = false;
            }
            else
            {
                but_lang_en.Checked = true;
                strLanguage = "en";
            }
        }
    }
}