using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class MeasureWeightRepository : GenericRepo<MeasureWeight> , IMeasureWeightRepository
    {
        string conStr;
        public MeasureWeightRepository(string connection) : base(connection) { conStr = connection; }

        public List<MeasureWeight> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MeasureWeight where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MeasureWeight> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MeasureWeight where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MeasureWeight> GetBySystemKeyword(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MeasureWeight where [SystemKeyword] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MeasureWeight> GetByRatio(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MeasureWeight where [Ratio] = @param1";
            return ExecutingReader(command, param);
        }

        public List<MeasureWeight> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from MeasureWeight where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
