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
        private ChessController controller = new ChessController();

       
       
        public BoardSquare()
        {
            InitializeComponent();
            

        }


        private void lblTile_Click(object sender, EventArgs e)
        {
            //tC.lblTileCick();
            //UpdateUI();
        }
        public void UpdateUI()
        {
            lblTile.Text = "K";
        
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
