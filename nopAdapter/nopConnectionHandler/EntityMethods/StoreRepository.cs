using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class StoreRepository : GenericRepo<Store> , IStoreRepository
    {
        string conStr;
        public StoreRepository(string connection) : base(connection) { conStr = connection; }

        public List<Store> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Store where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Store> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Store where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Store> GetByUrl(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Store where [Url] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Store> GetByHosts(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Store where [Hosts] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Store> GetByCompanyName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Store where [CompanyName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Store> GetByCompanyAddress(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Store where [CompanyAddress] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Store> GetByCompanyPhoneNumber(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Store where [CompanyPhoneNumber] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Store> GetByCompanyVat(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Store where [CompanyVat] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Store> GetBySslEnabled(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Store where [SslEnabled] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Store> GetByDefaultLanguageId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Store where [DefaultLanguageId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Store> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Store where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
