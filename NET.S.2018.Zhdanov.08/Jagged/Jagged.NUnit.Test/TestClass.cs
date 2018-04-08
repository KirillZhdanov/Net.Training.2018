using NUnit.Framework;
using System.Collections;
using System.Linq;
using Jagged;
namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        

        [Test]
        public void Sum()
        {
            int[][] actual = new[] { new[] { 1 }, new[] { 0, 4, 7 },  new[] { 15, 21 } };
            int[][] expected = new[] {  new[] { 1 }, new[] { 0,4, 7 }, new[] { 15, 21 } };
            DelegateToInterfaceSort.Sort(actual, new ComparatorByMaxElement().Compare);
           
            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
