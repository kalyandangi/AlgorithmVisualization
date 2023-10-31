namespace VisualizationUI
{
    partial class Dashboard
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
            sortingButton = new Button();
            searchingButton = new Button();
            dynamicProgrammingButton = new Button();
            graphButton = new Button();
            divideAndConquerButton = new Button();
            recursionButton = new Button();
            stringAlgorithmButton = new Button();
            geomatircAlgorithmButton = new Button();
            backtrackingAlgorithmButton = new Button();
            SuspendLayout();
            // 
            // sortingButton
            // 
            sortingButton.Location = new Point(56, 113);
            sortingButton.Name = "sortingButton";
            sortingButton.Size = new Size(143, 44);
            sortingButton.TabIndex = 0;
            sortingButton.Text = "Sorting";
            sortingButton.UseVisualStyleBackColor = true;
            // 
            // searchingButton
            // 
            searchingButton.Location = new Point(216, 113);
            searchingButton.Name = "searchingButton";
            searchingButton.Size = new Size(143, 44);
            searchingButton.TabIndex = 1;
            searchingButton.Text = "Search";
            searchingButton.UseVisualStyleBackColor = true;
            // 
            // dynamicProgrammingButton
            // 
            dynamicProgrammingButton.Location = new Point(56, 181);
            dynamicProgrammingButton.Name = "dynamicProgrammingButton";
            dynamicProgrammingButton.Size = new Size(208, 44);
            dynamicProgrammingButton.TabIndex = 2;
            dynamicProgrammingButton.Text = "Dynamic Programming";
            dynamicProgrammingButton.UseVisualStyleBackColor = true;
            // 
            // graphButton
            // 
            graphButton.Location = new Point(531, 113);
            graphButton.Name = "graphButton";
            graphButton.Size = new Size(143, 44);
            graphButton.TabIndex = 3;
            graphButton.Text = "Graph";
            graphButton.UseVisualStyleBackColor = true;
            // 
            // divideAndConquerButton
            // 
            divideAndConquerButton.Location = new Point(491, 181);
            divideAndConquerButton.Name = "divideAndConquerButton";
            divideAndConquerButton.Size = new Size(183, 44);
            divideAndConquerButton.TabIndex = 4;
            divideAndConquerButton.Text = "Divide and Conquer";
            divideAndConquerButton.UseVisualStyleBackColor = true;
            // 
            // recursionButton
            // 
            recursionButton.Location = new Point(365, 113);
            recursionButton.Name = "recursionButton";
            recursionButton.Size = new Size(143, 44);
            recursionButton.TabIndex = 5;
            recursionButton.Text = "Recursion";
            recursionButton.UseVisualStyleBackColor = true;
            recursionButton.Click += recursionButton_Click;
            // 
            // stringAlgorithmButton
            // 
            stringAlgorithmButton.Location = new Point(279, 181);
            stringAlgorithmButton.Name = "stringAlgorithmButton";
            stringAlgorithmButton.Size = new Size(175, 44);
            stringAlgorithmButton.TabIndex = 6;
            stringAlgorithmButton.Text = "String Algorithm";
            stringAlgorithmButton.UseVisualStyleBackColor = true;
            stringAlgorithmButton.Click += button1_Click;
            // 
            // geomatircAlgorithmButton
            // 
            geomatircAlgorithmButton.Location = new Point(56, 252);
            geomatircAlgorithmButton.Name = "geomatircAlgorithmButton";
            geomatircAlgorithmButton.Size = new Size(204, 44);
            geomatircAlgorithmButton.TabIndex = 7;
            geomatircAlgorithmButton.Text = "Geomatric Algorithm";
            geomatircAlgorithmButton.UseVisualStyleBackColor = true;
            // 
            // backtrackingAlgorithmButton
            // 
            backtrackingAlgorithmButton.Location = new Point(288, 252);
            backtrackingAlgorithmButton.Name = "backtrackingAlgorithmButton";
            backtrackingAlgorithmButton.Size = new Size(220, 44);
            backtrackingAlgorithmButton.TabIndex = 8;
            backtrackingAlgorithmButton.Text = "Backtracking Algorithm";
            backtrackingAlgorithmButton.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backtrackingAlgorithmButton);
            Controls.Add(geomatircAlgorithmButton);
            Controls.Add(stringAlgorithmButton);
            Controls.Add(recursionButton);
            Controls.Add(divideAndConquerButton);
            Controls.Add(graphButton);
            Controls.Add(dynamicProgrammingButton);
            Controls.Add(searchingButton);
            Controls.Add(sortingButton);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button sortingButton;
        private Button searchingButton;
        private Button dynamicProgrammingButton;
        private Button graphButton;
        private Button divideAndConquerButton;
        private Button recursionButton;
        private Button stringAlgorithmButton;
        private Button geomatircAlgorithmButton;
        private Button backtrackingAlgorithmButton;
    }
}