using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class CreditCards
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string CardNumber { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTimeOffset ExpireDate { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CustomerId { get; set; }

    }
}
