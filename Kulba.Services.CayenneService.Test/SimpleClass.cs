using Microsoft.Extensions.Logging;
using System;

namespace Kulba.Services.CayenneService.Test
{
    public class SimpleClass
    {
        private readonly ILogger _logger;

        public SimpleClass(ILogger logger)
        {
            _logger = logger;
        }

        public string ShowMessage()
        {
            var message = "Hello LogInformation method";
            _logger.LogInformation(message);
            return message;
        }
    }
}
