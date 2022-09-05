using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class NewsCommentRepository : GenericRepo<NewsComment> , INewsCommentRepository
    {
        string conStr;
        public NewsCommentRepository(string connection) : base(connection) { conStr = connection; }

        public List<NewsComment> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from NewsComment where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<NewsComment> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from NewsComment where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<NewsComment> GetByNewsItemId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from NewsComment where [NewsItemId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<NewsComment> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from NewsComment where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<NewsComment> GetByCommentTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from NewsComment where [CommentTitle] = @param1";
            return ExecutingReader(command, param);
        }

        public List<NewsComment> GetByCommentText(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from NewsComment where [CommentText] = @param1";
            return ExecutingReader(command, param);
        }

        public List<NewsComment> GetByIsApproved(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from NewsComment where [IsApproved] = @param1";
            return ExecutingReader(command, param);
        }

        public List<NewsComment> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from NewsComment where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
