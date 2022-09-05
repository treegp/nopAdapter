using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class DownloadRepository : GenericRepo<Download> , IDownloadRepository
    {
        string conStr;
        public DownloadRepository(string connection) : base(connection) { conStr = connection; }

        public List<Download> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Download where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Download> GetByDownloadGuid(Guid value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Download where [DownloadGuid] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Download> GetByUseDownloadUrl(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Download where [UseDownloadUrl] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Download> GetByDownloadUrl(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Download where [DownloadUrl] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Download> GetByDownloadBinary(byte[] value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Download where [DownloadBinary] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Download> GetByContentType(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Download where [ContentType] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Download> GetByFilename(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Download where [Filename] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Download> GetByExtension(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Download where [Extension] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Download> GetByIsNew(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Download where [IsNew] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
