TicTacToeBoard tttb = new();

tttb.AddPiece('x', 0, 0);
tttb.AddPiece('x', 0, 1);
tttb.AddPiece('x', 0, 2);

Console.WriteLine(tttb);

Console.WriteLine(tttb.Winner);