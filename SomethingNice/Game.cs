namespace SomethingNice
{
	// TODO add documentation because this is an abstract class
    // that is meant to be re used.
	internal abstract class Game
    {
		protected int playerNumber;
        
        internal Game(int players)
		{
			this.playerNumber = players;
		}

		internal abstract bool IsGameDone();

		internal abstract void Display();

		internal abstract void AskUserToPlay();
    }
}