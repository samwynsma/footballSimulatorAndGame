using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic.ApplicationServices;

public class MainMenu : Form
{
    public MainMenu()
    {
        this.Text = "Football Simulation Game";
        this.Size = new Size(1000, 400);
        this.StartPosition = FormStartPosition.CenterScreen;

        GroupBox footballField = new GroupBox();
        footballField.Location = new Point(50, 50);
        footballField.Size = new Size(900, 200);
        footballField.Text = "Field";
        footballField.BackColor = Color.Green;
        footballField.Paint += (sender, e) =>
        {
            int lineCount = 100;
            int clearance = 50;
            int availableWidth = footballField.ClientSize.Width - (clearance * 2);
            int step = availableWidth / lineCount;

            using (Pen linePen = new Pen(Color.White, 1))
            {
                for (int i = 0; i < lineCount; i++)
                {
                    int x = clearance + (i * step);
                    e.Graphics.DrawLine(linePen, x, 20, x, footballField.ClientSize.Height - 10);
                }
            }
        };
        this.Controls.Add(footballField);

    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainMenu());
    }
}

