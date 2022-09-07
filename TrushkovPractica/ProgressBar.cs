using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace TrushkovPractica
{
    public partial class ProgressBar : Form
    {
        ProgreeBarMy prb = new ProgreeBarMy();
        Timer tm = new Timer();
        public Graphics gr;

        public int temptNumber;
        public ProgressBar()
        {
            InitializeComponent();
           
            tm.Interval = 100;

          
            tm.Tick += UpdateForm;
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {
            tm.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
         
            
        }
       
       
        private void PaintPictureBox(object sender, PaintEventArgs e)
        {

           

            prb.DrawProgressBar(20, 20, 230, 310, e.Graphics);
            

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(minTextBox.Text);
                prb.minValue = value;
            }
            catch (Exception er)
            {
                int value = 0;
                prb.minValue = value;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(maxTextBox.Text);
                prb.maxValue = value;
            }
            catch(Exception er)
            {
                int value = 0;
                prb.maxValue = value;
            }
            }

        private void ChangeValue(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(valueTecTextBox.Text);
                prb.tecValue = value;
            }
            catch (Exception er)
            {


            }
        }
      
     

        private void UpdateForm(object sender, EventArgs e)
        {
           
            
            gr = Graphics.FromImage(pictureBox1.InitialImage);

            Rectangle reg = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);
          
          
            prb.CopingFiles();
            pictureBox1.Invalidate();
           
            prb.DrawProgressBar(20, 20, 230, 230, gr);
          
            Invalidate(reg);

        }

        private void StopOrNot(object sender, EventArgs e)
        {
            if (stopCheckBox.Checked == true)
            {
                tm.Stop();
            }
            else
            {
                tm.Start();
            }
        }
    }
    public class ProgreeBarMy 
    {
        public int tecValue;
        public int minValue;
        public int maxValue;
        public Bitmap[] indick = new Bitmap[14];
        int tec;
       public int TecValue
        {
            get
            {
                return TecValue;
            }
            set
            {
                tecValue = value;
            }
        }
        public void DrawProgressBar(int x, int y, int widht, int height, Graphics e)
        {
            tec++;
            for (int i = 1; i <= 13; i++) {
                indick[i - 1] = new Bitmap(@"C:\Users\Kangarion\Desktop\TrushkovPractica\Image\ProgressBar" + i + ".png");
            }


            RectangleF rec2 = new RectangleF(x * 3, y * 3.1f, tecValue * 1.5f, tecValue * 1.4f);
            RectangleF rec = new RectangleF(0, 0, tecValue, tecValue);
            GraphicsUnit units = GraphicsUnit.Pixel;

            Bitmap border = new Bitmap(@"C:\Users\Kangarion\Desktop\TrushkovPractica\Image\BorderBar.png");
            e.DrawImage(border, x, y, widht, height);
            Bitmap cirle = new Bitmap(@"C:\Users\Kangarion\Desktop\TrushkovPractica\Image\Circle.png");
            e.DrawImage(cirle, x * 2.8f, y * 2.5f, widht / 1.4f, height / 1.85f);
            e.DrawImage(cirle, x * 4.5f, y * 4.4f, widht / 2.40f, height / 3.25f);
            int procent = 0;
            if (maxValue > 0)
            {
                procent = (tecValue * 100) / maxValue;
            }
            e.DrawString(procent + "%", new Font("Arial", 20), Brushes.Black, x * 6 - 10, y * 6);

            int temp = 100 /12;
            #region[indicator]
            if (procent > temp*1)
            {
                e.DrawImage(indick[0], x * 7, y * 3, widht / 9, height / 9);
                e.FillEllipse(Brushes.Black, x*1.5f, y*18, widht/20, height/20);
            }
           if (procent > temp*2)
            {
                e.DrawImage(indick[1], x * 8.4f, y * 3.7f, widht / 8, height / 8);
                e.FillEllipse(Brushes.Black, x*3, y * 18, widht / 20, height / 20);
            }
            if (procent > temp*3)
            {
                e.DrawImage(indick[2], x * 9.2f, y * 5, widht / 8, height / 8);
                e.FillEllipse(Brushes.Black, x*4.5f, y * 18, widht / 20, height / 20);
            }   if (procent > temp*4)
            {
                e.DrawImage(indick[3], x * 9.1f, y * 7.4f, widht / 8, height / 13);
                e.FillEllipse(Brushes.Black, x*6, y * 18, widht / 20, height / 20);
            }  if (procent > temp*5)
            {
                e.DrawImage(indick[4], x * 8.5f, y * 8.5f, widht / 8, height / 10);
                e.FillEllipse(Brushes.Black, x*7.5f, y * 18, widht / 20, height / 20);
            } if (procent > temp*6)
            {
                e.DrawImage(indick[5], x * 7f, y * 9, widht / 8, height / 10);
                e.FillEllipse(Brushes.Black, x*9, y * 18, widht / 20, height / 20);
            } if (procent > temp*7)
            {
                e.DrawImage(indick[6], x * 5.5f, y * 9, widht / 12, height / 10);
                e.FillEllipse(Brushes.Black, x*10.5f, y * 18, widht / 20, height / 20);
            }
            if (procent > temp*8)
            {
                e.DrawImage(indick[7], x * 3.8f, y * 8, widht / 10, height / 10);
                e.FillEllipse(Brushes.Black, x*12, y * 18, widht / 20, height / 20);
            } if (procent > temp*9)
            {
                e.DrawImage(indick[9], x * 3f, y * 6.7f, widht / 8, height / 13);
               
            } if (procent > temp*10)
            {
                e.DrawImage(indick[10], x * 3.1f, y * 5f, widht / 7, height / 13);
                e.FillEllipse(Brushes.Black, x * 13.5f, y * 18, widht / 20, height / 20);
            }
            if (procent > temp*11)
            {
                e.DrawImage(indick[11], x * 3.8f, y * 3.8f, widht / 8, height / 9);
            }
            if (procent > temp*12)
            {
                e.DrawImage(indick[12], x * 5.1f, y *3.3f, widht / 8, height / 10);
                e.FillEllipse(Brushes.Black, x * 15, y * 18, widht / 20, height / 20);
            }

            #endregion

        }
        public  Bitmap RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);
            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            return bmp; //return the image
        }
        public void CopingFiles()
        {
            
          
           
           
            /* if (tecValue >= maxValue)
             {
                 tecValue = maxValue;

             }
             else
             {


                 tecValue += 1;
             }
            */
            if (tecValue < minValue)
            {
                tecValue = minValue;
            }
            if (tecValue < maxValue)
            {
                
                tecValue += 1;
              
            }
            else
            {
                tecValue = maxValue;
            }



            


        }
        





    }
}
