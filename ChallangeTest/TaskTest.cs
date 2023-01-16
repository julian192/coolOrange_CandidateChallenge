using coolOrange_CandidateChallenge;
using Task = coolOrange_CandidateChallenge.Task;

namespace ChallangeTest
{
    [TestFixture]
    public class TaskTest
    {
        [Test]
        public void TestInitialisation()
        {
            Task task = new Task("Test");
            Assert.IsTrue(task.getName().Equals("Test"));
        }

        [Test]
        public void TestSetterGetter()
        {
            Task task = new Task("Test");
            task.setComplexity(1);
            task.setPriority(Priority.HIGH_PRIORITY);
            task.setName("Name");
            Assert.IsTrue(task.getName().Equals("Name"));
            Assert.IsTrue(task.getComplexity() == 1);
            Assert.IsTrue(task.getPriority().Equals(Priority.HIGH_PRIORITY));
        }

        [Test]
        public void TestToString()
        {
            Task task = new Task("Test");
            task.setComplexity(1);
            task.setPriority(Priority.HIGH_PRIORITY);
            Console.WriteLine(task.toString());
            Assert.IsTrue(task.toString().Equals("Test priority: 10 complexity: 1"));
        }
    }
}
