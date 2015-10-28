using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChessGameRR
{
    class Chess
    {
         
      
     public   string[,] chessBoardIntel;
     public BoardSquare[,] chessBoardUI;
     public int[,] locations;
     public bool whiteTurn = true;
      
      public  bool isTileActivated = false;
        public Color savedColor;

            
            public void NieuwBord(Chessboard T, ChessController deController)
            {
            //Aanmaken bord intel
            chessBoardIntel = new string[8, 8]{
            {"bP","bP","bP","bP","bP","bP","bP","bP" },
            {"bP","bP","bP","bP","bP","bP","bP","bP" },
            {"E","E","E","E","E","E","E","E" },
            {"E","E","E","E","E","E","E","E" },
            {"E","E","E","E","E","E","E","E" },
            {"E","E","E","E","E","E","E","E" },
            {"wP","wP","wP","wP","wP","wP","wP","wP" },
            {"wP","wP","wP","wP","wP","wP","wP","wP" }};

            //Aanmaken boardsquares
            chessBoardUI = new BoardSquare[8, 8];
            locations = new int[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    chessBoardUI[i, j] = new BoardSquare(deController);
                    chessBoardUI[i, j].Parent = T;
                    chessBoardUI[i, j].Location = new Point(j * 75 + 75, i * 75 + 75);
                    chessBoardUI[i, j].posX = j;
                    chessBoardUI[i, j].posY = i;
                    chessBoardUI[i, j].Size = new Size(75, 75);

                    //black/white                 
                    DrawCheckers(i, j);
                }
            }
            validate();
            drawing();

        }
        public void drawing()
        {

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    switch (chessBoardIntel[i,j])
                    {
                        case "E": chessBoardUI[i, j].BackgroundImage = null; break;
                        case "wP": chessBoardUI[i, j].BackColor = Color.BlueViolet; break;
                        case "bP": chessBoardUI[i, j].BackColor = Color.DarkRed; break;
                    }

                }
            }
        }

        public void TileActivate(BoardSquare Tile)
        {
            ////Console.WriteLine("Testje " + Tile.posX + " " + Tile.posY);

            //int x, y;
            //x = Tile.posX;
            //y = Tile.posY;
            //    switch (locations[x, y])
            //    {
            //        case 1:
            //            SpeelStuk(chessBoardIntel[x, y], x, y);
            //            I = x;
            //                J=y;
            //            break;
            //        case 2:
            //            Change(x, y);
            //            break;
            //        case 3:                      
            //            validate();
            //            break;
            //    }

            //if (isTileActivated == false)
            //{
            //    savedColor = Tile.BackColor;
            //    Tile.BackColor = Color.Turquoise;
            //    isTileActivated = true;
            //}
            //else
            //{
            //    Tile.BackColor = savedColor;

            //    isTileActivated = false;

            //}

            //Console.WriteLine("test");
            //string ikke = chessBoardIntel[1, 2];
            //Console.WriteLine(ikke);



            SpeelStuk(chessBoardIntel[Tile.posY, Tile.posX].ToString(), Tile.posY, Tile.posX);
        }
        public void SpeelStuk(string stuk, int x , int y)
        {
            switch (stuk)
            {
                case "wP": 
                    //   if (y - 1 >= 0)
                    //       if (chessBoardIntel[x - 1, y - 1].Substring(0, 1) == "b")
                    //        locations[x - 1, y - 1] = 2;
                    //if (chessBoardIntel[x - 1, y] == "E")
                    //    locations[x - 1, y] = 2;
                    //if (y + 1 < 8)
                    //    if (chessBoardIntel[x - 1, y + 1].Substring(0, 1) == "b")
                    //        locations[x - 1, y + 1] = 2;
                    //if (x == 6)
                    //    if (chessBoardIntel[x - 2, y] == "E")
                    //        locations[x - 2, y] = 2;


                    if (chessBoardIntel[x - 1, y] == "E" && whiteTurn == true)
                    {
                        chessBoardIntel[x, y] = "E";
                        chessBoardIntel[x - 1, y] = "wP";
                        whiteTurn = false;
                    }
                    else
                    {
                        Console.WriteLine("Can't move ==> something is in the way");
                    }
                   drawing();
                    break;

                case "bP": 
                     if (chessBoardIntel[x + 1, y] == "E" && whiteTurn == false)
                    {
                        chessBoardIntel[x, y] = "E";
                        chessBoardIntel[x + 1, y] = "bP";
                        whiteTurn = true;
                    }
                    else
                    {
                        Console.WriteLine("Can't move ==> something is in the way");
                    }
                   drawing();
                    break;
            }
            validate();
            drawing();
        }
        public void validate()
        {
            int i, j;        
            //for (i = 0; i < 8; i++)
            //    for (j = 0; j < 8; j++)
            //    {
            //        if (chessBoardIntel[i, j] != "E")
            //            locations[i, j] = 1;
            //        else
            //            locations[i, j] = 0;
            //    }
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    DrawCheckers(i, j);
                }             
            }
        }
        public void DrawCheckers(int i, int j)
        {
            if (i % 2 == 0)
                if (j % 2 == 1)
                    chessBoardUI[i, j].BackColor = Color.Black;
                else
                    chessBoardUI[i, j].BackColor = Color.White;
            else
                if (j % 2 == 1)
                    chessBoardUI[i, j].BackColor = Color.White;
                else
                    chessBoardUI[i, j].BackColor = Color.Black;
        }
        //public void Change(int i, int j)
        //{
        //    chessBoardIntel[i, j] = chessBoardIntel[I, J];

        //    chessBoardIntel[I, J] = "E";
        //    validate();
        //    drawing();
        //}
    }
}
