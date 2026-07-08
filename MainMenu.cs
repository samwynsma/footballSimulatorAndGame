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

