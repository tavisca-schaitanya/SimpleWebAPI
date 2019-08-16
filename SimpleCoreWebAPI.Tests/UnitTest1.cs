using SimpleCoreWebAPI.Controllers;
using System;
using Xunit;

namespace SimpleCoreWebAPI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestWithHi()
        {
            GreetController greetController = new GreetController();
            Assert.Equal("Hello", greetController.Talk("hi"));
        }

        [Fact]
        public void TestWithHello()
        {
            GreetController greetController = new GreetController();
            Assert.Equal("Hi", greetController.Talk("Hello"));
        }


        [Fact]
        public void TestWithOthers()
        {
            GreetController greetController = new GreetController();
            Assert.Equal("I dont know what you are saying", greetController.Talk("Abc"));
        }
    }
}
