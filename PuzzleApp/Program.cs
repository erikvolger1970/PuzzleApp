using PuzzleApp.Core;

namespace PuzzleApp
{
    internal static class Program
    {
        private const string _defaultPuzzleFilename = "puzzleapp2.json";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            string puzzleFilename = args.Length > 0 ? args[0] : _defaultPuzzleFilename;
            Application.Run(new PuzzleForm(PuzzleFileReader.ReadPuzzle(puzzleFilename)));
        }        
    }
}