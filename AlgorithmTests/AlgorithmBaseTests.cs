using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Tests
{
    [TestClass()]
    public class AlgorithmBaseTests
    {
        [TestMethod()]
        public void SortTest()
        {
            var bubble = new BubbleSort<T>();
            var rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                Items.Add(rnd.Next(0, 100));

            }
            bubble.Sort();
        }
    }
}