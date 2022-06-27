using NUnit.Framework;
using System;

namespace TestAppConsole.Tests
{
    [TestFixture]
    public class CollectorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_PassOneTime_GetValueOne()
        {
            //Arrange
            var sut = new Collector();

            //Act
            var result = sut.Add("One");

            //Assert
            Assert.AreEqual("One", result);
        }


        [Test]
        public void Add_PassTwoTimes_GetConcat()
        {
            //Arrange
            var sut = new Collector();

            //Act
            sut.Add("One");
            sut.Add("One");
            var result = sut.Total;

            //Assert
            Assert.AreEqual("OneOne", result);
        }

        //[Test]
        //public void Add_PassNull_GetException()
        //{
        //    //Arrange
        //    var sut = new Collector();

        //    //Act Assert
        //    Assert.Throws<ArgumentNullException>(() => sut.Add(null)); 
        //}
    }
}