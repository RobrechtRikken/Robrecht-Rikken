using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameRR
{
    class ChessController
    {
       
       
        public void GameStart (Chessboard T)
        {
            Chess mStart = new Chess();           
                mStart.NieuwBord(T);
            
        }
    }
}
