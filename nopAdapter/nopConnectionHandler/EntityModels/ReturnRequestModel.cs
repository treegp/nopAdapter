using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class ReturnRequest
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string ReasonForReturn { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string RequestedAction { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CustomNumber { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StoreId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int OrderItemId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int Quantity { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ReturnedQuantity { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CustomerComments { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int UploadedFileId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string StaffNotes { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ReturnRequestStatusId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime UpdatedOnUtc { get; set; }

    }
}
