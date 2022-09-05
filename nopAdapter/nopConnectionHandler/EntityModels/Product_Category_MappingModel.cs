using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Product_Category_Mapping
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CategoryId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsFeaturedProduct { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

    }
}
