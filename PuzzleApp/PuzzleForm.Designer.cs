namespace PuzzleApp
{
    partial class PuzzleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            wordsPanel = new FlowLayoutPanel();
            lbSolution = new Label();
            SuspendLayout();
            // 
            // wordsPanel
            // 
            wordsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wordsPanel.Location = new Point(12, 12);
            wordsPanel.Name = "wordsPanel";
            wordsPanel.Size = new Size(878, 995);
            wordsPanel.TabIndex = 1;
            // 
            // lbSolution
            // 
            lbSolution.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbSolution.AutoSize = true;
            lbSolution.Location = new Point(12, 1010);
            lbSolution.Name = "lbSolution";
            lbSolution.Size = new Size(0, 20);
            lbSolution.TabIndex = 2;
            // 
            // PuzzleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 1039);
            Controls.Add(lbSolution);
            Controls.Add(wordsPanel);
            Name = "PuzzleForm";
            Text = "Puzzle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbSolution;
        private FlowLayoutPanel wordsPanel;
    }
}
