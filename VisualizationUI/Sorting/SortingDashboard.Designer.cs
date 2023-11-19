namespace VisualizationUI
{
    partial class SortingDashboard
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
            bubbleSortSelectionButton = new System.Windows.Forms.Button();
            selectionSortSelectionButton = new System.Windows.Forms.Button();
            insertionSortSelectionButton = new System.Windows.Forms.Button();
            mergeSortSelectionButton = new System.Windows.Forms.Button();
            quickSortSelectionButton = new System.Windows.Forms.Button();
            radixSortSelectionButton = new System.Windows.Forms.Button();
            heapSortSelectionButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // bubbleSortSelectionButton
            // 
            bubbleSortSelectionButton.Location = new System.Drawing.Point(59, 64);
            bubbleSortSelectionButton.Name = "bubbleSortSelectionButton";
            bubbleSortSelectionButton.Size = new System.Drawing.Size(184, 34);
            bubbleSortSelectionButton.TabIndex = 0;
            bubbleSortSelectionButton.Text = "Bubble Sort";
            bubbleSortSelectionButton.UseVisualStyleBackColor = true;
            bubbleSortSelectionButton.Click += bubbleSortSelectionButton_Click;
            // 
            // selectionSortSelectionButton
            // 
            selectionSortSelectionButton.Location = new System.Drawing.Point(273, 64);
            selectionSortSelectionButton.Name = "selectionSortSelectionButton";
            selectionSortSelectionButton.Size = new System.Drawing.Size(220, 34);
            selectionSortSelectionButton.TabIndex = 1;
            selectionSortSelectionButton.Text = "Selection Button";
            selectionSortSelectionButton.UseVisualStyleBackColor = true;
            selectionSortSelectionButton.Click += selectionSortSelectionButton_Click;
            // 
            // insertionSortSelectionButton
            // 
            insertionSortSelectionButton.Location = new System.Drawing.Point(536, 64);
            insertionSortSelectionButton.Name = "insertionSortSelectionButton";
            insertionSortSelectionButton.Size = new System.Drawing.Size(198, 34);
            insertionSortSelectionButton.TabIndex = 2;
            insertionSortSelectionButton.Text = "Insertion Sort";
            insertionSortSelectionButton.UseVisualStyleBackColor = true;
            insertionSortSelectionButton.Click += insertionSortSelectionButton_Click;
            // 
            // mergeSortSelectionButton
            // 
            mergeSortSelectionButton.Location = new System.Drawing.Point(59, 126);
            mergeSortSelectionButton.Name = "mergeSortSelectionButton";
            mergeSortSelectionButton.Size = new System.Drawing.Size(184, 34);
            mergeSortSelectionButton.TabIndex = 3;
            mergeSortSelectionButton.Text = "Merge Sort";
            mergeSortSelectionButton.UseVisualStyleBackColor = true;
            mergeSortSelectionButton.Click += mergeSortSelectionButton_Click;
            // 
            // quickSortSelectionButton
            // 
            quickSortSelectionButton.Location = new System.Drawing.Point(273, 126);
            quickSortSelectionButton.Name = "quickSortSelectionButton";
            quickSortSelectionButton.Size = new System.Drawing.Size(220, 34);
            quickSortSelectionButton.TabIndex = 4;
            quickSortSelectionButton.Text = "Quick Sort";
            quickSortSelectionButton.UseVisualStyleBackColor = true;
            quickSortSelectionButton.Click += quickSortSelectionButton_Click;
            // 
            // radixSortSelectionButton
            // 
            radixSortSelectionButton.Location = new System.Drawing.Point(536, 126);
            radixSortSelectionButton.Name = "radixSortSelectionButton";
            radixSortSelectionButton.Size = new System.Drawing.Size(198, 34);
            radixSortSelectionButton.TabIndex = 5;
            radixSortSelectionButton.Text = "Radix Sort";
            radixSortSelectionButton.UseVisualStyleBackColor = true;
            // 
            // heapSortSelectionButton
            // 
            heapSortSelectionButton.Location = new System.Drawing.Point(59, 195);
            heapSortSelectionButton.Name = "heapSortSelectionButton";
            heapSortSelectionButton.Size = new System.Drawing.Size(184, 34);
            heapSortSelectionButton.TabIndex = 6;
            heapSortSelectionButton.Text = "Heap Sort";
            heapSortSelectionButton.UseVisualStyleBackColor = true;
            // 
            // SortingDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(heapSortSelectionButton);
            Controls.Add(radixSortSelectionButton);
            Controls.Add(quickSortSelectionButton);
            Controls.Add(mergeSortSelectionButton);
            Controls.Add(insertionSortSelectionButton);
            Controls.Add(selectionSortSelectionButton);
            Controls.Add(bubbleSortSelectionButton);
            Name = "SortingDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SortingDashboard";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button bubbleSortSelectionButton;
        private System.Windows.Forms.Button selectionSortSelectionButton;
        private System.Windows.Forms.Button insertionSortSelectionButton;
        private System.Windows.Forms.Button mergeSortSelectionButton;
        private System.Windows.Forms.Button quickSortSelectionButton;
        private System.Windows.Forms.Button radixSortSelectionButton;
        private System.Windows.Forms.Button heapSortSelectionButton;
    }
}