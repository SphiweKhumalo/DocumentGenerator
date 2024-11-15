namespace DocumentGenerator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.CheckBox chkAutoSave;
        private System.Windows.Forms.Button btnViewHighlights;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.RichTextBox hiddenRichTextBox; // Hidden RichTextBox

        private void InitializeComponent()
        {
            this.chkAutoSave = new System.Windows.Forms.CheckBox();
            this.btnViewHighlights = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.hiddenRichTextBox = new System.Windows.Forms.RichTextBox(); // Initialize hidden RichTextBox
            this.SuspendLayout();

            // chkAutoSave
            this.chkAutoSave.AutoSize = true;
            this.chkAutoSave.Location = new System.Drawing.Point(12, 12);
            this.chkAutoSave.Name = "chkAutoSave";
            this.chkAutoSave.Size = new System.Drawing.Size(79, 17);
            this.chkAutoSave.TabIndex = 0;
            this.chkAutoSave.Text = "Auto Save";
            this.chkAutoSave.UseVisualStyleBackColor = true;

            // btnViewHighlights
            this.btnViewHighlights.Location = new System.Drawing.Point(12, 35);
            this.btnViewHighlights.Name = "btnViewHighlights";
            this.btnViewHighlights.Size = new System.Drawing.Size(130, 23);
            this.btnViewHighlights.TabIndex = 1;
            this.btnViewHighlights.Text = "View Saved Highlights";
            this.btnViewHighlights.UseVisualStyleBackColor = true;
            this.btnViewHighlights.Click += new System.EventHandler(this.btnViewHighlights_Click);

            // statusStrip
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 435);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 2;

            // toolStripStatusLabel
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel.Text = "Ready to Highlight";

            // hiddenRichTextBox (for capturing formatted text)
            this.hiddenRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.hiddenRichTextBox.Name = "hiddenRichTextBox";
            this.hiddenRichTextBox.Size = new System.Drawing.Size(1, 1);
            this.hiddenRichTextBox.TabIndex = 3;
            this.hiddenRichTextBox.Visible = false;

            // Form1
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.chkAutoSave);
            this.Controls.Add(this.btnViewHighlights);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.hiddenRichTextBox); // Add hidden RichTextBox to the form
            this.Name = "Form1";
            this.Text = "Text Highlighter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
