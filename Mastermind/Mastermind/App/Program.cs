namespace Mastermind.App
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (MastermindGame game = new MastermindGame())
            {
                game.Run();
            }
        }
    }
#endif
}

