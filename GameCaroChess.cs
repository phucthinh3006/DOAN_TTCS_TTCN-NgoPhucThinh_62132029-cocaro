using System;
using System.Collections.Generic;
using System.Linq;

using System.Drawing;
using System.Windows.Forms;

namespace Caro_Game
{
     enum Winner { PLAYER1, PLAYER2, NOONE, NONE }
    public class GameCaroChess
    {
        Chessboard _Chesssboard;
        Graphics _grs;
        Stack<Chess_BoardInfo> _stackChess;
        Winner _gameOver;
        int turn;
        int mod;
        string nameP1;
        string nameP2;
        List<List<Chess_BoardInfo>> _listChessBoard;
        public Chessboard chessboard { get => _Chesssboard; set => _Chesssboard = value; }
        public Graphics Grs { get => _grs; }
        public int Turn { get => turn; set => turn = value; }
        internal Winner GameOver { get => _gameOver; }
        public int Mod { get => mod; set => mod = value; }
        public string NameP1 { get => nameP1; set => nameP1 = value; }
        public string NameP2 { get => nameP2; set => nameP2 = value; }
        internal Stack<Chess_BoardInfo> StackChess { get => _stackChess; set => _stackChess = value; }

        public GameCaroChess(Graphics grs, string namePlayer1, string namePlayer2)
        {
            this._grs = grs;
            chessboard = new Chessboard(Grs);
            StackChess = new Stack<Chess_BoardInfo>();

            turn = 1;
            _gameOver = Winner.NONE;
            Mod = 2;
            NameP1 = namePlayer1;
            NameP2 = namePlayer2;
            _listChessBoard = chessboard.ListChessBoard;
        }


        public void drawChessBoard()
        {
            chessboard.drawChessboard();
          
        }
        void load_CheckBoard()
        {
            chessboard.load_CheckBoard();
        }
        bool chess(int Mouse_X, int Mouse_Y)
        {
            if (Mouse_X % MyConst._ChessBoard_SizeWitdth == 0 ||
                Mouse_Y % MyConst._ChessBoard_SizeHeight == 0)
            {
                return false;
            }
            int column = Mouse_X / MyConst._ChessBoard_SizeWitdth;
            int row = Mouse_Y / MyConst._ChessBoard_SizeHeight;
        
            if (_listChessBoard[row][column].Ownership != 0)
                return false;

            _listChessBoard[row][column].Ownership = turn;

            _listChessBoard[row][column].FileImage = _listChessBoard[row][column].Ownership == 1 ? MyConst.fileName_X : MyConst.fileName_O;
            drawChess(_listChessBoard[row][column]);
            StackChess.Push(_listChessBoard[row][column]);
            turn = turn != 1 ? 1 : 2;
            return true;
        }

        void drawChess(Chess_BoardInfo cbi)
        {
            if (cbi.Ownership == 0)
                return;

            string fileName;
            fileName = cbi.FileImage;

            Bitmap bm = new Bitmap(fileName);
            _Chesssboard.drawChess_Board(cbi.Location, bm);
        }
        public void drawChessBoardRefesh()
        {
            foreach (Chess_BoardInfo item in StackChess)
            {
                drawChess(item);
            }
        }


        #region Xử lí thắng thua
        void win()
        {
            string nof = "";
            switch (_gameOver)
            {
                case Winner.PLAYER1:
                    nof = string.Format("'{0}' Thắng", nameP1);
                    break;
                case Winner.PLAYER2:
                    nof = string.Format("'{0}' Thắng", nameP2);
                    break;
                case Winner.NOONE:
                    nof = "Hòa";
                    break;
               
                default:
                    return;
            }
            MessageBox.Show(nof, "GameOver");
            
        }
        public bool checkWin()
        {
            if (StackChess.Count == MyConst._NumRow * MyConst._NumColumn)
            {
                _gameOver = Winner.NOONE;
                turn = 3;
                return true;
            }


            foreach (Chess_BoardInfo item in StackChess)
            {
                if (browseAlong(item.Index_Column, item.Index_Row, item.Ownership) ||
              browseHorizontal(item.Index_Column, item.Index_Row, item.Ownership) ||
              browseMainDiagonal(item.Index_Column, item.Index_Row, item.Ownership) ||
              browseExtraDiagonal(item.Index_Row, item.Index_Column, item.Ownership))
                {
                    _gameOver = turn != 1 ? Winner.PLAYER1 : Winner.PLAYER2;
                    return true;
                }
            }
            return false;

        }

        bool browseAlong(int currIndex_C, int currIndex_R, int currPlayer)
        {
            if (currIndex_R > MyConst._NumRow - 5)
                return false;
            int cout = 1;
            for (cout = 1; cout < 5; cout++)
            {
                if (_listChessBoard[currIndex_R + cout][currIndex_C].Ownership != currPlayer)
                    return false;
            }
            if (currIndex_R == 0 || currIndex_R + cout == MyConst._NumRow)
                return true;
            if (_listChessBoard[currIndex_R + cout][currIndex_C].Ownership == 0 || _listChessBoard[currIndex_R - 1][currIndex_C].Ownership == 0)
                return true;

            return false;
        }
        bool browseHorizontal(int currIndex_C, int currIndex_R, int currPlayer)
        {
            if (currIndex_C > MyConst._NumColumn - 5)
                return false;
            int cout = 1;
            for (cout = 1; cout < 5; cout++)
            {
                if (_listChessBoard[currIndex_R][currIndex_C + cout].Ownership != currPlayer)
                    return false;
            }
            if (currIndex_C == 0 || currIndex_C + cout == MyConst._NumColumn)
                return true;
            if (_listChessBoard[currIndex_R][currIndex_C + cout].Ownership == 0 || _listChessBoard[currIndex_R][currIndex_C - 1].Ownership == 0)
                return true;

            return false;

        }
        bool browseMainDiagonal(int currIndex_C, int currIndex_R, int currPlayer)
        {
            if (currIndex_C > MyConst._NumColumn - 5 || currIndex_R > MyConst._NumRow - 5)
                return false;
            int cout = 1;
            for (cout = 1; cout < 5; cout++)
            {
                if (_listChessBoard[currIndex_R + cout][currIndex_C + cout].Ownership != currPlayer)
                    return false;
            }
            if (currIndex_C + cout == MyConst._NumColumn || currIndex_R + cout == MyConst._NumRow || currIndex_R == 0 || currIndex_C == 0)
                return true;
            if (_listChessBoard[currIndex_R + cout][currIndex_C + cout].Ownership == 0 || _listChessBoard[currIndex_R - 1][currIndex_C - 1].Ownership == 0)
                return true;

            return false;

        }
        bool browseExtraDiagonal(int currIndex_R, int currIndex_C, int currPlayer)
        {

            if (currIndex_R < 4 || currIndex_C > MyConst._NumColumn - 5)
                return false;
            int cout = 1;
            for (cout = 1; cout < 5; cout++)
            {
                if (_listChessBoard[currIndex_R - cout][currIndex_C + cout].Ownership != currPlayer)
                    return false;
            }
            if (currIndex_R == 4 || currIndex_C + cout == MyConst._NumColumn || currIndex_C == 0 || currIndex_R == MyConst._NumRow - 1)
                return true;
            if (_listChessBoard[currIndex_R - cout][currIndex_C + cout].Ownership == 0 || _listChessBoard[currIndex_R + 1][currIndex_C - 1].Ownership == 0)
                return true;
            return false;

        }

        #endregion
        void loadInfo(Label name, PictureBox ptb)
        {
            if (turn == 1)
            {
                name.Text = NameP1;
                ptb.BackgroundImage = new Bitmap(MyConst.fileName_X);
            }
            else
            {
                name.Text = NameP2;
                ptb.BackgroundImage = new Bitmap(MyConst.fileName_O);
            }
        }
        public void startGame(Label name, PictureBox ptb)
        {
            load_CheckBoard();
            if (mod == 1)
                
            loadInfo(name, ptb);

        }
        public void newGame(Panel pnlChessboard, Label name, PictureBox ptb, Button btn)
        {
            StackChess.Clear();

            turn = 1;
            _grs.Clear(pnlChessboard.BackColor);
            drawChessBoard();
            load_CheckBoard();
            _gameOver = Winner.NONE;
            name.Text = "";
            ptb.BackgroundImage = null;
            btn.Visible = true;

        }

        #region Mod game
        public int Mod2Player(int mouseX, int mouseY, Panel pnl, Label lb, PictureBox ptb)
        {
            if (chess(mouseX, mouseY))
            {
                if (checkWin())
                {
                    pnl.Enabled = false;
                    win();
                    return 1;
                }
            }
            else
                return -1;
            loadInfo(lb, ptb);
            return 0;
        }
       
        public void Undo(Label lbName, PictureBox ptb, Panel pnl)
        {
            if (StackChess.Count == 0 && mod == 2)
                return;
            if (StackChess.Count == 1 && mod == 1)
                return;
            
            else if (mod == 2)
                undoMod2(pnl);
            loadInfo(lbName, ptb);

        }

       
        void undoMod2(Panel pnl)
        {
            if (pnl == null)
                return;
            Chess_BoardInfo tmp = StackChess.Pop();
            tmp.Ownership = 0;
            tmp.FileImage = null;
            turn = turn != 1 ? 1 : 2;
            _grs.Clear(pnl.BackColor);
            chessboard.drawChessboard();
            drawChessBoardRefesh();
        }

        #endregion
    }

}
