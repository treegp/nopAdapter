using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ProductReview_ReviewType_MappingRepository : GenericRepo<ProductReview_ReviewType_Mapping> , IProductReview_ReviewType_MappingRepository
    {
        string conStr;
        public ProductReview_ReviewType_MappingRepository(string connection) : base(connection) { conStr = connection; }

        public List<ProductReview_ReviewType_Mapping> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview_ReviewType_Mapping where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReview_ReviewType_Mapping> GetByProductReviewId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview_ReviewType_Mapping where [ProductReviewId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReview_ReviewType_Mapping> GetByReviewTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview_ReviewType_Mapping where [ReviewTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductReview_ReviewType_Mapping> GetByRating(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductReview_ReviewType_Mapping where [Rating] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
