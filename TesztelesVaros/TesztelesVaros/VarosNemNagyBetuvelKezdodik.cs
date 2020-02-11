using System;
using System.Runtime.Serialization;

namespace TesztelesVaros
{
    [Serializable]
    public class VarosNemNagyBetuvelKezdodik : Exception //Öröklés használata a kivétel kezeléshez
    {
        public VarosNemNagyBetuvelKezdodik()
        {
        }

        public VarosNemNagyBetuvelKezdodik(string message) : base(message)
        {
        }

        public VarosNemNagyBetuvelKezdodik(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VarosNemNagyBetuvelKezdodik(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}