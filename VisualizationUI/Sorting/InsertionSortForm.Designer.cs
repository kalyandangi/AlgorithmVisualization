﻿namespace VisualizationUI.Sorting
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
            givenNumberLabel = new System.Windows.Forms.Label();
            insertionSortLabel = new System.Windows.Forms.Label();
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
            givenNumberLabel.Location = new System.Drawing.Point(201, 91);
            givenNumberLabel.Name = "givenNumberLabel";
            givenNumberLabel.Size = new System.Drawing.Size(126, 25);
            givenNumberLabel.TabIndex = 2;
            givenNumberLabel.Text = "Given Number";
            // 
            // insertionSortLabel
            // 
            insertionSortLabel.AutoSize = true;
            insertionSortLabel.Location = new System.Drawing.Point(709, 91);
            insertionSortLabel.Name = "insertionSortLabel";
            insertionSortLabel.Size = new System.Drawing.Size(119, 25);
            insertionSortLabel.TabIndex = 3;
            insertionSortLabel.Text = "Insertion Sort";
            // 
            // givenNumberRichTextBox
            // 
            givenNumberRichTextBox.Location = new System.Drawing.Point(73, 132);
            givenNumberRichTextBox.Name = "givenNumberRichTextBox";
            givenNumberRichTextBox.Size = new System.Drawing.Size(412, 87);
            givenNumberRichTextBox.TabIndex = 38;
            givenNumberRichTextBox.Text = "";
            // 
            // sortRichTextBox
            // 
            sortRichTextBox.Location = new System.Drawing.Point(571, 132);
            sortRichTextBox.Name = "sortRichTextBox";
            sortRichTextBox.Size = new System.Drawing.Size(412, 87);
            sortRichTextBox.TabIndex = 39;
            sortRichTextBox.Text = "";
            // 
            // sortButton
            // 
            sortButton.Location = new System.Drawing.Point(709, 531);
            sortButton.Name = "sortButton";
            sortButton.Size = new System.Drawing.Size(112, 34);
            sortButton.TabIndex = 37;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click_1;
            // 
            // generateNumberButton
            // 
            generateNumberButton.Location = new System.Drawing.Point(201, 531);
            generateNumberButton.Name = "generateNumberButton";
            generateNumberButton.Size = new System.Drawing.Size(112, 34);
            generateNumberButton.TabIndex = 36;
            generateNumberButton.Text = "Generate";
            generateNumberButton.UseVisualStyleBackColor = true;
            generateNumberButton.Click += generateNumberButton_Click_1;
            // 
            // resultPanel
            // 
            resultPanel.Location = new System.Drawing.Point(571, 225);
            resultPanel.Name = "resultPanel";
            resultPanel.Size = new System.Drawing.Size(412, 300);
            resultPanel.TabIndex = 35;
            // 
            // givenNumberPanel
            // 
            givenNumberPanel.Location = new System.Drawing.Point(73, 225);
            givenNumberPanel.Name = "givenNumberPanel";
            givenNumberPanel.Size = new System.Drawing.Size(412, 300);
            givenNumberPanel.TabIndex = 34;
            // 
            // InsertionSortForm
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
            Controls.Add(insertionSortLabel);
            Controls.Add(givenNumberLabel);
            Name = "InsertionSortForm";
            Text = "InertionSortForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label givenNumberLabel;
        private System.Windows.Forms.Label insertionSortLabel;
        private System.Windows.Forms.RichTextBox givenNumberRichTextBox;
        private System.Windows.Forms.RichTextBox sortRichTextBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button generateNumberButton;
        private System.Windows.Forms.Panel resultPanel;
        public System.Windows.Forms.Panel givenNumberPanel;
    }
}