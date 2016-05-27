using Microsoft.VisualStudio.TestTools.UnitTesting;
using AkwasiN_MVC_2016_05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkwasiN_MVC_2016_05.Tests
{
    [TestClass()]
    public class Uppgift3Tests
    {
        [TestMethod()]
        public void GetCurrentSpeedTest()
        {
            Uppgift3 testOne = new Uppgift3();
            var actual = testOne.GetCurrentSpeed(20, 5);
            var estimated = 4;
            Assert.AreEqual(actual, estimated, "Works as expected");
        }

        [TestMethod()]
        public void GetCurrentSpeedTest_intType()
        {
            Uppgift3 testTwo = new Uppgift3();
            var actual = testTwo.GetCurrentSpeed(20, 5);
            var estimated = 40;
            Assert.AreNotEqual(actual, estimated, "Works as expected");
        }

        [TestMethod()]
        public void GetCurrentSpeedTest_stringType()
        {
            Uppgift3 testTwo = new Uppgift3();
            var actual = testTwo.GetCurrentSpeed(20, 5);
            var estimated = "fyra";
            Assert.AreNotEqual(actual, estimated, "Returns correct as it checks Not Equal");
        }
    }
}