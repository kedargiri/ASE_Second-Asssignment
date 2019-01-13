using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingLanguage
{
  public  class Triangle:IShape
    {

      public  int x, y, width, height;
        /// <summary>
        /// 
        /// </summary>
        public Triangle():base()
        {
            width = 0;
            height = 0;
        }/// <summary>
         /// This methord returns new triangle when called
         /// </summary>
         /// <param name="x"></param>
         /// <param name="y"></param>
         /// <param name="width"></param>
         /// <param name="height"></param>

        public Triangle(int x, int y,int width, int height)
        {
            this.width = width;
            this.height = height;
        }/// <summary>
        /// this methord draw triangle on the graphic object
        /// </summary>
        /// <param name="g"></param>

        public void draw(Graphics g)
        {

            Point[] p = new Point[3];
            p[0].X = x;
            p[0].Y = y - (height / 2);

            p[1].X = x - (width / 2);
            p[1].Y = y + (height / 2);

            p[2].X = x + (width / 2);
            p[2].Y = y + (height / 2);
            Pen po = new Pen(Color.Black, 2);
            g.DrawPolygon(po, p);
            

        }/// <summary>
        /// this methord set the value of x,y,width and height
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
