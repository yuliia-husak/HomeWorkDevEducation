using System;
using System.Runtime.Serialization;

namespace Triangle
{
    [Serializable]
    class NotLiveTriangleExeption : Exception
    {
        public NotLiveTriangleExeption()
        {
        }

        public NotLiveTriangleExeption(string message) : base(message)
        {
        }

        public NotLiveTriangleExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotLiveTriangleExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}