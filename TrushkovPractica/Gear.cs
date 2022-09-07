using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace TrushkovPractica
{
    class Gear
    {
        List<PointF> clovePoints = new List<PointF>();
        
        public List<PointF> СlovePointReturn()
        {
            clovePoints.Add(new PointF(-0.2f,1));//a 1
            clovePoints.Add(new PointF(0.2f, 1));//b 2
            clovePoints.Add(new PointF(0.2f, 0.6f));//d 3
            clovePoints.Add(new PointF(0.27f, 0.5f));//w 4

            clovePoints.Add(new PointF(0.56f, 0.8f));//u
            clovePoints.Add(new PointF(0.78f, 0.57f));//v
            clovePoints.Add(new PointF(0.5f, 0.3f));//z
            clovePoints.Add(new PointF(0.6f, 0.2f));// O
            

            clovePoints.Add(new PointF(1f, 0.2f));//n
            clovePoints.Add(new PointF(1, -0.2f));//m
            clovePoints.Add(new PointF(-0.6f, -0.2f));//P
            clovePoints.Add(new PointF(0.55f, -0.3f));//t

            clovePoints.Add(new PointF(0.8f, -0.5f));//q
            clovePoints.Add(new PointF(0.6f, 0.77f));//r
            clovePoints.Add(new PointF(0.35f, -0.5f));//s
            clovePoints.Add(new PointF(0.2f, -0.6f));//l


            clovePoints.Add(new PointF(0.2f, -1));//j
            clovePoints.Add(new PointF(-0.2f, -1f));//i
            clovePoints.Add(new PointF(-0.2f, -0.6f));//k
            clovePoints.Add(new PointF(-0.6f, 0.2f));//h


            clovePoints.Add(new PointF(-0.6f, -0.8f));//f1
            clovePoints.Add(new PointF(-0.8f, -0.5f));//e1
            clovePoints.Add(new PointF(-0.55f, -0.35f));//g1
            clovePoints.Add(new PointF(-0.6f, -0.2f));//g


            clovePoints.Add(new PointF(-0.6f, -0.8f));//f1
            clovePoints.Add(new PointF(-0.8f, -0.5f));//e1
            clovePoints.Add(new PointF(-0.55f, -0.35f));//g1
            clovePoints.Add(new PointF(-0.6f, -0.2f));//g

            return clovePoints;
        }
        public List<PointF> Clock()
        {
            List<PointF> gearPoints = new List<PointF>();
            gearPoints.Add(new PointF(0, 0));
            gearPoints.Add(new PointF(0, 1));
            gearPoints.Add(new PointF(1, 1));
            gearPoints.Add(new PointF(1, 0));



            return gearPoints;
        }
        public List<PointF> Strelka()
        {
            List<PointF> gearPoints = new List<PointF>();
            gearPoints.Add(new PointF(0, 0));
            gearPoints.Add(new PointF(0, -1));
            gearPoints.Add(new PointF(0, 1));
            



            return gearPoints;
        }
    }
}
