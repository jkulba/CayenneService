using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Kulba.Services.CayenneService.Test
{
    public class SimpleTest : IDisposable
    {
        public SimpleTest()
        {
            Console.WriteLine("Simple Constructor");
        }

        public void Dispose()
        {
            Console.WriteLine("Simple Dispose Method");
        }


        [Fact]
        public void HelloTest()
        {
            Console.WriteLine("HelloTest Joe");

            var yeah = 2;
            Assert.Equal(2, yeah);
        }

    }
}
