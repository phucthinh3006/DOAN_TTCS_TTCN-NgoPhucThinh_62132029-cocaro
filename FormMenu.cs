using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Caro_Game
{
    public partial class FormMenu : Form
    {
        private string nameP1;
        private string nameP2;
        bool isPlayMusic;
        WMPLib.WindowsMediaPlayer mediaPlayer = new WMPLib.WindowsMediaPlayer();
        public string NameP1 { get => nameP1; set => nameP1 = value; }
        public string NameP2 { get => nameP2; set => nameP2 = value; }
        public bool IsPlayMusic { get => isPlayMusic; set => isPlayMusic = value; }
     
        public FormMenu()
        {
           
            InitializeComponent();
            NameP1 = "Player 1";
            NameP2 = "Player 2";
            mediaPlayer.URL = "";
            mediaPlayer.settings.setMode("autoRewind", true);
            mediaPlayer.settings.setMode("loop", true);
            mediaPlayer.settings.volume = 50;
            mediaPlayer.controls.play();
            IsPlayMusic = true;

        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
      

        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
     
            Thread.Sleep(50);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            changeFormName(2);
        }
        void changeFormName(int type)
        {
            FormName formName = new FormName( type);
            this.Hide();
            Thread.Sleep(500);
            formName.Show();
            this.Enabled = false;
        }
        void btnAbout_Click(object sender, EventArgs e)
        {

        }
        void changeAbout(int type)
        {

        }
        public void changePlayMusic()
        {
            if (IsPlayMusic == true)
            {
                btnMusic.Text = "Music: Off";
                IsPlayMusic = false;
                mediaPlayer.controls.pause();
            }
            else
            {
                btnMusic.Text = "Music: On";
                IsPlayMusic = true;
                mediaPlayer.controls.play();
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            changePlayMusic();
        }
        
        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            FormAbout fromAbout = new FormAbout();
            this.Hide();
            Thread.Sleep(500);
            fromAbout.Show();
            this.Enabled = false;
        }
    }
}
