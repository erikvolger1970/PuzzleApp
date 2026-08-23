using PuzzleApp.Core;

namespace PuzzleApp;

public partial class PuzzleForm : Form
{
    private readonly TextBoxCollection _textBoxes;

    public PuzzleForm(IEnumerable<PuzzleWord> words)
    {
        InitializeComponent();

        PuzzleFormControlBuilder builder = new(wordsPanel, TextBoxTextChanged);
        _textBoxes = builder.Build(words);
    }

    private void TextBoxTextChanged(object? sender, EventArgs e)
    {
        if (sender is TextBox selected)
        {
            if (selected.Tag is not null)
            {
                lbSolution.Text = _textBoxes.Solution();
            }

            if (string.IsNullOrEmpty(selected.PlaceholderText))
            {
                return;
            }

            foreach (TextBox other in _textBoxes.TextBoxes(selected))
            {
                if (other.PlaceholderText == selected.PlaceholderText)
                {
                    other.Text = selected.Text;
                }
            }

            // focus next control
        }
    }

    //private void TextBoxPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    //{
    //    if (e.KeyValue is >= 'a' and <= 'z')     
    //        return;
    //    if (e.KeyValue is '\t' or '\e')
    //        return;

    //    //e.cancel?
    //}
}
