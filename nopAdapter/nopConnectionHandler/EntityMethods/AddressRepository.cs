using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class AddressRepository : GenericRepo<Address> , IAddressRepository
    {
        string conStr;
        public AddressRepository(string connection) : base(connection) { conStr = connection; }

        public List<Address> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Address where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Address> GetByCountryId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Address where [CountryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Address> GetByStateProvinceId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Address where [StateProvinceId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Address> GetByFirstName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Address where [FirstName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Address> GetByLastName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Address where [LastName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Address> GetByEmail(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Address where [Email] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Address> GetByCompany(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Address where [Company] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Address> GetByCounty(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Address where [County] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Address> GetByCity(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Address where [City] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Address> GetByAddress1(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Address where [Address1] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Address> GetByAddress2(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Address where [Address2] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Address> GetByZipPostalCode(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Address where [ZipPostalCode] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Address> GetByPhoneNumber(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Address where [PhoneNumber] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Address> GetByFaxNumber(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Address where [FaxNumber] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Address> GetByCustomAttributes(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Address where [CustomAttributes] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Address> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Address where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
