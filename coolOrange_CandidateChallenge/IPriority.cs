using Microsoft.SqlServer.Server;

namespace coolOrange_CandidateChallenge
{
    internal interface IPriority
    {
        void setPriority(Priority priority);
        Priority getPriority();
    }

    public enum Priority
    {
        LOW_PRIORITY = 1,
        MID_PRIORITY = 5,
        HIGH_PRIORITY = 10
    }
}
