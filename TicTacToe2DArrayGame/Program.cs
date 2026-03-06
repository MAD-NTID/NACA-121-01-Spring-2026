TicTacToeBoard board = new();

while(!board.Winner && !board.GameOver)
{
    // Show the board each time we loop
    Console.WriteLine(board);

    Console.Write("Enter 'x' or 'o': ");
    char pieceInput = Console.ReadLine().ToLower()[0];

    Console.Write("Enter Row (0, 2): ");
    int row = int.Parse(Console.ReadLine());

    Console.Write("Enter Col (0, 2): ");
    int col = int.Parse(Console.ReadLine());

    board.AddPiece(pieceInput, row, col);
}

if(board.Winner)
    Console.WriteLine("We have a winner!");
else
    Console.WriteLine("No Winner");

if(board.GameOver && !board.Winner)
    Console.WriteLine("The board is full");

// Show the board after the game
Console.WriteLine(board);