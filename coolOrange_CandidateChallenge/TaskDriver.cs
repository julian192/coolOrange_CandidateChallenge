using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    class TaskDriver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TO - DO");
            Console.WriteLine("---------");

            Task[] tasks = new Task[3];
            tasks[0] = new Task("Doing Homework");
            tasks[1] = new Task("Eating Lunch");
            tasks[2] = new Task("Programming");

            tasks[0].setPriority(Priority.HIGH_PRIORITY);
            tasks[1].setPriority(Priority.LOW_PRIORITY);

            tasks[0].setComplexity(8);
            tasks[1].setComplexity(2);
            tasks[2].setComplexity(5);

            Console.WriteLine(tasks[0].toString());
            Console.WriteLine(tasks[1].toString());
            Console.WriteLine(tasks[2].toString());

            Task mostimportant = tasks[0];
            for(int i = 0; i < tasks.Length; i++)
                if (tasks[i].CompareTo(mostimportant) > 0)
                    mostimportant = tasks[i];

            Console.WriteLine("\n" + mostimportant.getName() + " is one of the most important tasks");
        }
    }
}
