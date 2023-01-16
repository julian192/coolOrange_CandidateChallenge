using System;

namespace coolOrange_CandidateChallenge
{
    public class Task : IPriority, IComplexity, IComparable
    {
        private String name;
        private Priority priority;
        private int complexity;
        public Task(String name) 
        {
            this.name = name;
            priority = Priority.MID_PRIORITY;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setPriority(Priority priority)
        {
            this.priority = priority;
        }

        public Priority getPriority()
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
            return ((int)this.priority) - ((int)task.priority);
        }

        public String toString()
        {
            return name + " priority: " + (int)priority + " complexity: " + complexity;
        }
    }
}
