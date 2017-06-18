using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    public class PanelProperties
    {
        public partial class StandaardPanel : Panel
        {
            public StandaardPanel()
            {
                Size = new Size(1160, 695);
                Location = new Point(0, 0);
                BackColor = Color.LightSteelBlue;
            }
        }
    }
}
