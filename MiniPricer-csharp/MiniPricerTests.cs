using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;

namespace MiniPricer_csharp
{
    public class MiniPricerTests
    {
        private Pricer _pricer;
        private double _precision=0.01; 

        [SetUp]
        public void Setup()
        {
            _pricer = new Pricer(_precision,new WorkingDay(),new FakeRandomGenerator());
        }

        [Test]
        public void Should_Return_CurrentPrice_When_FutureDateIsActualDate()
        {
            double price = _pricer.getPrice(new DateTime(2016, 1, 1), new DateTime(2016, 1, 1), 100, 10);
            var result = 100 - price;
            Assert.IsTrue(result < _precision);
        }

        [Test]
        public void Should_Return_FuturPrice_When_FutureDateIsTomorow()
        {
            double  price = _pricer.getPrice(new DateTime(2016, 1, 5), new DateTime(2016, 1,  6), 100, 10);
            double result = 110 - price;
            Assert.IsTrue(Math.Abs(result) < _precision);

        }


        [Test]
        public void Should_Return_FuturPrice_When_FutureDateIsOneWeekLater()
        {
            double price = _pricer.getPrice(new DateTime(2016, 1, 1), new DateTime(2016, 1, 8), 100, 10);
            double result = 161.051 - price;
            Assert.IsTrue(Math.Abs(result) < _precision);
            double resultmin = 59.049 - price;
        }


    }

}
