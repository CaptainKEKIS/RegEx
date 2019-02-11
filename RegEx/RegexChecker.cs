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

        public virtual void Check()
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
    class Zadnie3Checker : RegexChecker
    {
        public Zadnie3Checker(string Pattern) : base(Pattern)
        {
        }
        public override void Check()
        {
            Regex r1 = new Regex(Pattern);
            Match Mtch = r1.Match(Str);
            if (Mtch.Success)
            {
                MessageBox.Show($"Город: {Mtch.Groups[1]}{Environment.NewLine}Широта: {Mtch.Groups[4]}{Environment.NewLine}Долгота: {Mtch.Groups[7]}");
            }
            else
            {
                MessageBox.Show($"Not OK!");
            }
        }
    }
}
//1 4 6 