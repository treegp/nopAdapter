using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class VendorAttributeRepository : GenericRepo<VendorAttribute> , IVendorAttributeRepository
    {
        string conStr;
        public VendorAttributeRepository(string connection) : base(connection) { conStr = connection; }

        public List<VendorAttribute> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from VendorAttribute where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<VendorAttribute> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from VendorAttribute where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<VendorAttribute> GetByIsRequired(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from VendorAttribute where [IsRequired] = @param1";
            return ExecutingReader(command, param);
        }

        public List<VendorAttribute> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from VendorAttribute where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<VendorAttribute> GetByAttributeControlTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from VendorAttribute where [AttributeControlTypeId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
