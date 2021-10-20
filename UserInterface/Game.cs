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
        private BoardUI board;
        private HistoryTable history;
        public int Hard { get; set; }
        public AI AI;
        public AI getAI()
        {
            return this.AI;
        }
        public Game(int hard)
        {
            InitializeComponent();
            this.board = new BoardUI(this);
            this.history = new HistoryTable();
        }
    }
    public class RemovedPieces : TableLayoutPanel
    {
        private BoardUI board;
    }
    public class WhiteRemovedPieces : TableLayoutPanel
    {
        public WhiteRemovedPieces()
        {
            this.RowCount = 8;
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.Margin = new Padding(0);
            this.ColumnCount = 2;
            this.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            this.BackColor = Color.Black;

            this.Size = new Size(120, 240);
            this.DoubleBuffered = true;
        }
    }
    public class BlackRemovedPieces : TableLayoutPanel
    {
        public BlackRemovedPieces()
        {
            this.RowCount = 8;
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.Margin = new Padding(0);
            this.ColumnCount = 2;
            this.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            this.BackColor = Color.White;

            this.Size = new Size(120, 240);
            this.DoubleBuffered = true;
        }
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
        private void setPieceIcon(Board board)
        {
            this.BackgroundImage = null;
            if (board.getCell(this.cellID).isCellOccupied())
            {
                Piece piece = board.getCell(this.cellID).getPiece();
                string alliance = piece.getSide() == Sides.WHITE ? "W" : "B";
                string type = piece.getPieceType().getPieceName();
                string imagePath = Application.StartupPath + "\\Piece" + alliance + type + "PNG";
                this.BackgroundImage = Image.FromFile(@imagePath);
                this.BackgroundImageLayout = ImageLayout.Center;
            }
        }
        public void draw()
        {
            this.setColor();
            this.setPieceIcon(this.board.LogicBoard);
        }
        public void hightlight()
        {
            this.BackColor = Color.Green;
            this.Refresh();
        }
        public void unhightlight()
        {
            this.BackColor = preColor;
            this.Refresh();
        }
        public void hightlightLegalMoves()
        {
            foreach (Move move in this.pieceLegalMoves())
            {
               
            }
        }
        private List<Move> pieceLegalMoves()
        {
            if (this.board.MovePiece != null && this.board.MovePiece.getSide() == this.board.LogicBoard.CurrentPlayer.getAlliance())
            {
                List<Move> moves = this.board.MovePiece.getLegalMoves(this.board.LogicBoard);
                return moves;
            }
            return new List<Move>();
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
        public Piece MovePiece
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
        public BoardUI(Game game) : base()
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
        public CellPanel getCellPanel(int cellPanelID)
        {
            return this.listOfCells[cellPanelID];
        }
        public void refreshCell()
        {
            this.SoureCell = null;
            this.DesCell = null;
            this.MovePiece = null;
        }
        public void suggestMove()
        {
            
        }
        public void resetClick()
        {
            this.draw();
            this.refreshCell();
        }
        public void draw()
        {
            this.Controls.Clear();
            for (int i = 0; i < 64; i++)
            {
                this.listOfCells[i].draw();
                this.Controls.Add(this.listOfCells[i]);
            }
            this.Refresh();
        }
        public void executeMove(MoveTransition transition, Move move)
        {
            this.logicBoard = transition.ToBoard;
        }
    }
    public class HistoryTable : DataGridView
    {
        private MoveHistory moveHistory;
        public HistoryTable()
        {
            this.Location = new Point(650, 61);
            this.Size = new Size(300, 480);
            this.BackgroundColor = Color.Transparent;
            this.SendToBack();
            this.Visible = false;

            this.Columns.Add(new DataGridViewTextBoxColumn());
            this.Columns.Add(new DataGridViewTextBoxColumn());

            this.Columns[0].HeaderText = "White moves";
            this.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Columns[1].HeaderText = "Black moves";
            this.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.DefaultCellStyle.SelectionBackColor = Color.White;
            this.DefaultCellStyle.SelectionBackColor = Color.Black;
            this.AllowUserToAddRows = false;

            this.moveHistory = new MoveHistory();
            this.Rows.Add();
        }
        public void updateMoveHistory(Sides side, Move move)
        {
            this.moveHistory.add(move);
            if (side == Sides.WHITE)
            {
                this.Rows[this.Rows.Count - 1].Cells[0].Value = move.ToString();
            }
            else
            {
                this.Rows[this.Rows.Count - 1].Cells[1].Value = move.ToString();
                this.Rows.Add();
            }
            this.Refresh();
        }
        public MoveHistory GetMoveHistory()
        {
            return this.moveHistory;
        }
        public void undoLatestMove()
        {
            if (this.moveHistory.getNumberOfMoves() > 0)
            {
                this.Rows[(this.moveHistory.getNumberOfMoves() - 1) / 2].Cells[(this.moveHistory.getNumberOfMoves() - 1) % 2].Value = "";
                if (this.moveHistory.getLatestMove().MovePiece.getSide() == Sides.WHITE)
                {
                    if (this.Rows.Count > 1)
                    {
                        this.Rows.RemoveAt((this.moveHistory.getNumberOfMoves() - 1) / 2);
                    }
                }
                this.GetMoveHistory().removeLatestMove();
            }
        }
    }
}
