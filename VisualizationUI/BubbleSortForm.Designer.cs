using System.Drawing;
using System.Windows.Forms;

namespace VisualizationUI
{
    partial class BubbleSortForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            givenNubmerLabel = new Label();
            bubbleSortLabel = new Label();
            givenNumberPanel = new Panel();
            resultPanel = new Panel();
            generateButton = new Button();
            sortButton = new Button();
            SuspendLayout();
            // 
            // givenNubmerLabel
            // 
            givenNubmerLabel.AutoSize = true;
            givenNubmerLabel.Location = new Point(132, 72);
            givenNubmerLabel.Name = "givenNubmerLabel";
            givenNubmerLabel.Size = new Size(126, 25);
            givenNubmerLabel.TabIndex = 2;
            givenNubmerLabel.Text = "Given Number";
            // 
            // bubbleSortLabel
            // 
            bubbleSortLabel.AutoSize = true;
            bubbleSortLabel.Location = new Point(485, 72);
            bubbleSortLabel.Name = "bubbleSortLabel";
            bubbleSortLabel.Size = new Size(105, 25);
            bubbleSortLabel.TabIndex = 3;
            bubbleSortLabel.Text = "Bubble Sort";
            // 
            // givenNumberPanel
            // 
            givenNumberPanel.Location = new Point(41, 100);
            givenNumberPanel.Name = "givenNumberPanel";
            givenNumberPanel.Size = new Size(300, 303);
            givenNumberPanel.TabIndex = 4;
            // 
            // resultPanel
            // 
            resultPanel.Location = new Point(395, 100);
            resultPanel.Name = "resultPanel";
            resultPanel.Size = new Size(300, 303);
            resultPanel.TabIndex = 5;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(138, 412);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(112, 34);
            generateButton.TabIndex = 6;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // sortButton
            // 
            sortButton.Location = new Point(478, 409);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(112, 34);
            sortButton.TabIndex = 7;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // BubbleSortForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 523);
            Controls.Add(sortButton);
            Controls.Add(generateButton);
            Controls.Add(resultPanel);
            Controls.Add(givenNumberPanel);
            Controls.Add(bubbleSortLabel);
            Controls.Add(givenNubmerLabel);
            Name = "BubbleSortForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BubbleSort";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label givenNubmerLabel;
        private Label bubbleSortLabel;
        private Panel givenNumberPanel;
        private Panel resultPanel;
        private Button generateButton;
        private Button sortButton;
    }
}