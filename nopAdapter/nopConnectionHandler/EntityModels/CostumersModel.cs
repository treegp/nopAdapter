using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Costumers
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string FirstName { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string LastName { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTimeOffset RegDate { get; set; }

    }
}
