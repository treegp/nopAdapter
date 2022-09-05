using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class VendorAttributeValueRepository : GenericRepo<VendorAttributeValue> , IVendorAttributeValueRepository
    {
        string conStr;
        public VendorAttributeValueRepository(string connection) : base(connection) { conStr = connection; }

        public List<VendorAttributeValue> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from VendorAttributeValue where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<VendorAttributeValue> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from VendorAttributeValue where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<VendorAttributeValue> GetByVendorAttributeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from VendorAttributeValue where [VendorAttributeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<VendorAttributeValue> GetByIsPreSelected(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from VendorAttributeValue where [IsPreSelected] = @param1";
            return ExecutingReader(command, param);
        }

        public List<VendorAttributeValue> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from VendorAttributeValue where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
