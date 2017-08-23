using System;
using System.Net;

namespace CustomProxy
{
    public class ProxyAuthorisation : IWebProxy
    {
        ICredentials crendential = new NetworkCredential("DOMAIN\\username", "password");

        public ICredentials Credentials
        {
            get
            {
                return crendential;
            }
            set
            {
                crendential = value;
            }
        }

        public Uri GetProxy(Uri destination)
        {
            return new Uri(@"proxyURL", UriKind.Absolute);
        }

        public bool IsBypassed(Uri host)
        {
            return host.IsLoopback;
        }

    }
}
