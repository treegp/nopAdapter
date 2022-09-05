using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class DiscountRequirement
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DiscountId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> ParentId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string DiscountRequirementRuleSystemName { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> InteractionTypeId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsGroup { get; set; }

    }
}
