using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class QueuedEmailRepository : GenericRepo<QueuedEmail> , IQueuedEmailRepository
    {
        string conStr;
        public QueuedEmailRepository(string connection) : base(connection) { conStr = connection; }

        public List<QueuedEmail> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetByFrom(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [From] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetByFromName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [FromName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetByTo(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [To] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetByToName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [ToName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetByReplyTo(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [ReplyTo] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetByReplyToName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [ReplyToName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetByCC(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [CC] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetByBcc(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [Bcc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetBySubject(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [Subject] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetByEmailAccountId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [EmailAccountId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetByPriorityId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [PriorityId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetByBody(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [Body] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetByAttachmentFilePath(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [AttachmentFilePath] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetByAttachmentFileName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [AttachmentFileName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetByAttachedDownloadId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [AttachedDownloadId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetByDontSendBeforeDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [DontSendBeforeDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetBySentTries(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [SentTries] = @param1";
            return ExecutingReader(command, param);
        }

        public List<QueuedEmail> GetBySentOnUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from QueuedEmail where [SentOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
