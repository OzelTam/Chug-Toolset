using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChugToolset.Lib.NameCheck
{
    public interface IChecker
    {
        public string CheckerType { get; set; }
        public string CheckerTitle { get; set; }
        public string CheckUrl { get; set; }
        public Dictionary<string, object> GetInfo { get; set; }
       
    }
}
