using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class AffiliateRepository : GenericRepo<Affiliate> , IAffiliateRepository
    {
        string conStr;
        public AffiliateRepository(string connection) : base(connection) { conStr = connection; }

        public List<Affiliate> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Affiliate where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Affiliate> GetByAddressId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Affiliate where [AddressId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Affiliate> GetByAdminComment(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Affiliate where [AdminComment] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Affiliate> GetByFriendlyUrlName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Affiliate where [FriendlyUrlName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Affiliate> GetByDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Affiliate where [Deleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Affiliate> GetByActive(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Affiliate where [Active] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
