using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EGBStats
{
    class EGBMatch
    {
        private string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        public int matchId { get; set; }
        public string teamA { get; set; }
        public string teamB { get; set; }
        public double coefA { get; set; }
        public double coefB { get; set; }
        public double oddsA { get; set; }
        public double oddsB { get; set; }
        public string date 
        {
            get {
                return full_date.ToString(DateTimeFormat);
                }
            set { 
                    DateTime dt = new DateTime();
                    DateTime.TryParse(value, out dt);
                    full_date = dt;
                }
        }
        public DateTime full_date;
        public string winner { get; set; }
        public EGBMatch()
        { }
        public EGBMatch(EGBMatch m)
        {
            matchId = m.matchId;
            teamB = m.teamB;
            teamA = m.teamA;
            coefA = m.coefA;
            coefB = m.coefB;
            oddsA = m.oddsA;
            oddsB = m.oddsB;
            date = m.date;
            winner = m.winner;
        }
        public void GetMatch(int MatchID)
        {
            string res = Http.GET("http://egb.com/ajax.php?key=modules_home_view_ViewBets&type=modules&ind=home&ajax=view&act=ViewBets&id=" + MatchID.ToString());
            if (res.StartsWith("{\"success\":false")) // Success is false
                throw new Exception("Success is false");
            if (res.IndexOf("\"game\":\"Counter-Strike\"") < 0) // Game is not CSGO
                throw new Exception("Game is not csgo");
            if (res.IndexOf("class=\\\"s6") > 0) // Not a match bet, but a map/first round/etc
                throw new Exception("Not a match bet");
            // Request is all good
            matchId = Convert.ToInt32(GetAttribute("id", res));
            teamA = GetAttribute("gamer_1", res);
            teamB = GetAttribute("gamer_2", res);
            date = GetAttribute("bet_time", res);
            if (date == DateTime.MinValue.ToString(DateTimeFormat)) // Couldn't parse date
                throw new Exception("Date parsing error");

            string tmp = "";
            tmp = res.Substring(res.IndexOf("view_coef_1\\\" class=\\\"s3\\\">Rate: ") + ("view_coef_1\\\" class=\\\"s3\\\">Rate: ").Length);
            tmp = tmp.Substring(0, tmp.IndexOf('<'));
            coefA = Convert.ToDouble(tmp, CultureInfo.InvariantCulture.NumberFormat);
            tmp = res.Substring(res.IndexOf("view_coef_2\\\" class=\\\"s3\\\">Rate: ") + ("view_coef_2\\\" class=\\\"s3\\\">Rate: ").Length);
            tmp = tmp.Substring(0, tmp.IndexOf('<'));
            coefB = Convert.ToDouble(tmp, CultureInfo.InvariantCulture.NumberFormat);
            oddsA = coefB / (coefA + coefB);
            oddsB = coefA / (coefA + coefB);

            if (res.IndexOf("winner gamer_1") > 0)
                winner = "a";
            else if (res.IndexOf("winner gamer_2") > 0)
                winner = "b";
            else
                winner = "c";
        }
        private string GetAttribute(string attr, string source)
        {
            // "attr":"value"
            string sub = source.Substring(source.IndexOf("\"" + attr + "\":\"") + ("\"" + attr + "\":\"").Length);
            return sub.Substring(0, sub.IndexOf("\""));
        }
        public void SwapTeams()
        {
            if (winner == "a")
                winner = "b";
            else if (winner == "b")
                winner = "a";

            string tmp0 = teamA;
            teamA = teamB;
            teamB = tmp0;

            double tmp1 = coefA;
            coefA = coefB;
            coefB = tmp1;

            double tmp2 = oddsA;
            oddsA = oddsB;
            oddsB = tmp2;
        }
        public void FixTeamNames()
        {
            teamA = TeamNames.FixName(teamA);
            teamB = TeamNames.FixName(teamB);
        }
    }
}
