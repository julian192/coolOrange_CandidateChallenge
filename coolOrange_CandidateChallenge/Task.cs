using System;

namespace coolOrange_CandidateChallenge
{
    public class Task : IPriority, IComplexity, IComparable
    {
        String name;
        int priority;
        int complexity;
        public Task(String name) 
        {
            this.name = name;
        }

        public void setPriority(int priority)
        {
            this.priority = priority;
        }

        public int getPriority()
        {
            return priority;
        }

        public void setComplexity(int complexity)
        {
            this.complexity = complexity;
        }

        public int getComplexity()
        {
            return complexity;
        }

        public int CompareTo(Task task)
        {
            return this.priority - task.priority;
        }

        public String toString()
        {
            return name + " priotity: " + priority + " complexity: " + complexity;
        }
    }
}
