using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGameRR
{
    public partial class Chessboard : Form
    {
        string[,] chessBoardIntel;
        BoardSquare[,] chessBoardUI;

        public Chessboard()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
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

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    chessBoardUI[i, j] = new BoardSquare();
                    chessBoardUI[i, j].Parent = this;
                    chessBoardUI[i, j].Location = new Point(j * 50 + 50, i * 50 + 50);
                    chessBoardUI[i, j].posX = j;
                    chessBoardUI[i, j].posY = i;
                    chessBoardUI[i, j].Size = new Size(75, 75);

                    //black/white
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 1)
                        { chessBoardUI[i, j].BackColor = Color.Black; }
                        else { chessBoardUI[i, j].BackColor = Color.White; }
                    }
                    else{
                        if(j % 2 == 1)
                    {
                        chessBoardUI[i, j].BackColor = Color.White; 
                        }
                        else
                        
                            { chessBoardUI[i, j].BackColor = Color.Black; }
                        
                    }
                }
            }
            Validate();
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
    }
}
