using System.Runtime.CompilerServices;

namespace Milestone3 {
    namespace MiniTest {
        /// <summary>
        /// Error when a test doesn't exist but was expected to exist
        /// </summary>
        public class TestDoesNotExist : Exception {
            public TestDoesNotExist() : base() { }
            public TestDoesNotExist(string message) : base(message) { }
        }
        /// <summary>
        /// Error when a test exists but wasn't expected to exist
        /// </summary>
        public class TestExists : Exception {
            public TestExists() : base() { }
            public TestExists(string message) : base(message) { }
        }

        /// <summary>
        /// Test suite
        /// </summary>
        /// <typeparam name="T">Non-nullable class to be tested</typeparam>
        public class Test<T> where T : class {
            /// <summary>
            /// Name of the test suite to be displayed
            /// </summary>
            string name;

            /// <summary>
            /// Internal storage for the tests with initializer and testing functions
            /// </summary>
            Dictionary<string, (Func<T> init, Func<T?, bool>? test)> tests = new Dictionary<string, (Func<T> init, Func<T?, bool>? test)>();
            
            /// <summary>
            /// Create a new test suite
            /// </summary>
            /// <param name="name">Suite name</param>
            public Test(string name) {
                this.name = name;
            }

            /// <summary>
            /// Create a new test with a specific initialization method
            /// </summary>
            /// <param name="testName">Name of the test to perform</param>
            /// <param name="initFunc">Function to initialize the test item</param>
            /// <returns>Chainable test suite</returns>
            /// <exception cref="TestExists">Only one instance of a test is allowed to be created</exception>
            public Test<T> it(string testName, Func<T> initFunc) {
                // Throw error when test was created already
                if(tests.ContainsKey(testName)) throw new TestExists("Test " + testName + " has been created already.");

                // Include test in dictionary
                tests.Add(testName, (initFunc, null));

                return this;
            }
            /// <summary>
            /// Add a custom function for testing an item
            /// </summary>
            /// <param name="testName">Name of the test to perform</param>
            /// <param name="testFunc">Function to test the item, returning true/false for passing/failing the test</param>
            /// <returns>Chainable test suite</returns>
            /// <exception cref="TestDoesNotExist">Test must first be create with Test.it()</exception>
            public Test<T> should(string testName, Func<T?, bool> testFunc) {
                // Throw error when test has not been created
                if(!tests.ContainsKey(testName)) throw new TestDoesNotExist("Test " + testName + " does not exist yet.");

                // Add test to tuple
                var data = tests[testName];
                data.test = testFunc;
                tests[testName] = data;

                return this;
            }

            /// <summary>
            /// Run tests with printed output
            /// </summary>
            /// <returns>True when all tests pass</returns>
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
