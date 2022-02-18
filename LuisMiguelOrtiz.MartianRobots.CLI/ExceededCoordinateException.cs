using System;
using System.Runtime.Serialization;

namespace LuisMiguelOrtiz.MartianRobots.CLI
{
    [Serializable]
    public class ExceededCoordinateException : Exception
    {
        public ExceededCoordinateException()
        {
        }

        public ExceededCoordinateException(string message)
            : base(message)
        {
        }

        public ExceededCoordinateException(string message, Exception inner)
            : base(message, inner)
        {
        }
        protected ExceededCoordinateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}