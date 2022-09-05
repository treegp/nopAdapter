using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class TopicRepository : GenericRepo<Topic> , ITopicRepository
    {
        string conStr;
        public TopicRepository(string connection) : base(connection) { conStr = connection; }

        public List<Topic> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetBySystemName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [SystemName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByIncludeInSitemap(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [IncludeInSitemap] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByIncludeInTopMenu(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [IncludeInTopMenu] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByIncludeInFooterColumn1(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [IncludeInFooterColumn1] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByIncludeInFooterColumn2(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [IncludeInFooterColumn2] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByIncludeInFooterColumn3(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [IncludeInFooterColumn3] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByAccessibleWhenStoreClosed(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [AccessibleWhenStoreClosed] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByIsPasswordProtected(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [IsPasswordProtected] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByPassword(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [Password] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByBody(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [Body] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByPublished(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [Published] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByTopicTemplateId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [TopicTemplateId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByMetaKeywords(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [MetaKeywords] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByMetaDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [MetaDescription] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByMetaTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [MetaTitle] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetBySubjectToAcl(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [SubjectToAcl] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Topic> GetByLimitedToStores(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Topic where [LimitedToStores] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
