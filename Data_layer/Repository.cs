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
            try
            {
                IEnumerable<Faculty> toReturn = context.Faculties;
                if (toReturn != null)
                    return toReturn;
                else
                    throw new NullEntryFromDb("The Faculty model pulled from database is null");
            }
            catch (NullEntryFromDb ex)
            {
                logger.Error(ex.Message);
                return null;
            }
        }
        public ContactInfo GetContactInfo()
        {
            try
            {
                ContactInfo toReturn = context.ContactInf.FirstOrDefault();
                if (toReturn != null)
                    return toReturn;
                else
                    throw new NullEntryFromDb("The ContactInfo model pulled from database is null");
            }
            catch (NullEntryFromDb ex)
            {
                logger.Error(ex.Message);
                return null;
            }


        }
    }
}
