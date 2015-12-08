using System;


namespace Sinoptik
{
    public class StartApp
    {
        [STAThread()]
        static void Main()
        {
            App a = new App();

            View.MainWindow wnd = new View.MainWindow();

            a.Run(wnd);
        }
    }
}
