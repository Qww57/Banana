namespace SomethingNice.TicTacToe
{
	using System;

	internal class TicTacToeGame : Game
	{
		private Field field;

		private int currentPlayer;

		private CellValue[] playerValues = new CellValue[]
		{
			CellValue.Cross,
			CellValue.Circle
		};

		internal TicTacToeGame(): base(players: 2)
        {
			field = new Field();
			this.currentPlayer = 0;
        }

		internal override bool IsGameDone()
		{
			// TODO or someone won.
            // TODO 2 tell the user that it's over and why
			return this.field.IsFieldFull();
		}

		internal override void AskUserToPlay()
		{
			string userInput;

			Console.WriteLine("Which line do you want to choose?");
			userInput = Console.ReadLine();
			if (!int.TryParse(userInput, out int row))
			{
				AskUserToPlayAgain();
			}
            Console.WriteLine();

			Console.WriteLine("Which column do you want to choose?");
			userInput = Console.ReadLine();
			if (!int.TryParse(userInput, out int column))
            {
                AskUserToPlayAgain();
            }
			Console.WriteLine();

			if (!Play(row, column))
			{
				AskUserToPlayAgain();
			}
		}

		internal override void Display()
        {
            Console.Clear();

            CellValue p = this.GetCurrentPlayer();
            Console.WriteLine($"Current player: {p} ({FieldCell.CellValueToString(p)})");
            Console.WriteLine();

            field.DisplayField();

            Console.WriteLine();
        }

		private bool Play(int row, int column)
		{
			CellValue player = GetCurrentPlayer();

			if (!field.TryPlay(row, column, player))
			{
				return false;
			}
            
			this.UpdateCurrentPlayer();

			return true;
		}

		private void AskUserToPlayAgain()
        {
            Console.WriteLine("Sorry input was incorrect!");
            Console.WriteLine();

            this.AskUserToPlay();

            // TODO Clear the interface before asking to play again.
        }

		private CellValue GetCurrentPlayer()
		{
			return this.playerValues[this.currentPlayer];
		}

        private void UpdateCurrentPlayer()
		{
			this.currentPlayer = (this.currentPlayer + 1) % 2;
		}
    }
}
