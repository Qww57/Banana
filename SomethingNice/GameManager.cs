namespace SomethingNice
{
	using SomethingNice.TicTacToe;

	internal class GameManager
    {
		private Game game;
        
		internal Game TicTacToe()
        {
			// TODO as user to choose the game he wants to play
            // Should only propose this one for now.
            if (game == null)
            {
				game = new TicTacToeGame();
            }

			return game;
        }
    }
}
