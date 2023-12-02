namespace VisualizationUI.Searching
{
    partial class BinarySearch
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
            searchBinarySearchButton = new System.Windows.Forms.Button();
            SearchBinarySearchTextBox = new System.Windows.Forms.TextBox();
            repeatedNumberBinarySearchButton = new System.Windows.Forms.Button();
            smallestNumberBinarySearchButton = new System.Windows.Forms.Button();
            genereatedNumbersBinarySearchPanel = new System.Windows.Forms.Panel();
            binarySearchLabel = new System.Windows.Forms.Label();
            totalNumberBinarySearchButton = new System.Windows.Forms.Button();
            largestNumberBinarySearchButton = new System.Windows.Forms.Button();
            generateRandomNumbersBinarySearchButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // searchBinarySearchButton
            // 
            searchBinarySearchButton.Location = new System.Drawing.Point(612, 251);
            searchBinarySearchButton.Name = "searchBinarySearchButton";
            searchBinarySearchButton.Size = new System.Drawing.Size(117, 31);
            searchBinarySearchButton.TabIndex = 39;
            searchBinarySearchButton.Text = "Search";
            searchBinarySearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchBinarySearchTextBox
            // 
            SearchBinarySearchTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            SearchBinarySearchTextBox.Location = new System.Drawing.Point(558, 251);
            SearchBinarySearchTextBox.Name = "SearchBinarySearchTextBox";
            SearchBinarySearchTextBox.Size = new System.Drawing.Size(48, 31);
            SearchBinarySearchTextBox.TabIndex = 38;
            // 
            // repeatedNumberBinarySearchButton
            // 
            repeatedNumberBinarySearchButton.Location = new System.Drawing.Point(558, 173);
            repeatedNumberBinarySearchButton.Name = "repeatedNumberBinarySearchButton";
            repeatedNumberBinarySearchButton.Size = new System.Drawing.Size(170, 33);
            repeatedNumberBinarySearchButton.TabIndex = 34;
            repeatedNumberBinarySearchButton.Text = "Repeated Number";
            repeatedNumberBinarySearchButton.UseVisualStyleBackColor = true;
            // 
            // smallestNumberBinarySearchButton
            // 
            smallestNumberBinarySearchButton.Location = new System.Drawing.Point(557, 95);
            smallestNumberBinarySearchButton.Name = "smallestNumberBinarySearchButton";
            smallestNumberBinarySearchButton.Size = new System.Drawing.Size(171, 33);
            smallestNumberBinarySearchButton.TabIndex = 32;
            smallestNumberBinarySearchButton.Text = "Smallest Number";
            smallestNumberBinarySearchButton.UseVisualStyleBackColor = true;
            // 
            // genereatedNumbersBinarySearchPanel
            // 
            genereatedNumbersBinarySearchPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            genereatedNumbersBinarySearchPanel.Location = new System.Drawing.Point(18, 95);
            genereatedNumbersBinarySearchPanel.Name = "genereatedNumbersBinarySearchPanel";
            genereatedNumbersBinarySearchPanel.Size = new System.Drawing.Size(531, 187);
            genereatedNumbersBinarySearchPanel.TabIndex = 37;
            // 
            // binarySearchLabel
            // 
            binarySearchLabel.AutoSize = true;
            binarySearchLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            binarySearchLabel.Location = new System.Drawing.Point(228, 28);
            binarySearchLabel.Name = "binarySearchLabel";
            binarySearchLabel.Size = new System.Drawing.Size(174, 32);
            binarySearchLabel.TabIndex = 36;
            binarySearchLabel.Text = "Binary Search";
            // 
            // totalNumberBinarySearchButton
            // 
            totalNumberBinarySearchButton.Location = new System.Drawing.Point(558, 212);
            totalNumberBinarySearchButton.Name = "totalNumberBinarySearchButton";
            totalNumberBinarySearchButton.Size = new System.Drawing.Size(171, 33);
            totalNumberBinarySearchButton.TabIndex = 35;
            totalNumberBinarySearchButton.Text = "Total Number";
            totalNumberBinarySearchButton.UseVisualStyleBackColor = true;
            // 
            // largestNumberBinarySearchButton
            // 
            largestNumberBinarySearchButton.Location = new System.Drawing.Point(557, 134);
            largestNumberBinarySearchButton.Name = "largestNumberBinarySearchButton";
            largestNumberBinarySearchButton.Size = new System.Drawing.Size(171, 33);
            largestNumberBinarySearchButton.TabIndex = 33;
            largestNumberBinarySearchButton.Text = "Largest Number";
            largestNumberBinarySearchButton.UseVisualStyleBackColor = true;
            // 
            // generateRandomNumbersBinarySearchButton
            // 
            generateRandomNumbersBinarySearchButton.Location = new System.Drawing.Point(160, 288);
            generateRandomNumbersBinarySearchButton.Name = "generateRandomNumbersBinarySearchButton";
            generateRandomNumbersBinarySearchButton.Size = new System.Drawing.Size(137, 44);
            generateRandomNumbersBinarySearchButton.TabIndex = 31;
            generateRandomNumbersBinarySearchButton.Text = "Generate";
            generateRandomNumbersBinarySearchButton.UseVisualStyleBackColor = true;
            // 
            // BinarySearch
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(747, 360);
            Controls.Add(searchBinarySearchButton);
            Controls.Add(SearchBinarySearchTextBox);
            Controls.Add(repeatedNumberBinarySearchButton);
            Controls.Add(smallestNumberBinarySearchButton);
            Controls.Add(genereatedNumbersBinarySearchPanel);
            Controls.Add(binarySearchLabel);
            Controls.Add(totalNumberBinarySearchButton);
            Controls.Add(largestNumberBinarySearchButton);
            Controls.Add(generateRandomNumbersBinarySearchButton);
            Name = "BinarySearch";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "BinarySearch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button searchBinarySearchButton;
        private System.Windows.Forms.TextBox SearchBinarySearchTextBox;
        private System.Windows.Forms.Button repeatedNumberBinarySearchButton;
        private System.Windows.Forms.Button smallestNumberBinarySearchButton;
        private System.Windows.Forms.Panel genereatedNumbersBinarySearchPanel;
        private System.Windows.Forms.Label binarySearchLabel;
        private System.Windows.Forms.Button totalNumberBinarySearchButton;
        private System.Windows.Forms.Button largestNumberBinarySearchButton;
        private System.Windows.Forms.Button generateRandomNumbersBinarySearchButton;
    }
}