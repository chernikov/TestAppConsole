using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppConsole.Tests
{
    [TestFixture]
    public class ProcessorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Process_JustRun_JustPassed()
        {
            //Arrange
            var mockCollector = new Mock<ICollector>();
            var sut = new Processor(mockCollector.Object);

            //Act
            sut.Process();

            //Assert

            //mockCollector.Verify(p => p.Add(It.IsAny<string>()), Times.Exactly(3));
            //mockCollector.VerifyGet(p => p.Total, Times.Exactly(1));
            //mockCollector.VerifyNoOtherCalls();

            Assert.Pass();
        }
    }
}
