namespace VisualizationUI
{
    partial class SelectionSortForm
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
            selectionSortGenerateInputButton = new System.Windows.Forms.Button();
            selectionSortOutputButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // givenNumberPanel
            // 
            givenNumberPanel.Location = new System.Drawing.Point(60, 66);
            givenNumberPanel.Name = "givenNumberPanel";
            givenNumberPanel.Size = new System.Drawing.Size(300, 300);
            givenNumberPanel.TabIndex = 0;
            // 
            // resultPanel
            // 
            resultPanel.Location = new System.Drawing.Point(440, 66);
            resultPanel.Name = "resultPanel";
            resultPanel.Size = new System.Drawing.Size(300, 300);
            resultPanel.TabIndex = 1;
            // 
            // selectionSortGenerateInputButton
            // 
            selectionSortGenerateInputButton.Location = new System.Drawing.Point(140, 381);
            selectionSortGenerateInputButton.Name = "selectionSortGenerateInputButton";
            selectionSortGenerateInputButton.Size = new System.Drawing.Size(112, 34);
            selectionSortGenerateInputButton.TabIndex = 2;
            selectionSortGenerateInputButton.Text = "Generate";
            selectionSortGenerateInputButton.UseVisualStyleBackColor = true;
            selectionSortGenerateInputButton.Click += selectionSortGenerateInputButton_Click;
            // 
            // selectionSortOutputButton
            // 
            selectionSortOutputButton.Location = new System.Drawing.Point(511, 381);
            selectionSortOutputButton.Name = "selectionSortOutputButton";
            selectionSortOutputButton.Size = new System.Drawing.Size(112, 34);
            selectionSortOutputButton.TabIndex = 3;
            selectionSortOutputButton.Text = "Sort";
            selectionSortOutputButton.UseVisualStyleBackColor = true;
            selectionSortOutputButton.Click += selectionSortOutputButton_Click;
            // 
            // SelectionSortForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(selectionSortOutputButton);
            Controls.Add(selectionSortGenerateInputButton);
            Controls.Add(resultPanel);
            Controls.Add(givenNumberPanel);
            Name = "SelectionSortForm";
            Text = "SelectionSort";
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Panel givenNumberPanel;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Button selectionSortGenerateInputButton;
        private System.Windows.Forms.Button selectionSortOutputButton;
    }
}