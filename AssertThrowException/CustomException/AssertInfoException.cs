using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

MatiasPili1216.AssertThrowException
{
    /// <summary>
    /// Custom Assert - Info Exception
    /// </summary>
    public class AssertInfoException : Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException
    {
        /// <summary>
        /// Initializes a new instance of the AssertInfoException
        /// </summary>
        public AssertInfoException() : base() { }
        /// <summary>
        /// Initializes a new instance of the AssertInfoException with custom message
        /// </summary>
        /// <param name="msg">The custom message</param>
        public AssertInfoException(string msg) : base($"'AssertInfoException'. {msg}") { }
        /// <summary>
        /// Initializes a new instance of the AssertInfoException with custom message and InnerException
        /// </summary>
        /// <param name="msg">The custom message</param>
        /// <param name="ex">The InnerException</param>
        public AssertInfoException(string msg, Exception ex) : base($"'AssertInfoException'. {msg}", ex) { }
    }

}
