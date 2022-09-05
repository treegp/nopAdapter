using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ManufacturerTemplateRepository : GenericRepo<ManufacturerTemplate> , IManufacturerTemplateRepository
    {
        string conStr;
        public ManufacturerTemplateRepository(string connection) : base(connection) { conStr = connection; }

        public List<ManufacturerTemplate> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ManufacturerTemplate where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ManufacturerTemplate> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ManufacturerTemplate where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ManufacturerTemplate> GetByViewPath(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ManufacturerTemplate where [ViewPath] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ManufacturerTemplate> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ManufacturerTemplate where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
