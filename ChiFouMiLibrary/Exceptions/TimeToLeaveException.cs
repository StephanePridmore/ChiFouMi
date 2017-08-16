using System;
using System.Runtime.Serialization;

namespace ChiFouMiLibrary.Exceptions
{
    [Serializable]
    public class TimeToLeaveException : Exception
    {
        public TimeToLeaveException()
        {
        }

        public TimeToLeaveException(string message) : base(message)
        {
        }

        public TimeToLeaveException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TimeToLeaveException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
