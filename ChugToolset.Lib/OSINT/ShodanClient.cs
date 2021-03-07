using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChugToolset.Lib.OSINT
{
    class ShodanClient : Abstract.IOsintApiClient
    {
        public List<string> ClientTags => throw new NotImplementedException();

        public string SourceUrl => throw new NotImplementedException();

        public event EventHandler<Exception> OnError;
        public event EventHandler<string> OnEvent;
        public event EventHandler<string> OnCompleted;

        public IRestResponse Investigate()
        {
            throw new NotImplementedException();
        }
    }
}
