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
        ChessController controller = new ChessController( );

        public Chessboard()
        {
            InitializeComponent();
            

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            controller.GameStart(this);
            Validate();
        }

    }
}
