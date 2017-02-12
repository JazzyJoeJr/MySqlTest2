using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySqlTest2.Models
{
    public class JobStitch
    {
        public int Id { get; set; }
        public string JobNr { get; set; }
        public int Aantal { get; set; }
        public int Breedte { get; set; }
        public int Hoogte { get; set; }
        public int AantalBlz { get; set; }
        public bool Cover { get; set; }
        public string PapierBw { get; set; }
        public string PapierCover { get; set; }
        public int MedewerkerId { get; set; }
        public DateTime StartJob { get; set; }
        public DateTime StopJob { get; set; }
        public DateTime LeverDatum { get; set; }
    }
}