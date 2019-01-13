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
    public class LineTests
    {
        [TestMethod()]
        public void LineSetTest()
        {
            Line l = new Line();
            int x = 100, y = 100, tox=300,toy=400;

            l.set(x, y, tox,toy);

            Assert.AreEqual(x, l.x);
        }
    }
}