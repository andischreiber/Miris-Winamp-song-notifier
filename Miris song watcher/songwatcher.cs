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

namespace Miris_Songsaver
{
    public partial class songwatcher : Form
    {
        private string strWATitlePast;
        private string strWATitle;
        private string strWATitleTalk;
        private int WAstatus;
        private string strTTSURL;

        public System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        WebClient wc;

        public songwatcher()
        {
            InitializeComponent();
            //Timer
            t1.Interval = 1000;                                 // Interval ms
            t1.Tick += new EventHandler(t1_Tick);               // Eventhandler timer
            t1.Start();
            axWindowsMediaPlayer1.settings.volume = 100;        // max. volume
        }

        void t1_Tick(object sender, EventArgs e)
        {
            try
            {
                WAstatus = WinampLib.GetPlaybackStatus();       // Winamp states: 3=pause,1=play,0=stop
                switch (WAstatus)
                {
                    case 1: // Winamp playing
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
                            strWATitleTalk = strWATitle.Replace("&", "%26");            // correct URL chars
                            strTTSURL = "http://translate.google.com/translate_tts?tl=en&q=" + strWATitleTalk;

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
                    case 3: // Winamp paused
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
            // download completed - play sound
            if (e.Cancelled == true)
            {
                Console.Beep();
            }
            else
            {
                // voice output section
                axWindowsMediaPlayer1.URL = "speech.mp3";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
    }
}