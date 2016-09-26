using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Game
{
    class Head : Segment
    {
        private Direction direcrtion;

        public Head()
        {
            this.direcrtion = Direction.Up;
        }

        public void UpdatePosition()
        {
            switch (this.direcrtion)
            {
                case Direction.Up:
                    {
                        this.Y--;
                        break;
                    }
                case Direction.Down:
                    {
                        this.Y++;
                        break;
                    }
                case Direction.Left:
                    {
                        this.X--;
                        break;
                    }
                case Direction.Rights:
                    {
                        this.X++;
                        break;
                    }
            }
        }
    }
}
