using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class BlogCommentRepository : GenericRepo<BlogComment> , IBlogCommentRepository
    {
        string conStr;
        public BlogCommentRepository(string connection) : base(connection) { conStr = connection; }

        public List<BlogComment> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogComment where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogComment> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogComment where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogComment> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogComment where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogComment> GetByBlogPostId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogComment where [BlogPostId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogComment> GetByCommentText(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogComment where [CommentText] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogComment> GetByIsApproved(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogComment where [IsApproved] = @param1";
            return ExecutingReader(command, param);
        }

        public List<BlogComment> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from BlogComment where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
