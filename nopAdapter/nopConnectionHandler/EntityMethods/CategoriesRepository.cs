using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CategoriesRepository : GenericRepo<Categories> , ICategoriesRepository
    {
        string conStr;
        public CategoriesRepository(string connection) : base(connection) { conStr = connection; }

        public List<Categories> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Categories where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Categories> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Categories where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Categories> GetByParentCategoryId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Categories where [ParentCategoryId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
