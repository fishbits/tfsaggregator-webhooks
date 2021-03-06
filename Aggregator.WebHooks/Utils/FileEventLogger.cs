﻿using Aggregator.Core.Monitoring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aggregator.WebHooks.Utils
{
    internal class FileEventLogger : TextLogComposer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleEventLogger"/> class.
        /// </summary>
        /// <param name="minimumLogLevel">The minimum log level to show.</param>
        public FileEventLogger(string logFile, LogLevel minimumLogLevel)
            : base(new FileTextLogger(logFile, minimumLogLevel))
        {
        }
    }
}