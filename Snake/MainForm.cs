using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Snake.Game;
using Snake.Forms;

namespace Snake
{
    public partial class MainForm : Form
    {
        private GameFieldPanel gameFieldPanel;
        private Settings settings;
        private GuiSettings guiSettings;

        public MainForm()
        {
            InitializeComponent();
            this.settings = new Settings();
            this.guiSettings = new GuiSettings(this.settings);

            StartGame();
        }

        public void StartGame()
        {
            this.gameFieldPanel = new GameFieldPanel(this.guiSettings);
            this.gameFieldPanel.Visible = true;
            int border = 5;
            this.gameFieldPanel.Top = border;
            this.gameFieldPanel.Left = border;
            this.Controls.Add(gameFieldPanel);

            this.ClientSize = new Size
                (
                this.gameFieldPanel.Width + (2 * this.gameFieldPanel.Left),
                this.gameFieldPanel.Height + (2* this.gameFieldPanel.Top)
                );
        }
    }
}
