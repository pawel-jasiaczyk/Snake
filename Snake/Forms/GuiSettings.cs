using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake.Forms
{
    class GuiSettings
    {
        #region Private Variables

        private Snake.Game.Settings settings;

        #endregion

        #region Properties

        public Snake.Game.Settings GameSettings { get { return this.settings; } }
        public int SegmentSize { get; set; }
        public Color GameFieldColor { get; set; }

        #endregion
        
        #region C'tors

        public GuiSettings(Snake.Game.Settings settings)
        {
            this.settings = settings;

            // default settings
            this.SegmentSize = 10;
            this.GameFieldColor = Color.Green;
        }

        #endregion
    }
}
