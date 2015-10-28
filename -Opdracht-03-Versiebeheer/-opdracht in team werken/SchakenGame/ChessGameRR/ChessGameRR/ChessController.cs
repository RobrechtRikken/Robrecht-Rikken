using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameRR
{
    public class ChessController
    {
        Chess mChess = new Chess();   
        
       
        public void GameStart (Chessboard T)
        {

            mChess.NieuwBord(T, this);
            
        }
        public void TileClick(BoardSquare B)
        {
            mChess.TileActivate(B);


        }

    }
}
