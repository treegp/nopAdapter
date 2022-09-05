using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class AddressAttributeRepository : GenericRepo<AddressAttribute> , IAddressAttributeRepository
    {
        string conStr;
        public AddressAttributeRepository(string connection) : base(connection) { conStr = connection; }

        public List<AddressAttribute> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from AddressAttribute where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<AddressAttribute> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from AddressAttribute where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<AddressAttribute> GetByIsRequired(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from AddressAttribute where [IsRequired] = @param1";
            return ExecutingReader(command, param);
        }

        public List<AddressAttribute> GetByAttributeControlTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from AddressAttribute where [AttributeControlTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<AddressAttribute> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from AddressAttribute where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
