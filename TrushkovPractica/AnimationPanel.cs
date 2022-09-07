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
    public partial class AnimationPanel : UserControl
    {
        new Timer tm = new Timer();
        Animation anim = new Animation();
        public AnimationPanel()
        {
            InitializeComponent();
            DoubleBuffered = true;
            tm.Interval = 100;
            tm.Tick += FixedUpdate;
        }
        public void FixedUpdate(object sender, EventArgs e)
        {
            anim.DrawingObject();
        }
            
        private void AnimationPanel_Load(object sender, EventArgs e)
        {
            tm.Start();
        }
    }
    public class Animation
    {
        public Graphics g;
        
        public void DrawingObject()
        {
            gr = Graphics.FromImage(AnimationPanel.InitialImage);
            g.DrawLine(Pens.Black, 0, 0, 10, 10);
        }




    }
}
