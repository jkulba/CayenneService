using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Kulba.Services.CayenneService.Test
{
    public class HostedServiceTests : IClassFixture<HostedServiceFixture>
    {
        private readonly ITestOutputHelper _output;
        HostedServiceFixture _hostedServiceFixture;

        public HostedServiceTests(ITestOutputHelper _testOutputHelper, HostedServiceFixture hostedServiceFixture)
        {
            _output = _testOutputHelper;
            _hostedServiceFixture = hostedServiceFixture;
        }

        [Fact(DisplayName = "Successfully Load Applicaiton Configuration")]
        public void SuccessLoadConfiguration()
        {
            //Arrange
            _output.WriteLine("Arrange");
            
            //Act
            _output.WriteLine("Act");

            //Assert
            _output.WriteLine("Assert");
            Assert.True(true);
        }
    }
}
