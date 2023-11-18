namespace VisualizationUI.Sorting
{
    partial class MergeSortForm
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
            MergeSortLabel = new System.Windows.Forms.Label();
            givenNumberLabel = new System.Windows.Forms.Label();
            resultPanel = new System.Windows.Forms.Panel();
            givenNumberPanel = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // sortButton
            // 
            sortButton.Location = new System.Drawing.Point(541, 375);
            sortButton.Name = "sortButton";
            sortButton.Size = new System.Drawing.Size(112, 34);
            sortButton.TabIndex = 17;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // generateNumberButton
            // 
            generateNumberButton.Location = new System.Drawing.Point(141, 375);
            generateNumberButton.Name = "generateNumberButton";
            generateNumberButton.Size = new System.Drawing.Size(112, 34);
            generateNumberButton.TabIndex = 16;
            generateNumberButton.Text = "Generate";
            generateNumberButton.UseVisualStyleBackColor = true;
            generateNumberButton.Click += generateNumberButton_Click;
            // 
            // MergeSortLabel
            // 
            MergeSortLabel.AutoSize = true;
            MergeSortLabel.Location = new System.Drawing.Point(541, 41);
            MergeSortLabel.Name = "MergeSortLabel";
            MergeSortLabel.Size = new System.Drawing.Size(101, 25);
            MergeSortLabel.TabIndex = 15;
            MergeSortLabel.Text = "Merge Sort";
            // 
            // givenNumberLabel
            // 
            givenNumberLabel.AutoSize = true;
            givenNumberLabel.Location = new System.Drawing.Point(127, 41);
            givenNumberLabel.Name = "givenNumberLabel";
            givenNumberLabel.Size = new System.Drawing.Size(126, 25);
            givenNumberLabel.TabIndex = 14;
            givenNumberLabel.Text = "Given Number";
            // 
            // resultPanel
            // 
            resultPanel.Location = new System.Drawing.Point(444, 69);
            resultPanel.Name = "resultPanel";
            resultPanel.Size = new System.Drawing.Size(300, 300);
            resultPanel.TabIndex = 13;
            // 
            // givenNumberPanel
            // 
            givenNumberPanel.Location = new System.Drawing.Point(56, 69);
            givenNumberPanel.Name = "givenNumberPanel";
            givenNumberPanel.Size = new System.Drawing.Size(300, 300);
            givenNumberPanel.TabIndex = 12;
            // 
            // MergeSortForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 523);
            Controls.Add(sortButton);
            Controls.Add(generateNumberButton);
            Controls.Add(MergeSortLabel);
            Controls.Add(givenNumberLabel);
            Controls.Add(resultPanel);
            Controls.Add(givenNumberPanel);
            Name = "MergeSortForm";
            Text = "MergeSortForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button generateNumberButton;
        private System.Windows.Forms.Label MergeSortLabel;
        private System.Windows.Forms.Label givenNumberLabel;
        private System.Windows.Forms.Panel resultPanel;
        public System.Windows.Forms.Panel givenNumberPanel;
    }
}