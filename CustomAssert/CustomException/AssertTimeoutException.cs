using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomAssert
{
    /// <summary>
    /// Custom Assert - Timeout Exception
    /// </summary>
    public class AssertTimeoutException : UnitTestAssertException
    {
        /// <summary>
        /// Initializes a new instance of the AssertTimeoutException
        /// </summary>
        public AssertTimeoutException() : base() { }
        /// <summary>
        /// Initializes a new instance of the AssertTimeoutException with custom message
        /// </summary>
        /// <param name="msg">The custom message</param>
        public AssertTimeoutException(string msg) : base($"'AssertTimeoutException'. {msg}") { }
        /// <summary>
        /// Initializes a new instance of the AssertTimeoutException with custom message and InnerException
        /// </summary>
        /// <param name="msg">The custom message</param>
        /// <param name="ex">The InnerException</param>
        public AssertTimeoutException(string msg, Exception ex) : base($"'AssertTimeoutException'. {msg}", ex) { }
    }
}
