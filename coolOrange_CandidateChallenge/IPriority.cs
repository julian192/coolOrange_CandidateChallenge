using Microsoft.SqlServer.Server;

namespace coolOrange_CandidateChallenge
{
    internal interface IPriority
    {
        void setPriority(int priority);
        int getPriority();
    }
}
