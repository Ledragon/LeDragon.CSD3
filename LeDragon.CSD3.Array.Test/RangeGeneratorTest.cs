using System;
using NUnit.Framework;

namespace LeDragon.CSD3.Array.Test
{
    [TestFixture]
    public class RangeGeneratorTest
    {
        [Test]
        public void Shoul_Generate_11_Integer_Values()
        {
            var result = RangeGenerator.Create(0, 10, 10);
            Assert.AreEqual(11, result.Count);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(3, result[3]);
        }

        [Test]
        public void Should_Generate_11_Double_Values()
        {
            var result = RangeGenerator.Create(0d, 1d, 10);
            Assert.AreEqual(11, result.Count);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0.4, result[4]);
            //Fail
            Assert.IsTrue(Math.Abs(0.3- result[3])<1e-8);
        }
    }
}