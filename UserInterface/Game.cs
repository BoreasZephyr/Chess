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
        private RemovedPieces removedPieces;
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
            this.removedPieces = new RemovedPieces(board);
            this.Controls.Add(board);
            this.Controls.Add(history);
            this.Controls.Add(removedPieces);
            this.ControlBox = false;
            this.Hard = hard;
            this.AI = new AI(this.Hard);
        }

        public AI GetAI()
        {
            return this.AI;
        }
        public BoardUI BoardUI
        {
            get
            {
                return this.board;
            }
        }
        public HistoryTable getHistoryTable()
        {
            return this.history;
        }
        public RemovedPieces getRemovedPiecesPanel()
        {
            return this.removedPieces;
        }
        public void disable()
        {
            this.board.Enabled = false;
        }
        private void undo()
        {
            Move move = history.GetMoveHistory().getLatestMove();
            if (move != null)
            {
                this.board.LogicBoard = move.undo();
                this.board.SoureCell = null;
                this.board.DesCell = null;
                this.board.draw();
                this.history.undoLatestMove();
            }
        }
        private void btUndo_Click(object sender, EventArgs e)
        {
            this.undo();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            this.board.LogicBoard = Board.createStandardBoard();
            this.board.Enabled = true;
            this.board.draw();
            this.history.Rows.Clear();
            this.history.Rows.Add();
            this.history.GetMoveHistory().getMoveHistory().Clear();
            this.removedPieces.draw(this.history.GetMoveHistory());
        }

        private void btRet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }

        private void btHint_Click(object sender, EventArgs e)
        {
            this.board.suggestMove();
        }
    }
    public class RemovedPieces : TableLayoutPanel
    {
        private BoardUI board;
        private WhiteRemovedPieces whiteRemovedPieces;
        public WhiteRemovedPieces WhiteRemovedPieces
        {
            get
            {
                return this.whiteRemovedPieces;
            }
        }
        private BlackRemovedPieces blackRemovedPieces;
        public BlackRemovedPieces BlackRemovedPieces
        {
            get
            {
                return this.blackRemovedPieces;
            }
        }
        public RemovedPieces(BoardUI board):base()
        {
            this.whiteRemovedPieces = new WhiteRemovedPieces();
            this.blackRemovedPieces = new BlackRemovedPieces();

            this.RowCount = 1;
            this.ColumnCount = 2;
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            
            this.Location = new Point(60, 27);
            this.Size = new Size(500, 120);
            this.BackColor = Color.Transparent;
            this.Controls.Add(this.whiteRemovedPieces);
            this.Controls.Add(this.blackRemovedPieces);
            this.board = board;
        }
        public void draw(MoveHistory moveHistory)
        {
            this.whiteRemovedPieces.Controls.Clear();
            this.blackRemovedPieces.Controls.Clear();
            List<Piece> whiteRemovedPiece = new List<Piece>();
            List<Piece> blackRemovedPiece = new List<Piece>();
            foreach (Move move in moveHistory.getMoveHistory())
            {
                if (move.isAttack())
                {
                    Piece attackedPiece = move.getAttackedPiece();
                    if (attackedPiece.getSide() == Sides.WHITE)
                    {
                        whiteRemovedPiece.Add(attackedPiece);
                    }
                    else
                    {
                        blackRemovedPiece.Add(attackedPiece);
                    }
                }
            }
            foreach (Piece piece in whiteRemovedPiece)
            {
                Panel panel = new Panel();
                panel.Size = new Size(60, 30);
                panel.Margin = new Padding(0);
                string alliance = piece.getSide() == Sides.WHITE ? "W" : "B";
                string type = piece.getPieceType().getPieceName();
                panel.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Piece\\" + alliance + type + ".PNG");
                panel.BackgroundImageLayout = ImageLayout.Zoom;
                whiteRemovedPieces.Controls.Add(panel);
            }
            foreach (Piece piece in blackRemovedPiece)
            {
                Panel panel = new Panel();
                panel.Size = new Size(60, 30);
                panel.Margin = new Padding(0);
                string alliance = piece.getSide() == Sides.WHITE ? "W" : "B";
                string type = piece.getPieceType().getPieceName();
                panel.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Piece\\" + alliance + type + ".PNG");
                panel.BackgroundImageLayout = ImageLayout.Zoom;
                blackRemovedPieces.Controls.Add(panel);
            }
            this.Refresh();
        }
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
            this.BackColor = Color.FromArgb(193, 154, 107) ;

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
        private static Color darkColor = Color.FromArgb(193, 154, 107);
        private Color preColor;

        private Game parentForm { get; set; }
        public static List<CellPanel> listOfCellCanMove = new List<CellPanel>();
        public CellPanel(BoardUI board, int cellID)
        {
            this.board = board;
            this.cellID = cellID;
            this.Margin = new Padding(0);
            this.Size = new Size(95, 95);
            this.Name = "panel" + cellID;
            this.setColor();
            this.setPieceIcon(board.LogicBoard);
            this.parentForm = this.board.GameForm;
            this.MouseClick += new MouseEventHandler(CellPanel_Click);
        }
        void CellPanel_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.board.SoureCell == null)
                {
                    this.board.SoureCell = this.board.LogicBoard.getCell(this.cellID);
                    this.board.MovePiece = this.board.SoureCell.getPiece();
                    //ktra cell co quan co khong
                    if (this.board.MovePiece == null)
                    {
                        this.board.SoureCell = null;
                    }
                    //ktra click dung quan cua minh khong
                    else if (this.board.LogicBoard.CurrentPlayer.getAlliance() != this.board.MovePiece.getSide())
                    {
                        this.board.SoureCell = null;
                    }
                    else
                    {
                        this.hightlight();
                        this.hightlightLegalMoves();
                    }
                }
                else
                {
                    this.board.DesCell = this.board.LogicBoard.getCell(this.cellID);
                    Move move = MoveFactory.createMove(this.board.LogicBoard, this.board.SoureCell.getCellCoordinate(), this.board.DesCell.getCellCoordinate());
                    if (move.isPromote())
                    {
                        this.choosePiece((PawnPromotionMove)move);
                    }
                    if (move != ChessEngine.Move.NULL_MOVE)
                    {
                        MoveTransition transition = this.board.LogicBoard.CurrentPlayer.makeMove(move);
                        if (transition.getMoveStatus().isDone())
                        {
                            this.board.executeMove(transition, move);
                            move = this.board.GameForm.getAI().getMove(this.board.LogicBoard);
                        }
                        if (move != ChessEngine.Move.NULL_MOVE)
                        {
                            transition = this.board.LogicBoard.CurrentPlayer.makeMove(move);
                            if (transition.getMoveStatus().isDone())
                            {
                                this.board.executeMove(transition, move);
                                string soundmoved = Application.StartupPath + "\\Sound\\Move.WAV";
                                System.Media.SoundPlayer moved = new System.Media.SoundPlayer(soundmoved);
                                moved.Play();
                            }
                        }
                    }
                    else
                    {
                        //
                        this.board.resetClick();
                    }
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                this.board.resetClick();
            }
        }
        public void choosePiece(PawnPromotionMove move)
        {
            PawnQueening f = new PawnQueening();
            var res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                move.setPromotedPiece(f.type);
            }
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
                string imagePath = Application.StartupPath + "\\Piece\\" + alliance + type + ".PNG";
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
            this.BackColor = Color.FromArgb(72, 172, 74);
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
                this.board.getCellPanel(move.DesCoordinate).hightlight();
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
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            this.Size = new Size(769, 769);
            this.TabIndex = 0;
            this.Location = new Point(10 + 350, 25);
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
            this.resetClick();
            Move move = this.GameForm.getAI().getMove(this.logicBoard);
            MoveTransition trans = this.LogicBoard.CurrentPlayer.makeMove(move);
            if (trans.getMoveStatus().isDone())
            {
                this.listOfCells[move.getCurrentCoordinate()].BackColor = Color.FromArgb(127, 255, 212);
                this.listOfCells[move.DesCoordinate].BackColor = Color.FromArgb(127, 255, 212);
            }

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
            this.GameForm.getHistoryTable().updateMoveHistory(this.LogicBoard.CurrentPlayer.getOpponent().getAlliance(), move);
            this.GameForm.getRemovedPiecesPanel().draw(this.GameForm.getHistoryTable().GetMoveHistory());
            this.draw();
            this.refreshCell();

            if ((this.LogicBoard.CurrentPlayer.isCheckMate() || this.LogicBoard.CurrentPlayer.isStaleMate()) && this.LogicBoard.CurrentPlayer.getAlliance() == Sides.WHITE)
            {
                MessageBox.Show("The Winner is Black!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.GameForm.disable();
            }
            else if ((this.LogicBoard.CurrentPlayer.isCheckMate() || this.LogicBoard.CurrentPlayer.isStaleMate()) && this.LogicBoard.CurrentPlayer.getAlliance() == Sides.BLACK)
            {
                MessageBox.Show("The Winner is White!", "WINNNER", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.GameForm.disable();
            }
            else if (this.LogicBoard.CurrentPlayer.isInCheck())
            {
                MessageBox.Show("Check", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    public class HistoryTable : DataGridView
    {
        private MoveHistory moveHistory;
        public HistoryTable()
        {
            this.Location = new Point(1160, 27);
            this.Size = new Size(300, 480);
            this.BackgroundColor = Color.White;
            this.SendToBack();
            this.Visible = true;

            this.Columns.Add(new DataGridViewTextBoxColumn());
            this.Columns.Add(new DataGridViewTextBoxColumn());

            this.Columns[0].HeaderText = "White moves";
            this.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Columns[0].ReadOnly = true;
            this.Columns[1].HeaderText = "Black moves";
            this.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Columns[1].ReadOnly = true;

            this.DefaultCellStyle.SelectionBackColor = Color.White;
            this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(193, 154, 107);
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
