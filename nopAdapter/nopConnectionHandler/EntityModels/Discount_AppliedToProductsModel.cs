using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Discount_AppliedToProducts
    {
        [GenericRepoModel.Column(true,false,true)]
        public int Discount_Id { get; set; }

        [GenericRepoModel.Column(true,false,true)]
        public int Product_Id { get; set; }

    }
}
