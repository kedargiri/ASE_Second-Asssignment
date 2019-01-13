using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicalProgrammingLanguage
{
    class FactoryClass : Creator
    {/// <summary>
    /// This is the factory class which set validated sapes
    /// </summary>
    /// <param name="shapeType"></param>
    /// <returns></returns>
        public override IShape getShape(string shapeType)
        {
            shapeType = shapeType.ToLower().Trim(); //yoi could argue that you want a specific word string to create an object but I'm allowing any case combination


            if (shapeType.Equals("circle"))
            {
                return new Circle();

            }
            else if (shapeType.Equals("rectangle"))
            {
                return new Rectangle();

            }
            else if (shapeType.Equals("triangle"))
            {
                return new Triangle();

            }
            else if (shapeType.Equals("line"))
            {
                return new Line();

            }
            else if (shapeType.Equals("3drectangle"))
            {
                return new _3dRectangle();

            }
            else if (shapeType.Equals("polygon"))
            {
                return new Polygon();

            }
            else if (shapeType.Equals("texturecircle"))
            {
                return new TextureCircle();

            }
            else
            {
                //if we get here then what has been passed in is inkown so throw an appropriate exception
                System.ArgumentException argEx = new System.ArgumentException("Factory error: " + shapeType + " does not exist");
                throw argEx;
            }
        }

    }
}
