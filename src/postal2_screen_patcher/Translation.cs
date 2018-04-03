using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace postal2_screen_patcher
{
    public static class Translation
    {
        public static Dictionary<string, string> Texts = new Dictionary<string, string>();
        private static string _language;
        private static void reset()
        {
            Texts.Clear();
            char[] trimchars = new char[] { '\r', ' ' };

            string[] tmpdict = Encoding.UTF8.GetString((byte[]) Properties.Resources.ResourceManager.GetObject(_language)).Split('\n');
            foreach (string str in tmpdict)
            {
                string[] tmp = str.Split(new char[]{'='},2);
                try
                {
                    Texts.Add(tmp[0].Trim().Trim(trimchars), Escape(tmp[1].Trim().Trim(trimchars)));
                }
                catch { }
            }
        }
        private static Dictionary<string, string> escapeMapping = new Dictionary<string, string>()
        {
            {@"\\", "\\\\"},
            {@"\a", "\a"},
            { @"\b", "\b"},
            {@"\f", "\f"},
            {@"\n", "\n"},
            {@"\r", "\r"},
            {@"\t", "\t"},
            {@"\v", "\v"},
            {@"\0", "\0"},
            {"\\\"", "\""},
        };

        private static string Escape(string s)
        {
            foreach (var a in escapeMapping.Keys)
                s = s.Replace(a, escapeMapping[a]);
            return s;
        }
        public static string Language
        {
            get
            {
                return _language;
            }
            set
            {
                if (_language != value)
                {
                    _language = value;
                    reset();
                }
            }
        }
    }
    public static class StringHelpers
    {
        
    }
}
