namespace VisualizationUI.Searching
{
    partial class LinearSearch
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
        public void InitializeComponent()
        {
            generateRandomNumbersLinearSearchButton = new System.Windows.Forms.Button();
            smallestNumberLinearSearchButton = new System.Windows.Forms.Button();
            largestNumberLinearSearchButton = new System.Windows.Forms.Button();
            repeatedNumberLinearSearchButton = new System.Windows.Forms.Button();
            totalNumberLinearSearchButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            generatedNumbersLinearSearchPanel = new System.Windows.Forms.Panel();
            SearchLinearSearchTextBox = new System.Windows.Forms.TextBox();
            searchLinearSearchButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // generateRandomNumbersLinearSearchButton
            // 
            generateRandomNumbersLinearSearchButton.Location = new System.Drawing.Point(154, 296);
            generateRandomNumbersLinearSearchButton.Name = "generateRandomNumbersLinearSearchButton";
            generateRandomNumbersLinearSearchButton.Size = new System.Drawing.Size(137, 44);
            generateRandomNumbersLinearSearchButton.TabIndex = 1;
            generateRandomNumbersLinearSearchButton.Text = "Generate";
            generateRandomNumbersLinearSearchButton.UseVisualStyleBackColor = true;
            generateRandomNumbersLinearSearchButton.Click += generateRandomNumbersLinearSearchButton_Click;
            // 
            // smallestNumberLinearSearchButton
            // 
            smallestNumberLinearSearchButton.Location = new System.Drawing.Point(551, 103);
            smallestNumberLinearSearchButton.Name = "smallestNumberLinearSearchButton";
            smallestNumberLinearSearchButton.Size = new System.Drawing.Size(171, 33);
            smallestNumberLinearSearchButton.TabIndex = 7;
            smallestNumberLinearSearchButton.Text = "Smallest Number";
            smallestNumberLinearSearchButton.UseVisualStyleBackColor = true;
            smallestNumberLinearSearchButton.Click += smallestNumberLinearSearchButton_Click;
            // 
            // largestNumberLinearSearchButton
            // 
            largestNumberLinearSearchButton.Location = new System.Drawing.Point(551, 142);
            largestNumberLinearSearchButton.Name = "largestNumberLinearSearchButton";
            largestNumberLinearSearchButton.Size = new System.Drawing.Size(171, 33);
            largestNumberLinearSearchButton.TabIndex = 8;
            largestNumberLinearSearchButton.Text = "Largest Number";
            largestNumberLinearSearchButton.UseVisualStyleBackColor = true;
            largestNumberLinearSearchButton.Click += largestNumberLinearSearchButton_Click;
            // 
            // repeatedNumberLinearSearchButton
            // 
            repeatedNumberLinearSearchButton.Location = new System.Drawing.Point(552, 181);
            repeatedNumberLinearSearchButton.Name = "repeatedNumberLinearSearchButton";
            repeatedNumberLinearSearchButton.Size = new System.Drawing.Size(170, 33);
            repeatedNumberLinearSearchButton.TabIndex = 9;
            repeatedNumberLinearSearchButton.Text = "Repeated Number";
            repeatedNumberLinearSearchButton.UseVisualStyleBackColor = true;
            repeatedNumberLinearSearchButton.Click += repeatedNumberLinearSearchButton_Click;
            // 
            // totalNumberLinearSearchButton
            // 
            totalNumberLinearSearchButton.Location = new System.Drawing.Point(552, 220);
            totalNumberLinearSearchButton.Name = "totalNumberLinearSearchButton";
            totalNumberLinearSearchButton.Size = new System.Drawing.Size(171, 33);
            totalNumberLinearSearchButton.TabIndex = 10;
            totalNumberLinearSearchButton.Text = "Total Number";
            totalNumberLinearSearchButton.UseVisualStyleBackColor = true;
            totalNumberLinearSearchButton.Click += totalNumberLinearSearchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(222, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(169, 32);
            label1.TabIndex = 16;
            label1.Text = "Linear Search";
            // 
            // generatedNumbersLinearSearchPanel
            // 
            generatedNumbersLinearSearchPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            generatedNumbersLinearSearchPanel.Location = new System.Drawing.Point(12, 103);
            generatedNumbersLinearSearchPanel.Name = "generatedNumbersLinearSearchPanel";
            generatedNumbersLinearSearchPanel.Size = new System.Drawing.Size(531, 187);
            generatedNumbersLinearSearchPanel.TabIndex = 28;
            // 
            // SearchLinearSearchTextBox
            // 
            SearchLinearSearchTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            SearchLinearSearchTextBox.Location = new System.Drawing.Point(552, 259);
            SearchLinearSearchTextBox.Name = "SearchLinearSearchTextBox";
            SearchLinearSearchTextBox.Size = new System.Drawing.Size(48, 31);
            SearchLinearSearchTextBox.TabIndex = 29;
            // 
            // searchLinearSearchButton
            // 
            searchLinearSearchButton.Location = new System.Drawing.Point(606, 259);
            searchLinearSearchButton.Name = "searchLinearSearchButton";
            searchLinearSearchButton.Size = new System.Drawing.Size(117, 31);
            searchLinearSearchButton.TabIndex = 30;
            searchLinearSearchButton.Text = "Search";
            searchLinearSearchButton.UseVisualStyleBackColor = true;
            searchLinearSearchButton.Click += searchLinearSearchButton_Click;
            // 
            // LinearSearch
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(747, 360);
            Controls.Add(searchLinearSearchButton);
            Controls.Add(SearchLinearSearchTextBox);
            Controls.Add(repeatedNumberLinearSearchButton);
            Controls.Add(smallestNumberLinearSearchButton);
            Controls.Add(generatedNumbersLinearSearchPanel);
            Controls.Add(label1);
            Controls.Add(totalNumberLinearSearchButton);
            Controls.Add(largestNumberLinearSearchButton);
            Controls.Add(generateRandomNumbersLinearSearchButton);
            Name = "LinearSearch";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LinearSearch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button generateRandomNumbersLinearSearchButton;
        private System.Windows.Forms.Button smallestNumberLinearSearchButton;
        private System.Windows.Forms.Button largestNumberLinearSearchButton;
        private System.Windows.Forms.Button repeatedNumberLinearSearchButton;
        private System.Windows.Forms.Button totalNumberLinearSearchButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel generatedNumbersLinearSearchPanel;
        private System.Windows.Forms.TextBox SearchLinearSearchTextBox;
        private System.Windows.Forms.Button searchLinearSearchButton;
    }
}