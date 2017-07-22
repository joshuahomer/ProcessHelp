using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ProcessHelperGUI : Form
    {
        public ProcessHelperGUI()
        {
            InitializeComponent();
        }

        //click on start evaluation
        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Start Evaluation")
            {
                button1.Text = "Update Statistics";
            }
            var processInfo = GetProcessInfo();
            foreach(var current in processInfo)
            {
                processInfoView.Items.Add(current.Name);
            }
            
        }

        /// <summary>
        /// Must run as admin in order to have permissions to most of this information apparently
        /// </summary>
        /// <returns></returns>
        private List<PertinentProcessInfo> GetProcessInfo()
        {
            var returnList = new List<PertinentProcessInfo>();
            var allProcesses = Process.GetProcesses();
            var count = 0;

            label2.Text = allProcesses[0].MachineName;

            foreach(Process current in allProcesses)
            {
                try
                {
                    returnList.Add(new PertinentProcessInfo
                    {
                        Name = current.ProcessName,
                        Priority = current.BasePriority,
                        MachineName = current.MachineName,
                        StartTime = current.StartTime,
                        TotalProcessorTime = current.TotalProcessorTime,
                        Id = current.Id,
                        PagedSystemMemory = current.PagedSystemMemorySize64,
                        PeakPagedMemory = current.PeakPagedMemorySize64,
                        PagedMemory = current.PagedMemorySize64,
                        NonPagedSystemMemory = current.NonpagedSystemMemorySize64,
                        PeakPhysicalMemory = current.PeakWorkingSet64,
                        PeakVirtualMemory = current.PeakVirtualMemorySize64,
                        PhysicalMemory = current.WorkingSet64,
                        VirtualMemory = current.VirtualMemorySize64
                    });
                }
                catch
                {
                    count++;
                }
                
            }

            label4.Text = count.ToString();
            return returnList;
        }

        //do nothing
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
