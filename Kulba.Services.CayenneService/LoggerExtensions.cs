﻿using System;
using Microsoft.Extensions.Logging;

namespace Kulba.Services.CayenneService
{
    internal static class LoggerExtensions
    {
        private static Action<ILogger, DateTimeOffset, Exception> _programStarting;
        private static Action<ILogger, DateTimeOffset, Exception> _programStopping;

        static LoggerExtensions()
        {
            _programStarting = LoggerMessage.Define<DateTimeOffset>(LogLevel.Information, 1, "Starting at '{StartTime}'");
            _programStopping = LoggerMessage.Define<DateTimeOffset>(LogLevel.Information, 2, "Stopping at '{StopTime}'");
        }
        public static void ProgramStarting(this ILogger logger, DateTimeOffset startTime, Exception exception = null)
        {
            _programStarting(logger, startTime, exception);
        }
        public static void ProgramStopping(this ILogger logger, DateTimeOffset stopTime, Exception exception = null)
        {
            _programStopping(logger, stopTime, exception);
        }
    }
}