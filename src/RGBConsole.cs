using System.Drawing;
using System;

namespace ConsoleRGBColors
{
    public static class RGBConsole
    {
        private const string _ESC_Code_Sequence_Foreground = "\u001b[38;2;{0};{1};{2}m";
        private const string _ESC_Code_Sequence_Background = "\u001b[48;2;{0};{1};{2}m";
        private const string _ESC_Code_Sequence_Foreground_Default = "\u001b[39m";
        private const string _ESC_Code_Sequence_Background_Default = "\u001b[49m";

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
        /// Sets Foreground color into a <paramref name="r"/><paramref name="g"/><paramref name="b"/> color based on the character returned from the <code>RGBConsole.ChangeForeColorChar(r, g, b)</code> Just like the <code>Console.ForegroundColor = %something%</code>
        /// 
        /// </summary>
        /// <param name="r">The RED component value of the color</param>
        /// <param name="b">The GREEN component value of the color</param>
        /// <param name="g">The BLUE component of the color</param>
        public static void SetForeColor(int r, int g, int b) => Console.Write(ChangeForeColorChar(r, g, b));

        #region SetForeColor Overloads
        /// <summary>
        /// Sets Foreground color into a <paramref name="r"/><paramref name="g"/><paramref name="b"/> color based on the character returned from the <code>RGBConsole.ChangeForeColorChar(r, g, b)</code> Just like the <code>Console.ForegroundColor = %something%</code>
        /// 
        /// </summary>
        /// <param name="color">Gets the color as an object</param>
        public static void SetForeColor(Color color) => Console.Write(ChangeForeColorChar(color.R, color.G, color.B));
        #endregion

        /// <summary>
        /// Sets Background color into a <paramref name="r"/><paramref name="g"/><paramref name="b"/> color based on the character returned from the <code>RGBConsole.ChangeBackColorChar(r, g, b)</code> Just like the <code>Console.BackgroundColor = %something%</code>
        /// 
        /// </summary>
        /// <param name="r">The RED component value of the color</param>
        /// <param name="b">The GREEN component value of the color</param>
        /// <param name="g">The BLUE component of the color</param>
        public static void SetBackColor(int r, int g, int b) => Console.Write(ChangeBackColorChar(r, g, b));

        #region SetBackColor Overloads
        /// <summary>
        /// Sets Background color into a <paramref name="r"/><paramref name="g"/><paramref name="b"/> color based on the character returned from the <code>RGBConsole.ChangeBackColorChar(r, g, b)</code> Just like the <code>Console.BackgroundColor = %something%</code>
        /// 
        /// </summary>
        /// <param name="color">Gets the color as an object</param>
        public static void SetBackColor(Color color) => Console.Write(ChangeBackColorChar(color.R, color.G, color.B));
        #endregion

        /// <summary>
        /// Sets foreground color to terminal defual
        /// </summary>
        public static void SetForeColorDefault() => Console.Write(_ESC_Code_Sequence_Foreground_Default);

        /// <summary>
        /// Sets background color to terminal default
        /// </summary>
        public static void SetBackColorDefault() => Console.Write(_ESC_Code_Sequence_Background_Default);

        #endregion

        #region String Functions
        /// <summary>
        /// Changes a string foreground color based on the character returned from the <code>RGBConsole.ChangeForeColorChar(r, g, b)</code> Unfortunately, .NET does not have a similar example
        /// </summary>
        /// <param name="text">The text you want to color</param>
        /// <param name="r">The RED component value of the color</param>
        /// <param name="b">The GREEN component value of the color</param>
        /// <param name="g">The BLUE component of the color</param>
        /// <returns>It will returns <paramref name="text"/> so that it will be displayed in the display terminal with the <paramref name="r"/><paramref name="g"/><paramref name="b"/> foreground color you enterd</returns>
        public static string ChangeStringForeColor(this string text, int r, int g, int b) => $"{ChangeForeColorChar(r, g, b)}{text}{_ESC_Code_Sequence_Foreground_Default}";

        #region ChangeStringForeColor Overloads
        /// <summary>
        /// Changes a string foreground color based on the character returned from the <code>RGBConsole.ChangeForeColorChar(r, g, b)</code> Unfortunately, .NET does not have a similar example
        /// </summary>
        /// <param name="text">The text you want to color</param>
        /// <param name="color">Gets color as an object</param>
        /// <returns>It will returns <paramref name="text"/> so that it will be displayed in the display terminal with the rgb foreground <paramref name="color"/> you enterd</returns>
        public static string ChangeStringForeColor(this string text, Color color)
            => $"{ChangeForeColorChar(color.R, color.G, color.B)}{text}{_ESC_Code_Sequence_Foreground_Default}";
        #endregion

        /// <summary>
        /// Changes a string background color based on the character returned from the <code>RGBConsole.ChangeBackColorChar(r, g, b)</code> Unfortunately, .NET does not have a similar example
        /// </summary>
        /// <param name="text">The text you want to color</param>
        /// <param name="r">The RED component value of the color</param>
        /// <param name="b">The GREEN component value of the color</param>
        /// <param name="g">The BLUE component of the color</param>
        /// <returns>It will returns <paramref name="text"/> so that it will be displayed in the display terminal with the <paramref name="r"/><paramref name="g"/><paramref name="b"/> background color you enterd</returns>
        public static string ChangeStringBackColor(this string text, int r, int g, int b) => $"{ChangeBackColorChar(r, g, b)}{text}{_ESC_Code_Sequence_Background_Default}";

        #region ChangeStringBackColor Overloads
        /// <summary>
        /// Changes a string background color based on the character returned from the <code>RGBConsole.ChangeBackColorChar(r, g, b)</code> Unfortunately, .NET does not have a similar example
        /// </summary>
        /// <param name="text">The text you want to color</param>
        /// <param name="color">Gets color as an object</param>
        /// <returns>It will returns <paramref name="text"/> so that it will be displayed in the display terminal with the rgb background <paramref name="color"/> you enterd</returns>
        public static string ChangeStringBackColor(this string text, Color color)
            => $"{ChangeBackColorChar(color.R, color.G, color.B)}{text}{_ESC_Code_Sequence_Background_Default}";
        #endregion

        #endregion
    }
}