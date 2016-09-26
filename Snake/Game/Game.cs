using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Game
{
    class Game
    {
        private GamePoolType[,] gamePool;
        private List<Segment> snake;
        private System.Timers.Timer mainTimer;
        private Segment food;
        private Settings settings;
        
        

        public Game(Settings settings)
        {
            this.settings = settings;
            this.mainTimer = new System.Timers.Timer();
            this.gamePool = new GamePoolType[settings.GamePoolWidth, settings.GamePoolHeight];
            this.snake = new List<Segment>();
            this.food = new Segment();
        }

        public void StartGame()
        {
            this.mainTimer.Start();
        }

        public void PauseGame()
        {
            this.mainTimer.Stop();
        }

        private void UpadePositions()
        {
            for (int i = snake.Count; i >= 0; i--)
            {
                if (snake[i] is Tail)
                {
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
                else if (snake[i] is Head)
                {
                    (snake[i] as Head).UpdatePosition();
                }
            }
        }

        private void PlaceFood()
        {
            for (int i = 0; i < this.settings.GamePoolWidth; i++)
            {
                for (int j = 0; j < this.settings.GamePoolHeight; j++)
                {
                    this.gamePool[i,j] = GamePoolType.Free;
                }
            }

            gamePool[snake[0].X, snake[0].Y] = GamePoolType.Head;
            for (int i = 1; i < snake.Count; i++)
            {
                gamePool[snake[i].X, snake[i].Y] = GamePoolType.Tail;
            }

            List<Segment> freePoitions = new List<Segment>();
            for (int i = 0; i < settings.GamePoolWidth; i++)
            {
                for (int j = 0; j < settings.GamePoolHeight; j++)
                {
                    if (gamePool[i, j] == GamePoolType.Free)
                    {
                        Segment s = new Segment();
                        s.X = i;
                        s.Y = j;
                        freePoitions.Add(s);
                    }
                }
            }

            Random rand = new Random();
            int r = rand.Next(0, freePoitions.Count - 1);
            this.food = freePoitions[r];
        }
    }
}
