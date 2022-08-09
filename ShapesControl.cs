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
    class ShapesControl
    {
        private static Shapes[] shapesArray;

        static ShapesControl()
        {
            shapesArray = new Shapes[]
                {
                    new Shapes{ Width = 4, Height = 4, Center = new int[,]{ {1,1,1,1},{1,1,1,1},{1,1,1,1},{1,1,1,1} } ,PIC = Image.FromFile(@"..\..\red.png")},
                    new Shapes{ Width = 2, Height = 6, Center = new int[,]{{1,1},{ 1,1},{1,1},{1,1},{1,1},{1,1}},PIC = Image.FromFile(@"..\..\Lime.png")},
                    new Shapes{ Width = 6, Height = 4, Center = new int[,]{{0,0,1,1,0,0},{0,0,1,1,0,0},{1,1,1,1,1,1},{1,1,1,1,1,1}},PIC = Image.FromFile(@"..\..\yellow.png")},
                    new Shapes{ Width = 6, Height = 4, Center = new int[,]{{0,0,0,0,1,1},{0,0,0,0,1,1},{1,1,1,1,1,1},{1,1,1,1,1,1}},PIC = Image.FromFile(@"..\..\blue.png")},
                    new Shapes{ Width = 6, Height = 4, Center = new int[,]{{1,1,0,0,0,0},{1,1,0,0,0,0},{1,1,1,1,1,1},{1,1,1,1,1,1}},PIC = Image.FromFile(@"..\..\orange.png")},
                    new Shapes{ Width = 6, Height = 4, Center = new int[,]{{1,1,1,1,0,0},{1,1,1,1,0,0},{0,0,1,1,1,1},{0,0,1,1,1,1}},PIC = Image.FromFile(@"..\..\purple.png")},
                    new Shapes{ Width = 6, Height = 4, Center = new int[,]{{0,0,1,1,1,1},{0,0,1,1,1,1},{1,1,1,1,0,0},{1,1,1,1,0,0}},PIC = Image.FromFile(@"..\..\green.png")},
                    new Shapes{ Width = 6, Height = 4, Center = new int[,]{{1,1,0,0,1,1 },{1,1,0,0,1,1 },{1,1,1,1,1,1 },{1,1,1,1,1,1}},PIC = Image.FromFile(@"..\..\pink.png")}
                };
        }

        public static Shapes RandomShape()
        {
            var shape = shapesArray[new Random().Next(shapesArray.Length)];
            return shape;
        }
    }
}

