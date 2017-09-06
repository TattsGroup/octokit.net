using Octokit.Internal;

namespace Octokit
{
    public class TeamMembershipResponse
    {
        public StringEnum<TeamRole> Role { get; set; }

        public StringEnum<MembershipState> State { get; set; }
    }

    public enum TeamMembership
    {
        NotFound = 0,
        Pending = 1,
        Active = 2
    }

    public enum MembershipState
    {
        [Parameter(Value = "pending")]
        Pending,

        [Parameter(Value = "active")]
        Active
    }

    public enum TeamRole
    {
        [Parameter(Value = "member")]
        Member,

        [Parameter(Value = "maintainer")]
        Maintainer
    }

    public enum TeamRoleFilter
    {
        [Parameter(Value = "member")]
        Member,

        [Parameter(Value = "maintainer")]
        Maintainer,

        [Parameter(Value = "all")]
        All
    }
}
