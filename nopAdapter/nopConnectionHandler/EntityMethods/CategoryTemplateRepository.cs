using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CategoryTemplateRepository : GenericRepo<CategoryTemplate> , ICategoryTemplateRepository
    {
        string conStr;
        public CategoryTemplateRepository(string connection) : base(connection) { conStr = connection; }

        public List<CategoryTemplate> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CategoryTemplate where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CategoryTemplate> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CategoryTemplate where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CategoryTemplate> GetByViewPath(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CategoryTemplate where [ViewPath] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CategoryTemplate> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CategoryTemplate where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
