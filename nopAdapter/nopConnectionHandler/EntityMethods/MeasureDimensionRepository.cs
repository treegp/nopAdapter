using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class MeasureDimensionRepository : GenericRepo<MeasureDimension> , IMeasureDimensionRepository
    {
        string conStr;
        public MeasureDimensionRepository(string connection) : base(connection) { conStr = connection; }

        public List<MeasureDimension> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MeasureDimension where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MeasureDimension> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MeasureDimension where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MeasureDimension> GetBySystemKeyword(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MeasureDimension where [SystemKeyword] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MeasureDimension> GetByRatio(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MeasureDimension where [Ratio] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MeasureDimension> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MeasureDimension where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
