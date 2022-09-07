using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrushkovPractica
{
    public partial class AnimationForm : Form
    {
        Transformation tr = new Transformation();
        Transformation tr1 = new Transformation();
        Transformation tr2 = new Transformation();
        Transformation tr3 = new Transformation();
        Transformation tr4 = new Transformation();
        Gear gr = new Gear();
        Timer tm = new Timer();
        DrawObjects dr = new DrawObjects();
      public  int speed =100;
        public float speedGears = 20;
        public float speedminut = 10;
        public float speedHours = 1;
        public AnimationForm()
        {
            InitializeComponent();

            tm.Tick += FixedUpdate;
            
        }

        private void AnimationForm_Load(object sender, EventArgs e)
        {
            tm.Start();
            tr.localCoordinates = gr.СlovePointReturn();
           
                tr.Number(50, 50, 0, 250, 50);
            tr1.localCoordinates = gr.СlovePointReturn();
            tr1.Number(50, 50, 45, 250, 50);
            tr2.localCoordinates = gr.Clock();
            tr2.Number(50, 50, 0, 50, 100);
            tr3.localCoordinates = gr.Strelka();
            tr3.Number(50, 50, 0, 75, 125);
            tr4.localCoordinates = gr.Strelka();
            tr4.Number(50, 50, 0, 75, 125);
        
    }





        public void FixedUpdate(object sender, EventArgs e)
        {
            tm.Interval = speed* 10;

            tr.Rotation(speedGears);
            tr1.Rotation(-speedGears);
            tr2.Rotation(10);
            tr3.Rotation(speedminut);
            tr4.Rotation(speedHours);
            animPanel.Invalidate();
        }

        private void DrawObjects(object sender, PaintEventArgs e)
        {
           
            dr.DrawGear(e.Graphics, tr.WorldCoord, 0, 0);
            dr.DrawGear(e.Graphics, tr1.WorldCoord, 80, 80);
            dr.DrawGear(e.Graphics, tr.WorldCoord, 80, 195);
            dr.DrawLine(e.Graphics);
            Font f = new Font(this.Font, FontStyle.Regular);
            dr.DrawClock(e.Graphics, tr2.WorldCoord, 0, 75,f);
            dr.DrawStrelka(e.Graphics, tr3.WorldCoord, 0, 0, f);
            dr.DrawStrelka(e.Graphics, tr4.WorldCoord, 0, 0, f);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                speed = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                speedGears = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                speedminut = Convert.ToInt32(textBox3.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            try
            {
                speedHours = Convert.ToInt32(textBox4.Text);
            }
            catch (Exception ex)
            {

            }
        }
    }
    public class DrawObjects
    {
        float centerX = 0;
        float centerY = 0;
        public void DrawGear(Graphics g, List<PointF> localCoord, float shiftX, float shiftY)
        {
            if (localCoord.Count > 15)
            {   
                    
             
                PointF[] p = new PointF[16];
                for (int i = 0; i < 16; i++) {
                    p[i] = new PointF(localCoord[i].X+ shiftX,localCoord[i].Y+shiftY);
                        }

                g.FillPolygon(Brushes.Gray, p);

                if (centerX == 0)
                {
                    for (int i = 0; i < localCoord.Count; i++)
                    {


                        centerX += localCoord[i].X / localCoord.Count;
                        centerY += localCoord[i].Y / localCoord.Count;
                    }
                }
                g.FillEllipse(Brushes.Black, centerX+shiftX, centerY+shiftY, 5, 5);

            }
        }



        public void DrawLine(Graphics g)
        {
            g.DrawLine(Pens.Black, 200, 0, 230, 50);
            g.DrawLine(Pens.Black, 230, 50, 200, 100);
            g.DrawLine(Pens.Black, 200, 100, 230, 150);
            g.DrawLine(Pens.Black, 230, 150, 200, 200);
            g.DrawLine(Pens.Black, 200, 200, 230,250);
            g.DrawLine(Pens.Black, 230, 250, 200, 300);
            g.DrawLine(Pens.Black, 200, 300, 230, 350);
            g.DrawLine(Pens.Black, 230, 350, 200, 400);
            g.DrawLine(Pens.Black, 200, 400, 230, 450);
            g.DrawLine(Pens.Black, 230, 450, 200, 500);
            g.DrawLine(Pens.Black, 200, 500, 230, 550);
            g.DrawLine(Pens.Black, 230, 550, 200, 600);
            g.DrawLine(Pens.Black, 200, 600, 230, 650);
            
        }

        public void DrawClock(Graphics g, List<PointF> localCoord, float shiftX, float shiftY, Font f)
        {
            g.DrawEllipse(Pens.Black, shiftX, shiftY, 200, 200);

            g.DrawString("12",f, Brushes.Black, shiftX+90, shiftY+10);
            g.DrawString("1", f, Brushes.Black, shiftX + 130, shiftY + 20);
            g.DrawString("2", f, Brushes.Black, shiftX + 160, shiftY + 40);
            g.DrawString("3", f, Brushes.Black, shiftX + 180, shiftY + 90);
            g.DrawString("4", f, Brushes.Black, shiftX + 160, shiftY + 140);
            g.DrawString("5", f, Brushes.Black, shiftX + 130, shiftY + 170);
            g.DrawString("6", f, Brushes.Black, shiftX + 90, shiftY + 180);
            g.DrawString("7", f, Brushes.Black, shiftX + 60, shiftY + 170);
            g.DrawString("8", f, Brushes.Black, shiftX + 30, shiftY + 140);
            g.DrawString("9", f, Brushes.Black, shiftX + 20, shiftY + 90);
            g.DrawString("10", f, Brushes.Black, shiftX + 30, shiftY + 40);
            g.DrawString("11", f, Brushes.Black, shiftX + 60, shiftY + 20);

          
        }
        public void DrawStrelka(Graphics g, List<PointF> localCoord, float shiftX, float shiftY, Font f)
        {
            g.DrawLine(Pens.Black, localCoord[0].X , localCoord[0].Y , localCoord[1].X , localCoord[1].Y );
           
        }
        }
    public class Transformation
    {
        float widht, height, rotation, x, y;
        public List<PointF> localCoordinates;
        protected List<PointF> sceneCoord = new List<PointF>();
        int count1 = 0;
        public List<PointF> LocalCoord
        {
            get
            {
                return LocalCoord;
            }
            set
            {
                localCoordinates = value;
            }
        }
        public List<PointF> WorldCoord
        {

            get
            {
                return sceneCoord;
            }



        }

        public void Number(float widht, float height, float rotation, float x, float y)
        {

            if (localCoordinates != null)
            {
                for (int ir = 0; ir < localCoordinates.Count; ir++)
                {
                    this.widht = widht;
                    this.height = height;
                    this.rotation = rotation;
                    this.x = x;
                    this.y = y;
                    AnimationForm an = new AnimationForm();

                    float[,] M0 = new float[3, 3];
                    M0[0, 0] = 1;
                    M0[0, 1] = 0;
                    M0[0, 2] = 0;
                    //Второй столбец
                    M0[1, 0] = 0;
                    M0[1, 1] = 1;
                    M0[1, 2] = 0;
                    //Третий столбец
                    M0[2, 0] = localCoordinates[count1].X;
                    M0[2, 1] = localCoordinates[count1].Y;
                    M0[2, 2] = 1;

                    float xc = 0;
                    float yc = 0;
                    float count = this.localCoordinates.Count;
                    float numberPoints = 1 / count;
                    for (int i = 0; i < localCoordinates.Count; i++)
                    {
                        xc += numberPoints * (this.localCoordinates[i].X);
                        yc += numberPoints * (this.localCoordinates[i].Y);

                    }
                    /*if (localCoordinates.Count != count1)
                    {
                        xc += numberPoints * (this.localCoordinates[count1].X);
                        yc += numberPoints * (this.localCoordinates[count1].Y);

                    }*/


                    //Матрица локальных кооринат
                    float[,] M1 = new float[3, 3];
                    //Первый столбец
                    M1[0, 0] = 1;
                    M1[0, 1] = 0;
                    M1[0, 2] = 0;
                    //Второй столбец
                    M1[1, 0] = 0;
                    M1[1, 1] = 1;
                    M1[1, 2] = 0;
                    //Третий столбец
                    M1[2, 0] = -xc;
                    M1[2, 1] = -yc;
                    M1[2, 2] = 1;

                    //Матрицы размера
                    float[,] M2 = new float[3, 3];
                    //Первый стобец
                    M2[0, 0] = widht;
                    M2[0, 1] = 0;
                    M2[0, 2] = 0;
                    //Второй столбец
                    M2[1, 0] = 0;
                    M2[1, 1] = height;
                    M2[1, 2] = 0;
                    //Третий столбец
                    M2[2, 0] = 0;
                    M2[2, 1] = 0;
                    M2[2, 2] = 1;

                    double radians = rotation * (Math.PI / 180);
                    float cosa = float.Parse(Math.Cos(radians).ToString());
                    float sina = float.Parse(Math.Sin(radians).ToString());
                    float[,] M3 = new float[3, 3];
                    //Первый стобец
                    M3[0, 0] = cosa;
                    M3[0, 1] = sina;
                    M3[0, 2] = 0;
                    //Второй столбец
                    M3[1, 0] = -sina;
                    M3[1, 1] = cosa;
                    M3[1, 2] = 0;
                    //Третий столбец
                    M3[2, 0] = 0;
                    M3[2, 1] = 0;
                    M3[2, 2] = 1;

                    float[,] M4 = new float[3, 3];
                    //Первый стобец
                    M4[0, 0] = 1;
                    M4[0, 1] = 0;
                    M4[0, 2] = 0;
                    //Второй столбец
                    M4[1, 0] = 0;
                    M4[1, 1] = 1;
                    M4[1, 2] = 0;
                    //Третий столбец
                    M4[2, 0] = x;
                    M4[2, 1] = y;
                    M4[2, 2] = 1;

                    //Соотношение сторон экрана
                    float widthSreen = an.Size.Width;
                    float heightSreen = an.Size.Height;
                    float aspectRatioScreen = widthSreen / heightSreen;
                    //Соотношение сторон сцены
                    float widthScene = an.animPanel.Size.Width;
                    float aspectRatioScene = widthScene / aspectRatioScreen;
                    //Параметры пробразования по оси х
                    float ax = (widthSreen - 1) / widthScene;
                    float bx = 0 - ax * 0;
                    //Параметры пробразования по оси у
                    float ay = heightSreen / aspectRatioScene;
                    float by = 0 - ay * 0;

                    float[,] M5 = new float[3, 3];
                    //Первый стобец
                    M5[0, 0] = ax;
                    M5[0, 1] = 0;
                    M5[0, 2] = 0;
                    //Второй столбец
                    M5[1, 0] = 0;
                    M5[1, 1] = ay;
                    M5[1, 2] = 0;
                    //Третий столбец
                    M5[2, 0] = bx;
                    M5[2, 1] = by;
                    M5[2, 2] = 1;


                    float[,] f = new float[3, 3];
                    float[,] temp = new float[3, 3];

                    //M0-m1
                    f = Mult(M0, M1);
                    //M1-M2
                    temp = Mult(f, M2);
                    //-----M3
                    f = Mult(temp, M3);
                    // ------M4
                    temp = Mult(f, M4);
                    //-------M5
                    f = Mult(temp, M5);

                    sceneCoord.Add(new PointF(0, 0));
                    sceneCoord[count1] = new PointF(f[2, 0], f[2, 1]);
                    count1++;
                    if (count1 == localCoordinates.Count)
                    {
                        count1 = 0;
                    }

                }
            }


        }
        public float[,] Mult(float[,] M1, float[,] M2)
        {
            float[,] f = new float[3, 3];
            f[0, 0] = (M1[0, 0] * M2[0, 0] + M1[0, 1] * M2[1, 0] + M1[0, 2] * M2[2, 0]);
            f[1, 0] = (M1[1, 0] * M2[0, 0] + M1[1, 1] * M2[1, 0] + M1[1, 2] * M2[2, 0]);
            f[2, 0] = (M1[2, 0] * M2[0, 0] + M1[2, 1] * M2[1, 0] + M1[2, 2] * M2[2, 0]);
            f[0, 1] = (M1[0, 0] * M2[0, 1] + M1[0, 1] * M2[1, 1] + M1[0, 2] * M2[2, 1]);
            f[1, 1] = (M1[1, 0] * M2[0, 1] + M1[1, 1] * M2[1, 1] + M1[1, 2] * M2[2, 1]);
            f[2, 1] = (M1[2, 0] * M2[0, 1] + M1[2, 1] * M2[1, 1] + M1[2, 2] * M2[2, 1]);
            f[0, 2] = (M1[0, 0] * M2[0, 2] + M1[0, 1] * M2[1, 2] + M1[0, 2] * M2[2, 2]);
            f[1, 2] = (M1[1, 0] * M2[0, 2] + M1[1, 1] * M2[1, 2] + M1[1, 2] * M2[2, 2]);
            f[2, 2] = (M1[2, 0] * M2[0, 2] + M1[2, 1] * M2[1, 2] + M1[2, 2] * M2[2, 2]);
            return f;
        }





        public void Translate(float deltaX, float deltaY)
        {

            x += deltaX;
            y += deltaY;


            Number(widht, height, rotation, x, y);


        }
        public void Rotation(float corne)
        {
            rotation += corne;


            Number(widht, height, rotation, x, y);

        }
        public void Scale(float scaleX, float scaleY)
        {

            widht += scaleX;
            height += scaleY;


            Number(widht, height, rotation, x, y);

        }
    }
}


