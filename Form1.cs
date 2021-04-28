// Name: Emily Crabtree
// CSC339 - Spring 2021
// Assignment 4

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Connect4.Board;

namespace Connect4
{
    public partial class Form1 : Form
    {
        private Board board;
        public Form1()
        {
            InitializeComponent();
            
            //adds the event handler for when the screen is painted
            this.Paint += new PaintEventHandler(pic_board_Paint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //gets called when the main form is loaded
            board = new Board();

            MessageBox.Show("Welcome to Connect 4.", "Welcome.", MessageBoxButtons.OK);
        }

        private void pic_board_Paint(object sender, PaintEventArgs e)
        {
            //gets called whenever the screen is painted
            board.DrawBoard(e.Graphics);

            if(board.playerRed == true)
            {
                MessageBox.Show("It is Player 1's turn.");
                board.nextTurn();
            }

            else if (board.playerYellow == true)
            {
                MessageBox.Show("It is Player 2's turn.");
                board.nextTurn();
            }
        }

        private void quitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_col1_Click(object sender, EventArgs e)
        {
            board.placeCol1Piece(e.graphics);

            if (board.playerRed == true)
            {
                if (board.checkVerticalWin() == true)
                {
                board.win = true;
                }
                if (board.checkHorizontalWin() == true)
                {
                board.win = true;
                }
                if (board.checkLRDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkRLDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.win == true)
                {
                    MessageBox.Show("Red has won! Would you like to play again?", "Winner!", MessageBoxButtons.YesNo);
                    board.ResetBoard();
                }
            }

            if (board.playerYellow == true)
            {
                if (board.checkVerticalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkHorizontalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkLRDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkRLDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.win == true)
                {
                    MessageBox.Show("Yellow has won! Would you like to play again?", "Winner!", MessageBoxButtons.YesNo);
                    board.ResetBoard();
                }
            }
        }

        private void btn_col2_Click(object sender, EventArgs e)
        {
            board.placeCol2Piece(e.graphics);
            if (board.playerRed == true)
            {
                if (board.checkVerticalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkHorizontalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkLRDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkRLDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.win == true)
                {
                    MessageBox.Show("Red has won! Would you like to play again?", "Winner!", MessageBoxButtons.YesNo);
                    board.ResetBoard();
                }
            }

            if (board.playerYellow == true)
            {
                if (board.checkVerticalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkHorizontalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkLRDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkRLDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.win == true)
                {
                    MessageBox.Show("Yellow has won! Would you like to play again?", "Winner!", MessageBoxButtons.YesNo);
                    board.ResetBoard();
                }
            }

        }

        private void btn_col3_Click(object sender, EventArgs e)
        {
            board.placeCol3Piece(e.graphics);
            if (board.playerRed == true)
            {
                if (board.checkVerticalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkHorizontalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkLRDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkRLDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.win == true)
                {
                    MessageBox.Show("Red has won! Would you like to play again?", "Winner!", MessageBoxButtons.YesNo);
                    board.ResetBoard();
                }
            }

            if (board.playerYellow == true)
            {
                if (board.checkVerticalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkHorizontalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkLRDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkRLDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.win == true)
                {
                    MessageBox.Show("Yellow has won! Would you like to play again?", "Winner!", MessageBoxButtons.YesNo);
                    board.ResetBoard();
                }
            }
        }

        private void btn_col4_Click(object sender, EventArgs e)
        {
            board.placeCol4Piece(e.graphics);
            if (board.playerRed == true)
            {
                if (board.checkVerticalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkHorizontalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkLRDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkRLDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.win == true)
                {
                    MessageBox.Show("Red has won! Would you like to play again?", "Winner!", MessageBoxButtons.YesNo);
                    board.ResetBoard();
                }
            }

            if (board.playerYellow == true)
            {
                if (board.checkVerticalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkHorizontalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkLRDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkRLDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.win == true)
                {
                    MessageBox.Show("Yellow has won! Would you like to play again?", "Winner!", MessageBoxButtons.YesNo);
                    board.ResetBoard();
                }
            }
        }

        private void btn_col5_Click(object sender, EventArgs e)
        {
            board.placeCol5Piece(e.graphics);
            if (board.playerRed == true)
            {
                if (board.checkVerticalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkHorizontalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkLRDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkRLDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.win == true)
                {
                    MessageBox.Show("Red has won! Would you like to play again?", "Winner!", MessageBoxButtons.YesNo);
                    board.ResetBoard();
                }
            }

            if (board.playerYellow == true)
            {
                if (board.checkVerticalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkHorizontalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkLRDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkRLDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.win == true)
                {
                    MessageBox.Show("Yellow has won! Would you like to play again?", "Winner!", MessageBoxButtons.YesNo);
                    board.ResetBoard();
                }
            }
        }

        private void btn_col6_Click(object sender, EventArgs e)
        {
            board.placeCol6Piece(e.graphics);
            if (board.playerRed == true)
            {
                if (board.checkVerticalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkHorizontalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkLRDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkRLDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.win == true)
                {
                    MessageBox.Show("Red has won! Would you like to play again?", "Winner!", MessageBoxButtons.YesNo);
                    board.ResetBoard();
                }
            }

            if (board.playerYellow == true)
            {
                if (board.checkVerticalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkHorizontalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkLRDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkRLDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.win == true)
                {
                    MessageBox.Show("Yellow has won! Would you like to play again?", "Winner!", MessageBoxButtons.YesNo);
                    board.ResetBoard();
                }
            }
        }

        private void btn_col7_Click(object sender, EventArgs e)
        {
            board.placeCol7Piece(e.graphics);
            if (board.playerRed == true)
            {
                if (board.checkVerticalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkHorizontalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkLRDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkRLDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.win == true)
                {
                    MessageBox.Show("Red has won! Would you like to play again?", "Winner!", MessageBoxButtons.YesNo);
                    board.ResetBoard();
                }
            }

            if (board.playerYellow == true)
            {
                if (board.checkVerticalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkHorizontalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkLRDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.checkRLDiagonalWin() == true)
                {
                    board.win = true;
                }
                if (board.win == true)
                {
                    MessageBox.Show("Yellow has won! Would you like to play again?", "Winner!", MessageBoxButtons.YesNo);
                    board.ResetBoard();
                }
            }
        }
    }
}
