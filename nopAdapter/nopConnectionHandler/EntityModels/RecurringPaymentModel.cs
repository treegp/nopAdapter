using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class RecurringPayment
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int InitialOrderId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CycleLength { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CyclePeriodId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int TotalCycles { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime StartDateUtc { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsActive { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool LastPaymentFailed { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Deleted { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
