using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChugToolset.Lib.OSINT
{
    class IntelXClient : Abstract.IOsintApiClient
    {
        public List<string> ClientTags {get;}
        public string SourceUrl {get;}

        public event EventHandler<Exception> OnError;
        public event EventHandler<string> OnEvent;
        public event EventHandler<string> OnCompleted;

        public IRestResponse Investigate()
        {
            throw new NotImplementedException();
        }
    }
}
