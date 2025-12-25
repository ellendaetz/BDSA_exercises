# BDSA2020.Assignment00

These exercises are meant to get you familiar with the tools used during the course.

The C# part of the course will use Visual Studio Code on Windows primarily but you should be able to complete all exercises using either macOS or linux if you so choose.

## Notes

This assignment is not to be submitted for review.

## Exercise 1 - Setup workstation

1. Install .NET Core: <https://dotnet.microsoft.com/download>
1. Install PowerShell 7: <https://github.com/PowerShell/PowerShell/releases>
1. Optional: Install Windows Terminal from the Windows Store
1. Optional: Install Windows Subsystem for Linux <https://docs.microsoft.com/en-us/windows/wsl/install-win10>
1. Optional: Install Ubuntu 18.04 from the Windows Store
1. Optional: Install .NET Core in WSL (Ubuntu 18.04)
1. Optional: Install PowerShell 7 in WSL (Ubuntu 18.04)
1. Install Visual Studio Code: <https://code.visualstudio.com/>
1. Enable the following extensions:
   - C#
   - .NET Core Test Explorer
   - markdownlint
   - PowerShell
   - REST Client
   - Visual Studio IntelliCode
   - vscode-icons

## Exercise 2 - Boiler plate

Using the shell of your choice:

1. Create a C# console application project
1. Create an xunit test library project
1. Reference the console app from the test library
1. Create a solution file and add the two projects
1. Make sure everything runs using:

   ```bash
   dotnet build
   dotnet run
   dotnet test
   ```

## Exercise 3 - Leap year function

A leap year in the Gregorian calendar is defined by the following rules (simplified):

> Every year that is exactly divisible by four is a leap year, except for years that are exactly divisible by 100, but these centurial years are leap years if they are exactly divisible by 400. For example, the years 1700, 1800, and 1900 are not leap years, but the years 1600 and 2000 are.

Your function should have the following signature:

```csharp
bool IsLeapYear(int year)
```

Implement the function interatively using Test-Driven Development where first write a set of tests for the first rule (divisible by four) and then implement the rule.

Continue with the subsequent rules in the same fashion.

## Exercise 4 - User input

When you run your console app the user should be prompted to type in a year and hit `[Enter]`.

Your program should respond accordingly with a `yay` or `nay` whether it's a leap year or not.

Implement the requirements for the console app. If you are up for it write the tests first here as well.

## Exercise 5 - Error handling

Consider how you want to handle errors.

The leap year function should only apply to years from 1582.

How will you handle if a user inputs something which is not convertible to an integer?

Extend your program with a number of tests and implement your error handling.

## Exercise 6 - Documenting code

Using your favorite drawing tool for diagrams and your favorite modeling language, draw a diagram visualizing the algorithm used in the latest version of your IsLeapYear function.

## Exercise 7 - LaTeX

Create a document using LaTeX in which you embed the visual created in exercise 6 and describe in prose the algorithm referring to the image.
