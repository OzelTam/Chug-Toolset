using System;
using System.Collections.Generic;
using System.Text;

namespace ChugToolset.Lib.NameCheck
{
    public class UserProfile
    {
        public UserProfile(string username)
        {
            Username = username;
        }
        public string Username { get; set; }
        public List<ProfileResult> ProfileResults { get; set; }


    }

    public class ProfileResult
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Status { get; set; }


        public Dictionary<string, string> Results {get; set;}

    }


}
