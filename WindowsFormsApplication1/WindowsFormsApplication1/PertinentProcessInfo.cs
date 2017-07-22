using System;

namespace WindowsFormsApplication1
{
    public class PertinentProcessInfo
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public string MachineName { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan TotalProcessorTime { get; set; }
        public int Id { get; set; }
        public long NonPagedSystemMemory { get; set; }
        public long PagedMemory { get; set; }
        public long PagedSystemMemory { get; set; }
        public long PeakPagedMemory { get; set; }
        public long VirtualMemory { get; set; }
        public long PeakVirtualMemory { get; set; }
        public long PeakPhysicalMemory { get; set; }
        public long PhysicalMemory { get; set; }
    }
}