using Eto.Forms;
using Eto.Drawing;

namespace minimaleto
{
    public sealed class MainForm : Form
    {
        public MainForm()
        {
            Title = "minimaleto";
            ClientSize = new Size(400, 350);

            Content = new StackLayout
            {
                Items =
                {
                    "Hello World!",
                    // add more controls here
                }
            };
        }
    }
}