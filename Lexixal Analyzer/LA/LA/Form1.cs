using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FloatingPointRegexApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            string inputText = InputTextBox.Text;
            string regexPattern = @"^-?\d+(\.\d{1,6})?$"; // Regular expression pattern
            Regex regex = new Regex(regexPattern);

            // Clear previous results
            ResultsListBox.Items.Clear();

            // Match the input against the regular expression
            MatchCollection matches = regex.Matches(inputText);

            // Display the matching results
            foreach (Match match in matches)
            {
                ResultsListBox.Items.Add(match.Value);
            }
        }
    }
}
