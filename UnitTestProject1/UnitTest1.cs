using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Name_WithLessThan3Characters_ReturnFalse()
        {
            string name = "ab";
            bool result = IsNameValid(name);
            Assert.IsFalse(result);
        }

        public void Name_WithMoreThan15Characters_ReturnFalse()
        {
            string name = "asdfrghbnhgfcvgf";
            bool result = IsNameValid(name);
            Assert.IsFalse(result);
        }

        public void Name_With3To15Characters_ReturnsTrue()
        {
            string name1 = "abc";
            string name2 = "asdfrghbnhgfcvf";

            bool result1 = IsNameValid(name1);
            bool result2 = IsNameValid(name2);

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            
        }
        private bool IsNameValid(string name)
        {
            if (name.Length < 10 || name.Length > 50)
            {
                return false;
            }
            return false;
        }
        
    }
}
