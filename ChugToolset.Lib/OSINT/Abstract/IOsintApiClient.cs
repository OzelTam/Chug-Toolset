using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace ChugToolset.Lib.OSINT.Abstract
{
      public interface IOsintApiClient
    {
        #region "Events"
        /// <summary>
        /// Fires when an error occurred.
        /// </summary>
        public event EventHandler<Exception> OnError;

        /// <summary>
        /// Fires when an event occurres.
        /// </summary>
        public event EventHandler<string> OnEvent;

        /// <summary>
        /// Fires when an event completed.
        /// </summary>
        public event EventHandler<string> OnCompleted;
        #endregion

        #region "Properties"
        /// <summary>
        /// Used to list client capabilities of search/find<para/> 
        /// <strong>Example:</strong><br/>
        /// username,mail,password, etc... 
        /// </summary>
        public List<string> ClientTags { get; }


        /// <summary>
        /// Used to reffering to the data source url.
        /// </summary>
        public string SourceUrl { get;}
        #endregion
        
        #region "Methods"
        public IRestResponse Investigate();
        #endregion

    }
}
