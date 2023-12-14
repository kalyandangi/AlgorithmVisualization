namespace VisualizationUI.Searching
{
    partial class BreadthFirstSearch
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
            searchBreadthFirstSearchButton = new System.Windows.Forms.Button();
            SearchBreadthFirstSearchTextBox = new System.Windows.Forms.TextBox();
            repeatedNumberBreadthFirstSearchButton = new System.Windows.Forms.Button();
            smallestNumberBreadthFirstSearchButton = new System.Windows.Forms.Button();
            generatedNumbersBreadthFirstSearchPanel = new System.Windows.Forms.Panel();
            breadthFirstSearchLabel = new System.Windows.Forms.Label();
            totalNumberBreadthFirstSearchButton = new System.Windows.Forms.Button();
            largestNumberBreadthFirstSearchButton = new System.Windows.Forms.Button();
            generateRandomNumbersBreadthFirstSearchButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // searchBreadthFirstSearchButton
            // 
            searchBreadthFirstSearchButton.Location = new System.Drawing.Point(612, 251);
            searchBreadthFirstSearchButton.Name = "searchBreadthFirstSearchButton";
            searchBreadthFirstSearchButton.Size = new System.Drawing.Size(117, 31);
            searchBreadthFirstSearchButton.TabIndex = 39;
            searchBreadthFirstSearchButton.Text = "Search";
            searchBreadthFirstSearchButton.UseVisualStyleBackColor = true;
            searchBreadthFirstSearchButton.Click += searchBreadthFirstSearchButton_Click;
            // 
            // SearchBreadthFirstSearchTextBox
            // 
            SearchBreadthFirstSearchTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            SearchBreadthFirstSearchTextBox.Location = new System.Drawing.Point(558, 251);
            SearchBreadthFirstSearchTextBox.Name = "SearchBreadthFirstSearchTextBox";
            SearchBreadthFirstSearchTextBox.Size = new System.Drawing.Size(48, 31);
            SearchBreadthFirstSearchTextBox.TabIndex = 38;
            // 
            // repeatedNumberBreadthFirstSearchButton
            // 
            repeatedNumberBreadthFirstSearchButton.Location = new System.Drawing.Point(558, 173);
            repeatedNumberBreadthFirstSearchButton.Name = "repeatedNumberBreadthFirstSearchButton";
            repeatedNumberBreadthFirstSearchButton.Size = new System.Drawing.Size(170, 33);
            repeatedNumberBreadthFirstSearchButton.TabIndex = 34;
            repeatedNumberBreadthFirstSearchButton.Text = "Repeated Number";
            repeatedNumberBreadthFirstSearchButton.UseVisualStyleBackColor = true;
            repeatedNumberBreadthFirstSearchButton.Click += repeatedNumberBreadthFirstSearchButton_Click;
            // 
            // smallestNumberBreadthFirstSearchButton
            // 
            smallestNumberBreadthFirstSearchButton.Location = new System.Drawing.Point(557, 95);
            smallestNumberBreadthFirstSearchButton.Name = "smallestNumberBreadthFirstSearchButton";
            smallestNumberBreadthFirstSearchButton.Size = new System.Drawing.Size(171, 33);
            smallestNumberBreadthFirstSearchButton.TabIndex = 32;
            smallestNumberBreadthFirstSearchButton.Text = "Smallest Number";
            smallestNumberBreadthFirstSearchButton.UseVisualStyleBackColor = true;
            smallestNumberBreadthFirstSearchButton.Click += smallestNumberBreadthFirstSearchButton_Click;
            // 
            // generatedNumbersBreadthFirstSearchPanel
            // 
            generatedNumbersBreadthFirstSearchPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            generatedNumbersBreadthFirstSearchPanel.Location = new System.Drawing.Point(18, 95);
            generatedNumbersBreadthFirstSearchPanel.Name = "generatedNumbersBreadthFirstSearchPanel";
            generatedNumbersBreadthFirstSearchPanel.Size = new System.Drawing.Size(531, 187);
            generatedNumbersBreadthFirstSearchPanel.TabIndex = 37;
            // 
            // breadthFirstSearchLabel
            // 
            breadthFirstSearchLabel.AutoSize = true;
            breadthFirstSearchLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            breadthFirstSearchLabel.Location = new System.Drawing.Point(228, 28);
            breadthFirstSearchLabel.Name = "breadthFirstSearchLabel";
            breadthFirstSearchLabel.Size = new System.Drawing.Size(250, 32);
            breadthFirstSearchLabel.TabIndex = 36;
            breadthFirstSearchLabel.Text = "Breadth First Search";
            // 
            // totalNumberBreadthFirstSearchButton
            // 
            totalNumberBreadthFirstSearchButton.Location = new System.Drawing.Point(558, 212);
            totalNumberBreadthFirstSearchButton.Name = "totalNumberBreadthFirstSearchButton";
            totalNumberBreadthFirstSearchButton.Size = new System.Drawing.Size(171, 33);
            totalNumberBreadthFirstSearchButton.TabIndex = 35;
            totalNumberBreadthFirstSearchButton.Text = "Total Number";
            totalNumberBreadthFirstSearchButton.UseVisualStyleBackColor = true;
            totalNumberBreadthFirstSearchButton.Click += totalNumberBreadthFirstSearchButton_Click;
            // 
            // largestNumberBreadthFirstSearchButton
            // 
            largestNumberBreadthFirstSearchButton.Location = new System.Drawing.Point(557, 134);
            largestNumberBreadthFirstSearchButton.Name = "largestNumberBreadthFirstSearchButton";
            largestNumberBreadthFirstSearchButton.Size = new System.Drawing.Size(171, 33);
            largestNumberBreadthFirstSearchButton.TabIndex = 33;
            largestNumberBreadthFirstSearchButton.Text = "Largest Number";
            largestNumberBreadthFirstSearchButton.UseVisualStyleBackColor = true;
            largestNumberBreadthFirstSearchButton.Click += largestNumberBreadthFirstSearchButton_Click;
            // 
            // generateRandomNumbersBreadthFirstSearchButton
            // 
            generateRandomNumbersBreadthFirstSearchButton.Location = new System.Drawing.Point(160, 288);
            generateRandomNumbersBreadthFirstSearchButton.Name = "generateRandomNumbersBreadthFirstSearchButton";
            generateRandomNumbersBreadthFirstSearchButton.Size = new System.Drawing.Size(137, 44);
            generateRandomNumbersBreadthFirstSearchButton.TabIndex = 31;
            generateRandomNumbersBreadthFirstSearchButton.Text = "Generate";
            generateRandomNumbersBreadthFirstSearchButton.UseVisualStyleBackColor = true;
            generateRandomNumbersBreadthFirstSearchButton.Click += generateRandomNumbersBreadthFirstSearchButton_Click;
            // 
            // BreadthFirstSearch
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(747, 360);
            Controls.Add(searchBreadthFirstSearchButton);
            Controls.Add(SearchBreadthFirstSearchTextBox);
            Controls.Add(repeatedNumberBreadthFirstSearchButton);
            Controls.Add(smallestNumberBreadthFirstSearchButton);
            Controls.Add(generatedNumbersBreadthFirstSearchPanel);
            Controls.Add(breadthFirstSearchLabel);
            Controls.Add(totalNumberBreadthFirstSearchButton);
            Controls.Add(largestNumberBreadthFirstSearchButton);
            Controls.Add(generateRandomNumbersBreadthFirstSearchButton);
            Name = "BreadthFirstSearch";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "BreadthFirstSearch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button searchBreadthFirstSearchButton;
        private System.Windows.Forms.TextBox SearchBreadthFirstSearchTextBox;
        private System.Windows.Forms.Button repeatedNumberBreadthFirstSearchButton;
        private System.Windows.Forms.Button smallestNumberBreadthFirstSearchButton;
        private System.Windows.Forms.Panel generatedNumbersBreadthFirstSearchPanel;
        private System.Windows.Forms.Label breadthFirstSearchLabel;
        private System.Windows.Forms.Button totalNumberBreadthFirstSearchButton;
        private System.Windows.Forms.Button largestNumberBreadthFirstSearchButton;
        private System.Windows.Forms.Button generateRandomNumbersBreadthFirstSearchButton;
    }
}