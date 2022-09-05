using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class GdprConsentRepository : GenericRepo<GdprConsent> , IGdprConsentRepository
    {
        string conStr;
        public GdprConsentRepository(string connection) : base(connection) { conStr = connection; }

        public List<GdprConsent> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GdprConsent where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GdprConsent> GetByMessage(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GdprConsent where [Message] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GdprConsent> GetByIsRequired(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GdprConsent where [IsRequired] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GdprConsent> GetByRequiredMessage(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GdprConsent where [RequiredMessage] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GdprConsent> GetByDisplayDuringRegistration(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GdprConsent where [DisplayDuringRegistration] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GdprConsent> GetByDisplayOnCustomerInfoPage(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GdprConsent where [DisplayOnCustomerInfoPage] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GdprConsent> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GdprConsent where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
