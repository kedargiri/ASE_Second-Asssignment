using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingLanguage
{


    /// <summary>
    /// This is Polygon Class which inherites the properties of Ishape interface.
    /// </summary>
    public class Polygon : IShape
    {


        Point[] po;
        Pen p = new Pen(Color.Black, 2);
        /// <summary>
        /// It is a default constructor of polygon class without any parameter
        /// </summary>
        public Polygon() : base()
        {

        }

        /// <summary>
        /// It is Paramaterized Constructor of Polygon Class that get executed 
        /// when Polygon Shape called from factory class.
        /// </summary>
        /// <param name="po">Points of Polygon</param>
        public Polygon(Point[] po)
        {
            this.po = po;

        }

        /// <summary>
        /// This method draw a polygon.
        /// </summary>
        /// <param name="g">Graphic object</param>
        public void draw(Graphics g)
        {
            g.DrawPolygon(p, po);
        }


        /// <summary>
        /// The method set the value of all parameters required to draw a polygon.
        /// </summary>
        /// <param name="list">List of paramaters for that are required for creating points</param>
        public void set(params int[] list)
        {
            //this.x = list[0];
            //this.y = list[1];
            Point[] po = new Point[list.Length / 2];
            int j = 0;
            for (int i = 0; i < list.Length; i = i + 2)
            {

                po[j].X = list[i];
                po[j].Y = list[i + 1];
                //po[j] = new Point(pointx, pointy);
                j++;

            }
            this.po = po;

        }



    }
}
