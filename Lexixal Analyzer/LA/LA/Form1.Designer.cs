partial class MainForm
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
        this.InputTextBox = new System.Windows.Forms.TextBox();
        this.ProcessButton = new System.Windows.Forms.Button();
        this.ResultsListBox = new System.Windows.Forms.ListBox();
        this.SuspendLayout();
        // 
        // InputTextBox
        // 
        this.InputTextBox.Location = new System.Drawing.Point(12, 12);
        this.InputTextBox.Name = "InputTextBox";
        this.InputTextBox.Size = new System.Drawing.Size(200, 20);
        this.InputTextBox.TabIndex = 0;
        // 
        // ProcessButton
        // 
        this.ProcessButton.Location = new System.Drawing.Point(218, 10);
        this.ProcessButton.Name = "ProcessButton";
        this.ProcessButton.Size = new System.Drawing.Size(75, 23);
        this.ProcessButton.TabIndex = 1;
        this.ProcessButton.Text = "Process";
        this.ProcessButton.UseVisualStyleBackColor = true;
        this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
        // 
        // ResultsListBox
        // 
        this.ResultsListBox.FormattingEnabled = true;
        this.ResultsListBox.Location = new System.Drawing.Point(12, 47);
        this.ResultsListBox.Name = "ResultsListBox";
        this.ResultsListBox.Size = new System.Drawing.Size(281, 173);
        this.ResultsListBox.TabIndex = 2;
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(305, 232);
        this.Controls.Add(this.ResultsListBox);
        this.Controls.Add(this.ProcessButton);
        this.Controls.Add(this.InputTextBox);
        this.Name = "MainForm";
        this.Text = "Floating Point Regex App";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox InputTextBox;
    private System.Windows.Forms.Button ProcessButton;
    private System.Windows.Forms.ListBox ResultsListBox;
}

