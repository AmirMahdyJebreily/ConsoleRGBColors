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
The result :    
![Test colors Result](https://github.com/AmirMahdyJebreily/ConsoleRGBColors/blob/main/docs/assets/test_color.png)

Also you can use css default colors which in `Color` struct like this :
```csharp
Console.WriteLine($"Use Css {"Color".ChangeStringForeColor(Color.Chocolate)}");
```
The result :  
![Use Css Colors Results](https://github.com/AmirMahdyJebreily/ConsoleRGBColors/blob/main/docs/assets/use_css_colors.png)

To print a gradient use this codes:   
```csharp
// Vertical Gradient
ConsoleRGBColors.RGBConsole.PrintVerticalGradiant(text, (101, 78, 163), (234, 175, 200));

// Horizontal Gradient
ConsoleRGBColors.RGBConsole.PrintHorizontalGradiant(text, (0, 159, 255), (236, 47, 75));
```
result : 
![Vertical and Horizontal Gradients Result](https://github.com/AmirMahdyJebreily/ConsoleRGBColors/blob/main/docs/assets/gradients.png)

Fo more information about using, see the [Test](https://github.com/AmirMahdyJebreily/ConsoleRGBColors/blob/main/tests/ConsoleRGBColors.UnitTests/Program.cs)

![Tests Result](https://github.com/AmirMahdyJebreily/ConsoleRGBColors/blob/main//docs/assets/image.png)

---
thank you for star this project and submit issues in github ❤️
