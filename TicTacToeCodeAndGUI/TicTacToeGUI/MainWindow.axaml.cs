using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using System;
using System.Linq;
using Avalonia.Layout;
using Avalonia.Logging;


namespace TicTacToeGUI;


public partial class MainWindow : Window
{
    private ITicTacToe game;
    private TextBox player1TextBox;
    private TextBox player2TextBox;
    private TextBox turnBlockTextBox;
    private Button startButton;
    private Button restartButton;
    private Grid ticTacToeGrid;
    private bool started;
    private IBrush? defaultColor;

    public MainWindow()
    {
        Logger.TryGet(LogEventLevel.Fatal, LogArea.Control)?.Log(this, "Avalonia Infrastructure");
        System.Diagnostics.Debug.WriteLine("System Diagnostics Debug");
            
    
            
        //initalize the game
        this.game = new TicTacToe();
        this.defaultColor = null;
        InitializeComponent();
        //setting up the controllers
        this.player1TextBox = this.FindControl<TextBox>("Player1");
        this.player2TextBox = this.FindControl<TextBox>("Player2");
        this.turnBlockTextBox = this.FindControl<TextBox>("TurnBlock");
        this.startButton = this.FindControl<Button>("StartButton");
        this.restartButton = this.FindControl<Button>("RestartButton");
        this.ticTacToeGrid = this.FindControl<Grid>("TicTacToeGrid");
            
        this.started = false;
    }

    public void Start(object sender, RoutedEventArgs e)
    {
        // Find and store controls
        string player1 = this.player1TextBox.Text;
        string player2 = this.player2TextBox.Text;

        if(string.IsNullOrEmpty(player1)|| string.IsNullOrEmpty(player2))
            return;

        this.player1TextBox.IsEnabled = false;
        this.player2TextBox.IsEnabled = false;
        this.started = true;

        this.game.AddPlayers(player1, player2);

        // Hide the start button
        this.startButton.IsVisible = false;
        this.restartButton.IsVisible = true;

        // Show turns
        this.ShowTurn();
    }

    public void Restart(object sender, RoutedEventArgs e)
    {
        if(!started)
            return ;

        // Hide the restart button
        Button restart = (Button)sender;
        restart.IsVisible = false;
        this.restartButton.IsVisible = false;

        this.player1TextBox.Watermark = "Player 1's name";
        this.player2TextBox.Watermark = "Player 2's name";
        this.player1TextBox.IsEnabled = true;
        this.player2TextBox.IsEnabled = true;
        this.startButton.IsVisible = true;

        // Reset grid colors and content
        var buttons = this.ticTacToeGrid.Children.OfType<Button>();

        foreach (var button in buttons)
        {
            button.Background = this.defaultColor;
            button.Content = null;
            button.Foreground = Brushes.White;
        }
   
        //
        this.game.Restart();
        this.started = false;
        this.ticTacToeGrid.InvalidateVisual();

        // Hide turn block
        this.turnBlockTextBox.IsVisible = false;
    }

    private void ShowTurn()
    {
        this.turnBlockTextBox.IsEnabled = false;
        this.turnBlockTextBox.IsVisible = true;
        string turn = this.game.Turn.Owner;
        this.turnBlockTextBox.Text = turn + "'s turn";
 
    }

    public void MakeMove(object sender, RoutedEventArgs e)
    {
        if (this.game.IsGameOver)
        {
            return;
        }
        // Prevent the grid from being interactive if the players have not filled out player name field
        if(this.game.Players == null)
            return; 
        for(int i = 0; i < this.game.Players.Length; i++)
            if(this.game.Players[i] == null)
                return;

        // Cast the sender object to a Button
        Button button = (Button)sender;
        // if (button.Content != null)
        //     return;

        // Get the row and column from the button
        int row = Grid.GetRow(button);
        int col = Grid.GetColumn(button);
        
        //get the default color
        if (this.defaultColor is null)
            this.defaultColor = button.Background;
        

        try{
                
            if(this.game.Place(row, col)){
                IPiece piece = this.game.GetPiece(row, col);

                IBrush color = piece.Symbol == 'X' ? Brushes.Blue : Brushes.Red;

                button.Content = piece.Symbol;
                button.FontSize = 50;

                button.Background = color;


                ShowTurn();
                
            }
        }catch(Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
        }
    }
}