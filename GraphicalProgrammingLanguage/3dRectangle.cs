using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalProgrammingLanguage
{
   public class _3dRectangle:IShape
    {

        public int x, y, width, height;
        public _3dRectangle() : base()
        {
            width = 0;
            height = 0;
        }/// <summary>
         /// This methord returns new rectangle when called
         /// </summary>
         /// <param name="x"></param>
         /// <param name="y"></param>
         /// <param name="width"></param>
         /// <param name="height"></param>
        public _3dRectangle(int x, int y, int width, int height)
        {

            this.width = width; //the only thingthat is different from shape
            this.height = height;
        }
        /// <summary>
         /// this methord draw rectangle on graphic object
         /// </summary>
         /// <param name="g"></param>
        public void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawRectangle(p, x - width, y - height, width * 2, height * 2);
            Brush bgBrush = new SolidBrush(Color.Blue);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            //Fill the background using Solid brush and then apply a white wash 
            RectangleF rec = new RectangleF(x - width, y - height, width * 2, height * 2);
            g.FillRectangle(bgBrush, x - width, y - height, width * 2, height * 2);
            g.FillRectangle(new SolidBrush(Color.FromArgb(180, Color.White)), x - width, y - height, width * 2, height * 2);
            ControlPaint.DrawBorder3D(g, x - width, y - height, width * 2, height * 2, Border3DStyle.Raised);


        }
        /// <summary>
        /// this set the value of x, y, width and height
        /// </summary>
        /// <param name="list"></param>
        public void set(params int[] list)
        {
            this.x = list[0];
            this.y = list[1];
            this.width = list[2];
            this.height = list[3];
        }
    }
}
