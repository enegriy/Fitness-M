using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fitness_M
{
    /// <summary>
    /// Хэлпер для сообщений
    /// </summary>
    public static class MessageHelper
    {
        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        public static DialogResult ShowError(string error)
        {
            return MessageBox.Show(error, 
                "Ошибка", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
        }

        /// <summary>
        /// Сообщение вопрос (Да/Нет)
        /// </summary>
        public static DialogResult ShowQuestion(string question)
        {
            return MessageBox.Show(question, 
                "Вопрос", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
        }

        /// <summary>
        /// Сообщение вопрос
        /// </summary>
        public static DialogResult ShowQuestion(string question, MessageBoxButtons buttons)
        {
            return MessageBox.Show(question,
                "Вопрос",
                buttons,
                MessageBoxIcon.Question);
        }

        /// <summary>
        /// Сообщение информация 
        /// </summary>
        public static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Внимание", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
