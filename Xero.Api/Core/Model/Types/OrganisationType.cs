using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum OrganisationType
    {
        [EnumMember(Value = "COMPANY")]
        Company,
        [EnumMember(Value = "CHARITY")]
        Charity,
        [EnumMember(Value = "CLUB_OR_SOCIETY")]
        ClubSociety,
        [EnumMember(Value = "PARTNERSHIP")]
        Partnership,
        [EnumMember(Value = "PERSON")]
        Person,
        [EnumMember(Value = "SOLE_TRADER")]
        SoleTrader,
        [EnumMember(Value = "TRUST")]
        Trust,
        [EnumMember(Value = "LOOK_THROUGH_COMPANY")]
        Look-through Company,
        [EnumMember(Value = "NOT_FOR_PROFIT")]
        NotforProfit,
        [EnumMember(Value = "SELF_MANAGED_SUPERANNUATION_FUND")]
        SelfManagedSuperannuationFund,
        [EnumMember(Value = "SUPERANNUATION_FUND")]
        SuperannuationFund,
        [EnumMember(Value = "S_CORPORATION")]
        SCorporation
    }
}
