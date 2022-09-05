using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CurrencyRepository : GenericRepo<Currency> , ICurrencyRepository
    {
        string conStr;
        public CurrencyRepository(string connection) : base(connection) { conStr = connection; }

        public List<Currency> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Currency where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Currency> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Currency where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Currency> GetByCurrencyCode(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Currency where [CurrencyCode] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Currency> GetByDisplayLocale(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Currency where [DisplayLocale] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Currency> GetByCustomFormatting(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Currency where [CustomFormatting] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Currency> GetByRate(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Currency where [Rate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Currency> GetByLimitedToStores(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Currency where [LimitedToStores] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Currency> GetByPublished(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Currency where [Published] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Currency> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Currency where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Currency> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Currency where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Currency> GetByUpdatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Currency where [UpdatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Currency> GetByRoundingTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Currency where [RoundingTypeId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
