using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Kulba.Services.CayenneService.Test
{
    public class HostedServiceTests : IClassFixture<HostedServiceFixture>
    {
        private readonly ITestOutputHelper _output;
        private readonly IMessageSink _diagnosticMessageSink;
        HostedServiceFixture _hostedServiceFixture;

        public HostedServiceTests(ITestOutputHelper _testOutputHelper, HostedServiceFixture hostedServiceFixture, IMessageSink diagnosticMessageSink)
        {
            _output = _testOutputHelper;
            _hostedServiceFixture = hostedServiceFixture;
            _diagnosticMessageSink = diagnosticMessageSink;
        }

        [Fact(DisplayName = "Successfully Load Applicaiton Configuration")]
        public void SuccessLoadConfiguration()
        {
            var message = new DiagnosticMessage("Hello Joe Message Sink");
            _diagnosticMessageSink.OnMessage(message);
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
