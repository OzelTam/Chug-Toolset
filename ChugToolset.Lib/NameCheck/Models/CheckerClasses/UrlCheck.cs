using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChugToolset.Lib.NameCheck
{
    [Serializable]
    public class UrlCheck:IChecker
    {
        /// <summary>
        /// Title of the checker <para/> <strong>Example:</strong> <br/> Instagram, Twitter, etc...
        /// </summary>
        public string CheckerTitle { get; set; }
        /// <summary>
        /// >URL to check <para/> <strong>Example:</strong> <br/> https://www.instagram.com/{username}/ 
        /// </summary>
        public string CheckUrl { get; set; }
        /// <summary>
        /// A dictionary that holds key value pairs to extract information from the users profile <br/if an user exists in the first place.
        /// </summary>
        public Dictionary<string,object> GetInfo { get; set; }
        public string CheckerType { get; set; }

        //public Dictionary<string, object>  { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        ///
        /// </summary>
        /// <param name="checkerTitle"> Title of the checker <para/> <strong>Example:</strong> <br/> Instagram, Twitter, etc...</param>
        /// <param name="Url">URL to check <para/> <strong>Example:</strong> <br/> https://www.example.com/{username}/ </param>
        /// <param name="finders">A dictionary that holds key value pairs to extract information from the users profile <br/if an user exists in the forst place.</param>
        public UrlCheck(string checkerTitle, string Url, Dictionary<string, Finder> finders = null )
        {
            CheckerType = "url";
            if (!Url.ToLower().Contains("{username}"))
            {
                throw new Exception("Url must contain '{username}' placeholder to check and username.");
            }
            GetInfo = new Dictionary<string, object>();
            if (finders != null)
            {
                NameCheckFunction.MatchDictionary<Finder>(GetInfo, finders);
            }
            CheckerTitle = checkerTitle;
            CheckUrl = Url.ToLower();
        }

    }

    [Serializable]
    /// <summary>
    /// An object class that specifies the way to extract values from the user's profile.
    /// </summary>
    public class Finder
    {
        /// <summary>
        /// Specifies the method to use inorder to get an element from HTML of the web page.
        /// </summary>
        public enum GetBy
        {
            RegEx = 0,
            XPath = 1,
            ClassName = 2,
            Id = 3,
            AttributeValue = 4,
        }

        /// <summary>
        /// Way to use for getting html node.
        /// </summary>
        public GetBy GetElementBy { get; set; }


        /// <summary>
        /// Address of node to get. <para/> for:<br/>
        /// Regex= ("Expression", "GroupIndex")<br/>
        /// XPath= ("XPath", "Attribute to get")  'text for InnerText'<br/>
        /// ClassName= ("ClassName", "Attribute to get") 'text for InnerText'<br/>
        /// ElementId= ("ElementId", "Attribute to get") 'text for InnerText'<br/>
        /// AttributeValue= ("AttributeValue", "Value To Compare") 'Gets Inner Text'<br/>
        /// </summary>
        public (string,string) Address { get; set; }

        /// <summary>
        /// A object calss that used for finding relevant values.
        /// </summary>
        /// <param name="getElementBy"> Way to use for getting html node.<br/>
        /// Note: AttributeValue gets Inner text of the found node. </param>
        /// <param name="address"> Address of node to get. <para/> for:<br/>
        /// Regex= ("Expression", "GroupIndex")<br/>
        /// XPath= ("XPath", "Attribute to get")<br/>
        /// ClassName= ("ClassName", "Attribute to get")<br/>
        /// ElementId= ("ElementId", "Attribute to get")<br/>
        /// AttributeValue= ("AttributeValue", "Value To Compare") 'Gets Inner Text'<br/>
        /// <para/>
        /// </param>
        public Finder( GetBy getElementBy, (string, string) address)
        {
            
            GetElementBy = getElementBy;


            Address = address;
        }
    }
}
