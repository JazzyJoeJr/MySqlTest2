using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySqlTest2.Models
{
    public class JobLijstViewModel
    {
        public List<JobStitch> StitchJobs { get; set; }
        public JobStitch Job { get; set; }
    }
}