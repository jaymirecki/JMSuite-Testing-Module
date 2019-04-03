using System;
using JMSuite;

class Driver {
    static void Main () {
        Testing.ReportTestResults();
        Testing.CheckExpect("First Test", Foo, "foo");
        Testing.CheckExpect("Passing Test", Foo, "Foo");
        Testing.CheckExpect("Error Test", Error, "true");
        Testing.CheckExpect("Empty Test", Empty, "true");
        Testing.ReportTestResults();
    }

    static string Foo() {
        return "Foo";
    }
    static string Error() {
        int [] one = { 1 };
        return one[1].ToString();
    }
    static string Empty() {
        string empty = null;
        return empty;
        // return KeepEmpty(out empty);
    }
    static string KeepEmpty(out string empty) {
        // string copy = empty;
        empty = "";
        return empty;
    }
}