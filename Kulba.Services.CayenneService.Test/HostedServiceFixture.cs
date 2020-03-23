using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;


namespace Kulba.Services.CayenneService.Test
{
    public class HostedServiceFixture : IDisposable
    {
        public HostedServiceFixture()
        {
            // Create shared resources
        }

        public void Dispose()
        {
            // Destroy and shared resources created in the constuctor
        }
    }
}
