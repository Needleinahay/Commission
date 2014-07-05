using Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class Repository
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        CommissionContext context;
        public Repository(CommissionContext db)
        {
            context = db;
        }

        public IEnumerable<Faculty> GetFaculties()
        {
            try  { return context.Faculties; }
            catch
            {
                logger.Error("Could not pull faculties' list from DB.");
                return null;
            }
        }
        public ContactInfo GetContactInfo()
        {
            try { return context.ContactInf.FirstOrDefault(); }
            catch
            {
                logger.Error("Could not pull Contact information from DB.");
                return null;
            }
        }
    }
}
