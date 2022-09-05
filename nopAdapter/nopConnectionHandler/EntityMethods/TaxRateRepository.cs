using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class TaxRateRepository : GenericRepo<TaxRate> , ITaxRateRepository
    {
        string conStr;
        public TaxRateRepository(string connection) : base(connection) { conStr = connection; }

        public List<TaxRate> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TaxRate where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TaxRate> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TaxRate where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TaxRate> GetByTaxCategoryId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TaxRate where [TaxCategoryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TaxRate> GetByCountryId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TaxRate where [CountryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TaxRate> GetByStateProvinceId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TaxRate where [StateProvinceId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TaxRate> GetByZip(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TaxRate where [Zip] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TaxRate> GetByPercentage(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TaxRate where [Percentage] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
