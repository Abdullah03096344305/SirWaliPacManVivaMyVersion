using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using PacMan.GameGL;
using EZInput;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacManGUI
{
    public partial class Level2Form : Form
    {
        Game game;
        GameCollisionDetector collider;
        int StarPoints = 0;
        int playerhealth = 0;
        int playerScore = 0;
        public Level2Form()
        {
            InitializeComponent();
            game = new Game(this);
            collider = new GameCollisionDetector();
        }

        private void Level2Form_Load(object sender, EventArgs e)
        {
            GameGhostVertical gv1 = new GameGhostVertical(game.getBlueGhostImage(), game.getCell(3, 6));
            GameGhostVertical gv3 = new GameGhostVertical(game.getBlueGhostImage(), game.getCell(7, 10));
            GameGhostHorizontal gv2 = new GameGhostHorizontal(game.getOrangeGhostImage(), game.getCell(3, 12));
            GameGhostRandom gv4 = new GameGhostRandom(game.getRedGhostImage(), game.getCell(10, 12));

            game.addGhost(gv1);
            game.addGhost(gv2);
            game.addGhost(gv3);
            game.addGhost(gv4);
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            movePacMan();
            moveGhosts();
            showScore();
            NewGameScenario();
        }
        public void moveGhosts()
        {
            foreach (GameGhost g in game.ghosts)
            {
                if (collider.isGhostCollideWithPacMan(g))
                {
                    game.decreaseHealthpoints(-1);
                }

                g.move(g.nextCell());


            }
        }
        private void showScore()
        {

            lblScoreValue.Text = game.getScore().ToString();
            labelHealthValue.Text = game.getHealth().ToString();
            labelStarValue.Text = game.getStarPoints().ToString();

        }
        private void NewGameScenario()
        {
            StarPoints = game.getStarPoints();
            playerhealth = game.getHealth();
            playerScore = game.getScore();
            if (StarPoints == 3)
            {
                Form form2 = new YouWinForm();
                form2.Show();
            }
            else if (playerhealth == 0)
            {
                Form form2 = new GameOverForm();
                form2.Show();
            }
            else if (playerScore == 10)
            {
                game.addScorePoints(1);
            }
        }
        private void movePacMan()
        {
            GamePacManPlayer pacman = game.getPacManPlayer();
            GameCell potentialNewCell = pacman.CurrentCell;
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                potentialNewCell = pacman.CurrentCell.nextCell(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                potentialNewCell = pacman.CurrentCell.nextCell(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                potentialNewCell = pacman.CurrentCell.nextCell(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                potentialNewCell = pacman.CurrentCell.nextCell(GameDirection.Down);
            }
            GameCell currentCell = pacman.CurrentCell;
            currentCell.setGameObject(Game.getBlankGameObject());
            if (collider.isPacManCollideWithPallet(potentialNewCell))
            {
                game.addScorePoints(1);
            }
            if (collider.isPacManCollideWithStar(potentialNewCell))
            {
                game.addStarPoints(1);
            }
            pacman.move(potentialNewCell);
        }
    }
}
