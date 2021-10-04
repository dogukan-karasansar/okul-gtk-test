using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    int i = 0;
    
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void bt1_clicked(object sender, EventArgs e)
    {
        i++;
        this.button1.ModifyBg(StateType.Normal, new Gdk.Color(90, 40, 36));
        ModifyBg(StateType.Normal, new Gdk.Color(225, 204, 100));
        this.label1.Text = "Hello " + i;        
    }
}
