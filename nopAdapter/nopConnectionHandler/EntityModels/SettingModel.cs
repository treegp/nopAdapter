using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Setting
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Value { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int StoreId { get; set; }

    }
}
