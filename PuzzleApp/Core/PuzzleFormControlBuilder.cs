namespace PuzzleApp.Core;

internal class PuzzleFormControlBuilder(Control parent, EventHandler handler)
{
    public TextBoxCollection Build(IEnumerable<PuzzleWord> words)
    {
        TextBoxCollection textBoxes = new();

        foreach (PuzzleWord word in words)
        {
            FlowLayoutPanel wordPanel = CreateFlowPanel();
            parent.Controls.Add(wordPanel);

            wordPanel.Controls.Add(CreateDescriptionLabel(word.Description, 10 - word.Offset));

            int offset = word.Offset;
            foreach (int number in word.Numbers)
            {
                TextBox textBox = CreateInputBox(number, offset-- == 0);
                textBox.TextChanged += handler;
                wordPanel.Controls.Add(textBox);
                textBoxes.Add(textBox);
            }
        }

        return textBoxes;
    }

    private static FlowLayoutPanel CreateFlowPanel() =>
        new()
        {
            Dock = DockStyle.Top,
            Size = new Size(1373, 30)
        };

    private static Label CreateDescriptionLabel(string description, int number) =>
        new()
        {
            Size = new Size(200 + (number * 30), 27),
            Text = description,
            TextAlign = ContentAlignment.MiddleRight
        };

    private static TextBox CreateInputBox(int number, bool isSolutionChar) =>
        new()
        {
            Size = new Size(24, 27),
            TextAlign = HorizontalAlignment.Center,
            MaxLength = 1,
            BackColor = isSolutionChar ? Color.LightYellow : Color.White,
            Tag = isSolutionChar ? "Solution" : null,
            PlaceholderText = number != 0 ? number.ToString() : null
        };
}