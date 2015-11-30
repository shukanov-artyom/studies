using System;
using System.Diagnostics;

namespace PerformanceCounters
{
    public class CountersContainer
    {
        public PerformanceCounter ItemsPerSecCounter { get; set; }

        public PerformanceCounter BytesPerSecCounter { get; set; }
    }
}
