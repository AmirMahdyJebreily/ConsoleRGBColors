using System.Drawing;

namespace ConsoleRGBColors;

public static class RGBConsole
{
    private const string _ESC_Code_Sequence_Foreground = "ESC[38;2;{0};{1};{2}m";
    private const string _ESC_Code_Sequence_Background = "ESC[48;2;{0};{1};{2}m";

    #region Basic Functions   
    /// <summary>
    /// Based on <code>ESC[38;2;{r};{g};{b}m</code> ANSI Escape code
    /// </summary>
    /// <param name="r">The RED component value of the color</param>
    /// <param name="g">The GREEN component value of the color</param>
    /// <param name="b">The BLUE component value of the color</param>
    /// <returns>Returns an 'ANSI Ecape' characters that changes the Console's Foreground color</returns>
    public static string ChangeForeColorChar(int r, int g, int b) 
        => string.Format(_ESC_Code_Sequence_Foreground, r.ToString(), g.ToString(), b.ToString());

    #region ChangeForeColorChar Overloads
    /// <summary>
    /// Based on <code>ESC[38;2;{r};{g};{b}m</code> ANSI Escape code
    /// </summary>
    /// <param name="color">Gets the color as an object</param>
    /// <returns>Returns an 'ANSI Ecape' characters that changes the Console's Foreground color</returns>
    public static string ChangeForeColorChar(Color color)
        => string.Format(_ESC_Code_Sequence_Foreground, color.R.ToString(), color.G.ToString(), color.B.ToString());
    #endregion


    /// <summary>
    /// Based on <code>ESC[48;2;{r};{g};{b}m</code> ANSI Escape code
    /// </summary>
    /// <param name="r">The RED component value of the color</param>
    /// <param name="g">The GREEN component value of the color</param>
    /// <param name="b">The BLUE component value of the color</param>
    /// <returns>Returns an 'ANSI Ecape' characters that changes the Console's Background color</returns>
    public static string ChangeBackColorChar(int r, int g, int b)
        => string.Format(_ESC_Code_Sequence_Background, r.ToString(), g.ToString(), b.ToString());

    #region ChangeBackColorChar Overloads
    /// <summary>
    /// Based on <code>ESC[48;2;{r};{g};{b}m</code> ANSI Escape code
    /// </summary>
    /// <param name="color">Gets the color as an object</param>
    /// <returns>Returns an 'ANSI Ecape' characters that changes the Console's Background color</returns>
    public static string ChangeBackColorChar(Color color)
        => string.Format(_ESC_Code_Sequence_Background, color.R.ToString(), color.G.ToString(), color.B.ToString());
    #endregion
    #endregion

    #region Set Functions

    /// <summary> 
    /// Sets Foreground color into a RGB color based on the character returned from the <code>RGBConsole.ChangeForeColorChar(r, g, b)</code> Just like the <code>Console.ForegroundColor = %something%</code>
    /// 
    /// </summary>
    /// <param name="r">The RED component value of the color</param>
    /// <param name="b">The GREEN component value of the color</param>
    /// <param name="g">The BLUE component of the color</param>
    public static void SetForeColor(int r, int g, int b) => Console.Write(ChangeForeColorChar(r, g, b));

    #region SetForeColor Overloads
    /// <summary>
    /// Sets Foreground color into a RGB color based on the character returned from the <code>RGBConsole.ChangeForeColorChar(r, g, b)</code> Just like the <code>Console.ForegroundColor = %something%</code>
    /// 
    /// </summary>
    /// <param name="color">Gets the color as an object</param>
    public static void SetForeColor(Color color) => Console.Write(ChangeForeColorChar(color.R, color.G, color.B));
    #endregion

    /// <summary>
    /// Sets Background color into a RGB color based on the character returned from the <code>RGBConsole.ChangeBackColorChar(r, g, b)</code> Just like the <code>Console.BackgroundColor = %something%</code>
    /// 
    /// </summary>
    /// <param name="r">The RED component value of the color</param>
    /// <param name="b">The GREEN component value of the color</param>
    /// <param name="g">The BLUE component of the color</param>
    public static void SetBackColor(int r, int g, int b) => Console.Write(ChangeBackColorChar(r, g, b));

    #region SetBackColor Overloads
    /// <summary>
    /// Sets Background color into a RGB color based on the character returned from the <code>RGBConsole.ChangeBackColorChar(r, g, b)</code> Just like the <code>Console.BackgroundColor = %something%</code>
    /// 
    /// </summary>
    /// <param name="color">Gets the color as an object</param>
    public static void SetBackColor(Color color) => Console.Write(ChangeBackColorChar(color.R, color.G, color.B));
    #endregion

    #endregion
}
