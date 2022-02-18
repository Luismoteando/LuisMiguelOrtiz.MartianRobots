using System;
using System.Runtime.Serialization;

namespace LuisMiguelOrtiz.MartianRobots
{
    [Serializable]
    public class UnrecognizedCommandException : Exception
    {
        public UnrecognizedCommandException()
        {
        }

        public UnrecognizedCommandException(string message)
            : base(message)
        {
        }

        public UnrecognizedCommandException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected UnrecognizedCommandException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
