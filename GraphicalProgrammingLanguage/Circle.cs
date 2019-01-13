using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicalProgrammingLanguage
{
   public class Circle : IShape
    {
        public int x, y, radius;
        public Circle() : base()
        {

        }/// <summary>
        /// This methord returns new circle when called
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius"></param>
        public Circle(int x, int y, int radius)
        {

            this.radius = radius; //the only thingthat is different from shape
        }

        /// <summary>
        /// this methord draw circle on graphic object
        /// </summary>
        /// <param name="g"></param>
        public void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawEllipse(p, x-radius, y-radius, radius * 2, radius * 2);
        }

        /// <summary>
        /// this set the value of x, y and radius
        /// </summary>
        /// <param name="list"></param>
        public void set(params int[] list)
        {
            this.x = list[0];
            this.y = list[1];
            this.radius = list[2];
        }


    }
}
