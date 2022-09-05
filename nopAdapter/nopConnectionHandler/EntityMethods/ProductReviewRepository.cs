using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ProductReviewRepository : GenericRepo<ProductReview> , IProductReviewRepository
    {
        string conStr;
        public ProductReviewRepository(string connection) : base(connection) { conStr = connection; }

        public List<ProductReview> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReview> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReview> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReview> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReview> GetByIsApproved(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview where [IsApproved] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReview> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReview> GetByReviewText(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview where [ReviewText] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReview> GetByReplyText(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview where [ReplyText] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReview> GetByCustomerNotifiedOfReply(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview where [CustomerNotifiedOfReply] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReview> GetByRating(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview where [Rating] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReview> GetByHelpfulYesTotal(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview where [HelpfulYesTotal] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReview> GetByHelpfulNoTotal(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview where [HelpfulNoTotal] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReview> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
