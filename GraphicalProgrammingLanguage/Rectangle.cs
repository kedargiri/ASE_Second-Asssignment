using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingLanguage
{
    public class Rectangle:IShape
    {
       public int x, y, width, height;
        public Rectangle() : base()
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
        public Rectangle(int x, int y, int width, int height)
        {

            this.width = width; //the only thingthat is different from shape
            this.height = height;
        }/// <summary>
         /// this methord draw rectangle on graphic object
         /// </summary>
         /// <param name="g"></param>
        public void draw(Graphics g)
        {
            try
            {
                Pen p = new Pen(Color.Black, 2);
                g.DrawRectangle(p, x - (width / 2), y - (height / 2), width * 2, height * 2);
            }
            catch (Exception EX)
            {

                throw EX;
            }
            
        }
        /// <summary>
        /// this set the value of x, y, width and height
        /// </summary>
        /// <param name="list"></param>
        public void set(params int[] list)
        {
            try
            {
                this.x = list[0];
                this.y = list[1];
                this.width = list[2];
                this.height = list[3];
            }
            catch (Exception EX)
            {

                throw EX;
            }
            
        }
    }
}
