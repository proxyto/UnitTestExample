using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Test
{
    [TestFixture]
    class Stack
    {
        [Test]
        public void Test_Empty_Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(13);
            stack.Push(3);
            stack.Pop();
            stack.Pop();
            Assert.IsTrue(stack.Count==0);
            Assert.IsEmpty(stack);
        }
        [Test]
        public void Test_Contain_Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Assert.Contains(1, stack);  
        }
        [Test]
        public void Test_Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.IsFalse(stack.ElementAt(0) == stack.ElementAt(1));
            Assert.IsNotNull(stack.ElementAt(1));
            Assert.That(stack.ElementAt(1), Is.LessThan(5));
        }
    }
}
