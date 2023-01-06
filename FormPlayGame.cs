using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_Game
{
    enum Starting { Start, Stop };
    public partial class FormPlayGame : Form
    {
        
        GameCaroChess PlayGameCaro;
        
        Graphics _grs;
        string info = "Chào mừng các bạn đến với game cờ Caro\nLuật chơi:\n -Người chơi 1 đi trước: đánh vào vị trí bất\nkỳ trên bàn cờ.\n" +
                "-Khi tới lượt: người chơi phải tick vào một\n ô trên bàn cờ. Tick đủ 5 ô trở lên ô theo \nchiều dọc chiều ngang hoặc đường chéo mà \nkhông bị chặn 2 đầu thì sẽ thắng. " +
                "\n -Mỗi người chơi có 20s để đi. Sau 20s đó \nngười chơi không tick vào ô sẽ bị xử thua.\n**Chúc các bạn chơi vui vẻ**" ;

        string nameP1;
        string nameP2;
        int scoX, scoO;
        FormMenu _formMenu;
        //  FormName _formName;
        Starting checkGame;

        public GameCaroChess GameCaro { get => PlayGameCaro; set => PlayGameCaro = value; }
        public int ScoX { get => scoX; }
        public int ScoO { get => scoO; }

        public FormPlayGame(int mod, FormMenu formMenu, FormName formName)
        {
            InitializeComponent();
            _grs = pnlChessBoard.CreateGraphics();

            nameP1 = formName.NameP1;
            nameP2 = formName.NameP2;
            _formMenu = formMenu;
            GameCaro = new GameCaroChess(_grs, nameP1, nameP2);
            GameCaro.Mod = mod;
            // timerCoolDown.Start();
            loadForm();
            
            // checkGame = Starting.Stop;

        }

        void loadForm()
        {
            timerPlay.Start();
            checkGame = Starting.Stop;
            lbInfo.Text = info;
            lbNamePlayer1.Text = nameP1;
            lbNamePlayer2.Text = nameP2;
            scoO = scoX = 0;
            lbScoO.Text = ScoO.ToString();
            lbScoX.Text = ScoX.ToString();
            // pnlChessBoard.Enabled = false;
            btnNewGame.Enabled = false;
            newGameTSitem.Enabled = false;
            lockButton(false);
            if (PlayGameCaro.Mod == 1)
                this.Text += " (1 Player)";
            else
                this.Text += " (2 Players)";
            loadImageVolumn();
        }
        void loadImageVolumn()
        {
            if (_formMenu.IsPlayMusic)
            {
                btnMusic.BackgroundImage = new Bitmap(@"images\volume_on.gif");
            }
            else
                btnMusic.BackgroundImage = new Bitmap(@"images\volume_off.gif");
        }
        void lockButton(bool b)
        {
            winwinTSitem.Enabled = ggTSitem.Enabled = pauseTSitem.Enabled = undoTSitem.Enabled = btnPause.Enabled =
                btnUndo.Enabled = btnHoa.Enabled = btnGG.Enabled = b;
        }

        #region event
        private void PnlChessBoard_Paint(object sender, PaintEventArgs e)
        {
            GameCaro.drawChessBoard();
            GameCaro.drawChessBoardRefesh();
            
        }
        
        private void PnlChessBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || checkGame == Starting.Stop)
                return;
            hitTheChessboard(e.X, e.Y);
        }
        void hitTheChessboard(int mX, int mY)
        {
            timerCoolDown.Stop();
            int rsl = 0;
            if (GameCaro.Mod == 2)
            {
                rsl = GameCaro.Mod2Player(mX, mY, pnlChessBoard, lbName, ptbPlaying);
            }
            
            if (rsl == 1)
            {
                afterGameOver();
                return;
            }
            else if (rsl == 0)
            {
                lbCooldown.Text = formatTime(20);
                time = 20;
            }
            timerCoolDown.Start();

        }
        void afterGameOver()
        {
            restartCooldown();
            timerCoolDown.Stop();
            if (PlayGameCaro.Turn == 1)
                update_Score(2);
            else if (PlayGameCaro.Turn == 2)
                update_Score(1);
            GameCaro.newGame(pnlChessBoard, lbName, ptbPlaying, btnStartGane);
            checkGame = Starting.Stop;
            pnlChessBoard.Enabled = true;
            lockButton(false);
        }
        void update_Score(int winner)
        {
            if (winner == 1)
                scoX++;
            else if (winner == 2)
                scoO++;
            lbScoO.Text = ScoO.ToString();
            lbScoX.Text = ScoX.ToString();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimerPlay_Tick(object sender, EventArgs e)
        {
            if (lbInfo.Location.Y + lbInfo.Height < 0)
                lbInfo.Location = new Point(lbInfo.Location.X, pnlInfo.Height);
            lbInfo.Location = new Point(lbInfo.Location.X, lbInfo.Location.Y - 1);
            // kiểm tra stack rỗng
            btnUndo.Enabled = undoTSitem.Enabled = (PlayGameCaro.StackChess.Count == 0 && PlayGameCaro.Mod == 2) ||
                (PlayGameCaro.StackChess.Count <= 1 && PlayGameCaro.Mod == 1) ? false : true;


        }
        void startGame()
        {

            btnStartGane.Visible = false;
            GameCaro.startGame(lbName, ptbPlaying);
            //pnlChessBoard.Enabled = true;
            checkGame = Starting.Start;
            btnNewGame.Enabled = true;
            restartCooldown();
            timerCoolDown.Start();
            lockButton(true);
            btnNewGame.Enabled = true;
            newGameTSitem.Enabled = true;
        }
        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void BtnNewGame_Click_1(object sender, EventArgs e)
        {
            
            MessageBox.Show("Bạn muốn chọn game mới");
            loadfromName(2);
            
            
        }
        private void loadfromName(int type)
        {
            FormName formName = new FormName(type);
            this.Hide();
            formName.Show();
            this.Enabled = false;
        }
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGameBtn();
        }
        void newGameBtn()
        {

            if (scoX != 0 || scoO != 0 || checkGame == Starting.Start)
            {
                timerCoolDown.Stop();
                if (MessageBox.Show("Bạn có chắc muốn thoát màn chơi hiện tại?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    timerCoolDown.Start();
                    return;
                }
            }

            GameCaro.newGame(pnlChessBoard, lbName, ptbPlaying, btnStartGane);
            restartCooldown();
            checkGame = Starting.Stop;
            lockButton(false);
            scoO = scoX = 0;
            lbScoO.Text = ScoO.ToString();
            lbScoX.Text = ScoX.ToString();
            btnNewGame.Enabled = false;
            newGameTSitem.Enabled = false;
        }
        #endregion

        private void BtnNewGame_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Khaki;
        }

        private void BtnNewGame_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.BurlyWood;
            Thread.Sleep(50);
        }

        private void BtnBackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPlayGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkGame == Starting.Start)
            {
                timerCoolDown.Stop();
                DialogResult dlrsl = MessageBox.Show("Bạn có muốn thoát game hiện tại", "Exit to menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dlrsl == DialogResult.No)
                {
                    e.Cancel = true;
                    timerCoolDown.Start();
                    return;
                }

            }
            _formMenu.Show();
        }
        private void BtnUndo_Click(object sender, EventArgs e)
        {
            undo();
        }
        private void UndoTSitem_Click(object sender, EventArgs e)
        {
            undo();
        }

        void undo()
        {
            if (GameCaro.StackChess.Count <= 1 && PlayGameCaro.Mod == 2)
                btnUndo.Enabled = undoTSitem.Enabled = false;
            if (GameCaro.StackChess.Count <= 3 && PlayGameCaro.Mod == 1)
                btnUndo.Enabled = undoTSitem.Enabled = false;
            GameCaro.Undo(lbName, ptbPlaying, pnlChessBoard);
            restartCooldown();
        }
        #region cooldown
        int time = 20;
        private void TimerCoolDown_Tick(object sender, EventArgs e)
        {
            if (time < 0)
            {
                restartCooldown();
                cooldownEnd();
                return;
            }
            time -= 1;
            if (time >= 0)
                lbCooldown.Text = formatTime(time);
        }
        string formatTime(int i)
        {
            string rsl = "00:";
            if (i < 10)
                rsl += "0" + i.ToString();
            else
                rsl += i.ToString();
            return rsl;
        }
        void cooldownEnd()
        {
            string rsl = PlayGameCaro.Turn == 1 ? nameP2 : nameP1;
            timerCoolDown.Stop();
            MessageBox.Show(string.Format("'{0}' Thắng ", rsl), "GameOver");
            afterGameOver();



        }
        void pauseGame()
        {
            timerCoolDown.Stop();
            DialogResult dialogResult = MessageBox.Show("Bấm \"Ok\" để tiếp game!!!", "Pause Game");
            timerCoolDown.Start();
        }
        void restartCooldown()
        {
            lbCooldown.Text = formatTime(20);
            time = 20;
        }
        #endregion 
        private void BtnPause_Click(object sender, EventArgs e)
        {
            pauseGame();
        }

        private void PauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pauseGame();
        }
        void winwin()
        {
            timerCoolDown.Enabled = false;
            PlayGameCaro.Turn = 3;
            MessageBox.Show("Hòa", "GameOver");
            afterGameOver();
        }
        private void BtnHoa_Click(object sender, EventArgs e)
        {
            winwin();
        }
        void GG()
        {
            // gameCaro.Turn = gameCaro.Turn == 1 ? 2 : 1;
            timerCoolDown.Enabled = false;
            string rsl = PlayGameCaro.Turn == 1 ? nameP2 : nameP1;
            MessageBox.Show(string.Format("'{0}' Thắng", rsl), "GameOver");
            afterGameOver();
        }
        private void BtnGG_Click(object sender, EventArgs e)
        {
            GG();
        }

        private void GgTSitem_Click(object sender, EventArgs e)
        {
            GG();
        }

        private void BtnMusic_Click(object sender, EventArgs e)
        {
            _formMenu.changePlayMusic();
            loadImageVolumn();
        }

        private void BtnMusic_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.WhiteSmoke;
            Thread.Sleep(20);
        }

        private void WinwinTSitem_Click(object sender, EventArgs e)
        {
            winwin();
        }


    }
}
