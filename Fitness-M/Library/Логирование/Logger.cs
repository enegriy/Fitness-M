using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{

    /// <summary>
    /// Логирование
    /// </summary>
    public static class Logger
    {
        private const string m_FileName = "log.txt";

        /// <summary>
        /// Записать текст
        /// </summary>
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

        /// <summary>
        /// Записать текст и перевести каретку
        /// </summary>
        public static void WriteLine(string text, string fileName)
        {
            StreamWriter writter = new StreamWriter(fileName, true);
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

        /// <summary>
        /// Записать текст и перевести каретку
        /// </summary>
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
