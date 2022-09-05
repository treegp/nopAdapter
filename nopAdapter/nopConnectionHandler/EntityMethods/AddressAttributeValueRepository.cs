using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class AddressAttributeValueRepository : GenericRepo<AddressAttributeValue> , IAddressAttributeValueRepository
    {
        string conStr;
        public AddressAttributeValueRepository(string connection) : base(connection) { conStr = connection; }

        public List<AddressAttributeValue> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from AddressAttributeValue where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<AddressAttributeValue> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from AddressAttributeValue where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<AddressAttributeValue> GetByAddressAttributeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from AddressAttributeValue where [AddressAttributeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<AddressAttributeValue> GetByIsPreSelected(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from AddressAttributeValue where [IsPreSelected] = @param1";
            return ExecutingReader(command, param);
        }

        public List<AddressAttributeValue> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from AddressAttributeValue where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
