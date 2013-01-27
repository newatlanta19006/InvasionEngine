using System;

namespace InvasionGame
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (InvasionGame game = new InvasionGame())
            {
                game.Run();
            }
        }
    }
#endif
}

