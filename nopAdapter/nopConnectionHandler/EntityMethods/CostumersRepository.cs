using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CostumersRepository : GenericRepo<Costumers> , ICostumersRepository
    {
        string conStr;
        public CostumersRepository(string connection) : base(connection) { conStr = connection; }

        public List<Costumers> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Costumers where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Costumers> GetByFirstName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Costumers where [FirstName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Costumers> GetByLastName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Costumers where [LastName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Costumers> GetByRegDate(DateTimeOffset value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Costumers where [RegDate] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
