# How to run LuisMiguelOrtiz.MartianRobots

This project has been developed in .NET Framework and consists of a Console Application that processes robots, in a custom-sized grid, based on their position and a sequence of commands.

## Prerequisites
- Windows OS.
- Git for Windows.
- .NET Core SDK.

## Run
1. Open a Windows PowerShell window.
2. Clone the Git repository.
```
git clone https://github.com/Luismoteando/LuisMiguelOrtiz.MartianRobots.git
```
3. Navigate to the folder LuisMiguelOrtiz.MartianRobots.
```
cd LuisMiguelOrtiz.MartianRobots
```
4. Compile the project.
```
dotnet build
```
5. Navigate to the folder bin\Debug.
```
cd LuisMiguelOrtiz.MartianRobots.CLI\bin\Debug
```
6. Run the executable file with input as an argument.
```
.\LuisMiguelOrtiz.MartianRobots.CLI.exe "5 3`r`n1 1 E`r`nRFRFRFRF`r`n3 2 N`r`nFRRFLLFFRRFLL`r`n0 3 W`r`nLLFFFRFLFL"
```
On the command line, line break are replaced with its PowerShell equivalent ``` `r`n ```, and everything is enclosed between ``` "" ```.
So, the equivalent to:
```
5 3
1 1 E
RFRFRFRF
3 2 N
FRRFLLFFRRFLL
0 3 W
LLFFFRFLFL
```
would be: ```"5 3`r`n1 1 E`r`nRFRFRFRF`r`n3 2 N`r`nFRRFLLFFRRFLL`r`n0 3 W`r`nLLFFFRFLFL"```
