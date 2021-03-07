using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace ChugToolset.Lib.NameCheck
{
    [Serializable]
    public class ApiCheck : IChecker
    {

        /// <summary>
        /// A dictionary that holds Title, JSON/XML Key to get information from the users profile <br/if an user exists in the first place.
        /// </summary>
        public Dictionary<string, object> GetInfo { get; set; }

        /// <summary>
        /// Title of the checker <para/> <strong>Example:</strong> <br/> Instagram, Twitter, etc...
        /// </summary>
        public string CheckerTitle { get; set; }

        /// <summary>
        /// >URL to check <para/> <strong>Example:</strong> <br/> https://www.example.com/{username}/ 
        /// </summary>
        public string CheckUrl { get; set; }


        public ApiRequestOptions ApiRequestOption { get; set; }
        public string CheckerType { get ; set ; }

        public ApiCheck(string checkerTitle, string url, Dictionary<string, string> getInfo, ApiRequestOptions apiRequestOptions = null)
        {
            CheckerType = "api";
            if (!url.ToLower().Contains("{username}")) { throw new Exception("Url must contain {username} placeholder"); }
            CheckerTitle = checkerTitle;
            CheckUrl = url;
            GetInfo = new Dictionary<string, object>();

            GetInfo.MatchDictionary(getInfo);
         
            if (apiRequestOptions == null)
            {
                ApiRequestOption = new ApiRequestOptions(Method.GET);
            }
            else
            {
                ApiRequestOption = apiRequestOptions;
            }
            
        }


    }


    [Serializable]
    public class ApiRequestOptions
    {
        public Dictionary<string, object> Headers { get; set; }
        public Dictionary<string, object> Parameters { get; set; }
        public Method RequestMethod { get; set; }

        public ApiRequestOptions(Method requestMethod, Dictionary<string, object> parameters = null, Dictionary<string, object> headers = null)
        {
            RequestMethod = requestMethod;
            if (parameters == null) { Parameters = new Dictionary<string, object>(); } else { Parameters = parameters; }
            if (headers == null) { Headers = new Dictionary<string, object>(); } else { Headers = headers; }
        }

    }
}
