using System;
using Eto.Forms;

namespace minimaleto.WinForms
{
    internal static class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
            new Application(Eto.Platforms.WinForms).Run(new MainForm());
        }
    }
}