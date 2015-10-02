using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
	/// <summary>
	/// BussinesException
	/// </summary>
    [Serializable()]
    public class BussinesException : ApplicationException
    {
		/// <summary>
		/// BussinesException
		/// </summary>
        public BussinesException() : base() { }
		/// <summary>
		/// BussinesException
		/// </summary>
		/// <param name="message"></param>
        public BussinesException(string message) : base(message) { }
		/// <summary>
		/// BussinesException
		/// </summary>
		/// <param name="message"></param>
		/// <param name="inner"></param>
        public BussinesException(string message, System.Exception inner) : base(message, inner) { }

         // Конструктор для обработки сериализации типа
        protected BussinesException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext contex)
            : base(info, contex) { }
    }
}
