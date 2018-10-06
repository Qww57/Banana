namespace SomethingNice.TicTacToe
{
	using System;

	internal class TicTacToeOnePlayer: TicTacToeGame
    {
		public TicTacToeOnePlayer(): base()
        {
			
        }

		internal override void AskUserToPlay()
		{
			base.AskUserToPlay();
		}

		internal override void Display()
		{
			base.Display();
		}

		internal override bool IsGameDone()
		{
			return base.IsGameDone();
		}
	}
}
