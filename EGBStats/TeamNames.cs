using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGBStats
{
    static class TeamNames
    {
        public static string FixName(string name)
        {
            name = name.ToLower();
            name = name.Replace("cloud 9", "cloud9")
                       .Replace("natus vincere", "na'vi")
                       .Replace("virtus.pro", "vp")                    
                       .Replace("team dignitas", "dignitas")
                       .Replace("mousesports", "mouz")
                       .Replace("fsid3", "flipsid3")
                       .Replace("g2", "gamers2")
                       .Replace("hr", "hellraisers")
                       .Replace("enemy", "nme")
                       .Replace("mousespaz", "ms")
                       .Replace("teamswagyolo", "tsy")
                       .Replace("alientech", "at")
                       .Replace("ldlc white", "ldlc.white")
                       .Replace("luminosity", "lg")
                       .Replace("space soldiers", "spaces")
                       .Replace("vega squadron", "vega")
                       .Replace("playing ducks", "ducks")
                       .Replace("vox eminor", "vox")
                       .Replace("games4u", "g4u")
                       .Replace("kabum.td", "kabum")
                       .Replace(" staff", "");
            return name;
        }
    }
}
