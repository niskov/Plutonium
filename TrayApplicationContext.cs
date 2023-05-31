using System;
using System.Drawing;
using System.Windows.Forms;

public class TrayApplicationContext : ApplicationContext
{
    private NotifyIcon trayIcon;

    public TrayApplicationContext()
    {
        trayIcon = new NotifyIcon()
        {
            Icon = SystemIcons.Application, // Set this to your own icon
            ContextMenuStrip = new ContextMenuStrip
            {
                Items =
                {
                    new ToolStripMenuItem("Example Item", null, ExampleItem_Click),
                    new ToolStripMenuItem("Exit", null, Exit_Click),
                }
            },
            Visible = true
        };
    }

    void ExampleItem_Click(object sender, EventArgs e)
    {
        // This is where you would put your code to perform whatever action you want when the context menu item is clicked
        MessageBox.Show("You clicked the example item!");
    }

    void Exit_Click(object sender, EventArgs e)
    {
        // The user wants to exit the application. Close everything down.
        Application.Exit();
    }
}
