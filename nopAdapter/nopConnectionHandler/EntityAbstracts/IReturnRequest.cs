using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IReturnRequestRepository : IGenericRepo<ReturnRequest>
    {
        List<ReturnRequest> GetById(int value);

        List<ReturnRequest> GetByReasonForReturn(string value);

        List<ReturnRequest> GetByRequestedAction(string value);

        List<ReturnRequest> GetByCustomerId(int value);

        List<ReturnRequest> GetByCustomNumber(string value);

        List<ReturnRequest> GetByStoreId(int value);

        List<ReturnRequest> GetByOrderItemId(int value);

        List<ReturnRequest> GetByQuantity(int value);

        List<ReturnRequest> GetByReturnedQuantity(int value);

        List<ReturnRequest> GetByCustomerComments(string value);

        List<ReturnRequest> GetByUploadedFileId(int value);

        List<ReturnRequest> GetByStaffNotes(string value);

        List<ReturnRequest> GetByReturnRequestStatusId(int value);

        List<ReturnRequest> GetByCreatedOnUtc(DateTime value);

        List<ReturnRequest> GetByUpdatedOnUtc(DateTime value);

    }
}
