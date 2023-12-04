namespace VisualizationUI.Sorting
{
    partial class HeapSortForm
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
            givenNumberLabel = new System.Windows.Forms.Label();
            HeapSortLabel = new System.Windows.Forms.Label();
            givenNumberRichTextBox = new System.Windows.Forms.RichTextBox();
            sortRichTextBox = new System.Windows.Forms.RichTextBox();
            sortButton = new System.Windows.Forms.Button();
            generateNumberButton = new System.Windows.Forms.Button();
            resultPanel = new System.Windows.Forms.Panel();
            givenNumberPanel = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // givenNumberLabel
            // 
            givenNumberLabel.AutoSize = true;
            givenNumberLabel.Location = new System.Drawing.Point(201, 87);
            givenNumberLabel.Name = "givenNumberLabel";
            givenNumberLabel.Size = new System.Drawing.Size(126, 25);
            givenNumberLabel.TabIndex = 26;
            givenNumberLabel.Text = "Given Number";
            // 
            // HeapSortLabel
            // 
            HeapSortLabel.AutoSize = true;
            HeapSortLabel.Location = new System.Drawing.Point(699, 87);
            HeapSortLabel.Name = "HeapSortLabel";
            HeapSortLabel.Size = new System.Drawing.Size(92, 25);
            HeapSortLabel.TabIndex = 27;
            HeapSortLabel.Text = "Heap Sort";
            // 
            // givenNumberRichTextBox
            // 
            givenNumberRichTextBox.Location = new System.Drawing.Point(75, 126);
            givenNumberRichTextBox.Name = "givenNumberRichTextBox";
            givenNumberRichTextBox.Size = new System.Drawing.Size(412, 87);
            givenNumberRichTextBox.TabIndex = 44;
            givenNumberRichTextBox.Text = "";
            // 
            // sortRichTextBox
            // 
            sortRichTextBox.Location = new System.Drawing.Point(573, 117);
            sortRichTextBox.Name = "sortRichTextBox";
            sortRichTextBox.Size = new System.Drawing.Size(412, 87);
            sortRichTextBox.TabIndex = 45;
            sortRichTextBox.Text = "";
            // 
            // sortButton
            // 
            sortButton.Location = new System.Drawing.Point(699, 525);
            sortButton.Name = "sortButton";
            sortButton.Size = new System.Drawing.Size(112, 34);
            sortButton.TabIndex = 43;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // generateNumberButton
            // 
            generateNumberButton.Location = new System.Drawing.Point(201, 525);
            generateNumberButton.Name = "generateNumberButton";
            generateNumberButton.Size = new System.Drawing.Size(112, 34);
            generateNumberButton.TabIndex = 42;
            generateNumberButton.Text = "Generate";
            generateNumberButton.UseVisualStyleBackColor = true;
            generateNumberButton.Click += generateNumberButton_Click;
            // 
            // resultPanel
            // 
            resultPanel.Location = new System.Drawing.Point(567, 219);
            resultPanel.Name = "resultPanel";
            resultPanel.Size = new System.Drawing.Size(412, 300);
            resultPanel.TabIndex = 41;
            // 
            // givenNumberPanel
            // 
            givenNumberPanel.Location = new System.Drawing.Point(75, 219);
            givenNumberPanel.Name = "givenNumberPanel";
            givenNumberPanel.Size = new System.Drawing.Size(412, 300);
            givenNumberPanel.TabIndex = 40;
            // 
            // HeapSortForm
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
            Controls.Add(HeapSortLabel);
            Controls.Add(givenNumberLabel);
            Name = "HeapSortForm";
            Text = "HeapSortForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label givenNumberLabel;
        private System.Windows.Forms.Label HeapSortLabel;
        private System.Windows.Forms.RichTextBox givenNumberRichTextBox;
        private System.Windows.Forms.RichTextBox sortRichTextBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button generateNumberButton;
        private System.Windows.Forms.Panel resultPanel;
        public System.Windows.Forms.Panel givenNumberPanel;
    }
}