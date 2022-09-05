using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Discount_AppliedToCategories
    {
        [GenericRepoModel.Column(true,false,true)]
        public int Discount_Id { get; set; }

        [GenericRepoModel.Column(true,false,true)]
        public int Category_Id { get; set; }

    }
}
