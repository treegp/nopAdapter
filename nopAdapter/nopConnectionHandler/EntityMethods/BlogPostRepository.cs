using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class BlogPostRepository : GenericRepo<BlogPost> , IBlogPostRepository
    {
        string conStr;
        public BlogPostRepository(string connection) : base(connection) { conStr = connection; }

        public List<BlogPost> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogPost where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogPost> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogPost where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogPost> GetByBody(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogPost where [Body] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogPost> GetByMetaKeywords(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogPost where [MetaKeywords] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogPost> GetByMetaTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogPost where [MetaTitle] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogPost> GetByLanguageId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogPost where [LanguageId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogPost> GetByIncludeInSitemap(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogPost where [IncludeInSitemap] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogPost> GetByBodyOverview(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogPost where [BodyOverview] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogPost> GetByAllowComments(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogPost where [AllowComments] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogPost> GetByTags(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogPost where [Tags] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogPost> GetByStartDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogPost where [StartDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogPost> GetByEndDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogPost where [EndDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogPost> GetByMetaDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogPost where [MetaDescription] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogPost> GetByLimitedToStores(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogPost where [LimitedToStores] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogPost> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogPost where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
