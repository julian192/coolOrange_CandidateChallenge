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
            Console.WriteLine(tasks[0].toString());
            Console.WriteLine(tasks[1].toString());
            Console.WriteLine(tasks[2].toString());
        }
    }
}
