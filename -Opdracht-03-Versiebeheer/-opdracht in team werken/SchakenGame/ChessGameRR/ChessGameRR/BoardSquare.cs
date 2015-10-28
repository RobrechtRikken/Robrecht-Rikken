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
        public string lblInhoud;

        private ChessController controller;


       
       
        public BoardSquare(ChessController deController)
        {
            InitializeComponent();
            
            controller = deController;

        }


        private void lblTile_Click(object sender, EventArgs e)
        {
            //tC.lblTileCick();
            //UpdateUI();
        }
        public void UpdateUI()
        {
            
        
        }

        private void BoardSquare_Load(object sender, EventArgs e)
        {
          
        }

        private void BoardSquare_Click(object sender, EventArgs e)
        {

            controller.TileClick(this);


        }
    }
}
