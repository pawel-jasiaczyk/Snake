using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Forms
{
    class HeadSegment : Snake.Forms.Segment
    {
        public HeadSegment(GuiSettings guiSettings, Snake.Game.Segment head)
            : base(guiSettings, head)
        { }
    }
}
