using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace YetAnotherClass_CommandPrompt
{
    class CommandPrompt
    {
        int height, columns;
        string[] screenText;
        ConsoleColor backgroundColor, foregroundColor;

        public CommandPrompt(int h,int c, string title)
        {
            height = h;
            columns = c;
            Console.Title = title;
            screenText = new string[h];
            Console.SetWindowSize(c, h + 7);
            backgroundColor = ConsoleColor.Black;
            foregroundColor = ConsoleColor.Green;

            for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i] = "";
            }
        }

        public void Display()
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;

            Console.Clear();
            for (int i = 0; i < screenText.Length; i++)
            {
                Console.WriteLine(screenText[i]);
            }
        }

        public void SetScreenText(int lineNumber,string lineOfText)
        {
            screenText[lineNumber] = lineOfText;
        }

        public void SetBackgroundColor(string color)
        {
            backgroundColor = ConvertColor(color);
        }

        public void SetForegroundColor(string color)
        {
            foregroundColor = ConvertColor(color);
        }

        public void SaveScreen(string fileName)
        {
            FileStream stream;
            StreamWriter textOut = null;
            try
            {
                fileName = "../../../" + fileName;
                stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                textOut = new StreamWriter(stream);
                //your code here!!!
                textOut.WriteLine(height);
                textOut.WriteLine(columns);
                textOut.WriteLine(backgroundColor);
                textOut.WriteLine(foregroundColor);

                foreach (string str in screenText)
                {
                    textOut.WriteLine(str);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Creating file: ");
                Console.WriteLine(ex.ToString());
                return;
            }
            finally
            {
                if (textOut != null)
                    textOut.Close();
            }
        }

        public void ReloadScreen(string fileName)
        {
            FileStream stream;
            StreamReader textIn=null;
            try
            {
                fileName = "../../../" + fileName;
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                textIn = new StreamReader(stream);

                height = Convert.ToInt32(textIn.ReadLine());
                columns = Convert.ToInt32(textIn.ReadLine());
                backgroundColor = ConvertColor(textIn.ReadLine());
                foregroundColor = ConvertColor(textIn.ReadLine());

                screenText = new string[height];
                for (int i = 0; i < screenText.Length; i++)
                {
                    screenText[i] = textIn.ReadLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error Reading file: ");
                Console.WriteLine(ex.ToString());
                return;
            }
            finally
            {
                if (textIn != null)
                    textIn.Close();
            }
        }

        public void ClearScreen()
        {
            for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i] = "";
            }
        }

        public ConsoleColor ConvertColor(string strColor)
        {
            string [] strColorArray=strColor.Split(' ');
            string strColor2="";

            foreach (string str in strColorArray)
            {
                strColor2 += str;
            }

            ConsoleColor color;
            switch (strColor2.ToLower()) 
            {
                case "black":color = ConsoleColor.Black; break;
                case "red":color = ConsoleColor.Red; break;
                case "white": color = ConsoleColor.White; break;
                case "gray": color = ConsoleColor.Gray; break;
                case "blue": color = ConsoleColor.Blue; break;
                case "cyan": color = ConsoleColor.Cyan; break;
                case "darkblue": color = ConsoleColor.DarkBlue; break;
                case "darkcyan": color = ConsoleColor.DarkCyan; break;
                case "yellow": color = ConsoleColor.Yellow; break;
                case "green": color = ConsoleColor.Green; break;
                case "darkgreen": color = ConsoleColor.DarkGreen; break;
                case "darkred": color = ConsoleColor.DarkRed; break;
                case "darkmagenta": color = ConsoleColor.DarkMagenta; break;
                case "darkyellow": color = ConsoleColor.DarkYellow; break;
                case "magenta": color = ConsoleColor.Magenta; break;
                default: color = ConsoleColor.DarkGray; break;
            }

            return color;
        }
    }
}
