using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro_Game
{
    class Chess_BoardInfo
    {
        int index_Column;
        int index_Row;
        int ownership;
        Point location;
        string fileImage;
        public int Index_Column { get => index_Column; }
        public int Index_Row { get => index_Row; }
        public Point Location { get => location; }
        public int Ownership { get => ownership; set => ownership = value; }
        public string FileImage { get => fileImage; set => fileImage = value; }

        public Chess_BoardInfo()
        {
            this.index_Column = this.index_Row = 0;
            this.location = new Point(0, 0);
        }
        public Chess_BoardInfo(int index_Row,int index_Column, Point location,int currPlayer)
        {
            this.index_Row = index_Row;
            this.index_Column = index_Column;
            this.location = location;
            this.ownership = currPlayer;
            fileImage = "";
        }
        

    }
}
