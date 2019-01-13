﻿using System;
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
        }
        public Rectangle(int x, int y, int width, int height)
        {

            this.width = width; //the only thingthat is different from shape
            this.height = height;
        }
        public void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawRectangle(p, x - (width / 2), y - (height / 2), width * 2, height * 2);
        }

        public void set(params int[] list)
        {
            this.x = list[0];
            this.y = list[1];
            this.width = list[2];
            this.height = list[3];
        }
    }
}
