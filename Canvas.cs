using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frogtris
{
    class Canvas
    {
        public int Width;
        public int Height;
        public int[,] CenterArr;
        public int centerSize;
        public Graphics Canvas_Pic;
        public Bitmap Canvas_BM;
        public Graphics W_Canvas_Pic;
        public Bitmap W_Canvas_BM;
        public int score;
        public Canvas(int height, int width, int centerSize)
        {
            this.Width = width;
            this.Height = height;
            this.centerSize = centerSize;
        }

        public void loadCanvas(PictureBox Game)
        {
            Game.Width = Width * centerSize;
            Game.Height = Height * centerSize;
            Canvas_BM = new Bitmap(Game.Width, Game.Height);
            Canvas_Pic = Graphics.FromImage(Canvas_BM);
            Canvas_Pic.FillRectangle(Brushes.Black, 0, 0, Canvas_BM.Width, Canvas_BM.Height);
            Game.BackgroundImage = Canvas_BM;
            CenterArr = new int[Width, Height];
        }

        public void UpdateCenterArr(Shapes CS,int CurrX,int CurrY, Timer T1, PictureBox FrogPic, Frogs pepe)
        {
            bool con; ;
            for (int i = 0; i < CS.Width; i++)
                for (int j = 0; j < CS.Height; j++)
                    if (CS.Center[j, i] == 1)
                    {
                        con = checkIfGameOver(CurrY,T1,pepe,FrogPic);
                        if(con == true)
                            CenterArr[CurrX + i, CurrY + j] = 1;
                    }   
        }

        public bool checkIfGameOver(int CurrY, Timer T1,Frogs pepe,PictureBox FrogPic)
        {
            bool con = true;
            if (CurrY < 0)
            {
                T1.Stop();
                con = false;
                FrogPic.Image = pepe.Sad;
                MessageBox.Show("Game Over");
                Application.Exit();
            }
            return con;
        }

        public void DrawShapeOnCanvas(Shapes CS,PictureBox Game,int CurrX,int CurrY)
        {
            W_Canvas_BM = new Bitmap(Canvas_BM);
            W_Canvas_Pic = Graphics.FromImage(W_Canvas_BM);
            for (int i = 0; i < CS.Width; i++)
                for (int j = 0; j < CS.Height; j++)
                    if (CS.Center[j, i] == 1)
                        W_Canvas_Pic.DrawImage(CS.PIC, (CurrX + i) * centerSize, (CurrY + j) * centerSize, centerSize, centerSize);
            Game.Image = W_Canvas_BM;
        }


        public void ClearAndUpdateScore(Shapes CS,PictureBox PIC,Canvas Game,Timer T1,Label Score,Label Level)
        {
            int i, j;
            for (i = 0; i < Game.Height; i++)
            {
                for (j = Game.Width - 1; j >= 0; j--)
                    if (Game.CenterArr[j, i] == 0)
                        break;
                if (j == -1)
                {
                    score++;
                    Score.Text = "SCORE: " + score;
                    Level.Text = "LEVEL: " + score / 2;
                    T1.Interval -= 10;
                    for (j = 0; j < Game.Width; j++)
                    {
                        for (int k = i; k > 0; k--)
                            Game.CenterArr[j, k] = Game.CenterArr[j, k - 1];
                        Game.CenterArr[j, 0] = 0;
                    }
                }
            }
            for (i = 0; i < Game.Width; i++)
                for (j = 0; j < Game.Height; j++)
                {
                    Game.Canvas_Pic = Graphics.FromImage(Game.Canvas_BM);
                    Game.Canvas_Pic.DrawImage(Game.CenterArr[i, j] == 1 ? CS.PIC : Image.FromFile(@"..\..\black.png"), i * Game.centerSize, j * Game.centerSize, Game.centerSize, Game.centerSize);
                }
            PIC.Image = Game.Canvas_BM;
        }
    }
}
