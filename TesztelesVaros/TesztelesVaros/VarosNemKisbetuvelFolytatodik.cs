using System;
using System.Runtime.Serialization;

namespace TesztelesVaros
{
    [Serializable]
    internal class VarosNemKisbetuvelFolytatodik : Exception
    {
        public VarosNemKisbetuvelFolytatodik()
        {
        }

        public VarosNemKisbetuvelFolytatodik(string message) : base(message)
        {
        }

        public VarosNemKisbetuvelFolytatodik(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VarosNemKisbetuvelFolytatodik(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}