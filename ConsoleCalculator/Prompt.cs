using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

public static class Prompt
{
    public static string ShowDialog(string text, string caption)
    {
        Form prompt = new Form()
        {
            Font = new Font("Verdena", 9),
            Width = 450,
            Height = 170,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = caption,
            StartPosition = FormStartPosition.CenterScreen
        };
        Label textLabel = new Label() { Left = 30, Top = 20, Text = text, Font = new Font("Verdena",10) };
        TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 390 , Font = new Font("Verdena", 9)};
        Button confirmation = new Button() { Text = "Ok", Left = 300, Width = 100, Height = 30, Top = 80,
            DialogResult = DialogResult.OK,
            Font = new Font("Verdena",12)};
        confirmation.Click += (sender, e) => { prompt.Close(); };
        prompt.Controls.Add(textBox);
        prompt.Controls.Add(confirmation);
        prompt.Controls.Add(textLabel);
        prompt.AcceptButton = confirmation;

        return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
    }
}
