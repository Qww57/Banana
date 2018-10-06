//-----------------------------------------------------------------------------
// File = main.cs
//-----------------------------------------------------------------------------

namespace SomethingNice
{
	class MainClass
    {
        public static void Main(string[] args)
        {
            var manager = new GameManager();
            
			Game game = manager.TicTacToe();
			game.Display();

			while (!game.IsGameDone())
            {
                game.AskUserToPlay();
				game.Display();
            }
        }
    }
}