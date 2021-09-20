using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

MatiasPili1216.AssertThrowException
{
    /// <summary>
    /// Custom Assert - Warning Exception
    /// </summary>
    public class AssertWarningException : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException
    {
        /// <summary>
        /// Initializes a new instance of the AssertWarningException
        /// </summary>
        public AssertWarningException() : base() { }
        /// <summary>
        /// Initializes a new instance of the AssertWarningException with custom message
        /// </summary>
        /// <param name="msg">The custom message</param>
        public AssertWarningException(string msg) : base($"'AssertWarningException'. {msg}") { }
        /// <summary>
        /// Initializes a new instance of the AssertWarningException with custom message and InnerException
        /// </summary>
        /// <param name="msg">The custom message</param>
        /// <param name="ex">The InnerException</param>
        public AssertWarningException(string msg, Exception ex) : base($"'AssertWarningException'. {msg}", ex) { }
    }
}
