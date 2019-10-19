////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                                 testing.cs                                 //
//                           JMSuite Testing Module                           //
//               Created by: Jarett (Jay) Mirecki, April 2, 2019              //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Diagnostics;

namespace JMSuite {
    public static class Testing {
        public delegate string Test();
        private static string Output = "";
        private static int NumTests = 0;
        private static int PassedTests = 0;
        public static void CheckExpect (string testName, Test testInput, 
                     string expectedOutput) {
            // if (NumTests = null)
            //     NumTests = 0;
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
        public static void CheckExpectTimed(string testName, Test testInput, string expectedOutput) {
            string testOutput;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            CheckExpect(testName, testInput, expectedOutput);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            testOutput = 
                "Test \"" + testName + "\" was completed in " + 
                String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, 
                              ts.Minutes, ts.Seconds, ts.Milliseconds / 10) + 
                              ".\n";
            Output = Output + testOutput;
        }
        public static void ReportTestResults() {
            if (NumTests == 0)
                Output = "There were no tests to report.\n";
            else if (NumTests == PassedTests)
                Output = Output + "All tests passed!";
            else
                Output = Output + PassedTests.ToString() + "/" + NumTests.ToString() + " tests passed.\n";
            Console.Write(Output);
            Output = "";
        }
    }
}