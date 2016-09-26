using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Snake.Game;

namespace Snake.Forms
{
    class GameFieldPanel : Panel
    {
        private GuiSettings guiSettings;
        private Game.Game game;

        public GameFieldPanel(Snake.Forms.GuiSettings guiSettings)
        {
            this.game = new Game.Game(guiSettings.GameSettings);
            this.guiSettings = guiSettings;
            this.Width = guiSettings.GameSettings.GamePoolWidth * guiSettings.SegmentSize;
            this.Height = guiSettings.GameSettings.GamePoolHeight * guiSettings.SegmentSize;
            this.BackColor = guiSettings.GameFieldColor;
            this.ForeColor = guiSettings.GameFieldColor;
        }
    }
}
