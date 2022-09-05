using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class LanguageRepository : GenericRepo<Language> , ILanguageRepository
    {
        string conStr;
        public LanguageRepository(string connection) : base(connection) { conStr = connection; }

        public List<Language> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Language where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Language> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Language where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Language> GetByLanguageCulture(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Language where [LanguageCulture] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Language> GetByUniqueSeoCode(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Language where [UniqueSeoCode] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Language> GetByFlagImageFileName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Language where [FlagImageFileName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Language> GetByRtl(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Language where [Rtl] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Language> GetByLimitedToStores(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Language where [LimitedToStores] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Language> GetByDefaultCurrencyId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Language where [DefaultCurrencyId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Language> GetByPublished(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Language where [Published] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Language> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Language where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
