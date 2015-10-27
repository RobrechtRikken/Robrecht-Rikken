using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameRR
{
    class ChessController
    {
        Chess mChess = new Chess();   
       
        public void GameStart (Chessboard T)
        {

            mChess.NieuwBord(T);
            
        }
        public void TileClick(BoardSquare B)
        {
            mChess.TileActivate(B);


        }

    }
}
