using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace GettingUpTrainer
{
    static class Program
    {
        static string m_intro = "Getting Up Trainer";
        static string m_version = "[v1.0]";
        static string m_author = "by Bilakispa";

        static string m_githubURL = "Github URL: https://github.com/bilakispa/GettingUpTrainer";

        static string m_credits1 = " - XTreme2010 (Template) [Template URL: https://goo.gl/HeCh6G]";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Init();

            ConsoleSpiner spin = new ConsoleSpiner();

            while (true) {
                if (GetProcessesByName("GettingUp", out Process process)) {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string('-', Console.WindowWidth - 1));
                    Console.WriteLine("Status: Loaded{0}", new string(' ', 15));
                    Console.WriteLine("Id: {0}", process.Id);
                    Console.WriteLine(new string('-', Console.WindowWidth - 1));
                    Console.WriteLine("Usage: Press [F12] to show menu");

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(true);
                    Application.Run(new Overlay(process));
                    
                    break;
                }
                spin.Turn();
                Thread.Sleep(100);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadKey();
        }

        private static void Init()
        {
            Console.Title = Process.GetCurrentProcess().ProcessName;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(m_intro + " " + m_version + " " + m_author);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(m_githubURL);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Credits:" + m_credits1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.Write("Waiting for GettingUp.exe...");
        }

        public static bool GetProcessesByName(string pName, out Process process)
        {
            Process[] pList = Process.GetProcessesByName(pName);
            process = pList.Length > 0 ? pList[0] : null;
            return process != null;
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);

            for (int i = 0; i < Console.WindowWidth; i++)
                Console.Write("");

            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
