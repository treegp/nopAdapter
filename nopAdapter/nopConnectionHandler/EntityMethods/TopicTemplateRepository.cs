using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class TopicTemplateRepository : GenericRepo<TopicTemplate> , ITopicTemplateRepository
    {
        string conStr;
        public TopicTemplateRepository(string connection) : base(connection) { conStr = connection; }

        public List<TopicTemplate> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TopicTemplate where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TopicTemplate> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TopicTemplate where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TopicTemplate> GetByViewPath(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TopicTemplate where [ViewPath] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TopicTemplate> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TopicTemplate where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
