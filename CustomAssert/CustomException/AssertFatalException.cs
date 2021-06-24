using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomAssert
{
    /// <summary>
    /// Custom Assert - Fatal Exception
    /// </summary>
    public class AssertFatalException : UnitTestAssertException
    {
        /// <summary>
        /// Initializes a new instance of the AssertFatalException
        /// </summary>
        public AssertFatalException() : base() { }
        /// <summary>
        /// Initializes a new instance of the AssertFatalException with custom message
        /// </summary>
        /// <param name="msg">The custom message</param>
        public AssertFatalException(string msg) : base($"'AssertFatalException'. {msg}") { }
        /// <summary>
        /// Initializes a new instance of the AssertFatalException with custom message and InnerException
        /// </summary>
        /// <param name="msg">The custom message</param>
        /// <param name="ex">The InnerException</param>
        public AssertFatalException(string msg, Exception ex) : base($"'AssertFatalException'. {msg}", ex) { }
    }

}
