using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameRR
{
    class Tile
    {
        //Class Variables
        protected int mCoorX, mCoorY;
        protected bool mIsBlack;



        public Tile(int x, int y, bool isBlack)
        {
            mCoorX = x;
            mCoorY = y;
            mIsBlack = isBlack;
        }
        //Properties
        public int coorX 
        {
        get{return mCoorX;}
        }
        public int coorY
        {
            get { return mCoorY; }
        }
        public bool isBlack
        {
            get { return mIsBlack; }
        }


    }
}
