﻿using System;
using LeDragon.CSD3.Models;
using NUnit.Framework;

namespace LeDragon.CSD3.Scales.Test
{
    [TestFixture]
    public class LinearScaleTest
    {
        [Test]
        public void Should_Have_A_Constructor_With_Domain_And_Range()
        {
            var sut = new LinearScale(new Range<Double>(0, 1), new Range<Double>(0, 100));
            Assert.IsNotNull(sut);
        }

        [Test]
        public void Should_Have_An_Empty_Constructor()
        {
            var sut = new LinearScale();
            Assert.IsNotNull(sut);
        }

        [Test]
        public void Should_Have_A_Default_Range()
        {
            var sut = new LinearScale();
            Assert.IsNotNull(sut.Range);
        }

        [Test] public void Should_Have_A_Default_Domain()
        {
            var sut = new LinearScale();
            Assert.IsNotNull(sut.Domain);
        }

    }
}