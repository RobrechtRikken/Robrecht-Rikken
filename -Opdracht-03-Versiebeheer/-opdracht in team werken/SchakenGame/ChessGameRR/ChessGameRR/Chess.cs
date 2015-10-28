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
        int I, J;
      
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
                //Plaatjes toekennen aan elk stuk
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        switch (chessBoardIntel[i, j])
                        {
                            case "E": chessBoardUI[i, j].BackgroundImage = null; break;
                            case "wP": chessBoardUI[i, j].BackgroundImage = Image.FromFile("../../Pics/wP.png"); break;
                            case "bP": chessBoardUI[i, j].BackgroundImage = Image.FromFile("../../Pics/bP.png"); break;

                        }

                    }
                }

                //Achtergrondkleuk van mogelijke zetten activeren
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (locations[i, j] == 2)
                            chessBoardUI[i, j].BackColor = Color.Green;
                        else
                            DrawCheckers(i, j);

                        if (locations[i, j] == 3)
                            chessBoardUI[i, j].BackColor = Color.Blue;
                    }
                }
            }

        public void TileActivate(BoardSquare Tile)
        {        
            //Opvragen locations voor aangeklikte stuk
            int i, j;
            i = Tile.posY;
            j = Tile.posX;
            switch (locations[i, j])
            {
                case 1:
                    if (!isTileActivated)
                    {
                        SpeelStuk(chessBoardIntel[i, j], i, j);
                        Activate();
                        I = i;
                        J = j; 
                    }
                    break;
                case 3:
                    if (isTileActivated)
                    {
                        validate();
                        Activate();
                    }
                    break;

                case 2: change(i, j);
                    Activate();
                    break;
            }
            
        }
        public void SpeelStuk(string stuk, int x, int y)
        {
            int c;
                    switch (stuk)
                    {
                        case "wP":
                            if (whiteTurn)
                            {
                                if (y - 1 >= 0)
                                    if (chessBoardIntel[x - 1, y - 1].Substring(0, 1) == "b")
                                        locations[x - 1, y - 1] = 2;
                                if (chessBoardIntel[x - 1, y] == "E")
                                    locations[x - 1, y] = 2;
                                if (y + 1 < 8)
                                    if (chessBoardIntel[x - 1, y + 1].Substring(0, 1) == "b")
                                        locations[x - 1, y + 1] = 2;
                                if (x == 6)
                                    if (chessBoardIntel[x - 2, y] == "E")
                                        locations[x - 2, y] = 2;
                            }
                    break;


                  
                        case "bP":
                    if (!whiteTurn)
                    {
                        if (y - 1 >= 0)
                            if (chessBoardIntel[x + 1, y - 1].Substring(0, 1) == "w")
                                locations[x + 1, y - 1] = 2;
                        if (chessBoardIntel[x + 1, y] == "E")
                            locations[x + 1, y] = 2;
                        if (y + 1 < 8)
                            if (chessBoardIntel[x + 1, y + 1].Substring(0, 1) == "w")
                                locations[x + 1, y + 1] = 2;
                        if (x == 1)
                            if (chessBoardIntel[x + 2, y] == "E")
                                locations[x + 2, y] = 2;
                    }
                        break;
                                    
                    }
                    locations[x, y] = 3;
                    drawing();
            
        }
        
        public void validate()
        {
            int i, j;
            //Kijken welke vakjes toegankelijk zijn
            for (i = 0; i < 8; i++)
                for (j = 0; j < 8; j++)
                {
                    if (chessBoardIntel[i, j] != "E")
                        locations[i, j] = 1;
                    else
                        locations[i, j] = 0;
                }

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

        public void change(int i, int j)
        {

            chessBoardIntel[i, j] = chessBoardIntel[I, J];
            chessBoardIntel[I, J] = "E";
            ChangeTurn();
            validate();
            drawing();
        }
        public void ChangeTurn()
        { 
        if (whiteTurn)
        {
            whiteTurn = false;
        }
        else
        {
            whiteTurn = true;
        }
        }
        public void Activate()
        {
            if (isTileActivated)
            {
                isTileActivated = false;
            }
            else
            {
                isTileActivated = true;
            }
        }
    }
}
