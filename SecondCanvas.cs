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
    class SecondCanvas
    {
        public Bitmap Next_Canvas_BM;
        public Graphics Next_Canvas_PIC;
        public int Width;
        public int Height;
        public int centerSize;

        public SecondCanvas(int height, int width, int centerSize)
        {
            this.Width = width;
            this.Height = height;
            this.centerSize = centerSize;
        }

        public void NextShapePic(Shapes shape,PictureBox NextShapePIC)
        {
            Next_Canvas_BM = new Bitmap(Width * centerSize, Height * centerSize);
            Next_Canvas_PIC = Graphics.FromImage(Next_Canvas_BM);
            Next_Canvas_PIC.FillRectangle(Brushes.Black, 0, 0, Next_Canvas_BM.Width, Next_Canvas_BM.Height);
            var startX = (30 - shape.Width) / 2;
            var startY = (10 - shape.Height) / 2;
            for (int i = 0; i < shape.Height; i++)
                for (int j = 0; j < shape.Width; j++)
                    Next_Canvas_PIC.DrawImage(shape.Center[i, j] == 1 ? shape.PIC : Image.FromFile(@"..\..\black.png"), (startX + j) * centerSize, (startY + i) * centerSize, centerSize, centerSize);
            NextShapePIC.Size = Next_Canvas_BM.Size;
            NextShapePIC.Image = Next_Canvas_BM;
        }
    }
}
