using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class TestCase<TInput, TExpected>
    {
        public string TestName { get; set; }
        public TInput Input { get; set; }
        public TExpected Expected { get; set; }
        public Action TestAction { get; set; }

        public TestCase(string testName, TInput input, TExpected expected, Action testAction)
        {
            TestName = testName;
            Input = input;
            Expected = expected;
            TestAction = testAction;
        }

        public void Execute()
        {
            try
            {
                TestAction.Invoke();
                Console.WriteLine($"Test '{TestName}' passed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test '{TestName}' failed: {ex.Message}");
                throw;
            }
        }
    }
}
