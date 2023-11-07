namespace VisualizationUI
{
    partial class SelectionSort
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
            selectionSortGenerateInputPanel = new System.Windows.Forms.Panel();
            selectionSortOuputPanel = new System.Windows.Forms.Panel();
            selectionSortGenerateInputButton = new System.Windows.Forms.Button();
            selectionSortOutputButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // selectionSortGenerateInputPanel
            // 
            selectionSortGenerateInputPanel.Location = new System.Drawing.Point(60, 66);
            selectionSortGenerateInputPanel.Name = "selectionSortGenerateInputPanel";
            selectionSortGenerateInputPanel.Size = new System.Drawing.Size(300, 300);
            selectionSortGenerateInputPanel.TabIndex = 0;
            // 
            // selectionSortOuputPanel
            // 
            selectionSortOuputPanel.Location = new System.Drawing.Point(440, 66);
            selectionSortOuputPanel.Name = "selectionSortOuputPanel";
            selectionSortOuputPanel.Size = new System.Drawing.Size(300, 300);
            selectionSortOuputPanel.TabIndex = 1;
            // 
            // selectionSortGenerateInputButton
            // 
            selectionSortGenerateInputButton.Location = new System.Drawing.Point(140, 381);
            selectionSortGenerateInputButton.Name = "selectionSortGenerateInputButton";
            selectionSortGenerateInputButton.Size = new System.Drawing.Size(112, 34);
            selectionSortGenerateInputButton.TabIndex = 2;
            selectionSortGenerateInputButton.Text = "Generate";
            selectionSortGenerateInputButton.UseVisualStyleBackColor = true;
            // 
            // selectionSortOutputButton
            // 
            selectionSortOutputButton.Location = new System.Drawing.Point(511, 381);
            selectionSortOutputButton.Name = "selectionSortOutputButton";
            selectionSortOutputButton.Size = new System.Drawing.Size(112, 34);
            selectionSortOutputButton.TabIndex = 3;
            selectionSortOutputButton.Text = "Sort";
            selectionSortOutputButton.UseVisualStyleBackColor = true;
            // 
            // SelectionSort
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(selectionSortOutputButton);
            Controls.Add(selectionSortGenerateInputButton);
            Controls.Add(selectionSortOuputPanel);
            Controls.Add(selectionSortGenerateInputPanel);
            Name = "SelectionSort";
            Text = "SelectionSort";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel selectionSortGenerateInputPanel;
        private System.Windows.Forms.Panel selectionSortOuputPanel;
        private System.Windows.Forms.Button selectionSortGenerateInputButton;
        private System.Windows.Forms.Button selectionSortOutputButton;
    }
}