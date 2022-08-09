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
    class Shapes
    {
        public int Width;
        public int Height;
        public int[,] Center;
        public Image PIC;
        private int[,] prevCenter;
       
        public void TurnAroundShapes()
        {
            prevCenter = Center;
            Center = new int[Width, Height];
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    Center[i, j] = prevCenter[Height - 1 - j, i];

            var temp = Width;
            Width = Height;
            Height = temp;
        }

        public void Rollback()
        {
            Center = prevCenter;
            var temp = Width;
            Width = Height;
            Height = temp;
        }
    }
}