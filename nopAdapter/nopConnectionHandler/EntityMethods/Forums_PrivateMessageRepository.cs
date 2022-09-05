using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class Forums_PrivateMessageRepository : GenericRepo<Forums_PrivateMessage> , IForums_PrivateMessageRepository
    {
        string conStr;
        public Forums_PrivateMessageRepository(string connection) : base(connection) { conStr = connection; }

        public List<Forums_PrivateMessage> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_PrivateMessage where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_PrivateMessage> GetBySubject(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_PrivateMessage where [Subject] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_PrivateMessage> GetByText(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_PrivateMessage where [Text] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_PrivateMessage> GetByFromCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_PrivateMessage where [FromCustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_PrivateMessage> GetByToCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_PrivateMessage where [ToCustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_PrivateMessage> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_PrivateMessage where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_PrivateMessage> GetByIsRead(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_PrivateMessage where [IsRead] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_PrivateMessage> GetByIsDeletedByAuthor(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_PrivateMessage where [IsDeletedByAuthor] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_PrivateMessage> GetByIsDeletedByRecipient(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_PrivateMessage where [IsDeletedByRecipient] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Forums_PrivateMessage> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Forums_PrivateMessage where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
