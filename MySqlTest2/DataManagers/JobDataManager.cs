using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySqlTest2.Models;
using MySql.Data.MySqlClient;

namespace MySqlTest2.DataManagers
{
    public class JobDataManager
    {
        public List<JobStitch> GetJobsStitch()
        {
            List<JobStitch> stitchJobs = new List<JobStitch>();

            try
            {
                using (MySqlConnection connectie = new MySqlConnection(@"Server=185.13.227.203; Database=benondp171_jo; User= benondp171_jo; Password=J0test; "))
                using (MySqlCommand jobcommando = new MySqlCommand("SELECT Id, JobNr, Aantal, Breedte, Hoogte, AantalBlz, Cover, StartJob, StopJob, LeverDatum FROM JobStitch", connectie))
                {
                    connectie.Open();

                    using (MySqlDataReader jobLezer = jobcommando.ExecuteReader())
                    {
                        while (jobLezer.Read())
                        {
                            JobStitch s = new JobStitch();
                            int idIndex = jobLezer.GetOrdinal(nameof(JobStitch.Id));
                            s.Id = jobLezer.GetInt16(idIndex);
                            int idJobNr = jobLezer.GetOrdinal(nameof(JobStitch.JobNr));
                            s.JobNr = jobLezer.GetString(idJobNr);
                            int idAantal = jobLezer.GetOrdinal(nameof(JobStitch.Aantal));
                            s.Aantal = jobLezer.GetInt16(idAantal);
                            int idBreedte = jobLezer.GetOrdinal(nameof(JobStitch.Breedte));
                            s.Breedte = jobLezer.GetInt16(idBreedte);
                            int idHoogte = jobLezer.GetOrdinal(nameof(JobStitch.Hoogte));
                            s.Hoogte = jobLezer.GetInt16(idHoogte);
                            int idAantalBlz = jobLezer.GetOrdinal(nameof(JobStitch.AantalBlz));
                            s.AantalBlz = jobLezer.GetInt16(idAantalBlz);
                            int idCover = jobLezer.GetOrdinal(nameof(JobStitch.Cover));
                            s.Cover = jobLezer.GetBoolean(idCover);
                            int idStartJob = jobLezer.GetOrdinal(nameof(JobStitch.StartJob));
                            s.StartJob = jobLezer.GetDateTime(idStartJob);
                            int idStopJob = jobLezer.GetOrdinal(nameof(JobStitch.StopJob));
                            s.StopJob = jobLezer.GetDateTime(idStopJob);
                            int idLeverDatum = jobLezer.GetOrdinal(nameof(JobStitch.LeverDatum));
                            s.LeverDatum = jobLezer.GetDateTime(idLeverDatum);
                            stitchJobs.Add(s);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string fout = ex.Message;
            }
            return stitchJobs;
        }

        public int InsertJobStitch(JobStitch job)
        {
            int affectedRows = 100;
            try
            {
                using (MySqlConnection connectie = new MySqlConnection(@"Server=185.13.227.203; Database=benondp171_jo; User= benondp171_jo; Password=J0test; "))
                using (MySqlCommand insertcommando = new MySqlCommand("INSERT INTO JobStitch (JobNr, Aantal)" + "VALUES(@JobNr, @Aantal)", connectie))
                {
                    object dbJobNr = job.JobNr;
                    if (dbJobNr == null)
                    {
                        dbJobNr = DBNull.Value;
                    }
                    insertcommando.Parameters.Add("JobNr", MySqlDbType.VarChar, 32).Value = dbJobNr;

                    object dbAantal = job.Aantal;
                    if (dbAantal == null)
                    {
                        dbAantal = DBNull.Value;
                    }
                    insertcommando.Parameters.Add("Aantal", MySqlDbType.Int16, 11).Value = dbAantal;

                    //hier nog de rest van de database gelijkaardig invullen... zie blz. 30

                    connectie.Open();
                    affectedRows = insertcommando.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {

                string fout = ex.Message;
            }

            return affectedRows;
        }
    }
}