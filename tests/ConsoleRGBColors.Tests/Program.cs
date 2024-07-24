using ConsoleRGBColors;

int shiftIndexRight(int n, int maxIndex)
{
    if (n + 1 <= maxIndex)
        return n + 1;
    return 0;
}

string title = """ 
       █████████               █████              █████████            █████               
      ███░░░░░███             ░░███               ███░░░░░███          ░░███                
     ███     ░░░   ██████   ███████   ██████     ░███    ░███   ███████ ░███████    ██████  
    ░███          ███░░███ ███░░███  ███░░███    ░███████████  ███░░███ ░███░░███  ░░░░░███ 
    ░███         ░███ ░███░███ ░███ ░███████     ░███░░░░░███ ░███ ░███ ░███ ░███   ███████ 
    ░░███     ███░███ ░███░███ ░███ ░███░░░      ░███    ░███ ░███ ░███ ░███ ░███  ███░░███ 
     ░░█████████ ░░██████ ░░████████░░██████     █████   █████░░███████ ████ █████░░████████
      ░░░░░░░░░   ░░░░░░   ░░░░░░░░  ░░░░░░     ░░░░░   ░░░░░  ░░░░░███░░░░ ░░░░░  ░░░░░░░░ 
                                                               ███ ░███                      
                                                              ░░██████  
 """;


// define red and green adn blue factors variables
int r = 255,
    g = 0,
    b = 0,
// define variables for increase and decrease the factors
    additiveIndex = 1, // 0, 1, 2
    decreaseIndex = 0; // 0, 1, 2
int[] slopes = new int[3];

// Vertical Gradient
ConsoleRGBColors.RGBConsole.PrintVerticalGradiant(title, (101, 78, 163), (234, 175, 200));

// Horizontal Gradient
ConsoleRGBColors.RGBConsole.PrintHorizontalGradiant(title, (0, 159, 255), (236, 47, 75));

Console.WriteLine("Codeagha Console RGB Color Test");
Console.WriteLine("Github: https://github.com/AmirMahdyJebreily");

// print a horizontal colors gradiant : 
for (int i = 1; i < 7; i++)
{
    if (i % 2 != 0)
    {
        slopes = new int[3];
        slopes[additiveIndex] = 15;
        additiveIndex = shiftIndexRight(additiveIndex, 2);
    }
    else
    {
        slopes = new int[3];
        slopes[decreaseIndex] = -15;
        decreaseIndex = shiftIndexRight(decreaseIndex, 2);
    }
    for (int j = 0; j < 17; j++)
    {
        r += slopes[0];
        g += slopes[1];
        b += slopes[2];
        Console.Write("#".ChangeStringForeColor(r, g, b).ChangeStringBackColor(r, g, b));
    }
}
// create a vertical colors gradiants
Console.WriteLine("\nFor Continue Press any button...");
Console.ReadKey();
for (int i = 1; i < 7; i++)
{
    if (i % 2 != 0)
    {
        slopes = new int[3];
        slopes[additiveIndex] = 1;
        additiveIndex = shiftIndexRight(additiveIndex, 2);
    }
    else
    {
        slopes = new int[3];
        slopes[decreaseIndex] = -1;
        decreaseIndex = shiftIndexRight(decreaseIndex, 2);
    }
    for (int j = 0; j < 255; j++)
    {
        r += slopes[0];
        g += slopes[1];
        b += slopes[2];
        Console.Write(".::╟▒█▒┤CODEAGHA├▒█▒╢::.".ChangeStringForeColor(r, g, b));
        Console.Write($"  ({r.ToString().ChangeStringForeColor(255, 0, 71)}, {g.ToString().ChangeStringForeColor(0, 255, 71)}, {b.ToString().ChangeStringForeColor(0, 71, 255)})");
        Console.WriteLine("\t".ChangeStringForeColor(r, g, b));
        await Task.Delay(1);
    }
}