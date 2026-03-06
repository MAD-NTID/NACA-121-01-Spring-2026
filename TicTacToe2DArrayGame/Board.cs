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
        GameOver = false;
    }

    public void AddPiece(char piece, int row, int col)
    {
        // No validation - for now, just put the piece in there
        board[row, col] = piece;

        // TODO - Check for winner
        CheckWinner();

        // TODO - Check if Game Over
        IsGameOver();
    }

    public void CheckWinner()
    {
        // Check ROW winner (horizontal)
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

        // Reset the counter
        xCounter = 0;
        oCounter = 0;
        // Check for COL winner (vertical)
        for(int c = 0; c < COLS; c++)
        {
            for(int r = 0; r < ROWS; r++)
            {
                // The Logic
                if(board[r, c] == 'x')
                    xCounter++;
                else if(board[r, c] == 'o')
                    oCounter++;
                else
                    continue;
            }

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
    
        // Reset the counter
        xCounter = 0;
        oCounter = 0;

        // Next we check for vertical from Left to Right
        if(
            // x is the winner
            (board[0, 0] == 'x' && board[1, 1] == 'x' && board[2, 2] == 'x') ||

            // o is the winner
            (board[0, 0] == 'o' && board[1, 1] == 'o' && board[2, 2] == 'o'))
        {
            Winner = true;
            return;
        }

        // Next we check for vertical from Right to Left
        if(
            // x is the winner
            (board[0, 2] == 'x' && board[1, 1] == 'x' && board[2, 0] == 'x') ||

            // o is the winner
            (board[0, 2] == 'o' && board[1, 1] == 'o' && board[2, 0] == 'o'))
        {
            Winner = true;
            return;
        }
    }

    // Edge Case - 
    // How do we know that the game is over if there's no winner?
    public void IsGameOver()
    {
        int rowsFilled = 0;
        for(int r = 0; r < ROWS; r++)
        {
            for(int c = 0; c < COLS; c++)
            {
                if(board[r, c] != '\0')
                {
                    rowsFilled++;
                }
            }
        }

        // This Checks if rowsFilled equals to the 2D array length 3x3
        // In other words, if rowsFilled is 9 and that equals to 3x3, then
        // all rows are fille and game is over
        GameOver = rowsFilled == (ROWS * COLS);
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