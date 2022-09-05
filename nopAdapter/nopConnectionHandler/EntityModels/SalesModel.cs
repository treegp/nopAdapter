using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Sales
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CostumerId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTimeOffset CreatedDate { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal TotalCost { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int AddressId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int Status { get; set; }

    }
}
