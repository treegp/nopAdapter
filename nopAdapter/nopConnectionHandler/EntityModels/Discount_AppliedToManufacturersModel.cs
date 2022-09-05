using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Discount_AppliedToManufacturers
    {
        [GenericRepoModel.Column(true,false,true)]
        public int Discount_Id { get; set; }

        [GenericRepoModel.Column(true,false,true)]
        public int Manufacturer_Id { get; set; }

    }
}
