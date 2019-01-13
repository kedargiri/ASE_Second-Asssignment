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
        public Line() : base()
        {
            
        }
        public Line(int x, int y, int toX, int toY)
        {

           
        }
        public void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawLine(p, x, y, toX, toY);
        }

        public void set(params int[] list)
        {
            this.x = list[0];
            this.y = list[1];
            this.toX = list[2];
            this.toY = list[3];
        }
    }
}
