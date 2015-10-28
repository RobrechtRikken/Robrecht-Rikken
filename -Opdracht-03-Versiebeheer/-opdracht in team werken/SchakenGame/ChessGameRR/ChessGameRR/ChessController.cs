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
            //nieuw bord starten en controller meegeven
            mChess.NieuwBord(T, this);            
        }
        public void TileClick(BoardSquare B)
        {
            //tile meegeven
            mChess.TileActivate(B);
        }
    }
}
