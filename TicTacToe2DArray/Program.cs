TicTacToeBoard tttb = new();

// // Horizontal test on row 0
// tttb.AddPiece('x', 0, 0);
// tttb.AddPiece('x', 0, 1);
// tttb.AddPiece('x', 0, 2);

// // Vertical test on col 0
// tttb.AddPiece('x', 0, 0);
// tttb.AddPiece('x', 1, 0);
// tttb.AddPiece('x', 2, 0);

// // Diagonal test Left > Right
// tttb.AddPiece('x', 0, 0);
// tttb.AddPiece('x', 1, 1);
// tttb.AddPiece('x', 2, 2);

// // Diagonal test Left < Right
// tttb.AddPiece('x', 0, 2);
// tttb.AddPiece('x', 1, 1);
// tttb.AddPiece('x', 2, 0);

// // Bad Test 1 v
// tttb.AddPiece('x', 0, 2);
// tttb.AddPiece('x', 1, 1);
// tttb.AddPiece('x', 0, 0);

// Bad Test 2
tttb.AddPiece('x', 0, 2);
tttb.AddPiece('x', 1, 2);
tttb.AddPiece('x', 1, 1);


Console.WriteLine(tttb);

Console.WriteLine(tttb.Winner);