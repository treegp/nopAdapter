using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class VendorNoteRepository : GenericRepo<VendorNote> , IVendorNoteRepository
    {
        string conStr;
        public VendorNoteRepository(string connection) : base(connection) { conStr = connection; }

        public List<VendorNote> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from VendorNote where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<VendorNote> GetByNote(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from VendorNote where [Note] = @param1";
            return ExecutingReader(command, param);
        }

        public List<VendorNote> GetByVendorId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from VendorNote where [VendorId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<VendorNote> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from VendorNote where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
