using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static ChugToolset.Lib.NameCheck.NameCheckFunction;
namespace ChugToolset.Lib.NameCheck
{
    [Serializable]
    public class CheckPack
    {

        /// <summary>
        /// Name of the checker Package
        /// </summary>
        public string PackName { get; set; }
        private List<IChecker> checkClients { get; set; }

        
        public CheckPack(string packName, List<IChecker> checkClients_ = null)
        {
            if(checkClients_ == null)
            {
                checkClients = new List<IChecker>();
            }
            else
            {
                checkClients = checkClients_;

            }
            PackName = packName;
        }

        public void AddChecker(IChecker checkClient)
        {
            if(checkClients.Count(x => x.CheckerTitle == checkClient.CheckerTitle) > 0)
            {
                throw new Exception($"A cehcker already exists with the same title '{checkClient.CheckerTitle}'");
            }
            else
            {
                checkClients.Add(checkClient);
            }
        }

        public List<IChecker> GetCheckers()
        {
            return checkClients;
        }

        public bool RemoveChecker(string checkerTitle)
        {
            var ItemToRemove = checkClients.Where(x => x.CheckerTitle == checkerTitle).ToList();
            if (ItemToRemove.Count > 0)
            {
               checkClients.Remove(ItemToRemove[0]);
                return true;
            }
            else
            {
                return false;
            }
         
         }




        public async Task<UserProfile> CheckUsername(string username,string[] activeCheckerTitles = null, CheckUsernameOptions checkUsernameOptions = null)
        {
            if (checkUsernameOptions == null) {
                checkUsernameOptions = new CheckUsernameOptions(new CancellationToken());
            }

            List<IChecker> ActiveCheckerClients = new List<IChecker>();


            if (activeCheckerTitles == null) { ActiveCheckerClients = checkClients; }
            else { ActiveCheckerClients.AddRange(checkClients.Where(x => activeCheckerTitles.Contains(x.CheckerTitle)).ToList()); }

            UserProfile outputUserProfile = new UserProfile(username) { ProfileResults = new List<ProfileResult>() };
            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.MaxDegreeOfParallelism = checkUsernameOptions.maxCheckThreads;
            parallelOptions.CancellationToken = new CancellationToken();
           
         //   Parallel.ForEach(ActiveCheckerClients, parallelOptions, async (checkerClient) =>
         //  {
         //    await checkerClient.CheckUserAsync(outputUserProfile);
         //  }
         //  );

          foreach(var checkClient in ActiveCheckerClients)
            {
                await checkClient.CheckUserAsync(outputUserProfile);
            }


            return outputUserProfile;
        }

       public ObservableCollection<UserProfile> userProfiles = new ObservableCollection<UserProfile>();

        public async Task<ObservableCollection<UserProfile>> CheckUsername(string[] username, string[] activeCheckerTitles = null, CheckUsernameOptions checkUsernameOptions = null)
        {
            
            if (checkUsernameOptions == null)
            {
                checkUsernameOptions = new CheckUsernameOptions(new CancellationToken());
            }
            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.MaxDegreeOfParallelism = checkUsernameOptions.maxUserThreads;
            parallelOptions.CancellationToken = new CancellationToken();

    
        //    foreach(var usr in username)
        //    {
        //        var UserProfil = await CheckUsername(usr, activeCheckerTitles, checkUsernameOptions);
        //        userProfiles.Add(UserProfil);
        //    }


          Parallel.ForEach(username, parallelOptions, async user => {
           var UserProfil = await CheckUsername(user, activeCheckerTitles, checkUsernameOptions);
            
           userProfiles.Add(UserProfil);
           
           
        });
       
         
            return userProfiles;
        }

        public async Task<Dictionary<string, string>> GetUrlResultAsync(string username, UrlCheck urlCheck)
        {
            Dictionary<string, string> resultDictionary = new Dictionary<string, string>();
            string URL = urlCheck.CheckUrl.ToLower().Replace("{username}", username);
            try
            {
                NameCheckFunction.RaiseReportEvent(this, $"Requesting profile '{urlCheck.CheckerTitle}: {username}'...");
                HtmlWeb web = new HtmlWeb();
                HtmlDocument htmldoc =  await  web.LoadFromWebAsync(URL);
                NameCheckFunction.RaiseReportEvent(this, $"Got the profile '{urlCheck.CheckerTitle}: {username}'.");
                htmldoc.OptionFixNestedTags = true;
                foreach (var infoReq in urlCheck.GetInfo)
                {
                    var infoKey = infoReq.Key;
                    var InfoValue = "";
                    Finder infoFinder = (Finder)infoReq.Value;
                    switch (infoFinder.GetElementBy)
                    {
                        case Finder.GetBy.ClassName:
                            InfoValue = NameCheckFunction.GetByClassName(htmldoc, infoFinder.Address);
                            break;
                        case Finder.GetBy.Id:
                            InfoValue = NameCheckFunction.GetById(htmldoc, infoFinder.Address);
                            break;
                        case Finder.GetBy.RegEx:
                            InfoValue = NameCheckFunction.GetByRegex(htmldoc, infoFinder.Address);
                            break;
                        case Finder.GetBy.XPath:
                            InfoValue = NameCheckFunction.GetByXpath(htmldoc, infoFinder.Address);
                            break;
                        case Finder.GetBy.AttributeValue:
                            InfoValue = NameCheckFunction.GetByAttributeValue(htmldoc.DocumentNode, infoFinder.Address);
                            break;
                    }
                    resultDictionary.Add(infoKey, InfoValue);
                }

            }catch(Exception ex)
            {
                resultDictionary.Add("Error", ex.Message);
            }

            return resultDictionary;
        }
             
        private string GetValueFromPage(HtmlDocument htmldoc, (string, string) address)
        {
          
            return "";
        }


 
    }


    public class CheckUsernameOptions
    {
        /// <summary>
        /// Maximum numbers of users to check simultaneously.
        /// </summary>
        public int maxUserThreads { get; set; }


        /// <summary>
        /// Maximum numbers of checkers that can run simultaneously for each user.
        /// </summary>
        public int maxCheckThreads { get; set; }

        /// <summary>
        /// Cancellaniton Token
        /// </summary>
        public CancellationToken cancellationToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken_">Cancellaniton Token</param>
        /// <param name="maxUserThreads_">Maximum numbers of users to check simultaneously.</param>
        /// <param name="maxCheckThreads_">Maximum numbers of checkers that can run simultaneously for each user.</param>
        public CheckUsernameOptions(CancellationToken cancellationToken_ , int maxUserThreads_ = 3, int maxCheckThreads_ = 3)
        {
            maxUserThreads = maxUserThreads_;
            maxCheckThreads = maxCheckThreads_;
            cancellationToken = cancellationToken_;
        }

    }

}
