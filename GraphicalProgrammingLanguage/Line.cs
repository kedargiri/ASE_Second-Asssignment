using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingLanguage
{
    public class Line : IShape
    {
        public int x, y, toX,toY;

        /// <summary>
        /// 
        /// </summary>
        public Line() : base()
        {
           
        }/// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="toX"></param>
        /// <param name="toY"></param>
        public Line(int x, int y, int toX, int toY)
        {

           
        }
        /// <summary>
        /// this methord draw line on the graphic object
        /// </summary>
        /// <param name="g"></param>
        public void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawLine(p, x, y, toX, toY);
        }
        /// <summary>
        /// this methord set value of x,y,tox,toy
        /// </summary>
        /// <param name="list"></param>
        public void set(params int[] list)
        {
            this.x = list[0];
            this.y = list[1];
            this.toX = list[2];
            this.toY = list[3];
        }
    }
}
