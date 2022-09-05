using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class NewsRepository : GenericRepo<News> , INewsRepository
    {
        string conStr;
        public NewsRepository(string connection) : base(connection) { conStr = connection; }

        public List<News> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from News where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<News> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from News where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<News> GetByShort(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from News where [Short] = @param1";
            return ExecutingReader(command, param);
        }

        public List<News> GetByFull(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from News where [Full] = @param1";
            return ExecutingReader(command, param);
        }

        public List<News> GetByMetaKeywords(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from News where [MetaKeywords] = @param1";
            return ExecutingReader(command, param);
        }

        public List<News> GetByMetaTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from News where [MetaTitle] = @param1";
            return ExecutingReader(command, param);
        }

        public List<News> GetByLanguageId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from News where [LanguageId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<News> GetByPublished(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from News where [Published] = @param1";
            return ExecutingReader(command, param);
        }

        public List<News> GetByStartDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from News where [StartDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<News> GetByEndDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from News where [EndDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<News> GetByAllowComments(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from News where [AllowComments] = @param1";
            return ExecutingReader(command, param);
        }

        public List<News> GetByLimitedToStores(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from News where [LimitedToStores] = @param1";
            return ExecutingReader(command, param);
        }

        public List<News> GetByMetaDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from News where [MetaDescription] = @param1";
            return ExecutingReader(command, param);
        }

        public List<News> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from News where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
