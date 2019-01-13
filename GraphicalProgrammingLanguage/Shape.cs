using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingLanguage
{
    public interface IShape
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="g"></param>
        void draw(Graphics g);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        void set(params int[] list);
    }
}
