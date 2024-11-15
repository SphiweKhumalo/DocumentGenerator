using Gma.System.MouseKeyHook;
using System;
using System.IO;
using System.Windows.Forms;

namespace DocumentGenerator
{
    public partial class Form1 : Form
    {
        private IKeyboardMouseEvents _globalHook;
        private bool _autoSaveEnabled;
        private bool _isHighlightingEnabled = false;

        public Form1()
        {
            InitializeComponent();

            _globalHook = Hook.GlobalEvents();
            _globalHook.MouseUp += OnMouseUp;
            _globalHook.KeyDown += OnKeyDown;

            _autoSaveEnabled = chkAutoSave.Checked;
            chkAutoSave.CheckedChanged += chkAutoSave_CheckedChanged;
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _autoSaveEnabled && _isHighlightingEnabled)
            {
                SaveHighlightedContent();
            }
        }

        private async void SaveHighlightedContent()
        {
            // Clear the clipboard and simulate Ctrl+C to copy the selected text
            Clipboard.Clear();
            SendKeys.SendWait("^c");  // Simulate Ctrl+C

            // Wait for the clipboard to populate with the copied text (allowing for async copy operations)
            await Task.Delay(100); // Small delay to allow clipboard to catch up

            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                // If RTF content is available, save it with formatting
                hiddenRichTextBox.Rtf = Clipboard.GetText(TextDataFormat.Rtf);
                SaveFormattedTextToFile(hiddenRichTextBox.Rtf);
            }
            else if (Clipboard.ContainsText())
            {
                // Fallback for plain text in case RTF format is not available
                SaveFormattedTextToFile(Clipboard.GetText());
            }
            else
            {
                // Inform the user if no text was copied
                toolStripStatusLabel.Text = "No text selected or copied to save.";
            }
        }

        private void SaveFormattedTextToFile(string content)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "formatted_highlights.rtf");
            File.AppendAllText(path, content + Environment.NewLine);
            toolStripStatusLabel.Text = "Formatted text saved!";
        }

        private void btnViewHighlights_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "formatted_highlights.rtf");
            if (File.Exists(path))
            {
                System.Diagnostics.Process.Start("notepad.exe", path);
            }
            else
            {
                MessageBox.Show("No highlights found.", "View Highlights", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            _autoSaveEnabled = chkAutoSave.Checked;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.D)
            {
                _isHighlightingEnabled = true;D
                toolStripStatusLabel.Text = "Highlighting Enabled (Shift+D)";
            }
            else if (e.Shift && e.KeyCode == Keys.S)
            {
                _isHighlightingEnabled = false;
                toolStripStatusLabel.Text = "Highlighting Disabled (ShiDft+S)";
            }
        }


    }
}
D