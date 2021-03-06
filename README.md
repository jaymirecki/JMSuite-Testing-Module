# JMSuite Testing Module v1.0.0-beta.2
##### Public releases are available [here](https://github.com/jaymirecki/JMSuite-releases)
Unit testing module for C# .NET Framework.

## User Change Log
### v1.0.0-beta.2
* Ability to time a CheckExpect and report how long the test took.
### v1.0.0-beta.1
* Ability to CheckExpect and report test results at then end of the testing program.

## Developer Change Log
### v1.0.0-beta.2
* CheckExpectTimed implemented.
### v1.0.0-beta.1
* CheckExpect and ReportTestResults implemented.

# How to interact with the project
## Getting Started

To compile: 
```
csc.exe -target:library testing.cs
```

### Prerequisites

Use the csc compiler, likely located here (if using the LSW for Ubuntu)

```
/mnt/c/Windows/Microsoft.NET/Framework/vX.X/csc.exe
```

## Running the tests

Tests are located in test_driver.cs. To run:

```
csc.exe testing_driver.cs testing.cs
```
Make sure to use csc.exe for C#, NOT the Linux csc command for Scheme

To run in Linux terminal: 
```
mono testing_driver.exe
```
To run from Windows Explorer, just double-click the .exe

## Built With

* [Microsoft .NET Framework](https://dotnet.microsoft.com/download/dotnet-framework-runtime/net472) - To compile and run on Windows
* [Mono](https://www.mono-project.com/download/stable/) - To compile and run on Linux
* [Visual Studio Code](https://code.visualstudio.com/) - The editor used

## Authors

* Jarett (Jay) Mirecki
