using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    /// <summary>
    /// Текущий пользователь
    /// </summary>
    public static class CurrentUser
    {
        /// <summary>
        /// Идентификационный номер
        /// </summary>
        private static long m_Id;
        /// <summary>
        /// Идентификационный номер
        /// </summary>
        public static long Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }

        /// <summary>
        /// Роль
        /// </summary>
        private static Roles m_Role;
        /// <summary>
        /// Роль
        /// </summary>
        public static Roles Role 
        {
            get { return m_Role; }
            set { m_Role = value; }
        }
    }
}
