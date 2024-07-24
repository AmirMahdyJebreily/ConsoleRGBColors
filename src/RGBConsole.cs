using System.Drawing;
using System;

namespace ConsoleRGBColors
{
    /// <summary>
    /// Change console colosrs into rgb colors
    /// </summary>
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

        #region Void Print Functions
        /// <summary>
        /// This function prints a multi-line <paramref name="text"/> using <code>System.Console.WriteLine()</code> and paints a gradient on it from color (<paramref name="fromColor_R"/>, <paramref name="fromColor_G"/>, <paramref name="fromColor_B"/>) to color (<paramref name="toColor_R"/>, <paramref name="toColor_G"/>, <paramref name="toColor_B"/>).
        /// </summary>
        /// <param name="text">A multi-line text</param>
        /// <param name="fromColor_R">From color (RED Factor)</param>
        /// <param name="fromColor_G">From color (GREEN Factor)</param>
        /// <param name="fromColor_B">From color (BLUE Factor)</param>
        /// <param name="toColor_R">To color (RED Factor)</param>
        /// <param name="toColor_G">To color (GREEN Factor)</param>
        /// <param name="toColor_B">To color (BLUE Factor)</param>
        public static void PrintVerticalGradiant(string text, int fromColor_R, int fromColor_G, int fromColor_B, int toColor_R, int toColor_G, int toColor_B)
        {
            int r = fromColor_R,
                g = fromColor_G,
                b = fromColor_B;

            string[] lines = text.Split('\n');
            Console.WriteLine();
            for (int i = 0; i < lines.Length; i++)
            {
                r += (int)((toColor_R - fromColor_R) / lines.Length);
                g += (int)((toColor_G - fromColor_G) / lines.Length);
                b += (int)((toColor_B - fromColor_B) / lines.Length);
                Console.WriteLine(lines[i].ChangeStringForeColor(r, g, b));
            }
        }
        #region PrintVerticalGradiant Overloads
        /// <summary>
        /// This function prints a multi-line <paramref name="text"/> using <code>System.Console.WriteLine()</code> and paints a gradient on it from color (<paramref name="fromColor_R"/>, <paramref name="fromColor_G"/>, <paramref name="fromColor_B"/>) to color (<paramref name="toColor_R"/>, <paramref name="toColor_G"/>, <paramref name="toColor_B"/>).
        /// </summary>
        /// <param name="text">A multi-line text</param>
        /// <param name="fromColor">The from color</param>
        /// <param name="toColor">The to color</param>
        public static void PrintVerticalGradiant(string text, (int, int, int) fromColor, (int, int, int) toColor)
            => PrintVerticalGradiant(text, fromColor.Item1, fromColor.Item2, fromColor.Item3, toColor.Item1, toColor.Item2, toColor.Item3);

        /// <summary>
        /// This function prints a multi-line <paramref name="text"/> using <code>System.Console.WriteLine()</code> and paints a gradient on it from color (<paramref name="fromColor_R"/>, <paramref name="fromColor_G"/>, <paramref name="fromColor_B"/>) to color (<paramref name="toColor_R"/>, <paramref name="toColor_G"/>, <paramref name="toColor_B"/>).
        /// </summary>
        /// <param name="text">A multi-line text</param>
        /// <param name="fromColor">The from color</param>
        /// <param name="toColor">The to color</param>
        public static void PrintVerticalGradiant(string text, Color fromColor, Color toColor)
            => PrintVerticalGradiant(text, fromColor.R, fromColor.G, fromColor.B, toColor.R, toColor.G, toColor.B);
        #endregion

        /// <summary>
        /// This function prints a one-line <paramref name="text"/> using <code>System.Console.WriteLine()</code> and paints a gradient on it from color (<paramref name="fromColor_R"/>, <paramref name="fromColor_G"/>, <paramref name="fromColor_B"/>) to color (<paramref name="toColor_R"/>, <paramref name="toColor_G"/>, <paramref name="toColor_B"/>).
        /// </summary>
        /// <param name="text">A one-line text</param>
        /// <param name="fromColor_R">From color (RED Factor)</param>
        /// <param name="fromColor_G">From color (GREEN Factor)</param>
        /// <param name="fromColor_B">From color (BLUE Factor)</param>
        /// <param name="toColor_R">To color (RED Factor)</param>
        /// <param name="toColor_G">To color (GREEN Factor)</param>
        /// <param name="toColor_B">To color (BLUE Factor)</param>
        public static void PrintOneLineHorizontalGradiant(string text, int fromColor_R, int fromColor_G, int fromColor_B, int toColor_R, int toColor_G, int toColor_B)
        {
            int r = fromColor_R,
                g = fromColor_G,
                b = fromColor_B;

            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                r += (int)((toColor_R - fromColor_R) / chars.Length);
                g += (int)((toColor_G - fromColor_G) / chars.Length);
                b += (int)((toColor_B - fromColor_B) / chars.Length);
                Console.Write(chars[i].ToString().ChangeStringForeColor(r, g, b));
            }
        }
        #region PrintOneLineHorizontalGradiant Overloads
        /// <summary>
        /// This function prints a one-line <paramref name="text"/> using <code>System.Console.WriteLine()</code> and paints a gradient on it from color (<paramref name="fromColor_R"/>, <paramref name="fromColor_G"/>, <paramref name="fromColor_B"/>) to color (<paramref name="toColor_R"/>, <paramref name="toColor_G"/>, <paramref name="toColor_B"/>).
        /// </summary>
        /// <param name="text">A one-line text</param>
        /// <param name="fromColor">The from color</param>
        /// <param name="toColor">The to color</param>
        public static void PrintOneLineHorizontalGradiant(string text, (int, int, int) fromColor, (int, int, int) toColor)
            => PrintOneLineHorizontalGradiant(text, fromColor.Item1, fromColor.Item2, fromColor.Item3, toColor.Item1, toColor.Item2, toColor.Item3);

        /// <summary>
        /// This function prints a one-line <paramref name="text"/> using <code>System.Console.WriteLine()</code> and paints a gradient on it from color (<paramref name="fromColor_R"/>, <paramref name="fromColor_G"/>, <paramref name="fromColor_B"/>) to color (<paramref name="toColor_R"/>, <paramref name="toColor_G"/>, <paramref name="toColor_B"/>).
        /// </summary>
        /// <param name="text">A one-line text</param>
        /// <param name="fromColor">The from color</param>
        /// <param name="toColor">The to color</param>
        public static void PrintOneLineHorizontalGradiant(string text, Color fromColor, Color toColor)
            => PrintOneLineHorizontalGradiant(text, fromColor.R, fromColor.G, fromColor.B, toColor.R, toColor.G, toColor.B);
        #endregion

        /// <summary>
        /// This function prints a multi-line <paramref name="text"/> using <code>System.Console.WriteLine()</code> and paints a gradient on it from color (<paramref name="fromColor_R"/>, <paramref name="fromColor_G"/>, <paramref name="fromColor_B"/>) to color (<paramref name="toColor_R"/>, <paramref name="toColor_G"/>, <paramref name="toColor_B"/>).
        /// </summary>
        /// <param name="text">A multi-line text</param>
        /// <param name="fromColor_R">From color (RED Factor)</param>
        /// <param name="fromColor_G">From color (GREEN Factor)</param>
        /// <param name="fromColor_B">From color (BLUE Factor)</param>
        /// <param name="toColor_R">To color (RED Factor)</param>
        /// <param name="toColor_G">To color (GREEN Factor)</param>
        /// <param name="toColor_B">To color (BLUE Factor)</param>
        public static void PrintHorizontalGradiant(string text, int fromColor_R, int fromColor_G, int fromColor_B, int toColor_R, int toColor_G, int toColor_B)
        {
            string[] lines = text.Split('\n');
            int lineLength = 0;
            foreach (string line in lines)
            {
                if(lineLength < line.Length)
                    lineLength = line.Length;
            }
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length < lineLength)
                    lines[i] = lines[i].PadRight(lineLength, ' ');
                PrintOneLineHorizontalGradiant(lines[i], fromColor_R, fromColor_G, fromColor_B, toColor_R, toColor_G, toColor_B);
                Console.WriteLine();
            }
        }
        #region PrintHorizontalGradiant Overloads
        /// <summary>
        /// This function prints a multi-line <paramref name="text"/> using <code>System.Console.WriteLine()</code> and paints a gradient on it from color (<paramref name="fromColor_R"/>, <paramref name="fromColor_G"/>, <paramref name="fromColor_B"/>) to color (<paramref name="toColor_R"/>, <paramref name="toColor_G"/>, <paramref name="toColor_B"/>).
        /// </summary>
        /// <param name="text">A multi-line text</param>
        /// <param name="fromColor">The from color</param>
        /// <param name="toColor">The to color</param>
        public static void PrintHorizontalGradiant(string text, (int, int, int) fromColor, (int, int, int) toColor)
            => PrintHorizontalGradiant(text, fromColor.Item1, fromColor.Item2, fromColor.Item3, toColor.Item1, toColor.Item2, toColor.Item3);

        /// <summary>
        /// This function prints a multi-line <paramref name="text"/> using <code>System.Console.WriteLine()</code> and paints a gradient on it from color (<paramref name="fromColor_R"/>, <paramref name="fromColor_G"/>, <paramref name="fromColor_B"/>) to color (<paramref name="toColor_R"/>, <paramref name="toColor_G"/>, <paramref name="toColor_B"/>).
        /// </summary>
        /// <param name="text">A multi-line text</param>
        /// <param name="fromColor">The from color</param>
        /// <param name="toColor">The to color</param>
        public static void PrintHorizontalGradiant(string text, Color fromColor, Color toColor)
            => PrintHorizontalGradiant(text, fromColor.R, fromColor.G, fromColor.B, toColor.R, toColor.G, toColor.B);
        #endregion
        #endregion
    }
}