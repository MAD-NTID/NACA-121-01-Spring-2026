using System;

public class TicTacToe : ITicTacToe
{
    private IBoard board;
    private IPiece[] players;
    private IPiece turn;
    private int length;
    private IPiece winner;
    private int[] lastMove;

    public IPiece Turn{
        get{return turn;}
    }


    public TicTacToe()
    {
        this.Restart();
    }

    // o	This method should reset the TicTacToe game to the original conditions as defined in the constructor
    public void Restart()
    {
        // Create a new instance of the Board with 3 x 3 rows and columns and assign it to the board attribute
        this.board = new Board(3,3);
        
        // Initialize players with a size of 2
        this.players = new IPiece[2];
        this.length = 3;

        // Initialize turn with null
        // Initialize winner with nll
        this.turn = null;
        this.winner = null;
        this.lastMove = new int[2];
    }

    /*
        Returns boolean on whether the game is over or not. A game is considered over if:
        The board is full
        There’s a winner in any direction: horizontally, vertically, or diagonally

    */
    public bool IsGameOver{
        get{
            return this.IsBoardFull || this.GameWonHorizontial() || this.GameWonVertical() ||
            this.GameWonDiagonal1() || this.GameWonDiagonal2();
        }
    }

    public IPiece[] Players => players;

    public IPiece Winner => winner;

    public bool IsBoardFull{
        get{
            for(int row = 0; row < length; row++)
                for(int col = 0; col < length; col++)
                    if(this.board.IsEmptySpot(row, col))
                        return false;
            
            return true;
        }
    }

    public void AddPlayers(string player1, string player2)
    {
        Random random = new Random();
        int choice = random.Next(2);

        if(choice == 1) {
            this.players[0] = new XPiece(player1);
            this.players[1] = new OPiece(player2);
        } else {

            this.players[0] = new XPiece(player2);
            this.players[1] = new OPiece(player1);
        }

        this.turn = players[0];
  
    }


    public bool GameWonDiagonal1()
    {
        if(this.board.IsEmptySpot(0,0))
            return false;

        IPiece currentPiece = this.board.Cells[0,0];

        for(int row = 1; row < length; row++) {
           
            IPiece piece = this.board.Cells[row,row];
            if(!piece.Equals(currentPiece))
                return false;
            
        }
        
        return true;
    }

    public bool GameWonDiagonal2()
    {
        if(this.board.IsEmptySpot(0,2))
            return false;

        IPiece currentPiece = this.board.Cells[0,2];
        int col = 1;
        for (int row = 1; row < length; row++)
        {
            IPiece piece = this.board.Cells[row,col];
            col--;
            if(!piece.Equals(currentPiece))
                return false;
            
        }
        
        return true;
    }

    public bool GameWonHorizontial()
    {
        int row = lastMove[0];
        IPiece currentPiece = this.board.Cells[row,lastMove[1]];

        for (int col = 0; col < length; col++)
        {
            IPiece piece = this.board.Cells[row,col];
            if (this.board.IsEmptySpot(row, col))
                return false;
            if (!piece.Equals(currentPiece))
                return false;
        }
        
        return true;

       
    }

    public bool GameWonVertical()
    {
        int col = lastMove[1];
        IPiece currentPiece = this.board.Cells[lastMove[0],col];

        for (int row = 0; row < length; row++)
        {
            IPiece piece = this.board.Cells[row,col];
            if (this.board.IsEmptySpot(row, col))
                return false;
            if (!piece.Equals(currentPiece))
                return false;
        }
        
        return true;
    
    }

    public bool Place(int row, int col)
    {
        
        if (!this.board.Place(row, col, turn))
            return false;

        this.lastMove[0] = row;
        this.lastMove[1] = col;
        
        //toggle the turn
        if(turn.Equals(this.players[0])){
            this.turn = this.players[1];
        } else {
            turn = this.players[0];
        }
        return true;
    }

    public IPiece GetPiece(int row, int col)
    {
        return this.board.GetPiece(row, col);
    }


}