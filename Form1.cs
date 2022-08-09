using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Frogtris
{
    public partial class FrogTris : Form
    {
        Canvas Game = new Canvas(37, 30, 20);
        SecondCanvas Nxt = new SecondCanvas(10, 30, 10);
        int currentX;
        int currentY;
        Shapes currentShape = new Shapes();
        Shapes nextShape = new Shapes();
        Frogs Pepe = new Frogs();
        bool music_control = true;

        public FrogTris()
        {
            InitializeComponent();
            Pepe.theme(@"..\..\TT.wav");
            Game.loadCanvas(MainGame);
            currentShape = RandomShapeStart();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 300;
            timer1.Start();
            this.KeyDown += FrogTris_KeyDown;
            nextShape = getNextShape();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var isMoveSuccess = moveShapeIfPossible(moveDown: 1);
            if (!isMoveSuccess)
            {
                Game.Canvas_BM = new Bitmap(Game.W_Canvas_BM);
                Game.UpdateCenterArr(currentShape, currentX, currentY, timer1, FrogPic, Pepe);

                currentShape = nextShape;
                nextShape = getNextShape();
                Game.ClearAndUpdateScore(currentShape, MainGame, Game, timer1, ScoreLBL, LevelLBL);
            }
            Pepe.WhichFrog(FrogPic, Game);
        }

        private void FrogTris_KeyDown(object sender, KeyEventArgs e)
        {
            var verticalMove = 0;
            var horizontalMove = 0;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    verticalMove--;
                    verticalMove--;
                    break;
                case Keys.Right:
                    verticalMove++;
                    verticalMove++;
                    break;
                case Keys.Down:
                    horizontalMove++;
                    break;
                case Keys.Up:
                    currentShape.TurnAroundShapes();
                    break;
                case Keys.Space:
                    music_control = !music_control;
                    Pepe.MusicOnOff(music_control, @"..\..\TT.wav", MusicLBL);
                    break;
                default:
                    return;
            }
            var isMoveSuccess = moveShapeIfPossible(horizontalMove, verticalMove);
            if (!isMoveSuccess && e.KeyCode == Keys.Up)
                currentShape.Rollback();
        }

        private bool moveShapeIfPossible(int moveDown = 0, int moveSide = 0)
        {
            var newX = currentX + moveSide;
            var newY = currentY + moveDown;
            if (newX < 0 || newX + currentShape.Width > Game.Width || newY + currentShape.Height > Game.Height)
                return false;
            for (int i = 0; i < currentShape.Width; i++)
                for (int j = 0; j < currentShape.Height; j++)
                    if (newY + j > 0 && Game.CenterArr[newX + i, newY + j] == 1 && currentShape.Center[j, i] == 1)
                        return false;
            currentX = newX;
            currentY = newY;
            Game.DrawShapeOnCanvas(currentShape, MainGame, currentX, currentY);
            return true;
        }

        private Shapes RandomShapeStart()
        {
            var shape = ShapesControl.RandomShape();
            currentX = 6;
            currentY = -shape.Height;
            return shape;
        }

        private Shapes getNextShape()
        {
            var shape = RandomShapeStart();
            Nxt.NextShapePic(shape, NextShapePIC);
            return shape;
        }
    }
}