using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class GdprLogRepository : GenericRepo<GdprLog> , IGdprLogRepository
    {
        string conStr;
        public GdprLogRepository(string connection) : base(connection) { conStr = connection; }

        public List<GdprLog> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GdprLog where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GdprLog> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GdprLog where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GdprLog> GetByConsentId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GdprLog where [ConsentId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GdprLog> GetByCustomerInfo(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GdprLog where [CustomerInfo] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GdprLog> GetByRequestTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GdprLog where [RequestTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GdprLog> GetByRequestDetails(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GdprLog where [RequestDetails] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GdprLog> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GdprLog where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
