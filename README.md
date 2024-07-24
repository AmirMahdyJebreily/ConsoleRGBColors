# ConsoleRGBColors
Unfortunately, the .NET core does not have the ability for professional color schemes, and it was fun to play with ANSI. The result was this package
## Intall
### Use Nuget
```bash
dotnet add package ConsoleRGBColors --version 1.0.1
```
### Build the Source 
You can clone the repo and build the package dll file with the following commands:
```bash
git clone git@github.com:AmirMahdyJebreily/ConsoleRGBColors.git &&
cd ConsoleRGBColors &&
dotnet build -c Release
```
Now you can go to your console project and add the generated dll file to the references:
```bash
dotnet add app/app.csproj reference path/to/the/dll/file/ConsoleRGBColors.dll
```
## Using
To use ConsoleRGBColors, you must first add the following namespace:
```csharp
using ConsoleRGBColors;
```
Now you able to change ForeColor or BackColor of any string in any part of the text: 
```csharp
Console.WriteLine($"Test {"Color".ChangeStringForeColor(255,71,71)}");
Console.WriteLine($"Test {"Color".ChangeStringBackColor(255,71,71)}");
```
