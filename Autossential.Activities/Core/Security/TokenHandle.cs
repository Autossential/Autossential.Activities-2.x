using Autossential.Core.Enums;
using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;

namespace Autossential.Core.Security
{
    public static class TokenHandle
    {
        public const int LOGON32_PROVIDER_DEFAULT = 0;

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LogonUser(string lpszUsername, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, out SafeAccessTokenHandle phToken);

        public static IntPtr GetUserToken(NetworkCredential credential, LogonType logonType)
        {
            if (LogonUser(credential.UserName, credential.Domain, credential.Password, (int)logonType, LOGON32_PROVIDER_DEFAULT, out SafeAccessTokenHandle phToken))
            {
                return phToken.DangerousGetHandle();
            }

            // fail to login
            throw new Win32Exception(Marshal.GetLastWin32Error());
        }
    }
}
