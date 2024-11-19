namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private string[,] btnSymbols = new string[3, 3]; 
        private string player1Symbol = "X", player2Symbol = "O"; 
        private string currentPlayer;
        private string player1Name, player2Name;
        private int player1Wins = 0, player2Wins = 0, draws = 0;
        private bool gameActive = false;
        public Form1()
        {

            InitializeComponent();
            SetupInitialForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in gamePanel.Controls)
            {
                if (control is Button button)
                {
                    button.Click += GameButton_Click; 
                }
            }

            ToolTip toolTip = new ToolTip();
            statsListBox.View = View.List;

            // Set up the ToolTip text for the controls
            toolTip.SetToolTip(StartButton, "Click to start the game.");
            toolTip.SetToolTip(ContinueButton, "Click to continue to the next game.");
            toolTip.SetToolTip(ResetButton, "Click to reset the game.");
            toolTip.SetToolTip(player1NameTextBox, "Enter Player 1's name.");
            toolTip.SetToolTip(player2NameTextBox, "Enter Player 2's name.");
            toolTip.SetToolTip(player1SymbolTextBox, "Enter Player 1's symbol.");
            toolTip.SetToolTip(player2SymbolTextBox, "Enter Player 2's symbol.");

        }

        private void SetupInitialForm()
        {
            EnableGameSetupFields(true); 
            EnableGameButtons(false); 
            ContinueButton.Enabled = false; 
            player1SymbolTextBox.Text = player1Symbol; 
            player2SymbolTextBox.Text = player2Symbol;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (IsSetupValid())
            {
                player1Name = player1NameTextBox.Text;
                player2Name = player2NameTextBox.Text;
                currentPlayer = player1Name; 
                gameActive = true;

                EnableGameSetupFields(false); 
                EnableGameButtons(true); 
                StartButton.Enabled = false;
                ClearGrid();
                UpdateNextTurnLabel();
            }
            else
            {
                MessageBox.Show("Please enter valid player names.");
            }
        }

        private bool IsSetupValid()
        {
            return !string.IsNullOrEmpty(player1NameTextBox.Text) &&
                   !string.IsNullOrEmpty(player2NameTextBox.Text);
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender; 
            if (clickedButton.Text == "" && gameActive)
            {
                clickedButton.Text = currentPlayer == player1Name ? player1Symbol : player2Symbol;
                UpdateGrid(clickedButton); 
                CheckGameStatus();
                TogglePlayer(); 
                UpdateNextTurnLabel();
            }
        }

        private void UpdateGrid(Button clickedButton)
        {
            string[] indices = clickedButton.Tag.ToString().Split(',');
            int row = int.Parse(indices[0]);
            int col = int.Parse(indices[1]);
            btnSymbols[row, col] = clickedButton.Text; 
        }

        private List<string> gameResults = new List<string>();
        private void CheckGameStatus()
        {
            string winner = GetWinner();
            if (!string.IsNullOrEmpty(winner))
            {
                string result;
                if (winner == "Draw")
                {
                    MessageBox.Show("The game is a draw!");
                    draws++;
                    result = "Draw"; 
                }
                else
                {
                    string winningPlayer = winner == player1Symbol ? player1Name : player2Name;
                    MessageBox.Show($"{winningPlayer} wins!");
                    if (winner == player1Symbol) player1Wins++;
                    else player2Wins++;
                    result = winningPlayer;
                }
                
                gameResults.Add(result);
                UpdateGameStats(); 
                ContinueButton.Enabled = true; 
                EnableGameButtons(false); 
                gameActive = false;
            }
        }

        private string GetWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                
                if (btnSymbols[i, 0] != null && btnSymbols[i, 0] == btnSymbols[i, 1] && btnSymbols[i, 1] == btnSymbols[i, 2])
                    return btnSymbols[i, 0];

                
                if (btnSymbols[0, i] != null && btnSymbols[0, i] == btnSymbols[1, i] && btnSymbols[1, i] == btnSymbols[2, i])
                    return btnSymbols[0, i];
            }

           
            if (btnSymbols[0, 0] != null && btnSymbols[0, 0] == btnSymbols[1, 1] && btnSymbols[1, 1] == btnSymbols[2, 2])
                return btnSymbols[0, 0];

            if (btnSymbols[0, 2] != null && btnSymbols[0, 2] == btnSymbols[1, 1] && btnSymbols[1, 1] == btnSymbols[2, 0])
                return btnSymbols[0, 2];

            
            foreach (var symbol in btnSymbols)
            {
                if (string.IsNullOrEmpty(symbol)) 
                    return null;
            }
            return "Draw"; 
        }

        private void TogglePlayer()
        {
            currentPlayer = (currentPlayer == player1Name) ? player2Name : player1Name;
        }

        private void UpdateNextTurnLabel()
        {
            nextTurnLabel.Text = currentPlayer;
        }

        private void EnableGameButtons(bool enable)
        {
            foreach (Control control in gamePanel.Controls) 
            {
                if (control is Button button && button.Tag != null)
                {
                    button.Enabled = enable; 
                    if (!enable) button.Text = "";
                }
            }
        }


        private void ClearGrid()
        {
            Array.Clear(btnSymbols, 0, btnSymbols.Length);
            foreach (Control control in gamePanel.Controls)
            {
                if (control is Button button)
                {
                    button.Text = ""; 
                }
            }
        }


        private void UpdateGameStats()
        {
            statsListBox.Items.Clear(); // Clear previous stats

            for (int i = 0; i < gameResults.Count; i++)
            {
                statsListBox.Items.Add($"Game {i + 1}: {gameResults[i]}"); // Add each game's result in row-wise format
            }

            // Update the overall winner label
            if (player1Wins > player2Wins)
                winnerLabel.Text = player1Name; // Player 1 is the overall winner
            else if (player2Wins > player1Wins)
                winnerLabel.Text = player2Name; // Player 2 is the overall winner
            else
                winnerLabel.Text = "None"; // No overall winner
        }




        private void EnableGameSetupFields(bool enable)
        {
            player1NameTextBox.Enabled = enable;
            player2NameTextBox.Enabled = enable;
            player1SymbolTextBox.Enabled = enable;
            player2SymbolTextBox.Enabled = enable;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (!gameActive) 
            {
                ClearGrid(); 
                EnableGameButtons(true); 
                currentPlayer = player1Name; 
                gameActive = true; 
                UpdateNextTurnLabel();
                Console.WriteLine("Game has continued. Current player: " + currentPlayer);
            }
            else
            {
                MessageBox.Show("Cannot continue while the game is still active.");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SetupInitialForm(); 
            ClearGrid();
            nextTurnLabel.Text = "";
            winnerLabel.Text = "None"; 
        }
    }
}