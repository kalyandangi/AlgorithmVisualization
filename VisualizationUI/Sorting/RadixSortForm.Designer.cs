namespace VisualizationUI.Sorting
{
    partial class RadixSortForm
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
            sortButton = new System.Windows.Forms.Button();
            generateNumberButton = new System.Windows.Forms.Button();
            RadixSortLabel = new System.Windows.Forms.Label();
            givenNumberLabel = new System.Windows.Forms.Label();
            resultPanel = new System.Windows.Forms.Panel();
            givenNumberPanel = new System.Windows.Forms.Panel();
            givenNumberRichTextBox = new System.Windows.Forms.RichTextBox();
            sortRichTextBox = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // sortButton
            // 
            sortButton.Location = new System.Drawing.Point(645, 514);
            sortButton.Name = "sortButton";
            sortButton.Size = new System.Drawing.Size(112, 34);
            sortButton.TabIndex = 23;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // generateNumberButton
            // 
            generateNumberButton.Location = new System.Drawing.Point(112, 523);
            generateNumberButton.Name = "generateNumberButton";
            generateNumberButton.Size = new System.Drawing.Size(112, 34);
            generateNumberButton.TabIndex = 22;
            generateNumberButton.Text = "Generate";
            generateNumberButton.UseVisualStyleBackColor = true;
            generateNumberButton.Click += generateNumberButton_Click;
            // 
            // RadixSortLabel
            // 
            RadixSortLabel.AutoSize = true;
            RadixSortLabel.Location = new System.Drawing.Point(645, 77);
            RadixSortLabel.Name = "RadixSortLabel";
            RadixSortLabel.Size = new System.Drawing.Size(93, 25);
            RadixSortLabel.TabIndex = 21;
            RadixSortLabel.Text = "Radix Sort";
            // 
            // givenNumberLabel
            // 
            givenNumberLabel.AutoSize = true;
            givenNumberLabel.Location = new System.Drawing.Point(127, 77);
            givenNumberLabel.Name = "givenNumberLabel";
            givenNumberLabel.Size = new System.Drawing.Size(126, 25);
            givenNumberLabel.TabIndex = 20;
            givenNumberLabel.Text = "Given Number";
            // 
            // resultPanel
            // 
            resultPanel.Location = new System.Drawing.Point(546, 208);
            resultPanel.Name = "resultPanel";
            resultPanel.Size = new System.Drawing.Size(300, 300);
            resultPanel.TabIndex = 19;
            // 
            // givenNumberPanel
            // 
            givenNumberPanel.Location = new System.Drawing.Point(52, 217);
            givenNumberPanel.Name = "givenNumberPanel";
            givenNumberPanel.Size = new System.Drawing.Size(300, 300);
            givenNumberPanel.TabIndex = 18;
            // 
            // givenNumberRichTextBox
            // 
            givenNumberRichTextBox.Location = new System.Drawing.Point(56, 124);
            givenNumberRichTextBox.Name = "givenNumberRichTextBox";
            givenNumberRichTextBox.Size = new System.Drawing.Size(296, 87);
            givenNumberRichTextBox.TabIndex = 26;
            givenNumberRichTextBox.Text = "";
            // 
            // sortRichTextBox
            // 
            sortRichTextBox.Location = new System.Drawing.Point(550, 115);
            sortRichTextBox.Name = "sortRichTextBox";
            sortRichTextBox.Size = new System.Drawing.Size(296, 87);
            sortRichTextBox.TabIndex = 27;
            sortRichTextBox.Text = "";
            // 
            // RadixSortForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1037, 681);
            Controls.Add(sortRichTextBox);
            Controls.Add(givenNumberRichTextBox);
            Controls.Add(sortButton);
            Controls.Add(generateNumberButton);
            Controls.Add(RadixSortLabel);
            Controls.Add(givenNumberLabel);
            Controls.Add(resultPanel);
            Controls.Add(givenNumberPanel);
            Name = "RadixSortForm";
            Text = "RadixSortForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button generateNumberButton;
        private System.Windows.Forms.Label RadixSortLabel;
        private System.Windows.Forms.Label givenNumberLabel;
        private System.Windows.Forms.Panel resultPanel;
        public System.Windows.Forms.Panel givenNumberPanel;
        private System.Windows.Forms.RichTextBox givenNumberRichTextBox;
        private System.Windows.Forms.RichTextBox sortRichTextBox;
    }
}