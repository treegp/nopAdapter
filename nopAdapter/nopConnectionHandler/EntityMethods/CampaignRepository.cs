using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CampaignRepository : GenericRepo<Campaign> , ICampaignRepository
    {
        string conStr;
        public CampaignRepository(string connection) : base(connection) { conStr = connection; }

        public List<Campaign> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Campaign where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Campaign> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Campaign where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Campaign> GetBySubject(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Campaign where [Subject] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Campaign> GetByBody(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Campaign where [Body] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Campaign> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Campaign where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Campaign> GetByCustomerRoleId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Campaign where [CustomerRoleId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Campaign> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Campaign where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Campaign> GetByDontSendBeforeDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Campaign where [DontSendBeforeDateUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
