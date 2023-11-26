namespace VisualizationUI.Searching
{
    partial class SearchingDashboard
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
            linearSearchButton = new System.Windows.Forms.Button();
            binarySearchButton = new System.Windows.Forms.Button();
            interpolationSearchButton = new System.Windows.Forms.Button();
            breadthFirstSearchButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // linearSearchButton
            // 
            linearSearchButton.Location = new System.Drawing.Point(117, 165);
            linearSearchButton.Name = "linearSearchButton";
            linearSearchButton.Size = new System.Drawing.Size(191, 34);
            linearSearchButton.TabIndex = 0;
            linearSearchButton.Text = "Linear Search";
            linearSearchButton.UseVisualStyleBackColor = true;
            // 
            // binarySearchButton
            // 
            binarySearchButton.Location = new System.Drawing.Point(423, 165);
            binarySearchButton.Name = "binarySearchButton";
            binarySearchButton.Size = new System.Drawing.Size(233, 34);
            binarySearchButton.TabIndex = 1;
            binarySearchButton.Text = "Binary Search";
            binarySearchButton.UseVisualStyleBackColor = true;
            // 
            // interpolationSearchButton
            // 
            interpolationSearchButton.Location = new System.Drawing.Point(117, 232);
            interpolationSearchButton.Name = "interpolationSearchButton";
            interpolationSearchButton.Size = new System.Drawing.Size(191, 34);
            interpolationSearchButton.TabIndex = 2;
            interpolationSearchButton.Text = "Interpolation Search";
            interpolationSearchButton.UseVisualStyleBackColor = true;
            // 
            // breadthFirstSearchButton
            // 
            breadthFirstSearchButton.Location = new System.Drawing.Point(423, 232);
            breadthFirstSearchButton.Name = "breadthFirstSearchButton";
            breadthFirstSearchButton.Size = new System.Drawing.Size(233, 34);
            breadthFirstSearchButton.TabIndex = 3;
            breadthFirstSearchButton.Text = "Breadth First Serach";
            breadthFirstSearchButton.UseVisualStyleBackColor = true;
            breadthFirstSearchButton.Click += breadthFirstSearchButton_Click;
            // 
            // SearchingDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(breadthFirstSearchButton);
            Controls.Add(interpolationSearchButton);
            Controls.Add(binarySearchButton);
            Controls.Add(linearSearchButton);
            Name = "SearchingDashboard";
            Text = "SearchingDashboard";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button linearSearchButton;
        private System.Windows.Forms.Button binarySearchButton;
        private System.Windows.Forms.Button interpolationSearchButton;
        private System.Windows.Forms.Button breadthFirstSearchButton;
    }
}