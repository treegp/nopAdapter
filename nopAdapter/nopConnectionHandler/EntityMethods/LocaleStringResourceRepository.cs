using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class LocaleStringResourceRepository : GenericRepo<LocaleStringResource> , ILocaleStringResourceRepository
    {
        string conStr;
        public LocaleStringResourceRepository(string connection) : base(connection) { conStr = connection; }

        public List<LocaleStringResource> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from LocaleStringResource where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<LocaleStringResource> GetByResourceName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from LocaleStringResource where [ResourceName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<LocaleStringResource> GetByResourceValue(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from LocaleStringResource where [ResourceValue] = @param1";
            return ExecutingReader(command, param);
        }

        public List<LocaleStringResource> GetByLanguageId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from LocaleStringResource where [LanguageId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
