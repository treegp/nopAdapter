using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class MessageTemplateRepository : GenericRepo<MessageTemplate> , IMessageTemplateRepository
    {
        string conStr;
        public MessageTemplateRepository(string connection) : base(connection) { conStr = connection; }

        public List<MessageTemplate> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MessageTemplate where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MessageTemplate> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MessageTemplate where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MessageTemplate> GetByBccEmailAddresses(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MessageTemplate where [BccEmailAddresses] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MessageTemplate> GetBySubject(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MessageTemplate where [Subject] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MessageTemplate> GetByEmailAccountId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MessageTemplate where [EmailAccountId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MessageTemplate> GetByBody(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MessageTemplate where [Body] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MessageTemplate> GetByIsActive(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MessageTemplate where [IsActive] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MessageTemplate> GetByDelayBeforeSend(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MessageTemplate where [DelayBeforeSend] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MessageTemplate> GetByDelayPeriodId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MessageTemplate where [DelayPeriodId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MessageTemplate> GetByAttachedDownloadId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MessageTemplate where [AttachedDownloadId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MessageTemplate> GetByLimitedToStores(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MessageTemplate where [LimitedToStores] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
