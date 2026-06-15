# Gilded Rose starting position in C# NUnit

## Testing Strategy
### AI Testing
We pasted every class including GildedRoseTest into ChatGPT and said we need
```
i have these classes and i need some tests for it. Make useful tests only
[pasted sourecode]
this is one example of testing
[pasted test class]
```
We then went through the test cases and checked if they made sense

### TDD Principles
We additionally let ChatGPT check in a new chat, if our tests follow TDD Principles.\
This was it's answer:
* ✔ Good TDD-style test design
* ❌ Not strong evidence of strict TDD process
* ✔ Very good behavioral specification coverage
* ❌ Likely written in batches rather than red-green-refactor cycles

## Build the project

Use your normal build tools to build the projects in Debug mode.
For example, you can use the `dotnet` command line tool:

``` cmd
dotnet build GildedRose.sln -c Debug
```

## Run the Gilded Rose Command-Line program

For e.g. 10 days:

``` cmd
GildedRose/bin/Debug/net8.0/GildedRose 10
```

## Run all the unit tests

``` cmd
dotnet test
```