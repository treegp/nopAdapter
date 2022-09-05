using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class EmailAccountRepository : GenericRepo<EmailAccount> , IEmailAccountRepository
    {
        string conStr;
        public EmailAccountRepository(string connection) : base(connection) { conStr = connection; }

        public List<EmailAccount> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from EmailAccount where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<EmailAccount> GetByDisplayName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from EmailAccount where [DisplayName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<EmailAccount> GetByEmail(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from EmailAccount where [Email] = @param1";
            return ExecutingReader(command, param);
        }

        public List<EmailAccount> GetByHost(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from EmailAccount where [Host] = @param1";
            return ExecutingReader(command, param);
        }

        public List<EmailAccount> GetByUsername(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from EmailAccount where [Username] = @param1";
            return ExecutingReader(command, param);
        }

        public List<EmailAccount> GetByPassword(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from EmailAccount where [Password] = @param1";
            return ExecutingReader(command, param);
        }

        public List<EmailAccount> GetByPort(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from EmailAccount where [Port] = @param1";
            return ExecutingReader(command, param);
        }

        public List<EmailAccount> GetByEnableSsl(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from EmailAccount where [EnableSsl] = @param1";
            return ExecutingReader(command, param);
        }

        public List<EmailAccount> GetByUseDefaultCredentials(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from EmailAccount where [UseDefaultCredentials] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
