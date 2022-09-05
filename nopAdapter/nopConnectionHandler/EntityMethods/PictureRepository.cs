using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class PictureRepository : GenericRepo<Picture> , IPictureRepository
    {
        string conStr;
        public PictureRepository(string connection) : base(connection) { conStr = connection; }

        public List<Picture> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Picture where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Picture> GetByMimeType(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Picture where [MimeType] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Picture> GetBySeoFilename(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Picture where [SeoFilename] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Picture> GetByAltAttribute(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Picture where [AltAttribute] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Picture> GetByTitleAttribute(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Picture where [TitleAttribute] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Picture> GetByIsNew(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Picture where [IsNew] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Picture> GetByVirtualPath(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Picture where [VirtualPath] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
