using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    [Serializable()]
    public sealed class BussinesException : ApplicationException
    {
        public BussinesException() : base() { }
        public BussinesException(string message) : base(message) { }
        public BussinesException(string message, System.Exception inner) : base(message, inner) { }

         // Конструктор для обработки сериализации типа
        protected BussinesException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext contex)
            : base(info, contex) { }
    }
}
