using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ExternalAuthenticationRecordRepository : GenericRepo<ExternalAuthenticationRecord> , IExternalAuthenticationRecordRepository
    {
        string conStr;
        public ExternalAuthenticationRecordRepository(string connection) : base(connection) { conStr = connection; }

        public List<ExternalAuthenticationRecord> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ExternalAuthenticationRecord where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ExternalAuthenticationRecord> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ExternalAuthenticationRecord where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ExternalAuthenticationRecord> GetByEmail(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ExternalAuthenticationRecord where [Email] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ExternalAuthenticationRecord> GetByExternalIdentifier(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ExternalAuthenticationRecord where [ExternalIdentifier] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ExternalAuthenticationRecord> GetByExternalDisplayIdentifier(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ExternalAuthenticationRecord where [ExternalDisplayIdentifier] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ExternalAuthenticationRecord> GetByOAuthToken(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ExternalAuthenticationRecord where [OAuthToken] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ExternalAuthenticationRecord> GetByOAuthAccessToken(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ExternalAuthenticationRecord where [OAuthAccessToken] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ExternalAuthenticationRecord> GetByProviderSystemName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ExternalAuthenticationRecord where [ProviderSystemName] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
