using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class OrderNoteRepository : GenericRepo<OrderNote> , IOrderNoteRepository
    {
        string conStr;
        public OrderNoteRepository(string connection) : base(connection) { conStr = connection; }

        public List<OrderNote> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderNote where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderNote> GetByNote(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderNote where [Note] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderNote> GetByOrderId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderNote where [OrderId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderNote> GetByDownloadId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderNote where [DownloadId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderNote> GetByDisplayToCustomer(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderNote where [DisplayToCustomer] = @param1";
            return ExecutingReader(command, param);
        }

        public List<OrderNote> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from OrderNote where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
