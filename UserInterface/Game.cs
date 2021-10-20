using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessEngine;

namespace UserInterface
{
    public partial class Game : Form
    {
        
    }
    public class CellPanel : Panel
    {
        private int cellID;
        private BoardUI board;
        private static Color lightColor = Color.White;
        private static Color darkColor = Color.Black;
        private Color preColor;

        private Game parentForm { get; set; }
        public static List<CellPanel> listOfCellCanMove = new List<CellPanel>();
        public CellPanel(BoardUI board, int cellID)
        {
            this.board = board;
            this.cellID = cellID;
            this.Margin = new Padding(0);
            this.Size = new Size(100, 100);
            this.Name = "panel" + cellID;
        }
        private void setColor()
        {
            if (cellID / 8 == 0 || cellID / 8 == 2 || cellID / 8 == 4 || cellID / 8 == 6)
            {
                this.BackColor = cellID % 2 == 0 ? lightColor : darkColor;
                this.preColor = cellID % 2 == 0 ? lightColor : darkColor;
            }
            if (cellID / 8 == 1 || cellID / 8 == 3 || cellID / 8 == 5 || cellID / 8 == 7)
            {
                this.BackColor = cellID % 2 == 0 ? darkColor : lightColor;
                this.preColor = cellID % 2 == 0 ? darkColor : lightColor;
            }
        }
        public class BoardUI : TableLayoutPanel
        {
            private List<CellPanel> listOfCells;
            private Cell sourceCell;
            public Cell SoureCell
            {
                get
                {
                    return this.sourceCell;
                }
                set
                {
                    this.sourceCell = value;
                }
            }
            private Cell desCell;
            public Cell DesCell
            {
                get
                {
                    return this.desCell;
                }
                set
                {
                    this.desCell = value;
                }
            }
            private Piece movePiece;
            public Piece piece
            {
                get
                {
                    return this.movePiece;
                }
                set
                {
                    if (value != null)
                    {
                        movePiece = value;
                    }
                }
            }
            private Board logicBoard;
            public Board LogicBoard
            {
                get
                {
                    return this.logicBoard;
                }
                set
                {
                    if (value != null)
                    {
                        this.logicBoard = value;
                    }
                }
            }
            public Game GameForm { get; set; }
            public BoardUI(Game game):base()
            {
                this.ColumnCount = 8;
                this.GameForm = game;
                this.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                this.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                this.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                this.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                this.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                this.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                this.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                this.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                this.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                this.RowCount = 8;
                this.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
                this.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
                this.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
                this.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
                this.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
                this.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
                this.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
                this.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
                this.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));

                this.Size = new Size(500, 500);
                this.TabIndex = 0;
                this.Location = new Point(10 + 150, 59);
                this.Name = "Board";
                this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                this.logicBoard = Board.createStandardBoard();
                listOfCells = new List<CellPanel>();
                for (int i = 0; i < 64; i++)
                {
                    CellPanel cell = new CellPanel(this, i);
                    this.Controls.Add(cell, i % 8, i / 8);
                    listOfCells.Add(cell);
                }
                this.DoubleBuffered = true;

            }
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (!(obj is CellPanel))
            {
                return false;
            }
            return this.cellID == ((CellPanel)obj).cellID;
        }
        public override int GetHashCode()
        {
            return this.cellID;
        }
        private void setPieceIcon()
        {

        }
    }
}
