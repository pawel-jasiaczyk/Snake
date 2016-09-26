using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake.Forms
{
    class Segment : Button
    {
        private Snake.Game.Segment segment;

        public Segment(GuiSettings guiSettings, Snake.Game.Segment segment)
        {
            this.Width = guiSettings.SegmentSize;
            this.Height = guiSettings.SegmentSize;

            this.segment = segment;
        }
    }
}
