using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Morze
{
    static class Program
    {
        public const int NEXT_QUESTION_DELAY = 2000;
        private static Timer timer = new Timer();

        private static bool exitFlag = false;

        private static Form1 form;

        private static char currentQuestion;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            form = new Form1();
            Application.Run(form);

            while(!exitFlag)
            {
                Application.DoEvents();
            }
        }

        public static void OnExit()
        {
            timer.Stop();
            exitFlag = true;
        }

        public static void SetQuestion()
        {
            int cn = new Random().Next(0, MorzeSymbols.dictionary.Count);
            KeyValuePair<char, string> q = MorzeSymbols.dictionary.ToArray()[cn];
            currentQuestion = q.Key;
            form.setQuestion(q.Value, q.Key.ToString());
        }

        public static bool IsCorrectAnswer(char answ)
        {
            return currentQuestion == Char.ToLower(answ);
        }

        public static void RunTimer()
        {
            timer.Stop();
            timer = new Timer();
            timer.Start();
            timer.Tick += new EventHandler(OnTimerRaised);
            timer.Interval = NEXT_QUESTION_DELAY;
        }

        private static void OnTimerRaised(object obj, EventArgs e)
        {
            timer.Stop();
            SetQuestion();
        }

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            OnExit();
        }
    }
}
