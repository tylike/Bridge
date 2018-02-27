// ==++==
//
//   Copyright (c) Microsoft Corporation.  All rights reserved.
//
// ==--==
/*============================================================
**
** Class:  IOException
**
** <OWNER>Microsoft</OWNER>
**
**
** Purpose: Exception for a generic IO error.
**
**
===========================================================*/
/*
 * https://github.com/Microsoft/referencesource/blob/master/mscorlib/system/io/ioexception.cs
 */


using System;
using System.Runtime.Serialization;

namespace System.IO
{
    [Bridge.Reflectable]
    [Bridge.Convention]
    public class IOException : Exception
    {
        // For debugging purposes, store the complete path in the IOException
        // if possible.  Don't give it back to users due to security concerns.
        // Let the code that throws the exception worry about that.  But we can
        // at least assist people attached to the process with a managed
        // debugger.  Don't serialize it to avoid any security problems.
        // This information isn't guaranteed to be correct, but is our second
        // best effort at a file or directory involved, after the exception
        // message.
        [NonSerialized]
        private String _maybeFullPath;  // For debuggers on partial trust code

        public IOException() : base("Arg_IOException")
        {
        }

        public IOException(String message) : base(message)
        {
        }

        public IOException(String message, int hresult) : base(message)
        {
        }

        // Adding this for debuggers when looking at exceptions in partial
        // trust code that may not have interesting path information in
        // the exception message.
        internal IOException(String message, int hresult, String maybeFullPath) : base(message)
        {
            _maybeFullPath = maybeFullPath;
        }

        public IOException(String message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
