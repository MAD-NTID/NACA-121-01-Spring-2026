using System.Globalization;
using System.Text;

public class TicTacToeBoard
{
    const int ROWS = 3, COLS = 3;

    private char[,] board;
    public char[,] Board
    {
        get { return board; }
    }

    // Status Flags
    public bool Winner { get; private set; }
    public bool GameOver { get; private set; }

    public TicTacToeBoard()
    {
        // Creates the board 3x3
        board = new char[ROWS, COLS];
    }

    public void AddPiece(char piece, int x, int y)
    {
        // No validation - for now, just put the piece in there
        board[x, y] = piece;

        // TODO - Check for winner
        CheckWinner();

        // TODO - Check if Game Over
    }

    public void CheckWinner()
    {
        // Check ROW winner
        int xCounter = 0, oCounter = 0;
        for(int r = 0; r < ROWS; r++)
        {
            for(int c = 0; c < COLS; c++)
            {
                // The Logic
                if(board[r, c] == 'x')
                    xCounter++;
                else if(board[r, c] == 'o')
                    oCounter++;
                else
                    continue;
            }

            // Once done with the inner loop, we check if we have a winner
            if(xCounter == 3 || oCounter == 3)
            {
                Winner = true;
                // Break out of the loop
                return;
            }
            else
            {
                xCounter = 0;
                oCounter = 0;
            }
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        for(int x = 0; x < ROWS; x++)
        {
            for(int y = 0; y < COLS; y++)
            {
                // Display Space                true    false
                sb.Append(board[x, y] == '\0' ? ' ' : board[x, y]);
                // Ternary Operator is like if/else
                /*
                    If value at position x, y == '\0' (empty), then
                    draw an empty space ' ' or the piece currently in x, y
                */
                // This is to draw the inner lines
                if(y < COLS - 1)
                    sb.Append(" | ");
            }

            if(x < ROWS - 1)
                sb.AppendLine("\n---------");
        }

        return sb.ToString();
    }
}