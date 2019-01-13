using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingLanguage
{
    class TextureCircle:IShape
    {
        int x, y, radius;

        /// <summary>
        /// Constructor of tcircle class with out parameter
        /// </summary>
        public TextureCircle() : base()
        {

        }
        /// <summary>
        /// It is Paramaterized Constructor of TCircle Class that get executed 
        /// when TCircle Shape called from factory class.
        /// </summary>
        /// <param name="x">Point X axis location</param>
        /// <param name="y">Point Y axis location</param>
        /// <param name="radius">Radius of a 3dcircle</param>
        public TextureCircle(int x, int y, int radius)
        {

            this.radius = radius; //the only thingthat is different from shape
        }

        /// <summary>
        /// This method draw a texture circle on the graphic object.
        /// </summary>
        /// <param name="g">Graphic object</param>
        public void draw(Graphics g)
        {
            Bitmap bi = new Bitmap(@"C:\Users\girik\source\repos\GraphicalProgrammingLanguage\GraphicalProgrammingLanguage\Image.jpg");
            TextureBrush tBrush = new TextureBrush(bi);
            //Pen texturedPen = new Pen(tBrush, 30);
            g.FillEllipse(tBrush, x, y, radius * 2, radius * 2);
            //g.FillRectangle(tBrush, x, y, radius * 2, radius * 2);
        }

        /// <summary>
        /// The method set the value of all parameters required to draw texture circle.
        /// </summary>
        /// <param name="list">List of paramaters for creating texture circle</param>
        public void set(params int[] list)
        {
            this.x = list[0];
            this.y = list[1];
            this.radius = list[2];

        }


    }
}
