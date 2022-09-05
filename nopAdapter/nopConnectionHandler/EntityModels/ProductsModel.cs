using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Products
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Title { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CategoryId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal Price { get; set; }

    }
}
