using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class SearchTermRepository : GenericRepo<SearchTerm> , ISearchTermRepository
    {
        string conStr;
        public SearchTermRepository(string connection) : base(connection) { conStr = connection; }

        public List<SearchTerm> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SearchTerm where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<SearchTerm> GetByKeyword(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SearchTerm where [Keyword] = @param1";
            return ExecutingReader(command, param);
        }

        public List<SearchTerm> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SearchTerm where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<SearchTerm> GetByCount(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SearchTerm where [Count] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
