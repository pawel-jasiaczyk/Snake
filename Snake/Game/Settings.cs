using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Game
{
    class Settings
    {
        public int GamePoolWidth { get; set; }
        public int GamePoolHeight { get; set; }

        public Settings()
        {
            this.GamePoolHeight = 50;
            this.GamePoolWidth = 50;
        }
    }
}
