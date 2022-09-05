using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class StateProvinceRepository : GenericRepo<StateProvince> , IStateProvinceRepository
    {
        string conStr;
        public StateProvinceRepository(string connection) : base(connection) { conStr = connection; }

        public List<StateProvince> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StateProvince where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StateProvince> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StateProvince where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StateProvince> GetByAbbreviation(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StateProvince where [Abbreviation] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StateProvince> GetByCountryId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StateProvince where [CountryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StateProvince> GetByPublished(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StateProvince where [Published] = @param1";
            return ExecutingReader(command, param);
        }

        public List<StateProvince> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from StateProvince where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
