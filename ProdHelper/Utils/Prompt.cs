namespace ProdHelper.Utils
{
    public class Prompt
    {
        public static string ShowDialog(string text, string caption, string currentValue = "")
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                TopLevel = true,
                TopMost = true
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400, Text = currentValue };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : currentValue;
        }
    }
}
