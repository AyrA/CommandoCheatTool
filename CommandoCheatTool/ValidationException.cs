using System;
using System.Runtime.Serialization;

namespace CommandoCheatTool
{
    /// <summary>
    /// Exception thrown when validation fails
    /// </summary>
    [Serializable]
    internal class ValidationException : Exception
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public ValidationException(): base()
        {
        }

        /// <summary>
        /// Creates an exception with the given message
        /// </summary>
        /// <param name="message">Message</param>
        public ValidationException(string message) : base(message)
        {
        }

        /// <summary>
        /// Creates an exception with the given message and inner/parent exception
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="innerException">Inner exception</param>
        public ValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Creates an exception from serialized data
        /// </summary>
        /// <param name="info">Serialization info</param>
        /// <param name="context">Serialized data</param>
        protected ValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}