using System.Text;

namespace PuzzleApp.Core;

public class TextBoxCollection
{
    private readonly Dictionary<string, List<TextBox>> _textBoxes = [];
    private readonly List<TextBox> _solutionTextBoxes = [];

    public void Add(TextBox textBox)
    {
        if (textBox.Tag is not null)        
        {
            _solutionTextBoxes.Add(textBox);
        }

        if (string.IsNullOrWhiteSpace(textBox.PlaceholderText))
        {
            return;
        }

        if (_textBoxes.TryGetValue(textBox.PlaceholderText, out var list))
        {
            list.Add(textBox);
        }
        else
        {
            _textBoxes.Add(textBox.PlaceholderText, [textBox]);
        }
    }

    public IEnumerable<TextBox> TextBoxes(TextBox selected)
    {
        return string.IsNullOrWhiteSpace(selected.PlaceholderText)
            ? []
            : _textBoxes[selected.PlaceholderText].Where(tb => tb != selected);
    }

    public string Solution()
    {
        StringBuilder sb = new();
        var solution = _solutionTextBoxes
            .Select(tb => string.IsNullOrWhiteSpace(tb.Text) ? '_' : tb.Text.First())
            .ToArray();
        sb.Append(solution);
        return sb.ToString();
    }
}