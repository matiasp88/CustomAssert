using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomAssert
{
    /// <summary>
    /// Custom Assert - Error Exception
    /// </summary>
    public class AssertErrorException : UnitTestAssertException
    {
        /// <summary>
        /// Initializes a new instance of the AssertErrorException
        /// </summary>
        public AssertErrorException() : base() { }
        /// <summary>
        /// Initializes a new instance of the AssertErrorException with custom message
        /// </summary>
        /// <param name="msg">The custom message</param>
        public AssertErrorException(string msg) : base($"'AssertErrorException'. {msg}") { }
        /// <summary>
        /// Initializes a new instance of the AssertErrorException with custom message and InnerException
        /// </summary>
        /// <param name="msg">The custom message</param>
        /// <param name="ex">The InnerException</param>
        public AssertErrorException(string msg, Exception ex) : base($"'AssertErrorException'. {msg}", ex) { }
    }
}
