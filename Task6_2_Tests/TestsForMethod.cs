using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_2_lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task6_2_Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class TestsForMethod
    {
        IntParse obj;

        [TestInitialize]
        public void TestInitialize()
        {
            obj = new IntParse();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            obj = null;
        }
        
        [TestMethod]
        public void TstCheckForPositiveNumber()
        {
            //("Enter a number between −2,147,483,648 and +2,147,483,647 (inclusive):")
            int result = obj.ConvertToInteger("34");
            Assert.AreEqual(34, result);
        }

        [TestMethod]
        public void TstCheckForNegativeNumber()
        {
            //("Enter a number between −2,147,483,648 and +2,147,483,647 (inclusive):")
            int result = obj.ConvertToInteger("-34");
            Assert.AreEqual(-34, result);
        }

        [TestMethod]
        public void TstCheckForRightBorder()
        {
            //("Enter a number between −2,147,483,648 and +2,147,483,647 (inclusive):")
            int result = obj.ConvertToInteger("2147483647");
            Assert.AreEqual(2147483647, result);
        }
        
        [TestMethod]
        public void TstCheckForLeftBorder()
        {
            //("Enter a number between −2,147,483,648 and +2,147,483,647 (inclusive):")
            int result = obj.ConvertToInteger("−2147483648");
            Assert.AreEqual(-2147483648, result);
        }

        [TestMethod]
        public void TstCheckForLowerThenLeftBorder()
        {
            //("Enter a number between −2,147,483,648 and +2,147,483,647 (inclusive):")
            int result = obj.ConvertToInteger("−2147483649");
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TstCheckForHigherThenRightBorder()
        {
            //("Enter a number between −2,147,483,648 and +2,147,483,647 (inclusive):")
            int result = obj.ConvertToInteger("2147483649");
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TstCheckForEmpty()
        {
            //("Enter a number between −2,147,483,648 and +2,147,483,647 (inclusive):")
            int result = obj.ConvertToInteger("");
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TstCheckForString()
        {
            //("Enter a number between −2,147,483,648 and +2,147,483,647 (inclusive):")
            int result = obj.ConvertToInteger("error!");
            Assert.AreEqual(-1, result);
        }
    }
}
