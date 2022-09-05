using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Product_ProductTag_Mapping
    {
        [GenericRepoModel.Column(true,false,true)]
        public int Product_Id { get; set; }

        [GenericRepoModel.Column(true,false,true)]
        public int ProductTag_Id { get; set; }

    }
}
