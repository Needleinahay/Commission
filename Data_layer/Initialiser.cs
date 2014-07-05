using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Models;
using NLog;

namespace Data_layer
{
    public class Initialiser : DropCreateDatabaseAlways<CommissionContext>
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        protected override void Seed(CommissionContext db)
        {
            try
            {
                logger.Info("Initializing of the database...");
                // Adding contact infromation about the college
                db.ContactInf.Add(new ContactInfo { Name = "Mega College", Address = "Zip: 10101, Unknown street 5", Telephone = "+0 (123) 555-22-11", Email= "www.some@email.net", Info = "Some deteiled information on the College" });
                
                //Adding faculties
                db.Faculties.Add(new Faculty { FacultyId = 1, Name = "Engineering",      Details = "The Faculty of Engineering is one of the three main Faculties of our College.", Vacancies = 95, ScholarshipVacancies = 10 });
                db.Faculties.Add(new Faculty { FacultyId = 2, Name = "Computer Science", Details = "The Faculty of Computer science is one another great Faculty of our College.",  Vacancies = 75, ScholarshipVacancies = 5 });
                db.Faculties.Add(new Faculty { FacultyId = 3, Name = "Technology",       Details = "The Faculty of Technology is the oldest one.",                                  Vacancies = 42, ScholarshipVacancies = 25 });
                db.Faculties.Add(new Faculty { FacultyId = 4, Name = "Philosophy",       Details = "The Faculty of Philosophy is well known in the world.",                         Vacancies = 102, ScholarshipVacancies = 37 });
                db.Faculties.Add(new Faculty { FacultyId = 5, Name = "History",          Details = "The Faculty of History is well known in the world.",                            Vacancies = 98, ScholarshipVacancies = 35 });




            }
            catch
            {
                logger.Error("There was a problem while initialising database.");
            }
            logger.Info("Database is initialised.");
            base.Seed(db);
        }
    }
}
