using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class UrlRecordRepository : GenericRepo<UrlRecord> , IUrlRecordRepository
    {
        string conStr;
        public UrlRecordRepository(string connection) : base(connection) { conStr = connection; }

        public List<UrlRecord> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from UrlRecord where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<UrlRecord> GetByEntityName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from UrlRecord where [EntityName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<UrlRecord> GetBySlug(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from UrlRecord where [Slug] = @param1";
            return ExecutingReader(command, param);
        }

        public List<UrlRecord> GetByEntityId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from UrlRecord where [EntityId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<UrlRecord> GetByIsActive(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from UrlRecord where [IsActive] = @param1";
            return ExecutingReader(command, param);
        }

        public List<UrlRecord> GetByLanguageId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from UrlRecord where [LanguageId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
