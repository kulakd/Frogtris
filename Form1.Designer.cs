
namespace Frogtris
{
    partial class FrogTris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainGame = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ScoreLBL = new System.Windows.Forms.Label();
            this.LevelLBL = new System.Windows.Forms.Label();
            this.FrogPic = new System.Windows.Forms.PictureBox();
            this.NextShapePIC = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MusicLBL = new System.Windows.Forms.Label();
            this.conLBL = new System.Windows.Forms.Label();
            this.con1 = new System.Windows.Forms.Label();
            this.Con5 = new System.Windows.Forms.Label();
            this.CON3 = new System.Windows.Forms.Label();
            this.con2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrogPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextShapePIC)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGame
            // 
            this.MainGame.BackColor = System.Drawing.Color.Transparent;
            this.MainGame.Image = global::Frogtris.Properties.Resources.city1;
            this.MainGame.Location = new System.Drawing.Point(24, 12);
            this.MainGame.Name = "MainGame";
            this.MainGame.Size = new System.Drawing.Size(610, 737);
            this.MainGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainGame.TabIndex = 0;
            this.MainGame.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScoreLBL
            // 
            this.ScoreLBL.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLBL.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreLBL.Location = new System.Drawing.Point(640, 4);
            this.ScoreLBL.Name = "ScoreLBL";
            this.ScoreLBL.Size = new System.Drawing.Size(148, 50);
            this.ScoreLBL.TabIndex = 1;
            this.ScoreLBL.Text = "SCORE:  0";
            this.ScoreLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelLBL
            // 
            this.LevelLBL.BackColor = System.Drawing.Color.Transparent;
            this.LevelLBL.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LevelLBL.Location = new System.Drawing.Point(814, 0);
            this.LevelLBL.Name = "LevelLBL";
            this.LevelLBL.Size = new System.Drawing.Size(158, 54);
            this.LevelLBL.TabIndex = 2;
            this.LevelLBL.Text = "LEVEL: 0";
            this.LevelLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrogPic
            // 
            this.FrogPic.BackColor = System.Drawing.Color.Transparent;
            this.FrogPic.Image = global::Frogtris.Properties.Resources.pepe1;
            this.FrogPic.Location = new System.Drawing.Point(663, 96);
            this.FrogPic.Name = "FrogPic";
            this.FrogPic.Size = new System.Drawing.Size(293, 270);
            this.FrogPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FrogPic.TabIndex = 3;
            this.FrogPic.TabStop = false;
            // 
            // NextShapePIC
            // 
            this.NextShapePIC.BackColor = System.Drawing.Color.Transparent;
            this.NextShapePIC.Location = new System.Drawing.Point(644, 396);
            this.NextShapePIC.Name = "NextShapePIC";
            this.NextShapePIC.Size = new System.Drawing.Size(328, 109);
            this.NextShapePIC.TabIndex = 4;
            this.NextShapePIC.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(741, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Next Shape:";
            // 
            // MusicLBL
            // 
            this.MusicLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicLBL.BackColor = System.Drawing.Color.Lime;
            this.MusicLBL.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MusicLBL.Location = new System.Drawing.Point(663, 53);
            this.MusicLBL.Name = "MusicLBL";
            this.MusicLBL.Size = new System.Drawing.Size(293, 22);
            this.MusicLBL.TabIndex = 6;
            this.MusicLBL.Text = "MUSIC: ON";
            this.MusicLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conLBL
            // 
            this.conLBL.BackColor = System.Drawing.Color.Transparent;
            this.conLBL.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.conLBL.ForeColor = System.Drawing.Color.White;
            this.conLBL.Location = new System.Drawing.Point(640, 544);
            this.conLBL.Name = "conLBL";
            this.conLBL.Size = new System.Drawing.Size(332, 23);
            this.conLBL.TabIndex = 7;
            this.conLBL.Text = "CONTROLS:";
            this.conLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // con1
            // 
            this.con1.BackColor = System.Drawing.Color.Transparent;
            this.con1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.con1.Location = new System.Drawing.Point(644, 568);
            this.con1.Name = "con1";
            this.con1.Size = new System.Drawing.Size(328, 16);
            this.con1.TabIndex = 8;
            this.con1.Text = "LEFT/RIGHT ARROW --> MOVING LEFT/RIGHT";
            this.con1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Con5
            // 
            this.Con5.BackColor = System.Drawing.Color.Transparent;
            this.Con5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Con5.Location = new System.Drawing.Point(647, 621);
            this.Con5.Name = "Con5";
            this.Con5.Size = new System.Drawing.Size(325, 17);
            this.Con5.TabIndex = 9;
            this.Con5.Text = "SPACEBAR --> TURN MUSIC ON/OFF";
            this.Con5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CON3
            // 
            this.CON3.BackColor = System.Drawing.Color.Transparent;
            this.CON3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CON3.Location = new System.Drawing.Point(647, 601);
            this.CON3.Name = "CON3";
            this.CON3.Size = new System.Drawing.Size(313, 20);
            this.CON3.TabIndex = 10;
            this.CON3.Text = "DOWN ARROW --> INCREASE SPEED";
            this.CON3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // con2
            // 
            this.con2.BackColor = System.Drawing.Color.Transparent;
            this.con2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.con2.Location = new System.Drawing.Point(644, 584);
            this.con2.Name = "con2";
            this.con2.Size = new System.Drawing.Size(316, 17);
            this.con2.TabIndex = 11;
            this.con2.Text = "UP ARROW --> ROTATE BLOCK";
            this.con2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(650, 741);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Made by Dawid Kułakowski";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrogTris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Frogtris.Properties.Resources.city;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.con2);
            this.Controls.Add(this.CON3);
            this.Controls.Add(this.Con5);
            this.Controls.Add(this.con1);
            this.Controls.Add(this.conLBL);
            this.Controls.Add(this.MusicLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NextShapePIC);
            this.Controls.Add(this.FrogPic);
            this.Controls.Add(this.LevelLBL);
            this.Controls.Add(this.ScoreLBL);
            this.Controls.Add(this.MainGame);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrogTris";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MainGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrogPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextShapePIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ScoreLBL;
        private System.Windows.Forms.Label LevelLBL;
        private System.Windows.Forms.PictureBox FrogPic;
        private System.Windows.Forms.PictureBox NextShapePIC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MusicLBL;
        private System.Windows.Forms.Label conLBL;
        private System.Windows.Forms.Label con1;
        private System.Windows.Forms.Label Con5;
        private System.Windows.Forms.Label CON3;
        private System.Windows.Forms.Label con2;
        private System.Windows.Forms.Label label1;
    }
}

