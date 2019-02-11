using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace RegEx
{
    class RegexChecker
    {
        public string Pattern { get; set; }
        public string Str { get; set; }

        public RegexChecker(string Pattern)
        {
            this.Pattern = Pattern;
        }

        public void Check()
        {
            Regex r1 = new Regex(Pattern);
            if (r1.IsMatch(Str))
            {
                MessageBox.Show("OK!");
            }
            else
            {
                MessageBox.Show("Not OK!");
            }
        }
    }
}
