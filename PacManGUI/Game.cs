using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace PacMan.GameGL
{
    public class Game
    {
        GamePacManPlayer pacman;
        GameGrid grid;
        public List<GameGhost> ghosts;
        int score = 0;
        int health = 5;
        int starPoints = 0;
        int finalstarPoints;
        Form gameGUI;
        public Game(Form gameGUI)
        {
            finalstarPoints = getStarPoints();
            if(finalstarPoints == 0)
            {
                this.gameGUI = gameGUI;
                grid = new GameGrid("maze.txt", 17, 38);
                Image pacManImage = Game.getGameObjectImage('P');
                ghosts = new List<GameGhost>();
                GameCell startCell = grid.getCell(7, 9);
                pacman = new GamePacManPlayer(pacManImage, startCell);
                printMaze(grid);
            }
            if(finalstarPoints == 3)
            {
                setStarPoints(0);
                this.gameGUI = gameGUI;
                grid = new GameGrid("maze2.txt", 17, 38);
                Image pacManImage = Game.getGameObjectImage('P');
                ghosts = new List<GameGhost>();
                GameCell startCell = grid.getCell(7, 9);
                pacman = new GamePacManPlayer(pacManImage, startCell);
                printMaze(grid);               
            }
            
           

        }
        public GameCell getCell(int x, int y) {
            return grid.getCell(x, y);
        }
        public void addGhost(GameGhost ghost) {
            ghosts.Add(ghost);
        }
        public GamePacManPlayer getPacManPlayer() {
            return pacman;
        }
        public void decreaseHealthpoints(int points)
        {
            this.health = health + points;
        }
        public void addScorePoints(int points) {
            this.score = score + points;
        }

        public void addStarPoints(int points)
        {
            this.starPoints = starPoints + points;
        }
        public int getScore() {
            return score;
        }
        public int getStarPoints()
        {
            return starPoints;
        }
        public void setStarPoints(int starPoints)
        {
            this.starPoints = starPoints;
        }
        public int getHealth()
        {
            return health;
        }
        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {

                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    gameGUI.Controls.Add(cell.PictureBox);
                    //        printCell(cell);
                }

            }
        }

        public static GameObject getBlankGameObject() {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, PacManGUI.Properties.Resources.simplebox);
            return blankGameObject;
        }
        public Image getBlueGhostImage() {
                return PacManGUI.Properties.Resources.ZombieUp;
        }

        public Image getRedGhostImage()
        {
            return PacManGUI.Properties.Resources.RedAngryEnemy;
        }

        public Image getPinkGhostImage()
        {
            return PacManGUI.Properties.Resources.FireEnemy;
        }
        public Image getOrangeGhostImage()
        {
            return PacManGUI.Properties.Resources.GhostEnemy;
        }

        public static Image getGameObjectImage(char displayCharacter)
        {
            
            Image img = PacManGUI.Properties.Resources.simplebox;
          

            if (displayCharacter == '|' || displayCharacter == '%')
            {
                img = PacManGUI.Properties.Resources.BrownBlock;
            }

            if (displayCharacter == '#')
            {
                img = PacManGUI.Properties.Resources.BrownBlock;
            }
            if (displayCharacter == ',')
            {
                img = PacManGUI.Properties.Resources.download_removebg_preview;
            }

            if (displayCharacter == '.')
            {
                img = PacManGUI.Properties.Resources.pallet;
            }
            if (displayCharacter == 'P' || displayCharacter == 'p') {
                img = PacManGUI.Properties.Resources.pacman_open;
            }

            return img;
        }
    }
}
