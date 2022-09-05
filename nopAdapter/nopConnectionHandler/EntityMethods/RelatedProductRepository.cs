using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class RelatedProductRepository : GenericRepo<RelatedProduct> , IRelatedProductRepository
    {
        string conStr;
        public RelatedProductRepository(string connection) : base(connection) { conStr = connection; }

        public List<RelatedProduct> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RelatedProduct where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RelatedProduct> GetByProductId1(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RelatedProduct where [ProductId1] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RelatedProduct> GetByProductId2(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RelatedProduct where [ProductId2] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RelatedProduct> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RelatedProduct where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
