using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Test
{
    class Queue
    {
        [Test]
        public void Test_Empty_Queue()
        {
            Queue<int> queue = new Queue<int>();
            Assert.IsEmpty(queue);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.IsNotEmpty(queue);
        }
        [Test]
        public void Test_Contain_Queue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            Assert.Contains(1, queue);
        }
        [Test]
        public void Test_Queue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.AreEqual(3, queue.Count);
            Assert.IsFalse(queue.ElementAt(0) == queue.ElementAt(1));
            Assert.IsNotNull(queue.ElementAt(1));
            Assert.That(queue.ElementAt(1), Is.LessThan(5));
            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(2, queue.Dequeue());
            Assert.AreEqual(3, queue.Dequeue());
            Assert.AreEqual(0, queue.Count);
        }
    }
}
