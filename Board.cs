using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    class Board
    {
        // Create variables to be later used in program.
        public const int rows = 6;
        private const int cols = 7;
        public enum Player {EMPTY = 0, RED = 1, YELLOW = 2};
        private Player[,] board = new Player[rows,cols];
        public bool win = false;
        private Color tokenColor;
        public bool playerRed = true;
        public bool playerYellow = false;
        public bool playerEmpty = false;

        public Board()
        {
            //constructor
            ResetBoard();
        }

        public void ResetBoard()
        {
            //reset the game board to empty
            playerRed = true;
            tokenColor = Color.Red;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = Player.EMPTY;
                    playerEmpty = true;
                }
            }
        }

        public void DrawBoard(Graphics g)
        {
            int start = 50; //board top left corner offset

            g.FillRectangle(Brushes.Navy, start, start, 700, 600);

            //draw the board columns
            for(int i = 100;i<=600;i = i+100)
                g.DrawLine(Pens.White, start + i, start, start + i, start + 600);

            //draw the board rows
            for (int i = 100; i <= 500; i = i + 100)
                g.DrawLine(Pens.White, start, start + i, start + 700, start + i);


            for (int i= 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i, j] == Player.RED)
                    {
                        g.FillEllipse(Brushes.Red, (start + 5) + (j * 100), (start + 5) + (i * 100), 90, 90);
                        playerEmpty = false;
                    }
                    else if (board[i, j] == Player.YELLOW)
                    {
                        g.FillEllipse(Brushes.Yellow, (start + 5) + (j * 100), (start + 5) + (i * 100), 90, 90);
                        playerEmpty = false;
                    }
                    else
                    {
                        g.FillEllipse(Brushes.White, (start + 5) + (j * 100), (start + 5) + (i * 100), 90, 90);
                        playerEmpty = true;
                    }
                }
            }
        }

        public void nextTurn()
        {

            if (playerRed)
            {
                playerYellow = true;
                playerRed = false;
                tokenColor = Color.Yellow;
            }
            else if (playerYellow)
            {
                playerRed = true;
                playerYellow = false;
                tokenColor = Color.Red;
            }

        }

        public void placeCol1Piece(object graphics, Graphics g)
        {
            int start = 50;

            for (int i = rows; i > 0; i--)
            {
                if (playerRed == true)
                {
                    if (board[1, i] == Player.EMPTY)
                    {
                        g.FillEllipse(Brushes.Red, (start + 5) + (1 * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
                else if (playerYellow == true)
                {
                    if (board[1, i] == Player.EMPTY)
                    {
                        g.FillEllipse(Brushes.Yellow, (start + 5) + (1 * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
                else
                {
                    MessageBox.Show("That column is full. Pleace select another column.");
                    DrawBoard(g);
                }
            }
        }

        public void placeCol2Piece(Graphics g)
        {
            int start = 50;

            for (int i = rows; i > 0; i--)
            {
                if (playerRed == true)
                {
                    if (board[2, i] == Player.EMPTY)
                    {
                        g.FillEllipse(Brushes.Red, (start + 5) + (2 * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
                else if (playerYellow == true)
                {
                    if (board[2, i] == Player.EMPTY)
                    {
                        g.FillEllipse(Brushes.Yellow, (start + 5) + (2 * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
                else
                {
                    MessageBox.Show("That column is full. Pleace select another column.");
                    DrawBoard(g);
                }
            }
        }

        public void placeCol3Piece(Graphics g)
        {
            int start = 50;

            for (int i = rows; i > 0; i--)
            {
                if (playerRed == true)
                {
                    if (board[3, i] == Player.EMPTY)
                    {
                        g.FillEllipse(Brushes.Red, (start + 5) + (3 * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
                else if (playerYellow == true)
                {
                    if (board[3, i] == Player.EMPTY)
                    {
                        g.FillEllipse(Brushes.Yellow, (start + 5) + (3 * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
                else
                {
                    MessageBox.Show("That column is full. Pleace select another column.");
                    DrawBoard(g);
                }
            }
        }

        public void placeCol4Piece(Graphics g)
        {
            int start = 50;

            for (int i = rows; i > 0; i--)
            {
                if (playerRed == true)
                {
                    if (board[4, i] == Player.EMPTY)
                    {
                        g.FillEllipse(Brushes.Red, (start + 5) + (4 * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
                else if (playerYellow == true)
                {
                    if (board[4, i] == Player.EMPTY)
                    {
                        g.FillEllipse(Brushes.Yellow, (start + 5) + (4 * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
                else
                {
                    MessageBox.Show("That column is full. Pleace select another column.");
                    DrawBoard(g);
                }
            }
        }

        public void placeCol5Piece(Graphics g)
        {
            int start = 50;

            for (int i = rows; i > 0; i--)
            {
                if (playerRed == true)
                {
                    if (board[5, i] == Player.EMPTY)
                    {
                        g.FillEllipse(Brushes.Red, (start + 5) + (5 * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
                else if (playerYellow == true)
                {
                    if (board[5, i] == Player.EMPTY)
                    {
                        g.FillEllipse(Brushes.Yellow, (start + 5) + (5 * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
                else
                {
                    MessageBox.Show("That column is full. Pleace select another column.");
                    DrawBoard(g);
                }
            }
        }

        public void placeCol6Piece(Graphics g)
        {
            int start = 50;

            for (int i = rows; i > 0; i--)
            {
                if (playerRed == true)
                {
                    if (board[6, i] == Player.EMPTY)
                    {
                        g.FillEllipse(Brushes.Red, (start + 5) + (6 * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
                else if (playerYellow == true)
                {
                    if (board[6, i] == Player.EMPTY)
                    {
                        g.FillEllipse(Brushes.Yellow, (start + 5) + (6 * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
                else
                {
                    MessageBox.Show("That column is full. Pleace select another column.");
                    DrawBoard(g);
                }
            }
        }

        public void placeCol7Piece(Graphics g)
        {
            int start = 50;

            for (int i = rows; i > 0; i--)
            {
                if (playerRed == true)
                {
                    if (board[7, i] == Player.EMPTY)
                    {
                        g.FillEllipse(Brushes.Red, (start + 5) + (7 * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
                else if (playerYellow == true)
                {
                    if (board[7, i] == Player.EMPTY)
                    {
                        g.FillEllipse(Brushes.Yellow, (start + 5) + (7 * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
                else
                {
                    MessageBox.Show("That column is full. Pleace select another column.");
                    DrawBoard(g);
                }
            }
        }

        public bool checkVerticalWin()
        {
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (board[i,j] == Player.RED)
                    {
                        if (board[i,j+1] == Player.RED)
                        {
                            if (board[i,j+2] == Player.RED)
                            {
                                if (board[i,j+3] == Player.RED)
                                {
                                    win = true;
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (board[i, j] == Player.YELLOW)
                    {
                        if (board[i, j + 1] == Player.YELLOW)
                        {
                            if (board[i, j + 2] == Player.YELLOW)
                            {
                                if (board[i, j + 3] == Player.YELLOW)
                                {
                                    win = true;
                                }
                            }
                        }
                    }
                }
            }
            return win;
        }

        public bool checkHorizontalWin()
        {
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (board[i,j] == Player.RED)
                    {
                        if (board[i + 1, j] == Player.RED)
                        {
                            if (board[i + 2, j] == Player.RED)
                            {
                                if (board[i + 3, j] == Player.RED)
                                {
                                    win = true;
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (board[i, j] == Player.YELLOW)
                    {
                        if (board[i + 1, j] == Player.YELLOW)
                        {
                            if (board[i + 2, j] == Player.YELLOW)
                            {
                                if (board[i + 3, j] == Player.YELLOW)
                                {
                                    win = true;
                                }
                            }
                        }
                    }
                }
            }
            return win;
        }

        public bool checkLRDiagonalWin()
        {
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (board[i,j] == Player.RED)
                    {
                        if (board[i + 1, j + 1] == Player.RED)
                        {
                            if (board[i + 2, j + 2] == Player.RED)
                            {
                                if (board[i + 3, j + 3] == Player.RED)
                                {
                                    win = true;
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (board[i, j] == Player.YELLOW)
                    {
                        if (board[i + 1, j + 1] == Player.YELLOW)
                        {
                            if (board[i + 2, j + 2] == Player.YELLOW)
                            {
                                if (board[i + 3, j + 3] == Player.YELLOW)
                                {
                                    win = true;
                                }
                            }
                        }
                    }
                }
            }
            return win;
        }

        public bool checkRLDiagonalWin()
        {
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (board[i, j] == Player.RED)
                    {
                        if (board[i - 1, j + 1] == Player.RED)
                        {
                            if (board[i - 2, j + 2] == Player.RED)
                            {
                                if (board[i - 3, j + 3] == Player.RED)
                                {
                                    win = true;
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (board[i, j] == Player.YELLOW)
                    {
                        if (board[i - 1, j + 1] == Player.YELLOW)
                        {
                            if (board[i - 2, j + 2] == Player.YELLOW)
                            {
                                if (board[i - 3, j + 3] == Player.YELLOW)
                                {
                                    win = true;
                                }
                            }
                        }
                    }
                }
            }
            return win;
        }
    }
}
