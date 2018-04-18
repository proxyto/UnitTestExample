using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Test
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Test_Add_2_Small_Numbers()
        {
            Assert.AreEqual(7 , Library.Math.Add_2(3, 4)); 
        }
      
    }
}
