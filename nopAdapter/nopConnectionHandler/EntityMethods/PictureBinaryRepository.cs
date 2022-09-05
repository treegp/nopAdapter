using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class PictureBinaryRepository : GenericRepo<PictureBinary> , IPictureBinaryRepository
    {
        string conStr;
        public PictureBinaryRepository(string connection) : base(connection) { conStr = connection; }

        public List<PictureBinary> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PictureBinary where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PictureBinary> GetByPictureId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PictureBinary where [PictureId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<PictureBinary> GetByBinaryData(byte[] value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from PictureBinary where [BinaryData] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
