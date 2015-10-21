namespace ChessGameRR
{
    partial class BoardSquare
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTile
            // 
            this.lblTile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.Location = new System.Drawing.Point(0, 0);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(75, 75);
            this.lblTile.TabIndex = 0;
            this.lblTile.Text = "X";
            this.lblTile.Click += new System.EventHandler(this.lblTile_Click);
            // 
            // BoardSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTile);
            this.Name = "BoardSquare";
            this.Size = new System.Drawing.Size(75, 75);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTile;
    }
}
