using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class LocalizedPropertyRepository : GenericRepo<LocalizedProperty> , ILocalizedPropertyRepository
    {
        string conStr;
        public LocalizedPropertyRepository(string connection) : base(connection) { conStr = connection; }

        public List<LocalizedProperty> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from LocalizedProperty where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<LocalizedProperty> GetByLocaleKeyGroup(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from LocalizedProperty where [LocaleKeyGroup] = @param1";
            return ExecutingReader(command, param);
        }

        public List<LocalizedProperty> GetByLocaleKey(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from LocalizedProperty where [LocaleKey] = @param1";
            return ExecutingReader(command, param);
        }

        public List<LocalizedProperty> GetByLocaleValue(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from LocalizedProperty where [LocaleValue] = @param1";
            return ExecutingReader(command, param);
        }

        public List<LocalizedProperty> GetByLanguageId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from LocalizedProperty where [LanguageId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<LocalizedProperty> GetByEntityId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from LocalizedProperty where [EntityId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
