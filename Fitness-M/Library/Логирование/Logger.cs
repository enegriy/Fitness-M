using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    public static class Logger
    {
        private const string m_FileName = "Log.txt";

        public static void Write(string text)
        {
            StreamWriter writter = new StreamWriter(m_FileName, true);
            try
            {
                writter.Write(text);
                writter.Close();
            }
            catch
            {
                writter.Dispose();
            }
        }

        public static void WriteLine(string text)
        {
            StreamWriter writter = new StreamWriter(m_FileName, true);
            try
            {
                writter.WriteLine(text);
                writter.Close();
            }
            catch
            {
                writter.Dispose();
            }
        }

    }
}
