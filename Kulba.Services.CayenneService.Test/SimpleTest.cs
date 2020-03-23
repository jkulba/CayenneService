using Microsoft.Extensions.Logging;
using System;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Kulba.Services.CayenneService.Test
{
    
    public class SimpleTest : IDisposable
    {
        private readonly ILogger _logger;
        private readonly ITestOutputHelper _outputHelper;

        public SimpleTest(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
            _logger = outputHelper.BuildLogger();
        }

        public void Dispose()
        {
            Console.WriteLine("Simple Dispose Method");
        }

        [Fact]
        public void HelloTest()
        {
            var sut = new SimpleClass(_logger);
            var actual = sut.ShowMessage();
            actual.Should().NotBeNullOrWhiteSpace();
        }

    }
}
