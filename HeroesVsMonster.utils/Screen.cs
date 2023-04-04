using System.Text;

namespace HeroesVsMonster.Utils
{
    public static class Screen
    {
        public static void Print(int x, int y, params string[] content)
        {
            for (int i = 0; i < content.Length; i++)
            {
                Console.SetCursorPosition(x / 2 - content[i].Length / 2, y + i);
                Console.Write(content[i]);
            }
        }
        public static void PrintCharacter(int x, int y, string content)
        {
            Console.SetCursorPosition(x * 5 + 6, y * 3 + 10);
            Console.WriteLine("{0,-5}",content);
        }
        public static void PrintFullScreen(int y, params string[] content)
        {
            if (content.Max(s => s.Length) > 156 || y + content.Count() > 45)
                return;
            int x = 156;
            Print(x, y, content);
        }
        public static void PrintGame(int y, params string[] content)
        {
            if (content.Max(s => s.Length) > 106 || y + content.Count() > 27)
                return;
            int x = 106 + 8;
            y += 8;
            Print(x, y, content);
        }
        public static void PrintSlowGame(int y, params string[] content)
        {
            if (content.Max(s => s.Length) > 106 || y + content.Count() > 27)
                return;
            int x = 106 + 8;
            y += 8;
            Screen.ClearGame();
            foreach (string s in content)
            {
                Console.SetCursorPosition(x / 2 - s.Length / 2, y);
                for (int i = 0; i < s.Length && !Console.KeyAvailable; i++)
                {
                    Thread.Sleep(30);
                    Console.Write(s[i]);
                    if (Console.KeyAvailable)
                    {
                        Console.SetCursorPosition(x / 2 - s.Length / 2, y);
                        Console.Write(s);
                    }
                }
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (Console.KeyAvailable && !(s == content.Last()))
                    Console.ReadKey(true);
                y += 1;
            }
        }
        public static void PrintInfo(string content)
        {
            ClearInfo();
            if (content.Length > 142)
                return;
            Console.SetCursorPosition(7, 3);
            Console.Write(content);
        }
        public static void PrintSlowInfo(params string[] content)
        {
            ClearInfo();
            if (content.Max(s => s.Length) > 142)
                return;
            foreach (string s in content)
            {
                ClearInfo();
                Console.SetCursorPosition(7, 3);
                for (int i = 0; i < s.Length && !Console.KeyAvailable; i++)
                {
                    Console.Write(s[i]);
                    Thread.Sleep(30);
                    if (Console.KeyAvailable)
                    {
                        Console.SetCursorPosition(7, 3);
                        Console.Write(s);
                    }
                }
                if (!Console.KeyAvailable)
                    Thread.Sleep(1000);
                else
                {
                    Console.ReadKey(true);
                    Console.ReadKey(true);
                }
                if (Console.KeyAvailable && !(s == content.Last()))
                    Console.ReadKey(true);
            }
        }
        public static void PrintInfoHero(int y, params string[] content)
        {
            if (content.Max(s => s.Length) > 24 || y + content.Count() > 7)
                return;
            int x = 127;
            y += 9;
            for (int i = 0; i < content.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("                        ");
                Console.SetCursorPosition(x, y + i);
                Console.Write(content[i]);
            }
        }
        public static void PrintEquipment(int y, params string[] content)
        {
            if (content.Max(s => s.Length) > 24 || y + content.Count() > 5)
                return;
            int x = 127;
            y += 21;
            for (int i = 0; i < content.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("                        ");
                Console.SetCursorPosition(x, y + i);
                Console.Write(content[i]);
            }
        }
        public static void PrintInfoMonster(int y, params string[] content)
        {
            if (content.Max(s => s.Length) > 24 || y + content.Count() > 3)
                return;
            int x = 127;
            y += 31;
            for (int i = 0; i < content.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("                        ");
                Console.SetCursorPosition(x, y + i);
                Console.Write(content[i]);
            }
        }
        public static void ClearInfoMonster()
        {
            int x = 127;
            int y = 31;
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("                        ");
            }
        }
        public static string PrintActions(params string[] content)
        {
            ClearAction();
            int maxLenght = content.Max(s => s.Length);
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            int currentIndex = 0;
            bool isSwitched = false;
            if (6 + (content.Count() - 1) * (maxLenght + 10) + (maxLenght + 8) > 150)
                throw new ArgumentOutOfRangeException();
            do
            {

                do
                {
                    while (!Console.KeyAvailable)
                    {
                        for (int i = 0; i < content.Count(); i++)
                        {

                            if (i == currentIndex)
                            {
                                if (!isSwitched)
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                else
                                    Console.ForegroundColor = ConsoleColor.White;
                                isSwitched = !isSwitched;
                            }
                            else
                                Console.ForegroundColor = ConsoleColor.White;
                            string[] button = CreateButton(content[i], maxLenght);
                            int x = 6 + i * (maxLenght + 10);
                            PrintButton(x, button);
                        }
                        Thread.Sleep(300);
                    }
                    cki = Console.ReadKey(true);
                } while (cki.Key != ConsoleKey.LeftArrow && cki.Key != ConsoleKey.RightArrow && cki.Key != ConsoleKey.Spacebar);
                Console.ForegroundColor = ConsoleColor.White;
                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        currentIndex = currentIndex == 0 ? content.Count() - 1 : currentIndex - 1;
                        break;
                    case ConsoleKey.RightArrow:
                        currentIndex = currentIndex == content.Count() - 1 ? 0 : currentIndex + 1;
                        break;
                }
            } while (cki.Key != ConsoleKey.Spacebar);
            return content[currentIndex];

        }
        public static void PrintButton(int x, string[] button)
        {
            if (button.Count() > 5)
                return;
            int y = 38;
            foreach (string s in button)
            {
                Console.SetCursorPosition(x, y++);
                Console.Write(s);
            }

        }
        public static string[] CreateButton(string value, int maxLenght)
        {
            StringBuilder sbTop = new StringBuilder();
            StringBuilder sbMid = new StringBuilder();
            StringBuilder sbBot = new StringBuilder();
            StringBuilder sbTex = new StringBuilder();
            int charindex = 0;
            sbTop.Append('┌');
            sbMid.Append('│');
            sbTex.Append('│');
            sbBot.Append('└');
            for (int i = 0; i < maxLenght + 6; i++)
            {
                sbTop.Append('─');
                sbMid.Append(' ');
                sbBot.Append('─');
                if (i == 3 && value.Length == maxLenght && charindex < maxLenght)
                    sbTex.Append(value[charindex++]);
                else if (i >= 3 + (maxLenght - value.Length) / 2 && charindex < value.Length)
                    sbTex.Append(value[charindex++]);
                else
                    sbTex.Append(' ');

            }
            sbTop.Append('┐');
            sbMid.Append('│');
            sbTex.Append('│');
            sbBot.Append('┘');
            return new string[] { sbTop.ToString(), sbMid.ToString(), sbTex.ToString(), sbMid.ToString(), sbBot.ToString() };
        }
        public static void Clear()
        {
            PrintFullScreen(0, Pictures.ScreenBackground);
        }
        public static void ClearInfo()
        {
            Console.SetCursorPosition(7, 3);
            Console.Write(Pictures.InfoEraser);
        }
        public static void ClearGame()
        {

            PrintGame(0, Pictures.GameEraser);
        }
        public static void ClearBottomScreen()
        {
            PrintFullScreen(31, Pictures.BottomScreenEraser);
        }
        public static void ClearAction()
        {
            int x = 5;
            int y = 38;
            foreach (string s in Pictures.ActionEraser)
            {
                Console.SetCursorPosition(x, y++);
                Console.Write(s);
            }
        }
        public static string PrintGameVerticalMenu(int y, params string[] content)
        {
            if (content.Max(s => s.Length) > 106 || y + content.Count() > 27)
                throw new ArgumentOutOfRangeException();
            int x = 106 + 8;
            y += 8;
            return PrintVerticalMenu(x, y, content);
        }
        public static string PrintVerticalMenu(int y, params string[] content)
        {
            return PrintVerticalMenu(156, y, content);
        }
        public static string PrintVerticalMenu(int x, int y, params string[] texts)
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            string eraser = "";
            int currentIndex = 0;
            do
            {
                bool isVisible = true;
                foreach (char c in texts[currentIndex])
                {
                    eraser += " ";
                }
                do
                {
                    while (!Console.KeyAvailable)
                    {
                        for (int i = 0; i < texts.Length; i++)
                        {
                            if (i == currentIndex)
                            {
                                if (isVisible)
                                {
                                    Print(x, y + i * 2, eraser);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Print(x, y + i * 2, texts[i]);
                                }
                                isVisible = !isVisible;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Print(x, y + i * 2, texts[i]);
                            }
                        }
                        Thread.Sleep(400);
                    }
                    cki = Console.ReadKey(true);
                } while (cki.Key != ConsoleKey.DownArrow && cki.Key != ConsoleKey.UpArrow && cki.Key != ConsoleKey.Enter && cki.Key != ConsoleKey.Spacebar);
                Console.ForegroundColor = ConsoleColor.White;
                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (currentIndex == 0)
                            currentIndex = texts.Length - 1;
                        else
                            currentIndex -= 1;
                        break;
                    case ConsoleKey.DownArrow:
                        currentIndex = currentIndex == texts.Length - 1 ? 0 : currentIndex + 1;
                        break;
                }
            } while (cki.Key != ConsoleKey.Enter && cki.Key != ConsoleKey.Spacebar);
            return texts[currentIndex];
        }
    }
}
