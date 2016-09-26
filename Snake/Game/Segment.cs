using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Game
{
    class Segment
    {
        private int x, y;

        public int X
        {
            get { return x; }
            set { x = value;
                this.Move();
            }
        }
        public int Y
        {
            get { return y; }
            set {
                y = value;
                this.Move();
            }
        }

        public event EventHandler Moved;

        public virtual void Move()
        {
            if (this.Moved != null)
                Moved(this, new EventArgs());
        }
    }
}
