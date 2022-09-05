using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ProductReviewHelpfulnessRepository : GenericRepo<ProductReviewHelpfulness> , IProductReviewHelpfulnessRepository
    {
        string conStr;
        public ProductReviewHelpfulnessRepository(string connection) : base(connection) { conStr = connection; }

        public List<ProductReviewHelpfulness> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReviewHelpfulness where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReviewHelpfulness> GetByProductReviewId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReviewHelpfulness where [ProductReviewId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReviewHelpfulness> GetByWasHelpful(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReviewHelpfulness where [WasHelpful] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReviewHelpfulness> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReviewHelpfulness where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
