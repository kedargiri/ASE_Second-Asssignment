using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingLanguage
{
   abstract class Creator
    {/// <summary>
    /// this is the abstract class to set rule for factory class
    /// </summary>
    /// <param name="ShapeType"></param>
    /// <returns></returns>
        public abstract IShape getShape(string ShapeType);
    }
}
