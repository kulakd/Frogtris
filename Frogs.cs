using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Media;
namespace Frogtris
{
    class Frogs
    {
        public Image Stage1;
        public Image Stage2;
        public Image Stage3;
        public Image Stage4;
        public Image Sad;
        string path = @"..\..\pepe1.png";
        string path_2 = @"..\..\pepe2.png";
        string path_3 = @"..\..\pepe3.png";
        string path_4 = @"..\..\pepe4.png";
        string path_5 = @"..\..\pepeL.png";

        public Frogs()
        {
            Sad = Image.FromFile(path_5);
            Stage1 = Image.FromFile(path);
            Stage2 = Image.FromFile(path_3);
            Stage3 = Image.FromFile(path_4);
            Stage4 = Image.FromFile(path_2);
        }

        public void theme(string file)
        {
            SoundPlayer themes = new SoundPlayer(file);
            themes.PlayLooping();
        }

        public void theme_2(string file)
        {
            SoundPlayer themes = new SoundPlayer(file);
            themes.Stop();
        }

        public void MusicOnOff(bool control,string file,Label Msc)
        {
            if (control == true)
            {
                theme(file);
                Msc.BackColor = Color.Green;
                Msc.Text = "MUSIC: ON";
            }
            else
            {
                theme_2(file);
                Msc.BackColor = Color.Red;
                Msc.Text = "MUSIC: OFF";
            }
        }

        public void WhichFrog(PictureBox Frog,Canvas Game)
        {
            if (Game.score < 4)
                Frog.Image = Stage1;
            if(Game.score>=4 && Game.score<8)
                Frog.Image = Stage2;
            if (Game.score >= 8 && Game.score < 12)
                Frog.Image = Stage3;
            if (Game.score >= 12)
                Frog.Image = Stage4;
        }
    }
}
