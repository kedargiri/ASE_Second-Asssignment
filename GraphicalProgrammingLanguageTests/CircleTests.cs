using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphicalProgrammingLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingLanguage.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CircleSetTest()
        {
            Circle c = new Circle();
            int x = 100, y = 100, radius = 50;

            c.set(x, y, radius);

            Assert.AreEqual(x, c.x);
        }
    }
}