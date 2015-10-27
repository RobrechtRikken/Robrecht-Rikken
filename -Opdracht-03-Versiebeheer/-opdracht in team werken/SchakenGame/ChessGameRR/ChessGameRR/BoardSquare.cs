using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGameRR
{
    public partial class BoardSquare : UserControl
    {
        public int posX, posY;

        private Tile t;
        private TileController tC;
        //public BoardSquare(Tile tile, TileController tController)
        //{
        //    InitializeComponent();
        //    t = tile;
        //    tC = tController;

        //}
        public BoardSquare()
        {
            InitializeComponent();
            

        }


        private void lblTile_Click(object sender, EventArgs e)
        {
            tC.lblTileCick();
            UpdateUI();
        }
        public void UpdateUI()
        {
            lblTile.Text = "K";
        
        }

        private void BoardSquare_Load(object sender, EventArgs e)
        {

        }
    }
}
