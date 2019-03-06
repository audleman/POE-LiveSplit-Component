using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace POELiveSplitComponent.Component
{
    class ClientParser
    {
        // Example level up log entry:
        // 2017/06/09 21:43:04 697150734 951 [INFO Client 3308] : OldBenKenobiznutz (Templar) is now level 2
        private static readonly Regex LEVEL_UP = new Regex(@"^[^ ]+ [^ ]+ (\d+).*is now level (\d+)");
        //new Regex(@"^(.*)?is now level (\d+)");

        private LoadRemoverSplitter splitter;

        public ClientParser(LoadRemoverSplitter splitter)
        {
            this.splitter = splitter;
        }

        public void ProcessLine(string s)
        {
            Match match = LEVEL_UP.Match(s);
            if (match.Success)
            {
                GroupCollection groups = match.Groups;
                splitter.HandleLevelUp(Int32.Parse(groups[1].Value));
            }
        }
    }
}
