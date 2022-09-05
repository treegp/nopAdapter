using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class LocaleStringResource
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string ResourceName { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string ResourceValue { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int LanguageId { get; set; }

    }
}
