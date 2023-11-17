namespace VisualizationUI.Sorting
{
    partial class InsertionSortForm
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
            givenNumberPanel = new System.Windows.Forms.Panel();
            resultPanel = new System.Windows.Forms.Panel();
            givenNumberLabel = new System.Windows.Forms.Label();
            insertionSortLabel = new System.Windows.Forms.Label();
            generateNumberButton = new System.Windows.Forms.Button();
            sortButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // givenNumberPanel
            // 
            givenNumberPanel.Location = new System.Drawing.Point(36, 117);
            givenNumberPanel.Name = "givenNumberPanel";
            givenNumberPanel.Size = new System.Drawing.Size(300, 300);
            givenNumberPanel.TabIndex = 0;
         //   givenNumberPanel.Paint += givenNumberPanel_Paint;
            // 
            // resultPanel
            // 
            resultPanel.Location = new System.Drawing.Point(424, 117);
            resultPanel.Name = "resultPanel";
            resultPanel.Size = new System.Drawing.Size(300, 300);
            resultPanel.TabIndex = 1;
            // 
            // givenNumberLabel
            // 
            givenNumberLabel.AutoSize = true;
            givenNumberLabel.Location = new System.Drawing.Point(107, 89);
            givenNumberLabel.Name = "givenNumberLabel";
            givenNumberLabel.Size = new System.Drawing.Size(126, 25);
            givenNumberLabel.TabIndex = 2;
            givenNumberLabel.Text = "Given Number";
            // 
            // insertionSortLabel
            // 
            insertionSortLabel.AutoSize = true;
            insertionSortLabel.Location = new System.Drawing.Point(521, 89);
            insertionSortLabel.Name = "insertionSortLabel";
            insertionSortLabel.Size = new System.Drawing.Size(119, 25);
            insertionSortLabel.TabIndex = 3;
            insertionSortLabel.Text = "Insertion Sort";
            // 
            // generateNumberButton
            // 
            generateNumberButton.Location = new System.Drawing.Point(121, 423);
            generateNumberButton.Name = "generateNumberButton";
            generateNumberButton.Size = new System.Drawing.Size(112, 34);
            generateNumberButton.TabIndex = 4;
            generateNumberButton.Text = "Generate";
            generateNumberButton.UseVisualStyleBackColor = true;
            generateNumberButton.Click += generateNumberButton_Click;
            // 
            // sortButton
            // 
            sortButton.Location = new System.Drawing.Point(521, 423);
            sortButton.Name = "sortButton";
            sortButton.Size = new System.Drawing.Size(112, 34);
            sortButton.TabIndex = 5;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // InsertionSortForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 523);
            Controls.Add(sortButton);
            Controls.Add(generateNumberButton);
            Controls.Add(insertionSortLabel);
            Controls.Add(givenNumberLabel);
            Controls.Add(resultPanel);
            Controls.Add(givenNumberPanel);
            Name = "InsertionSortForm";
            Text = "InertionSortForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.Panel givenNumberPanel;
        public System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Label givenNumberLabel;
        private System.Windows.Forms.Label insertionSortLabel;
        private System.Windows.Forms.Button generateNumberButton;
        private System.Windows.Forms.Button sortButton;
    }
}