using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class ReportOption
    {
        public string Title { get; set; }
        public  bool IsColor { get; set; }
        public bool IsIncludeGraph { get; set; }
        public List<string> Creators { get; set; }
        public List<string> ExtraData { get; set; }
    }
}
