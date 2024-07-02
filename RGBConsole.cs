using System.Drawing;

namespace ConsoleRGBColors;

public static class RGBConsole
{
    private const string _ESC_Code_Sequence_Foreground = "ESC[38;2;{0};{1};{2}m";
    private const string _ESC_Code_Sequence_Background = "ESC[48;2;{0};{1};{2}m";

    // Return an 'ANSI Ecape' char that changes the Console's Foreground color
    public static string ChangeForeColorChar(int r, int g, int b) 
        => string.Format(_ESC_Code_Sequence_Foreground, r.ToString(), g.ToString(), b.ToString());

    #region ChangeForeColorChar Overloads
    public static string ChangeForeColorChar(Color color)
    => string.Format(_ESC_Code_Sequence_Foreground, color.R.ToString(), color.G.ToString(), color.B.ToString());
    #endregion

    // Return an 'ANSI Ecape' char that changes the Console's Background color
    public static string ChangeBackColorChar(int r, int g, int b)
        => string.Format(_ESC_Code_Sequence_Background, r.ToString(), g.ToString(), b.ToString());

    #region ChangeBackColorChar Overloads
    public static string ChangeBackColorChar(Color color)
    => string.Format(_ESC_Code_Sequence_Background, color.R.ToString(), color.G.ToString(), color.B.ToString());
    #endregion
}
