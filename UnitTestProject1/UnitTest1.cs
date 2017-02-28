using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program.WhatIsThisTriangle(10, 10, 15);   
        }
        [TestMethod]
        public void TestMethod2()
        {
            Program.WhatIsThisTriangle(0 , 0 , 1);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Program.WhatIsThisTriangle(-10, 10, 15);
        }
    }
}
