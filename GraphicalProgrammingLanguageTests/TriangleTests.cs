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
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleSetTest()
        {

            //Arrange
            Triangle t = new Triangle();
            int x = 50, y = 100, width = 100, height = 100;

            //Act
            t.set(x, y, width, height);

            // Assert
            Assert.AreEqual(x, t.x);
        }
    }
}