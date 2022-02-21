using System;
using System.Runtime.Serialization;

namespace LuisMiguelOrtiz.MartianRobots.Exceptions
{
    [Serializable]
    public class ExceededInstructionsException : Exception
    {
        public ExceededInstructionsException()
        {
        }

        public ExceededInstructionsException(string message) : base(message)
        {
        }

        public ExceededInstructionsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExceededInstructionsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}