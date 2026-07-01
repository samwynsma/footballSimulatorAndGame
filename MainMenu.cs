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
        this.Size = new Size(400, 1000);
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainMenu());
    }
}

