using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySqlTest2.Models
{
    public class JobLijstViewModel
    {
        public List<JobStitch> StitchJobs { get; set; }
        public List<JobStitch> StichJobsbyMachineId1 { get; set; }
        public List<JobStitch> StichJobsbyMachineId2 { get; set; }
        public List<JobStitch> StichJobsbyMachineId3 { get; set; }
        public List<JobStitch> StichJobsbyMachineId4 { get; set; }
        public List<JobStitch> StitchJobsbyMachineId0 { get; set; }
        public JobStitch Job { get; set; }
    }
}