using System.Text.Json;

namespace PuzzleApp.Core;

internal class PuzzleFileReader
{
    public static IEnumerable<PuzzleWord> ReadPuzzle(string filename)
    {
        var fileStream = File.OpenRead(filename);
        var words = JsonSerializer.Deserialize<IEnumerable<PuzzleWord>>(fileStream);
        return words ?? throw new Exception($"Cannot read {filename}");
    }
}
