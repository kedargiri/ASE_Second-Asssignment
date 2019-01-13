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
    public class RectangleTests
    {
        [TestMethod()]
        public void RectangleSetTest()
        {

            //Arrange
            Rectangle r = new Rectangle();
            int x = 100, y = 50, width = 200, height = 300;

            //Act
            r.set(x,y,width,height);

            // Assert
            Assert.AreEqual(x,r.x);
        }
    }
}