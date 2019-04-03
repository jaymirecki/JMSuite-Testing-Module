////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                                 testing.cs                                 //
//                           JMSuite Testing Module                           //
//               Created by: Jarett (Jay) Mirecki, April 2, 2019              //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;

namespace JMSuite {
    public static class Testing {
        public delegate string Test();
        private static string Output;
        private static int NumTests;
        private static int PassedTests;
        public static void CheckExpect (string testName, Test testInput, 
                     string expectedOutput) {
            NumTests = NumTests + 1;
            string testOutput;
            try {
                testOutput = testInput();
                if (testOutput == expectedOutput) {
                    PassedTests = PassedTests + 1;
                } else {
                    testOutput = "Test \"" + testName + "\" failed. Expected \"" + expectedOutput + "\" but got \"" + testOutput + "\".\n";
                    Output = Output + testOutput;
                }
            } catch (Exception e) {
                testOutput = "Test \"" + testName + "\" failed. Expected \"" + expectedOutput + "\" but raised exception \"" + e.ToString() + "\".\n";
                Output = Output + testOutput;
            }
        }
        public static void ReportTestResults() {
            if (NumTests == 0)
                Output = "There were no tests to report.\n";
            else if (NumTests == PassedTests)
                Output = "All tests passed!";
            else
                Output = Output + PassedTests.ToString() + "/" + NumTests.ToString() + " tests passed.\n";
            Console.Write(Output);
            Output = "";
        }
    }
}