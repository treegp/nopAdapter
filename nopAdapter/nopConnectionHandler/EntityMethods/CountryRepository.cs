using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CountryRepository : GenericRepo<Country> , ICountryRepository
    {
        string conStr;
        public CountryRepository(string connection) : base(connection) { conStr = connection; }

        public List<Country> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Country where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Country> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Country where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Country> GetByTwoLetterIsoCode(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Country where [TwoLetterIsoCode] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Country> GetByThreeLetterIsoCode(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Country where [ThreeLetterIsoCode] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Country> GetByAllowsBilling(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Country where [AllowsBilling] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Country> GetByAllowsShipping(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Country where [AllowsShipping] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Country> GetByNumericIsoCode(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Country where [NumericIsoCode] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Country> GetBySubjectToVat(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Country where [SubjectToVat] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Country> GetByPublished(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Country where [Published] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Country> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Country where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Country> GetByLimitedToStores(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Country where [LimitedToStores] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
