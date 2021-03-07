using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Xml.Serialization;
using RestSharp;
using System.Xml.Linq;
using System.Linq;
using System.Xml;

namespace ChugToolset.Lib.NameCheck
{
    public static class NameCheckFunction
    {
        
        public static event EventHandler<string> EventReport;
        public static void RaiseReportEvent(object sender ,string message)
        {
            EventReport?.Invoke(sender, message);
        }
        public static void MatchDictionary<T>(this Dictionary<string, object> mainDictionary, Dictionary<string,T> dictionaryToMatchWith)
        {
            foreach(var dictionaryItem in dictionaryToMatchWith)
            {
                mainDictionary.Add(dictionaryItem.Key, dictionaryItem.Value);
            }
        }
        public static void SavePack(this CheckPack checkPack ,string savePath)
        {
            if (File.Exists(savePath)) { File.Delete(savePath); }

            using (Stream stream = File.Open(savePath, FileMode.Create))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, checkPack);
                stream.Close();
            }

        }
        public static CheckPack LoadPack( string fromPath)
        {
            CheckPack deserializedPack;

            using (Stream stream = File.Open(fromPath, FileMode.Open))
            {
                var binaryFormatter = new BinaryFormatter();
                deserializedPack = (CheckPack)binaryFormatter.Deserialize(stream);
            }
            return deserializedPack;
        }

        public static string GetByAttributeValue(this HtmlNode htmlNode, (string,string) address)
        {
            RaiseReportEvent(htmlNode, $"Getting info from page content '{address.Item1}: {address.Item2}'");
            if (htmlNode.Attributes.Contains(address.Item1))
            {
                if (string.Compare(htmlNode.Attributes[address.Item1].Value, address.Item2, true) == 0)
                {
                    return htmlNode.InnerText;
                }
            }
            foreach (var childHtmlNode in htmlNode.ChildNodes)
            {
                var resultNode = GetByAttributeValue(childHtmlNode, address);
                if (resultNode != null) return resultNode;
            }
            RaiseReportEvent(htmlNode, $"Done. '{address.Item1}: {address.Item2}'");
            return "NOT FOUND";
        }

        public static string GetByClassName(this HtmlDocument doc, (string, string) address)
        {
            return GetByXpath(doc, ($"*[@class='{address.Item1}']", address.Item2));
        }

        public static string GetById(this HtmlDocument doc, (string, string) address)
        {
            return GetByXpath(doc, ($"*[@id='{address.Item1}']", address.Item2));

        }

        public static string GetByXpath(this HtmlDocument doc, (string, string) address)
        {
            var resultText = "NOT FOUND";
            RaiseReportEvent(doc, $"Getting info from page content '{address.Item1}: {address.Item2}'");
            try
            {
                var element = doc.DocumentNode.SelectSingleNode(address.Item1);
                if (address.Item2.ToLower() == "text")
                {
                    resultText = element.InnerText;
                }
                else
                {
                    resultText = element.Attributes[address.Item2].Value;
                }
            }
            catch
            {

            }
            RaiseReportEvent(doc, $"Done. '{address.Item1}: {address.Item2}'");
            return resultText;
        }

        public static string GetByRegex(this HtmlDocument doc,  (string, string) address)
        {


            var resultText = "NOT FOUND";
            var regex = new Regex(address.Item1);
            var groupIndex = Convert.ToInt32(address.Item2);
            RaiseReportEvent(doc, $"Getting info from page content '{address.Item1}: {address.Item2}'");
            try
            {
             var HtmlCode = doc.Text;
             var mtch = regex.Match(HtmlCode);
                if (mtch.Success)
                {
                    resultText = mtch.Groups[groupIndex].Value;
                }
            }
            catch{}

            RaiseReportEvent(doc, $"Done. '{address.Item1}: {address.Item2}'");
            return resultText;
        }

        public static string PharseAndGet(this Finder finder, HtmlDocument doc)
        {
            string result = "NOT FOUND";
            switch (finder.GetElementBy)
            {
                case Finder.GetBy.AttributeValue:
                    result = doc.DocumentNode.GetByAttributeValue(finder.Address);
                    break;
                case Finder.GetBy.ClassName:
                    result = doc.GetByClassName(finder.Address);
                    break;
                case Finder.GetBy.Id:
                    result = doc.GetById(finder.Address);
                    break;
                case Finder.GetBy.RegEx:
                    result = doc.GetByRegex(finder.Address);
                    break;
                case Finder.GetBy.XPath:
                    result = doc.GetByXpath(finder.Address);
                    break;
            }
            return result;
        }



        public static Dictionary<string,string> JsonUniqueKeys(this JObject jObject)
        {
            var values = JsonConvert.DeserializeObject<Dictionary<string, object>>(jObject.ToString());
            var ResturnVals = new Dictionary<string, string>();
            foreach (KeyValuePair<string, object> d in values)
            {
                if (d.Value is JObject)
                {
                    ResturnVals.Add(d.Key, d.Value.ToString());
                    var dict = JsonUniqueKeys(JObject.Parse(d.Value.ToString()));
                    foreach(var dc in dict)
                    {
                        if (!ResturnVals.ContainsKey(dc.Key))
                        {
                            ResturnVals.Add(dc.Key,dc.Value);
                        }  
                    }
                    
                  
                }
                else
                {

                    if (d.Value == null)
                    {
                        ResturnVals.Add(d.Key, "null");
                    }
                    else
                    {
                        ResturnVals.Add(d.Key, d.Value.ToString());
                    }
                   
                }
            }
            return ResturnVals;
        }



    
        public static Dictionary<string,string> SerializeRestResponseContent(IRestResponse response)
        {
            if(response.ContentType.Contains("application/json"))
            {
                var objD = JObject.Parse(response.Content).JsonUniqueKeys();
                return objD;

            }
            else if (response.ContentType.Contains( "application/xml"))
            {
                XElement xElement = XElement.Parse(response.Content);
                return xElement.Descendants(xElement.Name).ToDictionary(item => item.Name.ToString(), item => item.Value.ToString());
            }
            else
            {
                var dct = new Dictionary<string, string>();
                dct.Add("Error","Unknown Content Type");
                return dct;
            }
        }



        public static async Task<string> SendReqAsync(this ApiCheck apiCheck, string username)
        {

            var resDict = new Dictionary<string, string>();
            string CheckURL = apiCheck.CheckUrl.Replace("{username}", username);
            RestClient restClient = new RestClient(CheckURL);

            RestRequest restRequest = new RestRequest(apiCheck.ApiRequestOption.RequestMethod);
            foreach (var headr in apiCheck.ApiRequestOption.Headers)
            {
                restRequest.AddHeader(headr.Key, headr.Key);
            }
            foreach (var param in apiCheck.ApiRequestOption.Parameters)
            {
                restRequest.AddParameter(param.Key, param.Value);
            }
            var restResponse = await restClient.ExecuteAsync(restRequest);

            if (restResponse.StatusCode == HttpStatusCode.OK)
            {
                if(restResponse.ContentType.ToLower().Contains("application/json"))
                {
                    return restResponse.Content;
                }
                else if (restResponse.ContentType.ToLower().Contains("application/xml"))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(restResponse.Content);
                    string json = JsonConvert.SerializeXmlNode(doc);
                    return json;
                }
                else
                {
                    throw new Exception("Available content types: 'application/json', 'application/xml'");
                }
           
            }
            else
            {
                throw new Exception(restResponse.StatusDescription);
            }
        }

        private static string ResponseToJson(IRestResponse restResponse)
        {
            try
            {
                if (restResponse.ContentType.ToLower().Contains("application/json"))
                {
                    return restResponse.Content;
                }
                else if (restResponse.ContentType.ToLower().Contains("application/xml"))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(restResponse.Content);
                    string json = JsonConvert.SerializeXmlNode(doc);
                    return json;
                }
                else
                {
                    return "{}";
                }
            }
            catch
            {
                return "{}";
            }

        }private static string GetValueFromJString(string json, string path)
        {
            try
            {
              
                var pathRoad = path.Split("\\");

                foreach(var road in pathRoad)
                {
                    try
                    {
                        var jsonObject = JObject.Parse(json);
                        json = JsonConvert.SerializeObject( jsonObject[road]);
                    }
                    catch
                    {
                        json = "NOT FOUND";
                        break;
                    }
                 
                }

                return json;

            }catch
            {
                return "NOT FOUND";
            }

        }




        public static async Task CheckUserAsync(this IChecker checker ,  UserProfile userProfile)
        {
            var username = userProfile.Username;
            var resultDictionary = new Dictionary<string, string>();

            string CheckURL = checker.CheckUrl.Replace("{username}", username);
            string statusString = "Default";


                if (checker.CheckerType== "url")
                {
                Dictionary<string, object> InfoRequests = null;
                UrlCheck urlChecker;
                try
                {
                     urlChecker = (UrlCheck)checker;
                     InfoRequests = urlChecker.GetInfo;
                    foreach (var req in InfoRequests)
                    {
                        var finder = (Finder)req.Value;
                        try
                        {


                            HtmlWeb webClient = new HtmlWeb();
                            HtmlDocument htmlDocument = await webClient.LoadFromWebAsync(CheckURL);
                            string val = finder.PharseAndGet(htmlDocument);
                            resultDictionary.Add(req.Key, val);
                        }
                        catch
                        {
                            resultDictionary.Add(req.Key, "NOT FOUND");
                        }
                    }
                    statusString = "Done";
                }
                catch 
                {
                    resultDictionary.Clear();
                    if (InfoRequests != null)
                    {
                        foreach (var i in InfoRequests)
                        {
                            resultDictionary.Add($"ERROR - {i.Key}", "NOT FOUND");
                        }
                        statusString = "NOT FOUND";
                    }
                    else { resultDictionary.Add($"ERROR", "Error"); statusString = "ERROR"; }
                }

                }
                else if (checker.CheckerType == "api")
                {
                ApiCheck apiChecker = (ApiCheck)checker;
                var InfoRequests = apiChecker.GetInfo;
                try
                {
                    RestClient restClient = new RestClient(CheckURL);
                    RestRequest restRequest = new RestRequest(apiChecker.ApiRequestOption.RequestMethod);
                    foreach (var headr in apiChecker.ApiRequestOption.Headers)
                    {
                        restRequest.AddHeader(headr.Key, headr.Key);
                    }
                    foreach (var param in apiChecker.ApiRequestOption.Parameters)
                    {
                        restRequest.AddParameter(param.Key, param.Value);
                    }
                    var restResponse = await restClient.ExecuteAsync(restRequest);

                    if (restResponse.StatusCode == HttpStatusCode.OK)
                    {
                        var jText = ResponseToJson(restResponse);
                        foreach(var req in InfoRequests)
                        {
                            resultDictionary.Add(req.Key, GetValueFromJString(jText, req.Value.ToString()));
                        }


                    }
                    else if (restResponse.StatusCode == HttpStatusCode.NotFound)
                    {
                        foreach (var itm in InfoRequests)
                        {
                            resultDictionary.Add(itm.Key, "NOT FOUND");
                        }
                        statusString = "NOT FOUND";
                    }
                    else
                    {
                        foreach (var itm in InfoRequests)
                        {
                            resultDictionary.Add(itm.Key + "- ERROR", restResponse.StatusDescription);
                        }
                        statusString = "ERROR: " + restResponse.StatusDescription;
                    }
                }
                catch (Exception ex)
                {
                    resultDictionary.Clear();
                    if (InfoRequests != null)
                    {
                        foreach (var i in InfoRequests)
                        {
                            resultDictionary.Add($"ERROR - {i.Key}", "NOT FOUND");
                        }
                        statusString = "NOT FOUND";
                    }
                    else { resultDictionary.Add($"ERROR", "Error"); statusString = "ERROR"; }
                    statusString = "ERROR: " + ex.Message;
                }
            

           
            }
           
           
            ProfileResult pr = new ProfileResult()
            {
                Url = CheckURL,
                Title = checker.CheckerTitle,
                Status = statusString,
                Results = resultDictionary
            };
            userProfile.ProfileResults.Add(pr);

        }

    }
}
