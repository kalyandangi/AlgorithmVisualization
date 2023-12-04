namespace VisualizationUI
{
    partial class SelectionSortForm
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
            givenNumberRichTextBox = new System.Windows.Forms.RichTextBox();
            sortRichTextBox = new System.Windows.Forms.RichTextBox();
            sortButton = new System.Windows.Forms.Button();
            generateNumberButton = new System.Windows.Forms.Button();
            resultPanel = new System.Windows.Forms.Panel();
            givenNumberPanel = new System.Windows.Forms.Panel();
            selectionSortLabel = new System.Windows.Forms.Label();
            givenNumberLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // givenNumberRichTextBox
            // 
            givenNumberRichTextBox.Location = new System.Drawing.Point(63, 133);
            givenNumberRichTextBox.Name = "givenNumberRichTextBox";
            givenNumberRichTextBox.Size = new System.Drawing.Size(412, 87);
            givenNumberRichTextBox.TabIndex = 40;
            givenNumberRichTextBox.Text = "";
            // 
            // sortRichTextBox
            // 
            sortRichTextBox.Location = new System.Drawing.Point(574, 133);
            sortRichTextBox.Name = "sortRichTextBox";
            sortRichTextBox.Size = new System.Drawing.Size(412, 87);
            sortRichTextBox.TabIndex = 41;
            sortRichTextBox.Text = "";
            // 
            // sortButton
            // 
            sortButton.Location = new System.Drawing.Point(737, 541);
            sortButton.Name = "sortButton";
            sortButton.Size = new System.Drawing.Size(112, 34);
            sortButton.TabIndex = 39;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // generateNumberButton
            // 
            generateNumberButton.Location = new System.Drawing.Point(196, 541);
            generateNumberButton.Name = "generateNumberButton";
            generateNumberButton.Size = new System.Drawing.Size(112, 34);
            generateNumberButton.TabIndex = 38;
            generateNumberButton.Text = "Generate";
            generateNumberButton.UseVisualStyleBackColor = true;
            generateNumberButton.Click += generateNumberButton_Click;
            // 
            // resultPanel
            // 
            resultPanel.Location = new System.Drawing.Point(574, 235);
            resultPanel.Name = "resultPanel";
            resultPanel.Size = new System.Drawing.Size(412, 300);
            resultPanel.TabIndex = 37;
            // 
            // givenNumberPanel
            // 
            givenNumberPanel.Location = new System.Drawing.Point(63, 235);
            givenNumberPanel.Name = "givenNumberPanel";
            givenNumberPanel.Size = new System.Drawing.Size(412, 300);
            givenNumberPanel.TabIndex = 36;
            // 
            // selectionSortLabel
            // 
            selectionSortLabel.AutoSize = true;
            selectionSortLabel.Location = new System.Drawing.Point(737, 94);
            selectionSortLabel.Name = "selectionSortLabel";
            selectionSortLabel.Size = new System.Drawing.Size(121, 25);
            selectionSortLabel.TabIndex = 35;
            selectionSortLabel.Text = "Selection Sort";
            // 
            // givenNumberLabel
            // 
            givenNumberLabel.AutoSize = true;
            givenNumberLabel.Location = new System.Drawing.Point(196, 105);
            givenNumberLabel.Name = "givenNumberLabel";
            givenNumberLabel.Size = new System.Drawing.Size(126, 25);
            givenNumberLabel.TabIndex = 34;
            givenNumberLabel.Text = "Given Number";
            // 
            // SelectionSortForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1037, 681);
            Controls.Add(givenNumberRichTextBox);
            Controls.Add(sortRichTextBox);
            Controls.Add(sortButton);
            Controls.Add(generateNumberButton);
            Controls.Add(resultPanel);
            Controls.Add(givenNumberPanel);
            Controls.Add(selectionSortLabel);
            Controls.Add(givenNumberLabel);
            Name = "SelectionSortForm";
            Text = "SelectionSort";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox givenNumberRichTextBox;
        private System.Windows.Forms.RichTextBox sortRichTextBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button generateNumberButton;
        private System.Windows.Forms.Panel resultPanel;
        public System.Windows.Forms.Panel givenNumberPanel;
        private System.Windows.Forms.Label selectionSortLabel;
        private System.Windows.Forms.Label givenNumberLabel;
    }
}