using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_Game
{
    public class Chessboard
    {
        Graphics _grsChessBoard;
        public Graphics GrsChessBoard { get => _grsChessBoard; }
        internal List<List<Chess_BoardInfo>> ListChessBoard { get => listChessBoard; }

        List<List<Chess_BoardInfo>> listChessBoard;
        public Chessboard(Graphics grs)
        {
            _grsChessBoard = grs;
            listChessBoard = new List<List<Chess_BoardInfo>>();
            load_CheckBoard();
        }
        
        public void drawChessboard()
        {
            Pen pen = new Pen(Color.Brown, MyConst._SizeBoderChessBoard);
            // Vẽ các cột
            for (int i = 0; i <= MyConst._NumColumn; i++)
            {
                GrsChessBoard.DrawLine(pen, i* MyConst._ChessBoard_SizeHeight, 0,
                    i * MyConst._ChessBoard_SizeHeight,601);

            }
            // vẽ các hàng
            for (int i = 0; i <= MyConst._NumRow; i++)
            {
                GrsChessBoard.DrawLine(pen, 0, i* MyConst._ChessBoard_SizeWitdth,
                    691, i * MyConst._ChessBoard_SizeWitdth);
            }
            
        }
        

        public void load_CheckBoard()
        {
            
            listChessBoard.Clear();
            for (int i = 0; i < MyConst._NumRow; i++)
            {
                List<Chess_BoardInfo> tmp = new List<Chess_BoardInfo>();
                listChessBoard.Add(tmp);
                for (int j = 0; j < MyConst._NumColumn; j++)
                {
                    Point p = new Point(j * MyConst._ChessBoard_SizeWitdth, i * MyConst._ChessBoard_SizeHeight);
                    tmp.Add(new Chess_BoardInfo(i, j, p, 0));
                }
            }
        }
        public void drawChess_Board(Point p,Bitmap bm)
        {
            if (bm == null)
                return;
            Rectangle rte = new Rectangle(p.X+2,p.Y+2, MyConst._ChessBoard_SizeWitdth-3,
                MyConst._ChessBoard_SizeHeight-3);
            _grsChessBoard.DrawImage(bm,rte);
            
        }
    }
}
