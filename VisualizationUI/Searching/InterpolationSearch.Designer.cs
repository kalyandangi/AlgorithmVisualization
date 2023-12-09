namespace VisualizationUI.Searching
{
    partial class InterpolationSearch
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
            searchInterpolationSearchButton = new System.Windows.Forms.Button();
            SearchInterpolationSearchTextBox = new System.Windows.Forms.TextBox();
            repeatedNumberInterpolationSearchButton = new System.Windows.Forms.Button();
            smallestNumberInterpolationSearchButton = new System.Windows.Forms.Button();
            generatedNumbersInterpolationSearchPanel = new System.Windows.Forms.Panel();
            interpolationSearchLabel = new System.Windows.Forms.Label();
            totalNumberInterpolationSearchButton = new System.Windows.Forms.Button();
            largestNumberInterpolationSearchButton = new System.Windows.Forms.Button();
            generateRandomNumbersInterpolationSearchButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // searchInterpolationSearchButton
            // 
            searchInterpolationSearchButton.Location = new System.Drawing.Point(612, 251);
            searchInterpolationSearchButton.Name = "searchInterpolationSearchButton";
            searchInterpolationSearchButton.Size = new System.Drawing.Size(117, 31);
            searchInterpolationSearchButton.TabIndex = 39;
            searchInterpolationSearchButton.Text = "Search";
            searchInterpolationSearchButton.UseVisualStyleBackColor = true;
            searchInterpolationSearchButton.Click += searchInterpolationSearchButton_Click;
            // 
            // SearchInterpolationSearchTextBox
            // 
            SearchInterpolationSearchTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            SearchInterpolationSearchTextBox.Location = new System.Drawing.Point(558, 251);
            SearchInterpolationSearchTextBox.Name = "SearchInterpolationSearchTextBox";
            SearchInterpolationSearchTextBox.Size = new System.Drawing.Size(48, 31);
            SearchInterpolationSearchTextBox.TabIndex = 38;
            // 
            // repeatedNumberInterpolationSearchButton
            // 
            repeatedNumberInterpolationSearchButton.Location = new System.Drawing.Point(558, 173);
            repeatedNumberInterpolationSearchButton.Name = "repeatedNumberInterpolationSearchButton";
            repeatedNumberInterpolationSearchButton.Size = new System.Drawing.Size(170, 33);
            repeatedNumberInterpolationSearchButton.TabIndex = 34;
            repeatedNumberInterpolationSearchButton.Text = "Repeated Number";
            repeatedNumberInterpolationSearchButton.UseVisualStyleBackColor = true;
            repeatedNumberInterpolationSearchButton.Click += repeatedNumberInterpolationSearchButton_Click;
            // 
            // smallestNumberInterpolationSearchButton
            // 
            smallestNumberInterpolationSearchButton.Location = new System.Drawing.Point(557, 95);
            smallestNumberInterpolationSearchButton.Name = "smallestNumberInterpolationSearchButton";
            smallestNumberInterpolationSearchButton.Size = new System.Drawing.Size(171, 33);
            smallestNumberInterpolationSearchButton.TabIndex = 32;
            smallestNumberInterpolationSearchButton.Text = "Smallest Number";
            smallestNumberInterpolationSearchButton.UseVisualStyleBackColor = true;
            smallestNumberInterpolationSearchButton.Click += smallestNumberInterpolationSearchButton_Click;
            // 
            // generatedNumbersInterpolationSearchPanel
            // 
            generatedNumbersInterpolationSearchPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            generatedNumbersInterpolationSearchPanel.Location = new System.Drawing.Point(18, 95);
            generatedNumbersInterpolationSearchPanel.Name = "generatedNumbersInterpolationSearchPanel";
            generatedNumbersInterpolationSearchPanel.Size = new System.Drawing.Size(531, 187);
            generatedNumbersInterpolationSearchPanel.TabIndex = 37;
            // 
            // interpolationSearchLabel
            // 
            interpolationSearchLabel.AutoSize = true;
            interpolationSearchLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            interpolationSearchLabel.Location = new System.Drawing.Point(228, 28);
            interpolationSearchLabel.Name = "interpolationSearchLabel";
            interpolationSearchLabel.Size = new System.Drawing.Size(251, 32);
            interpolationSearchLabel.TabIndex = 36;
            interpolationSearchLabel.Text = "Interpolation Search";
            // 
            // totalNumberInterpolationSearchButton
            // 
            totalNumberInterpolationSearchButton.Location = new System.Drawing.Point(558, 212);
            totalNumberInterpolationSearchButton.Name = "totalNumberInterpolationSearchButton";
            totalNumberInterpolationSearchButton.Size = new System.Drawing.Size(171, 33);
            totalNumberInterpolationSearchButton.TabIndex = 35;
            totalNumberInterpolationSearchButton.Text = "Total Number";
            totalNumberInterpolationSearchButton.UseVisualStyleBackColor = true;
            totalNumberInterpolationSearchButton.Click += totalNumberInterpolationSearchButton_Click;
            // 
            // largestNumberInterpolationSearchButton
            // 
            largestNumberInterpolationSearchButton.Location = new System.Drawing.Point(557, 134);
            largestNumberInterpolationSearchButton.Name = "largestNumberInterpolationSearchButton";
            largestNumberInterpolationSearchButton.Size = new System.Drawing.Size(171, 33);
            largestNumberInterpolationSearchButton.TabIndex = 33;
            largestNumberInterpolationSearchButton.Text = "Largest Number";
            largestNumberInterpolationSearchButton.UseVisualStyleBackColor = true;
            largestNumberInterpolationSearchButton.Click += largestNumberInterpolationSearchButton_Click;
            // 
            // generateRandomNumbersInterpolationSearchButton
            // 
            generateRandomNumbersInterpolationSearchButton.Location = new System.Drawing.Point(160, 288);
            generateRandomNumbersInterpolationSearchButton.Name = "generateRandomNumbersInterpolationSearchButton";
            generateRandomNumbersInterpolationSearchButton.Size = new System.Drawing.Size(137, 44);
            generateRandomNumbersInterpolationSearchButton.TabIndex = 31;
            generateRandomNumbersInterpolationSearchButton.Text = "Generate";
            generateRandomNumbersInterpolationSearchButton.UseVisualStyleBackColor = true;
            generateRandomNumbersInterpolationSearchButton.Click += generateRandomNumbersInterpolationSearchButton_Click;
            // 
            // InterpolationSearch
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(747, 360);
            Controls.Add(searchInterpolationSearchButton);
            Controls.Add(SearchInterpolationSearchTextBox);
            Controls.Add(repeatedNumberInterpolationSearchButton);
            Controls.Add(smallestNumberInterpolationSearchButton);
            Controls.Add(generatedNumbersInterpolationSearchPanel);
            Controls.Add(interpolationSearchLabel);
            Controls.Add(totalNumberInterpolationSearchButton);
            Controls.Add(largestNumberInterpolationSearchButton);
            Controls.Add(generateRandomNumbersInterpolationSearchButton);
            Name = "InterpolationSearch";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "InterpolationSearch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button searchInterpolationSearchButton;
        private System.Windows.Forms.TextBox SearchInterpolationSearchTextBox;
        private System.Windows.Forms.Button repeatedNumberInterpolationSearchButton;
        private System.Windows.Forms.Button smallestNumberInterpolationSearchButton;
        private System.Windows.Forms.Panel generatedNumbersInterpolationSearchPanel;
        private System.Windows.Forms.Label interpolationSearchLabel;
        private System.Windows.Forms.Button totalNumberInterpolationSearchButton;
        private System.Windows.Forms.Button largestNumberInterpolationSearchButton;
        private System.Windows.Forms.Button generateRandomNumbersInterpolationSearchButton;
    }
}