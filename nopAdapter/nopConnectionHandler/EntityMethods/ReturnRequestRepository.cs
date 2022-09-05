using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ReturnRequestRepository : GenericRepo<ReturnRequest> , IReturnRequestRepository
    {
        string conStr;
        public ReturnRequestRepository(string connection) : base(connection) { conStr = connection; }

        public List<ReturnRequest> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequest where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequest> GetByReasonForReturn(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequest where [ReasonForReturn] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequest> GetByRequestedAction(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequest where [RequestedAction] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequest> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequest where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequest> GetByCustomNumber(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequest where [CustomNumber] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequest> GetByStoreId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequest where [StoreId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequest> GetByOrderItemId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequest where [OrderItemId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequest> GetByQuantity(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequest where [Quantity] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequest> GetByReturnedQuantity(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequest where [ReturnedQuantity] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequest> GetByCustomerComments(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequest where [CustomerComments] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequest> GetByUploadedFileId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequest where [UploadedFileId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequest> GetByStaffNotes(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequest where [StaffNotes] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequest> GetByReturnRequestStatusId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequest where [ReturnRequestStatusId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequest> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequest where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequest> GetByUpdatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequest where [UpdatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
