using System.Runtime.CompilerServices;

namespace Milestone2 {
    namespace MiniTest {
        public class TestDoesNotExist : Exception {
            public TestDoesNotExist() : base() { }
            public TestDoesNotExist(string message) : base(message) { }
        }
        public class TestExists : Exception {
            public TestExists() : base() { }
            public TestExists(string message) : base(message) { }
        }

        public class Test<T> where T : class {
            string name;
            // Name of the test, initialize function, result function
            Dictionary<string, (Func<T> init, Func<T?, bool>? test)> tests = new Dictionary<string, (Func<T> init, Func<T?, bool>? test)>();
            
            public Test(string name) {
                this.name = name;
            }

            public Test<T> it(string testName, Func<T> initFunc) {
                // Throw error when test was created already
                if(tests.ContainsKey(testName)) throw new TestExists("Test " + testName + " has been created already.");

                // Include test in dictionary
                tests.Add(testName, (initFunc, null));

                return this;
            }
            public Test<T> should(string testName, Func<T?, bool> testFunc) {
                // Throw error when test has not been created
                if(!tests.ContainsKey(testName)) throw new TestDoesNotExist("Test " + testName + " does not exist yet.");

                // Add test to tuple
                var data = tests[testName];
                data.test = testFunc;
                tests[testName] = data;

                return this;
            }

            public bool runTests() {
                int pass = 0;
                int fail = 0;

                // Show header
                Console.WriteLine(name);
                Console.WriteLine(new String('=', name.Length));

                // Iterate over each test
                foreach(KeyValuePair<string, (Func<T> init, Func<T?, bool>? test)> kvp in tests) {
                    T? value = null;
                    bool passed = false;

                    // Initialize line to display test
                    Console.WriteLine();
                    Console.Write("  [-] " + kvp.Key);

                    // Set up value
                    try {
                        value = kvp.Value.init();
                    } catch {
                        // Show failure on error
                        Console.Write("\r  [f]");
                        fail++;
                        continue;
                    }

                    // Enforce that the test is needed
                    if(kvp.Value.test == null) {
                        Console.Write("\r  [f]");
                        fail++;
                        continue;
                    }

                    // Run test on item
                    try {
                        passed = kvp.Value.test!(value);
                    } catch {
                        // Show failure on error
                        Console.Write("\r  [f]");
                        fail++;
                        continue;
                    }

                    // Final pass/fail status
                    if(passed) {
                        Console.Write("\r  [p]");
                        pass++;
                    } else {
                        Console.Write("\r  [f]");
                        fail++;
                    }
                }
                Console.WriteLine();

                // Show results of testing
                Console.WriteLine();
                
                Console.WriteLine("Results");
                Console.WriteLine("-------");
                Console.WriteLine();
                
                Console.WriteLine(String.Format("    Passes: {0} ({1}%)", pass, ((float)pass / (pass + fail)) * 100));
                Console.WriteLine(String.Format("  Failures: {0} ({1}%)", fail, ((float)fail / (pass + fail)) * 100));
                Console.WriteLine();
                
                if(((float)pass / (pass + fail)) == 1)
                    Console.WriteLine("  Code is compliant.");
                else
                    Console.WriteLine("  Code is non-compliant.");

                return ((float)pass / (pass + fail)) == 1;
            }
        }
    }
}
