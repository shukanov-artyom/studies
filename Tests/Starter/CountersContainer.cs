using System;
using System.Diagnostics;

namespace Starter
{
    public class CountersContainer
    {
        public PerformanceCounter ItemsPerSecCounter { get; set; }

        public PerformanceCounter BytesPerSecCounter { get; set; }
    }
}
